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
using AccesoDatos;

namespace PresentacionEscritorio
{
    public partial class frmListarClientes : Form
    {
        private List<Cliente> listaClientesLocal;
        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void dgbClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarGrilla()
        {

            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                listaClientesLocal = negocio.Listarclientes();
                dgbClientes.DataSource = listaClientesLocal;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}

