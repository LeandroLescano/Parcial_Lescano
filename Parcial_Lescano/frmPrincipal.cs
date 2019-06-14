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
    public partial class frmPrincipal : Form
    {
        private List<Mago> listado;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MagoNegocio negocio = new MagoNegocio();
            listado = negocio.listarMagos();
            dgvMagos.DataSource = listado;
            dgvMagos.Columns["ID"].Visible = false;
        }

        private void btnVerHechizos_Click(object sender, EventArgs e)
        {
            if (dgvMagos.CurrentRow.Index >= 0)
            {
                Mago mago = (Mago)dgvMagos.CurrentRow.DataBoundItem;
                frmHechizos ventanaH = new frmHechizos(mago);
                ventanaH.ShowDialog();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dgvMagos.DataSource = listado;
            }
            else
            {
                if (txtBusqueda.Text.Length >= 1)
                {
                    List<Mago> lista;
                    lista = listado.FindAll(X => X.Nombre != null && X.Nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper()));
                    dgvMagos.DataSource = lista;
                }
            }
        }

        private void btnAsociarHechizo_Click(object sender, EventArgs e)
        {
            if (dgvMagos.CurrentRow.Index >= 0)
            {
                Mago mago = (Mago)dgvMagos.CurrentRow.DataBoundItem;
                frmAsociarHechizos asociar = new frmAsociarHechizos(mago);
                asociar.ShowDialog();
            }
        }

    }
}

