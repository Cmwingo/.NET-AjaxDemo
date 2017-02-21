using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxDemo.Models
{
    public class Destination
    {
        public string City { get; set; }
        public string Country { get; set; }
        public int Id { get; set; }

        public Destination (string city, string country, int id =0)
        {
            City = city;
            Country = country;
            Id = id;
        }
    }
}
