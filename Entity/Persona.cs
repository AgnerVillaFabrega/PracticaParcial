using System;

namespace Entity
{
    public class Persona
    {
        public string TipoContrato { get; set; }
        public decimal NIT { get; set; }
        public string NombreTercero { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal ValorPagado { get; set; }

        public Persona()
        {
        }

        public Persona(string tipoContrato, decimal nIT, string nombreTercero, DateTime fechaPago, decimal valorPagado)
        {
            TipoContrato = tipoContrato;
            NIT = nIT;
            NombreTercero = nombreTercero;
            FechaPago = fechaPago;
            ValorPagado = valorPagado;
        }
        public override string ToString()
        {
            return $"{TipoContrato};{NIT};{NombreTercero};{FechaPago.ToString("dd/MM/yyyy")};{ValorPagado}";
        }
    }
}
