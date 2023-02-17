using OnionArchitecture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Data
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string Detail { get; set; } = null!;

        public int StockAvilable { get; set; }

    }
}
