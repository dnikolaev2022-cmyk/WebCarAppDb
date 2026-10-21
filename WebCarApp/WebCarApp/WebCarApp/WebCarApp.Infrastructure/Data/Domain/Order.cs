using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCarApp.Infrastructure.Data.Domain
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int CarId { get; set; } 

        public DateTime OrderDate { get; set; }

        public Client Client { get; set; }

        public Car Car { get; set; }
    }
}
