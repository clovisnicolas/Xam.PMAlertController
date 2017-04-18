# Xam.PMAlertController
Xamarin.iOS Bindings for [PMAlertController](https://github.com/Codeido/PMAlertController)

## Install
Soon to be available on NuGet

## Quickstart
```csharp
var alertVC = new PMAlertController("Welcome", "This is a PMAlertController", UIImage.FromBundle("home"), PMAlertControllerStyle.Walkthrough);
alertVC.AddAction(new PMAlertAction("Cool", PMAlertActionStyle.Default, null));
alertVC.AddAction(new PMAlertAction("I don't care", PMAlertActionStyle.Cancel, null));
this.PresentViewController(alertVC, true, null);  
```

## Build

Bindings have been made thanks to [Lucas Teixeira](https://github.com/Flash3001) unofficial Swift3 bindings for Xamarion.iOS.

Instructions are on [StackOverflow](http://stackoverflow.com/documentation/xamarin.ios/6091/binding-swift-libraries)

## License
MIT © Clovis Nicolas
