![Header](/docs/header.png)

## ℹ️ About
Loose adaptation of CS 1.6 UI for Avalonia.

## 🗒️ Disclaimer
This is not an exact port of the CS 1.6 interface style, but rather a free adaptation.
Olso, I don't see any need to put this visual theme in a separate nuget package:
1) it's not a fact that anyone except me will use it. 
2) it's much more convenient to have sources directly in your project (with the ability to change them as needed).

## 🛠️ How to use
1) Copy the `Styling` and `Assets\Fonts` folders to your project
2) Replace the `cs16AvaloniaTheme` project name with your project name in the path to the Gohu font (see the `\Styling\ControlsResources.axaml`, row 7)
3) Include styles in `App.axaml`. To do this, simply add the line node `Application.Styles`:
```xaml
<StyleInclude Source="/Styling/Style.axaml" />
```
