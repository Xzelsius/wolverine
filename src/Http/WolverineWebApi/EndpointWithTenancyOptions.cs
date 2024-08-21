using Microsoft.Extensions.Options;
using Wolverine.Http;

namespace WolverineWebApi
{
    public static class EndpointWithTenancyOptions
    {
        [WolverineGet("/with-options-snapshot")]
        public static void Foo(IOptionsSnapshot<TenancyOptions> snapshot)
        {
            // blub
        }
    }
}
