using Entidad;
using Negocio;
using Presentacion.Contabilidad; 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Contabilidad.Periodo
{
    public partial class FrmPeriodo_Lista : Form
    {
        //Objeto de la clase Negocio.
        ClsPeriodoNg ObjPeriodoNg = new ClsPeriodoNg();

        //Variables paginado.
        private int pageSize = 30;
        private int pageNumber = 1;
        private int totalRecords = 0;


        public FrmPeriodo_Lista()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            //this.DgwPeriodo.DataSource = ObjPeriodoNg.ListaPeriodo();
            DataSet ds = ObjPeriodoNg.ObtenerDatosPaginados(pageNumber, pageSize, out totalRecords);
            this.DgwPeriodo.DataSource = ds.Tables[0];

            LblPaginaInicio.Text = $"Pagina: {pageNumber}";
            LblTotalRegistro.Text = $"Total Registros: {totalRecords}";

            // Habilitar/Deshabilitar botones de navegación
            this.BtnAnterior.Enabled = pageNumber > 1;
            this.BtnSiguiente.Enabled = pageNumber * pageSize < totalRecords;


        }
        private void FrmPeriodo_Lista_Load(object sender, EventArgs e)
        {
            CargarDatos();  

        }    

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (pageNumber * pageSize < totalRecords)
            {
                pageNumber++;
                CargarDatos();
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                CargarDatos();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnGuardar.BackColor = Color.FromArgb(251, 236, 93);
            this.BtnModificar.BackColor = SystemColors.Control;
            this.BtnEliminar.BackColor = SystemColors.Control;
            this.BtnCerrar.BackColor = SystemColors.Control;
            this.BtnCerrar.ForeColor = Color.Black;
        }

        private void BtnModificar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnModificar.BackColor = Color.FromArgb(251, 236, 93);
            this.BtnGuardar.BackColor = SystemColors.Control;
            this.BtnEliminar.BackColor = SystemColors.Control;
            this.BtnCerrar.BackColor = SystemColors.Control;
            this.BtnCerrar.ForeColor = Color.Black;
        }

        private void BtnEliminar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnEliminar.BackColor = Color.FromArgb(251, 236, 93);
            this.BtnGuardar.BackColor = SystemColors.Control;
            this.BtnModificar.BackColor = SystemColors.Control;
            this.BtnCerrar.BackColor = SystemColors.Control;
            this.BtnCerrar.ForeColor = Color.Black;
        }

        private void PnlAbajo_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnGuardar.BackColor = SystemColors.Control;
            this.BtnModificar.BackColor = SystemColors.Control;
            this.BtnEliminar.BackColor = SystemColors.Control;
            this.BtnCerrar.BackColor = SystemColors.Control;
            this.BtnCerrar.ForeColor = Color.Black;
        }

        private void BtnCerrar_MouseEnter_1(object sender, EventArgs e)
        {
            this.BtnCerrar.BackColor = Color.FromArgb(232, 35, 0);
            this.BtnCerrar.ForeColor = Color.White;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
