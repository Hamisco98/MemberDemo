using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MemberDemo.Models.Classes
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }

        [InverseProperty(nameof(City.Country))]
        public ICollection<City> Cities { get; set; }
    }
}
