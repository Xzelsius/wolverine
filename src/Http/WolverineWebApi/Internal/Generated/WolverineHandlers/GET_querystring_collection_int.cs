// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_querystring_collection_int
    public class GET_querystring_collection_int : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_querystring_collection_int(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }

        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var collection = new System.Collections.Generic.List<int>();
            foreach (var collectionValue in httpContext.Request.Query["collection"])
            {
                if (int.TryParse(collectionValue, System.Globalization.CultureInfo.InvariantCulture, out var collectionValueParsed))
                {
                    collection.Add(collectionValueParsed);
                }
            }
            
            // The actual HTTP request handler execution
            var result_of_UsingIntCollection = WolverineWebApi.QuerystringCollectionEndpoints.UsingIntCollection(collection);

            await WriteString(httpContext, result_of_UsingIntCollection);
        }
    }

    // END: GET_querystring_collection_int
    
    
}