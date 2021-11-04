using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebApp.Models
{
    public class Location
    {
        [Required]
        [DisplayName("Şehir Id")]
        public int CityId { get; set; }

        [Required]
        [DisplayName("Şehir Adı")]
        public string CityName { get; set; }

        [Required]
        [DisplayName("Tarih")]
        public string Date { get; set; }

        [Required]
        [DisplayName("Havadurumu Tahmini Bilgisi")]
        public string Weather { get; set; }

        [Required]
        [DisplayName("Hissedilen Sıcaklık")]
        public string Temperature { get; set; }


    }
}
