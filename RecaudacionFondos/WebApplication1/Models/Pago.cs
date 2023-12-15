using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int IdParticipante { get; set; }
        public DateTime Fecha { get; set; }
        public int Monto { get; set; }
    }
}