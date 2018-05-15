using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using TestWebApp.Models.User;

namespace TestWebApp.Controllers
{
    public class UserController : AsyncController
    {
        private static readonly HttpClient _client = new HttpClient();
        // GET: User
        public async Task<ActionResult> Index()
        {
            UserViewModel vm = new UserViewModel();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://reqres.in/api/users")
            };

            var response = await _client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var data = await response.Content.ReadAsStringAsync();
                vm.UserResponse = data;
            }
 
            return View(vm);
        }
    }
}