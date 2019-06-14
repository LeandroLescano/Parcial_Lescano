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
    public partial class frmAsociarHechizos : Form
    {
        private Mago magoLocal;
        HechizoNegocio negocio = new HechizoNegocio();

        public frmAsociarHechizos()
        {
            InitializeComponent();
        }

        public frmAsociarHechizos(Mago m)
        {
            InitializeComponent();
            magoLocal = m;
        }

        private void frmAsociarHechizos_Load(object sender, EventArgs e)
        {
            txtNombre.Text = magoLocal.Nombre;
            txtCasa.Text = magoLocal.Casa.Descripcion;
            cmbHechizos.DataSource = negocio.listarHechizos();
            cmbHechizos.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Hechizo hAgregar = (Hechizo)cmbHechizos.SelectedItem;
            List<Hechizo> hechizosAsociados = new List<Hechizo>();
            hechizosAsociados = negocio.listarHechizosXMago(magoLocal);
            foreach (Hechizo h in hechizosAsociados)
            {
                if(h.Nombre == hAgregar.Nombre)
                {
                    MessageBox.Show("Este hechizo ya está asociado al mago.", "Cuidado!");
                    return;
                }
            }

            negocio.agregarHechizo(magoLocal, hAgregar);
            MessageBox.Show("Hechizo '" + hAgregar.Nombre + "' asociado al mago '" + magoLocal.Nombre + "'.");
            this.Close();
        }
    }
}
