using Entidad;
using Datos;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Negocio
{
    public class ClsPeriodoNg
    {
        ClsPeriodoDt ObjPeriodoDt = new ClsPeriodoDt();
        
        public DataTable ListaPeriodo()
        {
            return ObjPeriodoDt.ListaPeriodo();
        }

        public void NuevoPeriodo(ClsPeriodoEn c)
        {
            ObjPeriodoDt.NuevoPeriodo(c);
        }

        public DataSet ObtenerDatosPaginados(int pageNumber, int pageSize, out int totalRecords)
        {
            return ObjPeriodoDt.ObtenerDatosPaginados(pageNumber, pageSize, out totalRecords);
        }


    }
}
