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
        }


    }
}
