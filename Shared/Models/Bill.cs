using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public int Id_Stuff { get; set; }

    }
}
