using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsPeriodoEn
    {
        public int IDPeriodo { get; set; }
        public int? Periodo { get; set; }
        public DateTime? FechaInicioPeriodo { get; set; }
        public DateTime? FechaFinalPeriodo { get; set; }
        public string EstadoPeriodo { get; set; }
        public DateTime? FechaInicioContabilidad { get; set; }
        public DateTime? FechaInicioVencimiento { get; set; }
        public DateTime? FechaFinalContabilidad { get; set; }
        public DateTime? FechaFinalVencimiento { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }
}
