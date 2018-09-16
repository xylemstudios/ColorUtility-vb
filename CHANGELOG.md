# Changelog

This document serves as a changelog.

## ~~Planned~~ ideas

These ideas were planned at some point:
- Color picker wheel
- CMYK support
- Open swatches
- Alpha support
- Custom sliders for slicker UI

## 1.72

### Added
- HSV support
- Add option to copy after picking a color from the screen
- Screen color picker can now be exited

### Fixed
- Fix slider right-click bug
- Fix language combobox not displaying the proper language
- Fix on-screen color picker multiple clicks causing it to freak out
- Fix empty textboxes

### Changed
- Grayscale filter now uses HSV instead of Luma
- Allow delete with the DEL key in the color combiner

### Removed
- "Advanced grayscale color" removed, since HSV does the same thing

### Internal notes
- Executable size trimmed down by removing an unnescesarily large icon
- Now uses a language provider class
- Now uses a color manager
- Screen color picker now only starts gathering information on click
- Version number is no longer hard-coded but is obtained from application properties
- Some refactoring of control names


## 1.60

### Added
- Add websafe button
- Add "Get all colors in an image" tool
- Add a right-click menu to the color box (to copy as other color formats)

### Fixed
- Color picker no longer flashes
- Memory leak on the on-screen color picker
- Fix incorrect grayscale color in "Advanced random color"

### Internal notes
- Code cleanup


## 1.53

### Added
- Add extra tools

### Fixed
- Color picker cursor no longer resets
- Color picker uses less memory
- Fix keyboard shortcuts not working in some places

### Changed
- Improved the "Intensify" color picker


## 1.48

### Added
- Hexadecimal and Decimal textbox now turn red if the value is not correct
- "Intensify" color filter (beta)

### Fixed
- Color picker now crashes less frequently
- Reduced memory usage (yep, again)
- Fix languages on Windows XP

### Internal notes
- Don't reallocate the color picker cursor multiple times


## 1.42

### Added
- Credits tab

### Fixed
- Norwegian is now properly detected
- Reduced memory usage
- Textbox fix (not sure what this was, but it was big...)


## 1.30

### Added
- Multi-language support: Norwegian, French, Spanish
- Random color button

### Fixed
- Color picker should be faster (again)
- Settings were not being saved

### Internal notes
- The main form is focused when opening the app (to make sure it is on top)


## 1.25

### Added
- Settings

### Fixed
- Color picker should be faster

## 1.1

### Added
- Color filters

### Changed
- Improved color picker

### Internal notes
- Code cleanup


## 1.05

### Added
- On-screen color picker

### Fixed
- Fix fatal crash


## 1.0

Initial release!