using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace V4ColdIsolated6
{
    public static class HelloHttp
    {
        [Function("HelloHttp")]
        public static HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
