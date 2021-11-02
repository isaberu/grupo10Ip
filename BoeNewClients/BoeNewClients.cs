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
            //TODO: Al abrir la aplicacion comprobar si existen ya clientes cargados del día de hoy. Si aún no se han importado preguntamos al usuario si quiere buscar e importa los nuevos clientes.
            marcaFechasCalendario();
            cargaProvincias();

        }

        /* Cargamos los clientes de forma dinamica parseando*/
        private void cargarClientes_Click(object sender, EventArgs e)
        {
            DateTime fecha;
            String dia;
            String mes;
            String year;
            String url;

            fecha = calendarioCargarClientes.Value;
            dia = fecha.ToString("dd");
            mes = fecha.ToString("MM");
            year = fecha.ToString("yyyy");
            url = "https://www.boe.es/borme/dias/" + year + "/" + mes + "/"  + dia;//https://www.boe.es/borme/dias/2021/03/05/
            System.Diagnostics.Process.Start(url);

            //TODO. Abrir directamente el pdf por medio del código de las provincia que tienen asignadas en la web del BOE, seleccionando previamente la provincia.

            //Mejora. Leer pdf en busca de nuevas empresas que no tengamos en base de datos.
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

            //se debe mejorar con el try catch para evitar que se cierre el fomrulario inesperadamente

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

            this.calendarioMarcado.BoldedDates = DataLayer.GetFechasCargadas(fecha_desde, fecha_hasta).ToArray();


        }

        private void cargaProvincias() {
            //se debe mejorar con el try catch para evitar que se cierre el fomrulario inesperadamente
            List<String> provincias;

            provincias = DataLayer.GetProvincias();
            foreach (String provincia in provincias) {
                comboProvincias.Items.Add(provincia);
            
            }
        }

        private void buscarClientes_Click(object sender, EventArgs e)
        {
            //se debe mejorar con el try catch para evitar que se cierre el fomrulario inesperadamente
            List<List<String>> resultados;
            String provincia = "";

            if (comboProvincias.SelectedItem != null) {
                provincia = comboProvincias.SelectedItem.ToString();
            }

            dataGridResultados.ColumnCount = 4;
            dataGridResultados.Columns[0].Name = "Nombre empresa";
            dataGridResultados.Columns[1].Name = "Provincia";
            dataGridResultados.Columns[2].Name = "Teléfono";
            dataGridResultados.Columns[3].Name = "Contactado";

            resultados = DataLayer.GetResultados(provincia, calendarioBuscador.Value);
            //dataGridResultados.DataSource (resultados); //Datos deueltos con la consulta en base de datos
            //como es uns lista:
            dataGridResultados.Rows.Clear();
            foreach (List<String> resultado in resultados) {
                dataGridResultados.Rows.Add(resultado.ToArray());
            }



        }

        private void comboProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
