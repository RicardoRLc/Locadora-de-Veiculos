// using System;
// using Models;
// using Controllers;
// using System.Windows.Forms;

// namespace Locadora_Veiculos_Ltda
// {
//     public partial class CadastrarVeiculo : Form
//     {
//         LocacaoModels cliente;
//         public CadastrarVeiculo(Form parent, int id = 0)
//         {
//             try
//             {
//                 cliente = ClienteController.GetCliente(id);
//             }
//             catch
//             {

//             }
//             InitializeComponent(parent, id > 0);
//         }

//         private void btn_ConfirmarClick(object sender, EventArgs e)
//         {
//             try
//             {
//                 if ((rtxt_Marca.Text != string.Empty)
//                 && (mtxt_AnoFab.Text != string.Empty)
//                 && (mtxt_Preco.Text != string.Empty)
//                 && (cb_QtdEstoque.Text != string.Empty))
//                 {
//                     if (cliente == null)
//                     {
//                         VeiculosController.CadastrarVeiculo(
//                         rtxt_Marca.Text,
//                         mtxt_AnoFab.Text,
//                         mtxt_Preco.Text,
//                         cb_QtdEstoque.Text == "1 Unidade"
//                             ? 1
//                             : cb_QtdEstoque.Text == "2 Unidades"
//                                 ? 2
//                                 : cb_QtdEstoque.Text == "3 Unidades"
//                                     ? 3
//                                     : cb_QtdEstoque.Text == "5 Unidades"
//                                         ? 5
//                                         : 10
//                         );
//                         MessageBox.Show("Cadastrado Com Sucesso!");

//                     }
//                     else
//                     {
//                         VeiculosController.AtualizaVeiculo(
//                          rtxt_Marca.Text,
//                         mtxt_AnoFab.Text,
//                         mtxt_Preco.Text,
//                         cb_QtdEstoque.Text == "1 Unidade"
//                             ? 1
//                             : cb_QtdEstoque.Text == "2 Unidades"
//                                 ? 2
//                                 : cb_QtdEstoque.Text == "3 Unidades"
//                                     ? 3
//                                     : cb_QtdEstoque.Text == "5 Unidades"
//                                         ? 5
//                                         : 10
//                         );
//                         MessageBox.Show("Alteração Feita!");
//                     }
//                     this.Close();
//                     this.parent.Show();
//                 }
//                 else
//                 {
//                     MessageBox.Show("Preencha Todos Os Campos!");
//                 }
//             }
//             catch (Exception er)
//             {
//                 MessageBox.Show(er.Message, "Preencha Todos Os Campos!");
//             }
//         }

//         private void btn_CancelarClick(object sender, EventArgs e)
//         {
//             this.Close();
//         }

//         private void LoadForm(object sender, EventArgs e)
//         {
//             this.rtxt_Marca.Text = Veiculo.Marca;
//             this.mtxt_AnoFab.Text = Veiculo.mtxt_AnoFab;
//             this.mtxt_Preco.Text = Veiculo.CpfCliente;
//             this.cb_QtdEstoque.SelectedValue = Veiculo.DiasDevolucao;
//         }
//     }
// }