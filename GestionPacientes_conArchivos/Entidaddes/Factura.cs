using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public static List<Factura> ObtenerListadoDeFacturas()
        {
            var facturasEnum = Enum.GetValues(typeof(TipoFactura)).Cast<TipoFactura>().ToList();

            return (from fe in facturasEnum
                    select new Factura()
                    {
                        Text = fe.ToString().Replace('_', ' '),
                        Value = (int)fe
                    }).ToList();
        }

        public static string ObtenerNombreFactura(int value)
        {
            var facturas = Factura.ObtenerListadoDeFacturas();

            return (from f in facturas
                   where f.Value == value
                   select f.Text).FirstOrDefault();
        }
    }
}
