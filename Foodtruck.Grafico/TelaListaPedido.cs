using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class TelaListaPedido : Form
    {
        public TelaListaPedido()
        {
            InitializeComponent();
        }

        private void TelaListaPedido_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CarregarPedidos()
        {
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.AutoGenerateColumns = false;
            List<Pedido> pedidos = Program.Gerenciador.TodosOsPedidos();
            dgPedidos.DataSource = pedidos;
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarPedidos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
