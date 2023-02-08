using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using WolverineWebApi;

namespace Wolverine.Http.Tests;

public class using_container_services_as_method_arguments : IntegrationContext
{
    [Fact]
    public async Task use_normal_container_services()
    {
        var body = await Host.Scenario(x =>
        {
            x.Get.Url("/message/hey");

        });
        
        body.ReadAsText().ShouldBe("Message was hey");
        
        Host.Services.GetRequiredService<Recorder>()
            .Actions.ShouldContain("Got: hey");
    }
}