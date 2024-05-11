using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace watchesASP.Api.Entities
{
    public class Watch
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int MovTypeId { get; set; }

        public MovType? MovType { get; set; }

        public decimal Price { get; set; }

        public string Style { get; set; }

        public string WaterResist { get; set; }

        public DateOnly ReleaseDate { get; set; }

    }
}