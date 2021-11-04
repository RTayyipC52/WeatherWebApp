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
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "1.11.2021 - Pazartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:7°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "2.11.2021 - Salı", Weather = "Güneşli", Temperature = "Max:25°C Min:9°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "3.11.2021 - Çarşamba", Weather = "Yağmurlu", Temperature = "Max:12°C Min:5°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "4.11.2021 - Perşembe", Weather = "Kar Yağışlı", Temperature = "Max:10°C Min:3°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "5.11.2021 - Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:15°C Min:7°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "6.11.2021 - Cumartesi", Weather = "Bulutlu", Temperature = "Max:16°C Min:6°C" });
                locations.Add(new Location() { CityId = 1, CityName = "Ankara", Date = "7.11.2021 - Pazar", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:14°C Min:4°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "1.11.2021 - Pazartesi", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:9°C Min:3°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "2.11.2021 - Salı", Weather = "Güneşli", Temperature = "Max:13°C Min:8°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "3.11.2021 - Çarşamba", Weather = "Bulutlu", Temperature = "Max:14°C Min:9°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "4.11.2021 - Perşembe", Weather = "Yağmurlu", Temperature = "Max:12°C Min:6°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "5.11.2021 - Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:15°C Min:8°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "6.11.2021 - Cumartesi", Weather = "Bulutlu", Temperature = "Max:16°C Min:7°C" });
                locations.Add(new Location() { CityId = 2, CityName = "İstanbul", Date = "7.11.2021 - Pazar", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:13°C Min:6°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "1.11.2021 - Pazartesi", Weather = "Yağmurlu", Temperature = "Max:15°C Min:8°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "2.11.2021 - Salı", Weather = "Bulutlu", Temperature = "Max:16°C Min:7°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "3.11.2021 - Çarşamba", Weather = "Yağmurlu", Temperature = "Max:14°C Min:9°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "4.11.2021 - Perşembe", Weather = "Parçalı Bulutlu", Temperature = "Max:17°C Min:8°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "5.11.2021 - Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:18°C Min:10°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "6.11.2021 - Cumartesi", Weather = "Bulutlu", Temperature = "Max:16°C Min:9°C" });
                locations.Add(new Location() { CityId = 3, CityName = "İzmir", Date = "7.11.2021 - Pazar", Weather = "Güneşli", Temperature = "Max:21°C Min:11°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "1.11.2021 - Pazartesi", Weather = "Bulutlu", Temperature = "Max:19°C Min:10°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "2.11.2021 - Salı", Weather = "Güneşli", Temperature = "Max:24°C Min:12°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "3.11.2021 - Çarşamba", Weather = "Yağmurlu", Temperature = "Max:15°C Min:7°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "4.11.2021 - Perşembe", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:13°C Min:5°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "5.11.2021 - Cuma", Weather = "Kar Yağışlı", Temperature = "Max:11°C Min:0°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "6.11.2021 - Cumartesi", Weather = "Kar Yağışlı", Temperature = "Max:10°C Min:-1°C" });
                locations.Add(new Location() { CityId = 4, CityName = "Rize", Date = "7.11.2021 - Pazar", Weather = "Yağmurlu", Temperature = "Max:11°C Min:7°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "1.11.2021 - Pazartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "2.11.2021 - Salı", Weather = "Parçalı Bulutlu", Temperature = "Max:18°C Min:8°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "3.11.2021 - Çarşamba", Weather = "Yağmurlu", Temperature = "Max:14°C Min:6°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "4.11.2021 - Perşembe", Weather = "Kar Yağışlı", Temperature = "Max:11°C Min:4°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "5.11.2021 - Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:14°C Min:7°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "6.11.2021 - Cumartesi", Weather = "Bulutlu", Temperature = "Max:15°C Min:8°C" });
                locations.Add(new Location() { CityId = 5, CityName = "Adana", Date = "7.11.2021 - Pazar", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:13°C Min:6°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "1.11.2021 - Pazartesi", Weather = "Yağmurlu", Temperature = "Max:12°C Min:4°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "2.11.2021 - Salı", Weather = "Güneşli", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "3.11.2021 - Çarşamba", Weather = "Yağmurlu", Temperature = "Max:15°C Min:6°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "4.11.2021 - Perşembe", Weather = "Kar Yağışlı", Temperature = "Max:10°C Min:3°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "5.11.2021 - Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:14°C Min:6°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "6.11.2021 - Cumartesi", Weather = "Bulutlu", Temperature = "Max:16°C Min:8°C" });
                locations.Add(new Location() { CityId = 6, CityName = "Trabzon", Date = "7.11.2021 - Pazar", Weather = "Güneşli", Temperature = "Max:21°C Min:9°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "1.11.2021 - Pazartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "2.11.2021 - Salı", Weather = "Güneşli", Temperature = "Max:23°C Min:10°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "3.11.2021 - Çarşamba", Weather = "Yağmurlu", Temperature = "Max:15°C Min:6°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "4.11.2021 - Perşembe", Weather = "Kar Yağışlı", Temperature = "Max:12°C Min:5°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "5.11.2021 - Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:14°C Min:8°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "6.11.2021 - Cumartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 7, CityName = "Ordu", Date = "7.11.2021 - Pazar", Weather = "Güneşli", Temperature = "Max:21°C Min:8°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "1.11.2021 - Pazartesi", Weather = "Yağmurlu", Temperature = "Max:17°C Min:8°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "2.11.2021 - Salı", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "3.11.2021 - Çarşamba", Weather = "Yağmurlu", Temperature = "Max:15°C Min:7°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "4.11.2021 - Perşembe", Weather = "Yağmurlu", Temperature = "Max:16°C Min:7°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "5.11.2021 - Cuma", Weather = "Parçalı Bulutlu", Temperature = "Max:17°C Min:9°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "6.11.2021 - Cumartesi", Weather = "Bulutlu", Temperature = "Max:19°C Min:7°C" });
                locations.Add(new Location() { CityId = 8, CityName = "Paris", Date = "7.11.2021 - Pazar", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:11°C Min:2°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "1.11.2021 - Pazartesi", Weather = "Kar Yağışlı", Temperature = "Max:9°C Min:1°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "2.11.2021 - Salı", Weather = "Güneşli", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "3.11.2021 - Çarşamba", Weather = "Yağmurlu", Temperature = "Max:12°C Min:6°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "4.11.2021 - Perşembe", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "5.11.2021 - Cuma", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:11°C Min:5°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "6.11.2021 - Cumartesi", Weather = "Kar Yağışlı", Temperature = "Max:8°C Min:2°C" });
                locations.Add(new Location() { CityId = 9, CityName = "Londra", Date = "7.11.2021 - Pazar", Weather = "Yağmurlu", Temperature = "Max:15°C Min:7°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "1.11.2021 - Pazartesi", Weather = "Bulutlu", Temperature = "Max:17°C Min:8°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "2.11.2021 - Salı", Weather = "Yağmurlu", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "3.11.2021 - Çarşamba", Weather = "Yağmurlu", Temperature = "Max:13°C Min:7°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "4.11.2021 - Perşembe", Weather = "Gök Gürültülü Sağanak Yağışlı", Temperature = "Max:11°C Min:6°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "5.11.2021 - Cuma", Weather = "Karla Karışık Yağmurlu", Temperature = "Max:9°C Min:2°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "6.11.2021 - Cumartesi", Weather = "Bulutlu", Temperature = "Max:14°C Min:5°C" });
                locations.Add(new Location() { CityId = 10, CityName = "New York", Date = "7.11.2021 - Pazar", Weather = "Güneşli", Temperature = "Max:18°C Min:9°C" });
            };
            return locations;
        }
    }
}
