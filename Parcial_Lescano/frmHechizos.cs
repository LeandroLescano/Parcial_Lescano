using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Parcial_Lescano
{
    public partial class frmHechizos : Form
    {
        private List<Hechizo> listado;
        private Mago magoLocal;
        public frmHechizos()
        {
            InitializeComponent();
        }

        public frmHechizos(Mago mago)
        {
            InitializeComponent();
            magoLocal = mago;
        }

        private void Hechizos_Load(object sender, EventArgs e)
        {
            HechizoNegocio negocio = new HechizoNegocio();
            listado = negocio.listarHechizosXMago(magoLocal);
            dgvHechizos.DataSource = listado;
            dgvHechizos.Columns["ID"].Visible = false;
            dgvHechizos.Columns["HechizoVencedor"].Visible = false;
            lblMago.Text += magoLocal.Nombre;
        }
    }
}
