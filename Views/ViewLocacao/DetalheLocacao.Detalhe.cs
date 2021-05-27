using System;
using Models;
using Library;
using Controllers;
using System.Drawing;
using System.Windows.Forms;

namespace Locadora_Veiculos_Ltda
{
    partial class LocacaoDetalhe : Form
    {
        Library.Label lbl_DadosCliente;
        Library.Label lbl_IdCliente;
        Library.Label lbl_NomeCliente;
        Library.Label lbl_DataNascimento;
        Library.Label lbl_DadosLocacao;
        Library.Label lbl_CpfCliente;
        Library.Label lbl_IdLocacao;
        Library.Label lbl_DataLocacao;
        Library.Label lbl_DataDevolucao;
        Library.Label lbl_QtdeVeiculos;
        Library.Label lbl_ValorTotal;
        Library.Label lbl_DadosVeiculos;
        Library.RichTextBox rtxt_Veiculos;
        Library.ButtonDetail btn_SairDetalhe;
        Library.ButtonDetail btn_DeleteLocacao;
        Form parent;

        int idLocacao;
        LocacaoModels locacaoX;
        
        public void InitializeComponent(Form parent, LocacaoModels locacao)
        {
            
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(600, 540);
            this.idLocacao = locacao.IdLocacao;
            this.locacaoX = locacao;
            this.parent = parent;

            ClienteModels cliente = ClienteController.GetCliente(locacao.IdCliente);

            this.lbl_DadosCliente = new Library.Label();
            this.lbl_DadosCliente.Text = "DADOS CLIENTE";
            this.lbl_DadosCliente.ForeColor = Color.Red;
            this.lbl_DadosCliente.Location = new Point(20, 20);
            this.Controls.Add(lbl_DadosCliente);

            this.lbl_IdCliente = new Library.Label();
            this.lbl_IdCliente.Text = "ID do Cliente: " + locacao.IdCliente.ToString();
            this.lbl_IdCliente.Location = new Point(20, 40);
            this.Controls.Add(lbl_IdCliente);

            this.lbl_NomeCliente = new Library.Label();
            this.lbl_NomeCliente.Text = "Nome: " + cliente.NomeCliente;
            this.lbl_NomeCliente.Location = new Point(20, 70);
            this.Controls.Add(lbl_NomeCliente);

            this.lbl_DataNascimento = new Library.Label();
            this.lbl_DataNascimento.Text = "Data de Nascimento: " + cliente.DataNascimento;
            this.lbl_DataNascimento.Location = new Point(20, 100);
            this.Controls.Add(lbl_DataNascimento);

            this.lbl_CpfCliente = new Library.Label();
            this.lbl_CpfCliente.Text = "CPF: " + cliente.CpfCliente;
            this.lbl_CpfCliente.Location = new Point(300, 100);
            this.Controls.Add(lbl_CpfCliente);

            this.lbl_DadosLocacao = new Library.Label();
            this.lbl_DadosLocacao.Text = "DADOS LOCAÇÃO";
            this.lbl_DadosLocacao.ForeColor = Color.Red;
            this.lbl_DadosLocacao.Location = new Point(20, 150);
            this.Controls.Add(lbl_DadosLocacao);

            this.lbl_IdLocacao = new Library.Label();
            this.lbl_IdLocacao.Text = "ID da Locação: " + locacao.IdLocacao.ToString();
            this.lbl_IdLocacao.Location = new Point(20, 170);
            this.Controls.Add(lbl_IdLocacao);

            this.lbl_DataLocacao = new Library.Label();
            this.lbl_DataLocacao.Text = "Data da Locação: " + locacao.DataLocacao.ToString("dd/MM/yyyy");
            this.lbl_DataLocacao.Location = new Point(20, 200);
            this.Controls.Add(lbl_DataLocacao);

            this.lbl_DataDevolucao = new Library.Label();
            this.lbl_DataDevolucao.Text = "Data de Devolução: " + locacao.CalculoDataDevol().ToString("dd/MM/yyyy");
            this.lbl_DataDevolucao.Location = new Point(300, 200);
            this.Controls.Add(lbl_DataDevolucao);

            this.lbl_QtdeVeiculos = new Library.Label();
            this.lbl_QtdeVeiculos.Text = "Quantidade de Veiculos: " + locacao.QtdeVeiculos().ToString();
            this.lbl_QtdeVeiculos.Location = new Point(20, 230);
            this.Controls.Add(lbl_QtdeVeiculos);

            this.lbl_ValorTotal = new Library.Label();
            this.lbl_ValorTotal.Text = "Total da Locação: " + locacao.ValorTotal().ToString("C2");
            this.lbl_ValorTotal.Location = new Point(300, 230);
            this.Controls.Add(lbl_ValorTotal);

            this.lbl_DadosVeiculos = new Library.Label();
            this.lbl_DadosVeiculos.Text = "DADOS VEICULO";
            this.lbl_DadosVeiculos.ForeColor = Color.Red;
            this.lbl_DadosVeiculos.Location = new Point(20, 280);
            this.Controls.Add(lbl_DadosVeiculos);

            this.rtxt_Veiculos = new Library.RichTextBox();
            this.rtxt_Veiculos.Text = "" + locacao.VeiculosLocados();
            this.rtxt_Veiculos.Location = new Point(20, 300);
            this.rtxt_Veiculos.Size = new Size(540, 100);
            this.rtxt_Veiculos.ReadOnly = true;
            this.Controls.Add(rtxt_Veiculos);
            
            this.btn_DeleteLocacao = new Library.ButtonDetail(ButtonType.Delete);
            this.btn_DeleteLocacao.Text = "DELETAR";
            this.btn_DeleteLocacao.Location = new Point(120, 420);
            this.btn_DeleteLocacao.BackColor = Color.DarkGray;
            this.btn_DeleteLocacao.Click += new EventHandler(this.btn_DeleteLocacaoClick);
            this.Controls.Add(btn_DeleteLocacao);
            
            this.btn_SairDetalhe = new Library.ButtonDetail(ButtonType.Sair);
            this.btn_SairDetalhe.Text = "SAIR";
            this.btn_SairDetalhe.Location = new Point(320, 420);
            this.btn_SairDetalhe.BackColor = Color.DarkGray;
            this.btn_SairDetalhe.Click += new EventHandler(this.btn_SairDetalheClick);
            this.Controls.Add(btn_SairDetalhe);
        }
    }
}