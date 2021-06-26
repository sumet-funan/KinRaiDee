using KinRaiDee.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace KinRaiDee.Web.Controllers
{
    public class MenuController : Controller
    {
        private static readonly HttpClient client = new();

        private static List<Menu> _menu = null;

        public async Task<IActionResult> IndexAsync()
        {
            if (_menu != null)
            {
                return View(_menu);
            }

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var streamTask = client.GetStreamAsync("https://bcaaa4c0-5f5f-4b58-8fa1-9e7352c599ec.mock.pstmn.io/GetMenu");
            _menu = await JsonSerializer.DeserializeAsync<List<Menu>>(await streamTask);
            return View(_menu);
        }
    }
}
