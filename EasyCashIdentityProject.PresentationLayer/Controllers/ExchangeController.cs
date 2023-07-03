using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            #region
            var usdClient = new HttpClient();
            var usdRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USD&to=TRY&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "6b5d9ea256msh2120b0d66e6f078p16642ejsn95a51d4014f3" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var usdResponse = await usdClient.SendAsync(usdRequest))
            {
                usdResponse.EnsureSuccessStatusCode();
                var usdBody = await usdResponse.Content.ReadAsStringAsync();
                ViewBag.UsdToTry = usdBody;
            }
            #endregion

            #region
            var eurClient = new HttpClient();
            var eurRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=EUR&to=TRY&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "6b5d9ea256msh2120b0d66e6f078p16642ejsn95a51d4014f3" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var eurResponse = await eurClient.SendAsync(eurRequest))
            {
                eurResponse.EnsureSuccessStatusCode();
                var eurBody = await eurResponse.Content.ReadAsStringAsync();
                ViewBag.EurToTry = eurBody;
            }
            #endregion

            #region
            var gbpClient = new HttpClient();
            var gbpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=GBP&to=TRY&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "6b5d9ea256msh2120b0d66e6f078p16642ejsn95a51d4014f3" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var gbpResponse = await gbpClient.SendAsync(gbpRequest))
            {
                gbpResponse.EnsureSuccessStatusCode();
                var gbpBody = await gbpResponse.Content.ReadAsStringAsync();
                ViewBag.GbpToTry = gbpBody;
            }
            #endregion

            #region
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USD&to=EUR&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "6b5d9ea256msh2120b0d66e6f078p16642ejsn95a51d4014f3" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ViewBag.UsdToEur = body;
            }
            #endregion

            return View();
        }
    }
}