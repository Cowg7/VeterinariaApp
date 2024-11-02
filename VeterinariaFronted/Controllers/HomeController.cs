using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
=======
using Newtonsoft.Json;
using System.Diagnostics;
>>>>>>> 8f964237215e8671a95502cd1ed201f6e3fd3de8
using VeterinariaFronted.Models;

namespace VeterinariaFronted.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
<<<<<<< HEAD
            _httpClient.BaseAddress = new Uri("https://localhost:7111/api");
        }


        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("Mascotas/VerMascotasCompleta");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                try
                {
                    var mascotas = JsonSerializer.Deserialize<IEnumerable<MascotasViewModel>>(content, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });

                    return View("Index", mascotas);
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Deserialización falló: {ex.Message}");
                }
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
            }

            return View(new List<MascotasViewModel>());
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
=======
            string apiUrl = Environment.GetEnvironmentVariable("API_URL") ?? "https://localhost:7111/api";
            _httpClient.BaseAddress = new Uri(apiUrl);
        }

        // Método para obtener la lista de productos
        public async Task<IActionResult> Productos()
        {
            var response = await _httpClient.GetAsync("/Productos");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<IEnumerable<Producto>>(content);
                return View(productos);
            }
            return View(new List<Producto>());
        }

        // Método para obtener la lista de ventas diarias
        public async Task<IActionResult> VentasDiarias()
        {
            var response = await _httpClient.GetAsync("/VentasDiarias");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ventasDiarias = JsonConvert.DeserializeObject<IEnumerable<VentasDiarias>>(content);
                return View(ventasDiarias);
            }
            return View(new List<VentasDiarias>());
        }

        // Método para obtener el inventario por mes
        public async Task<IActionResult> InventarioPorMes()
        {
            var response = await _httpClient.GetAsync("/InventarioPorMes");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var inventario = JsonConvert.DeserializeObject<IEnumerable<InventarioPorMes>>(content);
                return View(inventario);
            }
            return View(new List<InventarioPorMes>());
        }


        public async Task <IActionResult> Index()
        {
            return View();
        }
>>>>>>> 8f964237215e8671a95502cd1ed201f6e3fd3de8
    }
}
