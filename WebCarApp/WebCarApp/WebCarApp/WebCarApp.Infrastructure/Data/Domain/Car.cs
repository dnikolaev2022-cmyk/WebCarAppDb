using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCarApp.Infrastructure.Data.Domain
{
    public class Car
    {
        public int Id { get; set; }

        public string Model { get; set; } = string.Empty;

        public string Picture { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; }
            = new List<Order>();
    }
}
