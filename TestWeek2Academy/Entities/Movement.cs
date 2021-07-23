using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2Academy.Entities
{
    public interface Movement
    {
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }

    }
}
