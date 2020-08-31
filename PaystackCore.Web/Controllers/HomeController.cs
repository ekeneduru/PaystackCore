using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Paystack.Core;
using PaystackCore.Web.Models;

namespace PaystackCore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        string SecretKey = "sk_test_21775c2c3facacc2d86e79f5c53e5cf6222a8121";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            PayStackApi api = new PayStackApi(SecretKey);

            TransactionInitializeRequest request = new TransactionInitializeRequest();
            request.AmountInKobo = 100;
            request.Email = "ekeneduru@yahoo.com";


            //request.MetadataObject["CustomOrderNumber"] = postProcessPaymentRequest.Order.CustomOrderNumber;
            //request.MetadataObject["OrderGuid"] = postProcessPaymentRequest.Order.OrderGuid.ToString();
            //request.CallbackUrl = $"{storeLocation}Plugins/PaymentPayStackStandard/HandleCallback";
            request.Reference = Guid.NewGuid().ToString();


            var response = api.Transactions.Initialize(request, true);
            if (response.Status == true)
            {
                HttpContext.Response.Redirect(response.Data.AuthorizationUrl);
              

            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
