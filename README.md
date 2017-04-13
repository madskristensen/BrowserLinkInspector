# Browser Link Inspector 2017

<!-- Replace this badge with your own-->
[![Build status](https://ci.appveyor.com/api/projects/status/hv6uyc059rqbc6fj?svg=true)](https://ci.appveyor.com/project/madskristensen/extensibilitytools)

<!-- Update the VS Gallery link after you upload the VSIX-->
Download this extension from the [VS Gallery](https://visualstudiogallery.msdn.microsoft.com/[GuidFromGallery])
or get the [CI build](http://vsixgallery.com/extension/bc4780ab-de6e-4999-bebf-51390e1b75ef/).

---------------------------------------

Adds inspect and debug mode directly in the browsers

See the [change log](CHANGELOG.md) for changes and road map.

## Features

- Inspect mode `(Ctrl+Alt+I)`
- Debug mode `(Ctrl+Alt+D)`

### Inspect Mode
This mode will put the browser in a state where hovering the various DOM elements in the Browser will open the corresponding file in Visual Studio and select the range that produced the DOM element.

### Debug Mode
Does the same as Inspect Mode as well as put the document in edit mode. It is then possible to make text changes directly in the browser and see the changes persisted back into the source file in Visual Studio in real time.


## Known Issues
ASP.NET Core projects are not yet supported.

## Contribute
Check out the [contribution guidelines](.github/CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure
to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features
used by this project.

## License
[Apache 2.0](LICENSE)