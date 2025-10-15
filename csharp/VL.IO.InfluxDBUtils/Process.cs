// For examples, see:
// https://thegraybook.vvvv.org/reference/extending/writing-nodes.html#examples
namespace VL.IO.InfluxDB;

using InfluxDB3.Client;
using InfluxDB3.Client.Internal;
using InfluxDB3.Client.Write;
using Stride.Core.Serialization.Serializers;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

[ProcessNode]
public class Demo
{
    private int _value;

    public void Update(IInfluxDBClient client) { 
    
        Read(client);
    }

    private async void Read(IInfluxDBClient client)
    {
        const string sql = $"SELECT * FROM vvvv WHERE time >= now() - interval '1 hour'";
        var resutl = client.Query(query: sql);
        await foreach (var row in resutl)
        {
            foreach(var entry in row)
            {
                if(entry != null)
                    Console.WriteLine(entry.ToString());
            }
           
        }
    }
}