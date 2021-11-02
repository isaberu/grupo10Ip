using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoeNewClients
{
    public partial class BoeNewClients : Form
    {
        public BoeNewClients()
        {
            InitializeComponent();
        }

        private void BoeNewClients_Load(object sender, EventArgs e)
        {
            //TODO: Al abrir la aplicacion vamos a comprobar si existen ya clientes del día de hoy. Si aún no se han importado preguntamos al usuario si quiere buscar e importa los nuevos clientes. 
            marcaFechasCalendario();

        }

        private void cargarClientes_Click(object sender, EventArgs e)
        {
            DateTime fecha;
            fecha = calendarioCargarClientes.Value;
            MessageBox.Show(fecha.ToString("dd/MM/yyyy"), "Hola", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void calendarioMarcado_DateChanged(object sender, DateRangeEventArgs e)
        {
            marcaFechasCalendario(true);
        }

        //funcionalidad
        private void marcaFechasCalendario(Boolean dateChanged = false)
        {
            
            DateTime fecha_desde;
            DateTime fecha_hasta;
            Random rnd = new Random();

            if (dateChanged)
            {
                fecha_desde = this.calendarioMarcado.SelectionStart;
            }
            else
            {
                fecha_desde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);   
            }

            fecha_hasta = fecha_desde.AddMonths(2).AddDays(-1);
            this.calendarioMarcado.MaxDate = fecha_hasta;
            //TODO. Bucar en BBDD en el rango de fechas.
            //MessageBox.Show(fecha_desde.ToString("dd/MM/yyyy") + " - " + fecha_hasta.ToString("dd/MM/yyyy"), "Hola", MessageBoxButtons.OK, MessageBoxIcon.Question);

            this.calendarioMarcado.BoldedDates =
            new System.DateTime[] { new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                                    new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                                    new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                                    new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                                    new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                                    new System.DateTime(2021, fecha_hasta.Month, rnd.Next(1, 30))};

            
        }


    }
}
