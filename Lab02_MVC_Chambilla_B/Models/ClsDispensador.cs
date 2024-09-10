using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02_MVC_Chambilla_B.Models
{
    public class ClsDispensador
    {
        public double monto { get; set; }
        public int b10 { get; set; }
        public int b20 { get; set; }
        public int b50 { get; set; }
        public int b100 { get; set; }
        public int m5 { get; set; }
        public int m2 { get; set; }
        public int m1 { get; set; }
        public double c05 { get; set; }
        public double c02 { get; set; }
        public double c01 { get; set; }

        public int cantidadm { get; set; }
        public double cantidadc { get; set; }

        public int cantidadb { get; set; }
        public int cantidad { get; set; }
    }
}