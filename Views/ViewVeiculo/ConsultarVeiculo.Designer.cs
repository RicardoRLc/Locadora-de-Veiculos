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
    partial class ConsultaVeiculo : Form
    {
        Library.Label lbl_ConsultaVeiculo;
        ToolTip tt_BuscaVeiculo;
        Library.RichTextBox rtxt_ConsultaVeiculo;
        Library.ListView lv_ListaVeiculos;
        Library.Button btn_ListaConsulta;
        Library.Button btn_ListaSair;
        Form parent;
        
        public void InitializeComponent(Form parent)
        {

            this.BackColor = Color.DarkGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(500, 420);
            this.Dock = DockStyle.Fill;
            this.parent = parent;

            this.lbl_ConsultaVeiculo = new Library.Label();
            this.lbl_ConsultaVeiculo.Text = "Buscar Veiculo :";
            this.lbl_ConsultaVeiculo.Location = new Point(30, 20);
            this.Controls.Add(lbl_ConsultaVeiculo);

            this.tt_BuscaVeiculo = new Library.ToolTip();

            this.rtxt_ConsultaVeiculo = new Library.RichTextBox();
            this.rtxt_ConsultaVeiculo.Location = new Point(150, 20);
            this.Controls.Add(rtxt_ConsultaVeiculo);
            this.tt_BuscaVeiculo.SetToolTip(rtxt_ConsultaVeiculo, "Digite o nome ou selecione abaixo");
            this.rtxt_ConsultaVeiculo.KeyPress += new KeyPressEventHandler(keypressed);

            this.lv_ListaVeiculos = new Library.ListView();
            this.lv_ListaVeiculos.Location = new Point(20, 50);
            this.lv_ListaVeiculos.Size = new Size(440, 250);
            List<VeiculoModels> listaVeiculo = (from veiculo in VeiculoController.GetVeiculos() where veiculo.Marca.Contains(rtxt_ConsultaVeiculo.Text) select veiculo).ToList();
            ListViewItem veiculos = new ListViewItem();
            foreach (VeiculoModels veiculo in VeiculoController.GetVeiculos())
            {
                ListViewItem lv_ListaVeiculo = new ListViewItem(veiculo.IdVeiculo.ToString());
                lv_ListaVeiculo.SubItems.Add(veiculo.Marca);
                lv_ListaVeiculo.SubItems.Add(veiculo.Modelo);
                lv_ListaVeiculo.SubItems.Add(veiculo.Ano);
                lv_ListaVeiculo.SubItems.Add(veiculo.ValorLocacaoVeiculo.ToString());
                lv_ListaVeiculo.SubItems.Add(veiculo.EstoqueVeiculo.ToString());
                lv_ListaVeiculos.Items.Add(lv_ListaVeiculo);
            }
            this.lv_ListaVeiculos.MultiSelect = false;
            this.lv_ListaVeiculos.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaVeiculos.Columns.Add("Marca", -2, HorizontalAlignment.Left);
            this.lv_ListaVeiculos.Columns.Add("Modelo", -2, HorizontalAlignment.Center);
            this.lv_ListaVeiculos.Columns.Add("Ano", -2, HorizontalAlignment.Center);
            this.lv_ListaVeiculos.Columns.Add("Valor Loca????o", -2, HorizontalAlignment.Center);
            this.lv_ListaVeiculos.Columns.Add("Qtde Estoque", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaVeiculos);

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