# VL.IO.InfluxDB

This is a wrapper of the [InfluxDB 3 C# .NET Client](https://github.com/InfluxCommunity/influxdb3-csharp) to write and read to influxDBs. For more Informations about see their [documentation](https://docs.influxdata.com). For all infos about the InfluxDB3.Client API see the [API documentation](https://influxcommunity.github.io/influxdb3-csharp/api/InfluxDB3.Client.html).

For use with vvvv, the visual live-programming environment for .NET: http://vvvv.org

## Known Issues
Write Nodes: The IsCompleted function from the task is not trigger proberbly   
Query Nodes: Type parsing of the return values is not included in the library

## Getting started
- Install as [described here](https://thegraybook.vvvv.org/reference/hde/managing-nugets.html) via commandline:

    `nuget install VL.IO.InfluxDB`

- Usage examples and more information are included in the pack and can be found via the [Help Browser](https://thegraybook.vvvv.org/reference/hde/findinghelp.html)

## Contributing
- Report issues on [the vvvv forum](https://forum.vvvv.org/c/vvvv-gamma/28)
- For custom development requests, please [get in touch](mailto:devvvvs@vvvv.org)
- When making a pull-request, please make sure to read the general [guidelines on contributing to vvvv libraries](https://thegraybook.vvvv.org/reference/extending/contributing.html)

## Credits
Links to libraries this is based on: [InfluxDB 3 C# .NET Client](https://github.com/InfluxCommunity/influxdb3-csharp)

## Sponsoring
Development of this library was partially sponsored by:  
* [MESO Digital Interiors GmbH ](http://meso.design)
