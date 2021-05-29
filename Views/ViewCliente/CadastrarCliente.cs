using System;
using Models;
using Controllers;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Locadora_Veiculos_Ltda
{
    public partial class CadastroCliente : Form
    {
        ClienteModels cliente;
        public CadastroCliente(Form parent, int id = 0)
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
                Regex nome = new Regex(@"^[a-zA-Z]+$");
                Regex nascimento = new Regex(@"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$");
                Regex cpf = new Regex(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$");
                if ((!nome.IsMatch(this.rtxt_NomeCliente.Text)))
                {
                    this.TextErrorNome.SetError(this.rtxt_NomeCliente, "Somente letras!");
                }
                else if (!nascimento.IsMatch(this.mtxt_DataNasc.Text))
                {
                    this.TextErrorNasc.SetError(this.mtxt_DataNasc, "Preencha corretamente a data!");
                }
                else if (!cpf.IsMatch(this.mtxt_CpfCLiente.Text))
                {
                    this.TextErrorCpf.SetError(this.mtxt_CpfCLiente, "Preencha corretamente o cpf!");
                }
                else if (cb_DiasDevol.SelectedItem == null)
                {
                    this.TextErrorDev.SetError(this.cb_DiasDevol, "Selecione os dias de devolução!");
                }
                else if ((rtxt_NomeCliente.Text != string.Empty)
                && (mtxt_DataNasc.Text != string.Empty)
                && (mtxt_CpfCLiente.Text != string.Empty)
                && (cb_DiasDevol.Text != string.Empty))
                {
                    if (cliente == null)
                    {
                        ClienteController.CadastrarCliente(
                        rtxt_NomeCliente.Text,
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
                        // Como limpar o icone do erro ao digitar corretamente???
                        this.TextErrorNasc.SetError(this.rtxt_NomeCliente, String.Empty);
                        this.TextErrorNasc.SetError(this.mtxt_DataNasc, String.Empty);
                        this.TextErrorCpf.SetError(this.mtxt_CpfCLiente, String.Empty);
                        this.TextErrorDev.SetError(this.cb_DiasDevol, String.Empty);
                        MessageBox.Show("Cadastrado Com Sucesso!");

                    }
                    else
                    {
                        ClienteController.AtualizaCliente(
                        cliente.IdCliente,
                        rtxt_NomeCliente.Text,
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
            this.rtxt_NomeCliente.Text = cliente.NomeCliente;
            this.mtxt_DataNasc.Text = cliente.DataNascimento;
            this.mtxt_CpfCLiente.Text = cliente.CpfCliente;
            this.cb_DiasDevol.SelectedValue = cliente.DiasDevolucao;
        }
    }
}