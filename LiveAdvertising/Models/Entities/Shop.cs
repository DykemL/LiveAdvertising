using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveAdvertising.Models.Entities
{
    public class Shop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public List<Stream> Streams { get; set; }
    }
}
