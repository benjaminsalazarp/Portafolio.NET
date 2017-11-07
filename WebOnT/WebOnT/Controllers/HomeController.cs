using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOnT.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebOnT.Controllers
{
    public class HomeController : Controller
    {
        // hosted web api
        String BaseUrl = "https://thawing-forest-71712.herokuapp.com/";
        public async Task<ActionResult> Index()
        {
            List<Cuenta> CuentaInfo = new List<Cuenta>();

            using (var client = new HttpClient())
            {
                // servicio base url
                client.BaseAddress = new Uri(BaseUrl);

                client.DefaultRequestHeaders.Clear();
                //Define formato  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //envia solicitud para encontrar web api REST servicio cuentas con HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/cuentas");

                //revisa si hay respuesta o no que envia usnado HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    // guarda los detalles de la respuesta recivida web api
 
                     var CuentaResponse = Res.Content.ReadAsStringAsync().Result;

                    //deserializa la respuesta recivida de web api y alamcena en la lista de cuenta  
                    CuentaInfo = JsonConvert.DeserializeObject<List<Cuenta>>(CuentaResponse);
                }
                //retorna lista 
                return View(CuentaInfo);
            }


        }
        
    }
}