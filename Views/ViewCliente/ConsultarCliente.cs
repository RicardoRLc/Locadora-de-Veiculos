using System;
using Models;
using Controllers;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Locadora_Veiculos_Ltda
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente(Form parent)
        {
            InitializeComponent(parent);
        }

        public void RefreshForm()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(this.RefreshForm));
            }
            Application.DoEvents();
        }
        
        private void keypressed(Object o, KeyPressEventArgs e)
        {
            lv_ListaClientes.Items.Clear();
            List<ClienteModels> listaCliente = (from cliente in ClienteController.GetClientes() where cliente.NomeCliente.Contains(rtxt_ConsultaCliente.Text, StringComparison.OrdinalIgnoreCase) select cliente).ToList();
            ListViewItem clientes = new ListViewItem();
            foreach (ClienteModels cliente in listaCliente)
            {
                ListViewItem lv_ListaCliente = new ListViewItem(cliente.IdCliente.ToString());
                lv_ListaCliente.SubItems.Add(cliente.NomeCliente);
                lv_ListaCliente.SubItems.Add(cliente.DataNascimento);
                lv_ListaCliente.SubItems.Add(cliente.CpfCliente);
                lv_ListaCliente.SubItems.Add(cliente.DiasDevolucao.ToString());
                lv_ListaClientes.Items.Add(lv_ListaCliente);
            }
            this.Refresh();
            Application.DoEvents();
        }


        private void btn_ListaConsultaClick(object sender, EventArgs e)
        {
            try
            {
                string IdCliente = this.lv_ListaClientes.SelectedItems[0].Text;
                ClienteModels cliente = ClienteController.GetCliente(Int32.Parse(IdCliente));
                ClienteDetalhe btn_ListaConsultaClick = new ClienteDetalhe(this, cliente);
                btn_ListaConsultaClick.Show();
            }
            catch
            {
                MessageBox.Show("Selecione Um Cliente!");
            }
        }
        
        private void btn_ListaSairClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}