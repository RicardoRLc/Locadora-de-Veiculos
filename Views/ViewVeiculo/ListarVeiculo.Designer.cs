// using System;
// using Models;
// using Controllers;
// using System.Drawing;
// using System.Windows.Forms;
// using System.Collections.Generic;

// namespace Locadora_Veiculos_Ltda
// {
//     public partial class ListarVeiculos : Form
//     {
//         Library.ListView lv_ListaVeiculos;
//         Library.Button btn_ListaSair;
//         Form parent;

//         // List customer window
//         public void InitializeComponent(Form parent)
//         {
//             this.BackColor = Color.LightGray;
//             this.Font = new Font(this.Font, FontStyle.Bold);
//             this.Size = new Size(500, 380);
//             this.parent = parent;
            
//             this.lv_ListaVeiculos = new Library.ListView();
//             this.lv_ListaVeiculos.Location = new Point(0, 20);
//             this.lv_ListaVeiculos.Size = new Size(440, 250);
//             ListViewItem Vlv_ListaVeiculos = new ListViewItem();
//             List<ClienteModels> Vlv_ListaVeiculosLista = VeiculosController.GetVeiculos();
//             foreach (var veiculo in VeiculoLista)
//             {
//                 ListViewItem lv_ListaVeiculos = new ListViewItem(cliente.IdCliente.ToString());
//                 lv_ListaVeiculos.SubItems.Add(cliente.NomeCliente);
//                 lv_ListaVeiculos.SubItems.Add(cliente.DataNascimento);
//                 lv_ListaVeiculos.SubItems.Add(cliente.CpfCliente);
//                 lv_ListaVeiculos.SubItems.Add(cliente.DiasDevolucao.ToString());
//                 lv_ListaVeiculos.Items.Add(lv_ListaVeiculos);
//             }
//             this.lv_ListaVeiculos.MultiSelect = false;
//             this.lv_ListaVeiculos.Columns.Add("ID", -2, HorizontalAlignment.Center);
//             this.lv_ListaVeiculos.Columns.Add("Nome", -2, HorizontalAlignment.Left);
//             this.lv_ListaVeiculos.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Center);
//             this.lv_ListaVeiculos.Columns.Add("CPF", -2, HorizontalAlignment.Center);
//             this.lv_ListaVeiculos.Columns.Add("Dias Devolução", -2, HorizontalAlignment.Center);
//             this.Controls.Add(lv_ListaVeiculoss);
            
//             this.btn_ListaSair = new Library.Button();
//             this.btn_ListaSair.Location = new Point(160, 280);
//             this.btn_ListaSair.Text = "SAIR";
//             this.btn_ListaSair.Click += new EventHandler(btn_ListaSairClick);
//             this.Controls.Add(btn_ListaSair);
//         }
//     }
// }