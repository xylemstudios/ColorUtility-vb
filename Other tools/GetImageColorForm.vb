Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices.Marshal
Public Class GetImageColorForm
    Dim previousText As String = ""
    Dim transfer_speed As Integer
    Dim s As New Stopwatch
    Dim stopped As Boolean = False
    Dim count, total As Integer
    Structure Messages
        Dim checking As String
        Dim imgNotValid As String
        Dim idle As String
        Dim dialogChoose As String
        Dim dialogFilter As String
        Dim fileDoesNotExist As String
        Dim errorText As String
        Dim initializing As String
        Dim gatheringColors As String
        Dim populatingList As String
        Dim completed As String
        Dim estimatedtime As String
        Dim seconds As String
        Dim imageIsTooBig As String
        Dim timeelapsed As String
        Dim [stop] As String
        Dim stopping As String
        Dim start As String
        Dim search As String
    End Structure
    Friend msg As New Messages
    Private Function grayscale(ByVal _color As Color) As Byte
        Dim luma As Integer = CInt(_color.R * 0.3 + _color.G * 0.59 + _color.B * 0.11)
        Return luma
    End Function
    Private Function SecondsToDate(ByVal Seconds As Double, Optional ByVal showSeconds As Boolean = True) As String
        If Seconds < 60 Then
            Return msg.seconds.Replace("{0}", Seconds)
        Else
            If showSeconds Then
                Return Date.FromOADate(Seconds / 86400).ToLongTimeString
            Else
                Return Date.FromOADate(Seconds / 86400).ToShortTimeString
            End If
        End If
    End Function
    Private Sub updateStuff(ByVal filename As String)
        previousText = filename
        pathTxt.Text = filename
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pathButton.Click
        Dim dialog As New OpenFileDialog
        dialog.Title = msg.dialogChoose
        dialog.Filter = msg.dialogFilter & "|*.*"
        dialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            updateStuff(dialog.FileName)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        If startButton.Tag = "s" Then
            setStatus(msg.checking)
            Application.DoEvents()
            Dim file As String = pathTxt.Text
            If ImageChecker.IsValidImage(file) And FileIO.FileSystem.FileExists(file) And Not ImageChecker.IsAnimatedGif(file) Then
                'valid
                ListView1.Items.Clear()
                startButton.Text = msg.stop
                BackgroundWorker1.RunWorkerAsync()
                startButton.Tag = "r"
            Else
                'not valid
                setStatus(msg.idle)
                Me.BringToFront()
                MsgBox(msg.imgNotValid, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, msg.errorText)
                startButton.Tag = "s"
                Exit Sub
            End If
        Else
            setStatus(msg.stopping)
            startButton.Enabled = False
            startButton.Text = msg.stopping
            If BackgroundWorker1.IsBusy Then
                Do Until BackgroundWorker1.IsBusy = False
                    BackgroundWorker1.CancelAsync()
                    Application.DoEvents()
                Loop
            End If
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        setStatus(msg.initializing)
        Try
            total = 0
            count = 0
            s.Start()
            Dim b As Bitmap = Bitmap.FromFile(pathTxt.Text)
            Dim bmd As BitmapData = b.LockBits(New Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb)
            Dim scan0 As IntPtr = bmd.Scan0
            Dim pixels(b.Width * b.Height - 1) As Integer

            setStatus(msg.gatheringColors)
            Copy(scan0, pixels, 0, pixels.Length)
            b.UnlockBits(bmd)

            scan0 = Nothing
            bmd = Nothing
            b.Dispose()
            b = Nothing

            Dim distinctColors As New List(Of Color)
            Dim co As Color
            For Each int As Integer In pixels.Distinct.ToArray
                co = Color.FromArgb(int)
                distinctColors.Add(Color.FromArgb(co.R, co.G, co.B))
            Next
            distinctColors = distinctColors.Distinct.ToList
            total = pixels.Count
            count = distinctColors.Count
            pixels = Nothing
            co = Nothing

            ProgressBar1.Maximum = distinctColors.Count

            setStatus(msg.populatingList)
            For Each _c In distinctColors
                If BackgroundWorker1.CancellationPending Then
                    stopped = True
                    startButton.Text = msg.start
                    startButton.Enabled = True
                    startButton.Tag = "s"
                    setStatus(msg.idle)
                    Exit Sub
                End If
                If My.Settings.optimizeSpeed Then System.Threading.Thread.Sleep(1)
                Dim l As New ListViewItem
                l.Text = ColorTranslator.ToHtml(_c)
                l.SubItems.Add(_c.R)
                l.SubItems.Add(_c.G)
                l.SubItems.Add(_c.B)
                l.BackColor = _c
                l.ForeColor = If(grayscale(_c) > 126, Color.Black, Color.White)
                ListView1.Items.Add(l)
                lst.Add(l)
                'ListView1.EnsureVisible(ListView1.Items.Count - 1) 'optional, no slowdown.
                If ListView1.Items.Count = 1 Then
                    BackgroundWorker2.RunWorkerAsync()
                    selectButton.Enabled = False
                End If
                l = Nothing
                _c = Nothing
            Next
            startButton.Enabled = True
            startButton.Tag = "s"
            setStatus(msg.completed.Replace("{0}", total).Replace("{1}", count))
            s.Stop()
            distinctColors = Nothing
            stopped = False
            startButton.Text = msg.start
        Catch ex As System.OutOfMemoryException
            setStatus(msg.idle)
            progressLabel.Text = msg.timeelapsed & ": " & msg.seconds.Replace("{0}", 0)
            startButton.Enabled = True
            MsgBox(msg.imageIsTooBig, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, msg.errorText)
            Exit Sub
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub
    Public Sub updateLang()
        Text = lang("TOOL_ALLCOLORS")
        pathLabel.Text = lang("TOOL_ALLCOLORS", "PATH")
        startButton.Text = lang("COMMON", "START")
        selectButton.Text = lang("TOOL_ALLCOLORS", "SELECT")
        closeButton.Text = lang("COMMON", "CLOSE")
        ColumnHeader1.Text = "#"
        ColumnHeader2.Text = lang("RGB", "R")
        ColumnHeader3.Text = lang("RGB", "G")
        ColumnHeader4.Text = lang("RGB", "B")
        With msg
            .checking = lang("TOOL_ALLCOLORS", "MSG_CHECKING")
            .imgNotValid = lang("TOOL_ALLCOLORS", "MSG_INVALID")
            .idle = lang("TOOL_ALLCOLORS", "MSG_IDLE")
            .dialogChoose = lang("TOOL_ALLCOLORS", "MSG_CHOOSE")
            .dialogFilter = lang("TOOL_ALLCOLORS", "MSG_DIALOGFILTER")
            .fileDoesNotExist = lang("TOOL_ALLCOLORS", "MSG_DOESNOTEXIST")
            .errorText = lang("COMMON", "ERROR")
            .initializing = lang("TOOL_ALLCOLORS", "INITIALIZING")
            .gatheringColors = lang("TOOL_ALLCOLORS", "MSG_GATHERING")
            .populatingList = lang("TOOL_ALLCOLORS", "MSG_POPULATING")
            .completed = lang("TOOL_ALLCOLORS", "MSG_DONE")
            .estimatedtime = lang("TOOL_ALLCOLORS", "MSG_ETA")
            .seconds = lang("TOOL_ALLCOLORS", "MSG_SECS")
            .imageIsTooBig = lang("TOOL_ALLCOLORS", "MSG_IMGTOOBIG")
            .timeelapsed = lang("TOOL_ALLCOLORS", "MSG_ELAPSED")
            .stop = lang("COMMON", "STOP")
            .stopping = lang("TOOL_ALLCOLORS", "MSG_STOPPING")
            .start = lang("COMMON", "START")
            .search = lang("COMMON", "SEARCH")
        End With
    End Sub
    Private Sub GetImageColorForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        BackgroundWorker1.CancelAsync()
    End Sub
    Private Sub GetImageColorForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setStatus(msg.idle)
        updateLang()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectButton.Click
        Form1.colormanager.RGB = ListView1.SelectedItems(0).BackColor
    End Sub
    Private Sub setStatus(ByVal str As String)
        statusLabel.Text = str
    End Sub
    Private Sub setSpeed(ByVal v As Integer, ByVal max As Integer, ByVal start As Date)
        transfer_speed = v / (Date.UtcNow - start).TotalSeconds
        progressLabel.Text = msg.estimatedtime.Replace("{0}", SecondsToDate(Math.Round((max - v) / transfer_speed)))
    End Sub
    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            Dim start As Date = Date.UtcNow
            Do While startButton.Tag = "r"
                Threading.Thread.Sleep(If(My.Settings.optimizeSpeed, 400, 200))
                ProgressBar1.Value = ListView1.Items.Count
                setSpeed(ProgressBar1.Value, ProgressBar1.Maximum, start)
                setStatus(msg.populatingList & " " & Math.Round(ProgressBar1.Value / ProgressBar1.Maximum * 100, 2) & "% (" & ProgressBar1.Value & " / " & ProgressBar1.Maximum & ")")
            Loop
            setStatus(If(stopped, msg.idle, msg.completed.Replace("{0}", total).Replace("{1}", count)))
            progressLabel.Text = msg.timeelapsed & ": " & SecondsToDate(s.ElapsedMilliseconds \ 1000)
            s.Reset()
            stopped = False
            startButton.Text = msg.start
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchTxt.Click
        If searchTxt.Text = msg.search & "..." And searchTxt.ForeColor = Color.DarkGray Then
            searchTxt.Text = ""
            searchTxt.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchTxt.Leave
        If searchTxt.Text = "" Then
            searchTxt.Text = msg.search & "..."
            searchTxt.ForeColor = Color.DarkGray
        End If
    End Sub
    Public Function CheckIfListViewCanSearch(ByVal ListView As ListView, ByVal Text As String) As Boolean
        Try
            Return Not IsNothing(ListView.FindItemWithText(Text, True, 0, True))
        Catch ex As Exception
            Return False
        End Try
    End Function
    Dim lastSearchedIndex As Integer = 0
    Dim lst As New List(Of ListViewItem)
    Sub Search()
        Dim lastSearchedIndex As Integer = 0
        If lst.Count > 0 And CheckIfListViewCanSearch(ListView1, searchTxt.Text) Then
            Dim Item As ListViewItem
            Try
                Item = ListView1.FindItemWithText(searchTxt.Text, True, lastSearchedIndex, True)
            Catch ex As Exception
                Item = Nothing
            End Try
            If Not IsNothing(Item) Then
                ListView1.Select()
                ListView1.Items.Add(Item)

                Item.EnsureVisible()
                lastSearchedIndex = Item.Index + 1
            Else
                lastSearchedIndex = 0
            End If
            Search()
            searchTxt.BackColor = Color.FromKnownColor(KnownColor.Window)
        Else
            'No match
            searchTxt.BackColor = Color.Tomato
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchTxt.TextChanged
        If searchTxt.ForeColor <> Color.DarkGray And searchTxt.Text <> "" Then
            ListView1.Items.Clear()
            Search()
        Else
            'ListView1.Items.AddRange(DirectCast(lst, ListView.ListViewItemCollection))
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pathTxt.TextChanged
        If FileIO.FileSystem.FileExists(pathTxt.Text) Then
            pathTxt.BackColor = Color.FromKnownColor(KnownColor.Window)
            startButton.Enabled = True
        Else
            pathTxt.BackColor = Color.Tomato
            startButton.Enabled = False
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        selectButton.Enabled = (ListView1.SelectedIndices.Count = 1)
    End Sub
End Class