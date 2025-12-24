using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Http;
using Microsoft.Azure.Functions.Worker.Http;
using System.Net

public class ApiFunctions
{
    [Function("AdminSeedPlaces")]
    public HttpResponseData AdminSeedPlaces(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "admin/places/seed")] HttpRequestData req)
    {
        var res = req.CreateResponse(HttpStatusCode.OK);
        res.WriteString("{\"status\":\"ok\",\"message\":\"places seeded\"}");
        return res;
    }

    [Function("AdminIssuePassport")]
    public HttpResponseData AdminIssuePassport(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "admin/passports/issue")] HttpRequestData req)
    {
        var res = req.CreateResponse(HttpStatusCode.OK);
        res.WriteString("{\"passportId\":\"demo\",\"activationToken\":\"demo-token\"}");
        return res;
    }

    [Function("ClaimPassport")]
    public HttpResponseData ClaimPassport(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "passports/claim")] HttpRequestData req)
    {
        var res = req.CreateResponse(HttpStatusCode.OK);
        res.WriteString("{\"status\":\"claimed\"}");
        return res;
    }

    [Function("ScanPlace")]
    public HttpResponseData ScanPlace(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "places/scan")] HttpRequestData req)
    {
        var res = req.CreateResponse(HttpStatusCode.OK);
        res.WriteString("{\"status\":\"scanned\"}");
        return res;
    }
}
