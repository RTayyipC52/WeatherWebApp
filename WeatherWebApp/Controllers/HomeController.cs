using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebApp.Models;

namespace WeatherWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var model = new List<Location>();
            
            return View(GetLocations());
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

        public List<Location> GetLocations()
        {
            List<Location> locations = new List<Location>();
            {
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "Pazartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:7°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "Salı", Weather = "Güneşli", Temperature = "Max:25°C Min:9°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "Çarşamba", Weather = "Yağmurlu", Temperature = "Max:12°C Min:5°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "Perşembe", Weather = "Kar Yağışlı", Temperature = "Max:10°C Min:3°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:15°C Min:7°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "Cumartesi", Weather = "Bulutlu", Temperature = "Max:16°C Min:6°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "Pazar", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:14°C Min:4°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "Pazartesi", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:9°C Min:3°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "Salı", Weather = "Güneşli", Temperature = "Max:13°C Min:8°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "Çarşamba", Weather = "Bulutlu", Temperature = "Max:14°C Min:9°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "Perşembe", Weather = "Yağmurlu", Temperature = "Max:12°C Min:6°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:15°C Min:8°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "Cumartesi", Weather = "Bulutlu", Temperature = "Max:16°C Min:7°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "Pazar", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:13°C Min:6°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "Pazartesi", Weather = "Yağmurlu", Temperature = "Max:15°C Min:8°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "Salı", Weather = "Bulutlu", Temperature = "Max:16°C Min:7°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "Çarşamba", Weather = "Yağmurlu", Temperature = "Max:14°C Min:9°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "Perşembe", Weather = "Parçalı Bulutlu", Temperature = "Max:17°C Min:8°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:18°C Min:10°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "Cumartesi", Weather = "Bulutlu", Temperature = "Max:16°C Min:9°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "Pazar", Weather = "Güneşli", Temperature = "Max:21°C Min:11°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "Pazartesi", Weather = "Bulutlu", Temperature = "Max:19°C Min:10°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "Salı", Weather = "Güneşli", Temperature = "Max:24°C Min:12°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "Çarşamba", Weather = "Yağmurlu", Temperature = "Max:15°C Min:7°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "Perşembe", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:13°C Min:5°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "Cuma", Weather = "Kar Yağışlı", Temperature = "Max:11°C Min:0°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "Cumartesi", Weather = "Kar Yağışlı", Temperature = "Max:10°C Min:-1°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "Pazar", Weather = "Yağmurlu", Temperature = "Max:11°C Min:7°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "Pazartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "Salı", Weather = "Parçalı Bulutlu", Temperature = "Max:18°C Min:8°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "Çarşamba", Weather = "Yağmurlu", Temperature = "Max:14°C Min:6°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "Perşembe", Weather = "Kar Yağışlı", Temperature = "Max:11°C Min:4°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:14°C Min:7°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "Cumartesi", Weather = "Bulutlu", Temperature = "Max:15°C Min:8°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "Pazar", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:13°C Min:6°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "Pazartesi", Weather = "Yağmurlu", Temperature = "Max:12°C Min:4°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "Salı", Weather = "Güneşli", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "Çarşamba", Weather = "Yağmurlu", Temperature = "Max:15°C Min:6°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "Perşembe", Weather = "Kar Yağışlı", Temperature = "Max:10°C Min:3°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:14°C Min:6°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "Cumartesi", Weather = "Bulutlu", Temperature = "Max:16°C Min:8°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "Pazar", Weather = "Güneşli", Temperature = "Max:21°C Min:9°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "Pazartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "Salı", Weather = "Güneşli", Temperature = "Max:23°C Min:10°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "Çarşamba", Weather = "Yağmurlu", Temperature = "Max:15°C Min:6°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "Perşembe", Weather = "Kar Yağışlı", Temperature = "Max:12°C Min:5°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:14°C Min:8°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "Cumartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "Pazar", Weather = "Güneşli", Temperature = "Max:21°C Min:8°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "Pazartesi", Weather = "Yağmurlu", Temperature = "Max:17°C Min:8°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "Salı", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "Çarşamba", Weather = "Yağmurlu", Temperature = "Max:15°C Min:7°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "Perşembe", Weather = "Yağmurlu", Temperature = "Max:16°C Min:7°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "Cumartesi", Weather = "Bulutlu", Temperature = "Max:19°C Min:7°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "Pazar", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:11°C Min:2°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "Pazartesi", Weather = "Kar Yağışlı", Temperature = "Max:9°C Min:1°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "Salı", Weather = "Güneşli", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "Çarşamba", Weather = "Yağmurlu", Temperature = "Max:12°C Min:6°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "Perşembe", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "Cuma", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:11°C Min:5°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "Cumartesi", Weather = "Kar Yağışlı", Temperature = "Max:8°C Min:2°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "Pazar", Weather = "Yağmurlu", Temperature = "Max:15°C Min:7°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "Pazartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:8°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "Salı", Weather = "Yağmurlu", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "Çarşamba", Weather = "Yağmurlu", Temperature = "Max:13°C Min:7°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "Perşembe", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:11°C Min:6°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "Cuma", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:9°C Min:2°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "Cumartesi", Weather = "Bulutlu", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "Pazar", Weather = "Güneşli", Temperature = "Max:18°C Min:9°C" });
            };
            return locations;
        }
    }
}
