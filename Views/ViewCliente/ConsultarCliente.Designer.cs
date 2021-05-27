using System;
using Models;
using Controllers;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Locadora_Veiculos_Ltda
{
    partial class ConsultaCliente : Form
    {
        Library.Label lbl_ConsultaCliente;
        ToolTip tt_BuscaCliente;
        Library.RichTextBox rtxt_ConsultaCliente;
        Library.ListView lv_ListaClientes;
        Library.Button btn_ListaConsulta;
        Library.Button btn_ListaSair;
        Form parent;

        public void InitializeComponent(Form parent)
        {

            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(500, 420);
            this.Dock = DockStyle.Fill;
            this.parent = parent;

            this.lbl_ConsultaCliente = new Library.Label();
            this.lbl_ConsultaCliente.Text = "Buscar Cliente :";
            this.lbl_ConsultaCliente.Location = new Point(30, 20);
            this.Controls.Add(lbl_ConsultaCliente);

            this.tt_BuscaCliente = new Library.ToolTip();

            this.rtxt_ConsultaCliente = new Library.RichTextBox();
            this.rtxt_ConsultaCliente.Location = new Point(150, 20);
            this.Controls.Add(rtxt_ConsultaCliente);
            this.tt_BuscaCliente.SetToolTip(rtxt_ConsultaCliente, "Digite o nome ou selecione abaixo");
            this.rtxt_ConsultaCliente.KeyPress += new KeyPressEventHandler(keypressed);

            this.lv_ListaClientes = new Library.ListView();
            this.lv_ListaClientes.Location = new Point(20, 50);
            this.lv_ListaClientes.Size = new Size(440, 250);
            List<ClienteModels> listaCliente = (from cliente in ClienteController.GetClientes() where cliente.NomeCliente.Contains(rtxt_ConsultaCliente.Text) select cliente).ToList();
            ListViewItem clientes = new ListViewItem();
            foreach (ClienteModels cliente in ClienteController.GetClientes())
            {
                ListViewItem lv_ListaCliente = new ListViewItem(cliente.IdCliente.ToString());
                lv_ListaCliente.SubItems.Add(cliente.NomeCliente);
                lv_ListaCliente.SubItems.Add(cliente.DataNascimento);
                lv_ListaCliente.SubItems.Add(cliente.CpfCliente);
                lv_ListaCliente.SubItems.Add(cliente.DiasDevolucao.ToString());
                lv_ListaClientes.Items.Add(lv_ListaCliente);
            }
            this.lv_ListaClientes.MultiSelect = false;
            this.lv_ListaClientes.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            this.lv_ListaClientes.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("CPF", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("Dias Devolução", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaClientes);

            Task t = new Task(new Action(() => { RefreshForm(); }));
            t.Start();

            this.btn_ListaConsulta = new Library.Button();
            this.btn_ListaConsulta.Location = new Point(80, 310);
            this.btn_ListaConsulta.Text = "CONSULTA";
            this.btn_ListaConsulta.Click += new EventHandler(btn_ListaConsultaClick);
            this.Controls.Add(btn_ListaConsulta);

            this.btn_ListaSair = new Library.Button();
            this.btn_ListaSair.Location = new Point(260, 310);
            this.btn_ListaSair.Text = "SAIR";
            this.btn_ListaSair.Click += new EventHandler(btn_ListaSairClick);
            this.Controls.Add(btn_ListaSair);
        }
    }
}