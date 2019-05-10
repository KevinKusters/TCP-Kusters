using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionEscritorio
{
    public partial class frmPrincipal : Form
    {
        frmAgregarClientes client;
        frmAgregarTurnos turn;
        frmListarClientes listClient;
        frmListarTurnos listTurn;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (turn == null)
            {
                turn = new frmAgregarTurnos();
                turn.MdiParent = this;
                turn.FormClosed += new FormClosedEventHandler(turn_FormClosed);
                turn.Show();
            }
        }

        void turn_FormClosed(object sender, EventArgs e)
        {
            turn = null;
        }

        private void verTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listTurn == null)
            {
                listTurn = new frmListarTurnos();
                listTurn.MdiParent = this;
                listTurn.FormClosed += new FormClosedEventHandler(listTurn_FormClosed);
                listTurn.Show();
            }
        }

        void listTurn_FormClosed(object sender, EventArgs e)
        {
            listTurn = null;
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                client = new frmAgregarClientes();
                client.MdiParent = this;
                client.FormClosed += new FormClosedEventHandler(client_FormClosed);
                client.Show();
            }
        }
        void client_FormClosed(object sender, EventArgs e)
        {
            client = null;
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listClient == null)
            {
                listClient = new frmListarClientes();
                listClient.MdiParent = this;
                listClient.FormClosed += new FormClosedEventHandler(listClient_FormClosed);
                listClient.Show();
            }
        }

        void listClient_FormClosed(object sender, EventArgs e)
        {
            listClient = null;
        }
    }
}
