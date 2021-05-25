using System;
using Models;
using Controllers;
using System.Windows.Forms;

namespace Locadora_Veiculos_Ltda
{
    public partial class CadastrarVeiculo : Form
    {
        LocacaoModels cliente;
        public CadastrarVeiculo(Form parent, int id = 0)
        {
            try
            {
                cliente = ClienteController.GetCliente(id);
            }
            catch
            {

            }
            InitializeComponent(parent, id > 0);
        }

        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                if ((rtxt_Marca.Text != string.Empty)
                && (mtxt_DataNasc.Text != string.Empty)
                && (mtxt_CpfCLiente.Text != string.Empty)
                && (cb_DiasDevol.Text != string.Empty))
                {
                    if (cliente == null)
                    {
                        ClienteController.CadastrarVeiculo(
                        rtxt_Marca.Text,
                        mtxt_DataNasc.Text,
                        mtxt_CpfCLiente.Text,
                        cb_QtdEstoque.Text == "1 Unidade"
                            ? 1
                            : cb_QtdEstoque.Text == "2 Unidades"
                                ? 2
                                : cb_QtdEstoque.Text == "3 Unidades"
                                    ? 3
                                    : cb_QtdEstoque.Text == "5 Unidades"
                                        ? 5
                                        : 10
                        );
                        MessageBox.Show("Cadastrado Com Sucesso!");

                    }
                    else
                    {
                        ClienteController.AtualizaVeiculo(
                        cliente.IdCliente,
                        rtxt_Marca.Text,
                         mtxt_DataNasc.Text,
                        mtxt_CpfCLiente.Text,
                        cb_DiasDevol.Text == "1 Dia"
                            ? 1
                            : cb_DiasDevol.Text == "2 Dias"
                                ? 2
                                : cb_DiasDevol.Text == "3 Dias"
                                    ? 3
                                    : cb_DiasDevol.Text == "4 Dias"
                                        ? 4
                                        : 7
                        );
                        MessageBox.Show("Alteração Feita!");
                    }
                    this.Close();
                    this.parent.Show();
                }
                else
                {
                    MessageBox.Show("Preencha Todos Os Campos!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Preencha Todos Os Campos!");
            }
        }

        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            this.rtxt_Marca.Text = cliente.NomeCliente;
            this.mtxt_DataNasc.Text = cliente.DataNascimento;
            this.mtxt_CpfCLiente.Text = cliente.CpfCliente;
            this.cb_DiasDevol.SelectedValue = cliente.DiasDevolucao;
        }
    }
}