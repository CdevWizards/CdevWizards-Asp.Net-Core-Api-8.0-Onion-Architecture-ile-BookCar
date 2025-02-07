using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.ServiceDtos;

using Microsoft.Extensions.Logging;

namespace WebUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;   

        public ServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ActionResult> Index()
        {
             // İStekte bulunmak için istemci oluşturduk.
            var client = _httpClientFactory.CreateClient();
            var responseMessage=await client.GetAsync
            ("http://localhost:5204/api/Service");
            if (responseMessage.IsSuccessStatusCode) // durum kodları 200-299
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                // dotnet add package Newtonsoft.Json
                // using Newtonsoft.Json;
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(values);
        }
        return View();
    }
    }
}
           