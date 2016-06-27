using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Factura
    {
        private DateTime fecha;
        private double importeTotal;
        private int idVendedor;
        private int numero;
        private int idFormaDePago;
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public double ImporteTotal { get { return importeTotal; } set { importeTotal = value; } }
        public int IdVendedor { get { return idVendedor; } set { idVendedor = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public int IdFormaDePago { get { return idFormaDePago; } set { idFormaDePago = value; } }
    }
}
