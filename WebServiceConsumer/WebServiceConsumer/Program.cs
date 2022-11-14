// See https://aka.ms/new-console-template for more information
using SampleReference;
using System.ServiceModel;
using System.ServiceModel.Channels;

SampleServiceClient ServiceClient = new SampleServiceClient();
EndpointAddressBuilder endpointAddressBuilder = new EndpointAddressBuilder(new EndpointAddress("http://localhost:16812/SampleService.svc"));
endpointAddressBuilder.Headers.Add(AddressHeader.CreateAddressHeader("Key", string.Empty, "1234"));
SampleServiceClient client = new SampleServiceClient(ServiceClient.ChannelFactory.Endpoint.Binding, endpointAddressBuilder.ToEndpointAddress());

var hello = await client.HelloWorldAsync();
Console.WriteLine(hello);
try
{
    var simpleInvalid = await ServiceClient.SimpleOperationAsync(new SimpleObject { Type = Simple.One, Value = 3.5m });
    Console.WriteLine(simpleInvalid.Value);
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
var simpleValid = await client.SimpleOperationAsync(new SimpleObject { Type = Simple.Two, Value = 3.25m });
Console.WriteLine(simpleValid.Value);