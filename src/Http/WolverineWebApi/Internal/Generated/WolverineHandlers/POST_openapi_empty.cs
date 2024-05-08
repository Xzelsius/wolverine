// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Runtime;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_openapi_empty
    public class POST_openapi_empty : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly Wolverine.Runtime.IWolverineRuntime _wolverineRuntime;

        public POST_openapi_empty(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, Wolverine.Runtime.IWolverineRuntime wolverineRuntime) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _wolverineRuntime = wolverineRuntime;
        }

        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var messageContext = new Wolverine.Runtime.MessageContext(_wolverineRuntime);
            var openApiEndpoints = new WolverineWebApi.OpenApiEndpoints();
            
            // The actual HTTP request handler execution
            var httpMessage1 = openApiEndpoints.PostCommand();

            
            // Outgoing, cascaded message
            await messageContext.EnqueueCascadingAsync(httpMessage1).ConfigureAwait(false);

            // Wolverine automatically sets the status code to 204 for empty responses
            if (!httpContext.Response.HasStarted) httpContext.Response.StatusCode = 204;
            
            // Making sure there is at least one call to flush outgoing, cascading messages
            await messageContext.FlushOutgoingMessagesAsync().ConfigureAwait(false);

        }
    }

    // END: POST_openapi_empty
    
    
}