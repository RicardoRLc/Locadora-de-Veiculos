using System;
using Models;
using Library;
using System.Drawing;
using System.Windows.Forms;

namespace Locadora_Veiculos_Ltda
{
    partial class VeiculoDetalhe : Form
    {
        Library.Label lbl_IdVeiculo;
        Library.Label lbl_Marca;
        Library.Label lbl_Modelo;
        Library.Label lbl_Ano;
        Library.Label lbl_ValorLocacao;
        Library.Label lbl_QtdeEstoque;
        Library.ButtonDetail btn_SairDetalhe;
        Library.ButtonDetail btn_UpdateVeiculo;
        Library.ButtonDetail btn_DeleteVeiculo;
        Form parent;

        int idVeiculo;
        VeiculoModels veiculoX;

        
        public void InitializeComponent(Form parent, VeiculoModels veiculo)
        {
            
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(500, 290);
            this.idVeiculo = veiculo.IdVeiculo;
            this.veiculoX = veiculo;
            this.parent = parent;

            this.lbl_IdVeiculo = new Library.Label();
            this.lbl_IdVeiculo.Text = "ID do Veiculo: " + veiculo.IdVeiculo;
            this.lbl_IdVeiculo.Location = new Point(20, 20);
            this.lbl_IdVeiculo.Font = new Font(lbl_IdVeiculo.Font, FontStyle.Bold);
            this.lbl_IdVeiculo.ForeColor = Color.Black;
            this.Controls.Add(lbl_IdVeiculo);

            this.lbl_Marca = new Library.Label();
            this.lbl_Marca.Text = "Marca: " + veiculo.Marca;
            this.lbl_Marca.Location = new Point(20, 50);
            this.lbl_Marca.Font = new Font(lbl_Marca.Font, FontStyle.Bold);
            this.lbl_Marca.ForeColor = Color.Black;
            this.Controls.Add(lbl_Marca);

            this.lbl_Modelo = new Library.Label();
            this.lbl_Modelo.Text = "Modelo: " + veiculo.Modelo;
            this.lbl_Modelo.Location = new Point(20, 80);
            this.lbl_Modelo.Font = new Font(lbl_Modelo.Font, FontStyle.Bold);
            this.lbl_Modelo.ForeColor = Color.Black;
            this.Controls.Add(lbl_Modelo);

            this.lbl_Ano = new Library.Label();
            this.lbl_Ano.Text = "Ano: " + veiculo.Ano;
            this.lbl_Ano.Location = new Point(20, 110);
            this.lbl_Ano.Font = new Font(lbl_Ano.Font, FontStyle.Bold);
            this.lbl_Ano.ForeColor = Color.Black;
            this.Controls.Add(lbl_Ano);

            this.lbl_ValorLocacao = new Library.Label();
            this.lbl_ValorLocacao.Text = "Valor Locação: " + veiculo.ValorLocacaoVeiculo.ToString();
            this.lbl_ValorLocacao.Location = new Point(20, 140);
            this.lbl_ValorLocacao.Font = new Font(lbl_ValorLocacao.Font, FontStyle.Bold);
            this.lbl_ValorLocacao.ForeColor = Color.Black;
            this.Controls.Add(lbl_ValorLocacao);

            this.lbl_QtdeEstoque = new Library.Label();
            this.lbl_QtdeEstoque.Text = "Qtde Estoque: " + veiculo.EstoqueVeiculo.ToString();
            this.lbl_QtdeEstoque.Location = new Point(20, 140);
            this.lbl_QtdeEstoque.Font = new Font(lbl_QtdeEstoque.Font, FontStyle.Bold);
            this.lbl_QtdeEstoque.ForeColor = Color.Black;
            this.Controls.Add(lbl_QtdeEstoque);

            this.btn_DeleteVeiculo = new Library.ButtonDetail(ButtonType.Delete);
            this.btn_DeleteVeiculo.Text = "DELETAR";
            this.btn_DeleteVeiculo.Location = new Point(10, 180);
            this.btn_DeleteVeiculo.Size = new Size(140, 50);
            this.btn_DeleteVeiculo.BackColor = Color.DarkGray;
            this.btn_DeleteVeiculo.Click += new EventHandler(this.btn_DeleteVeiculoClick);
            this.Controls.Add(btn_DeleteVeiculo);

            this.btn_UpdateVeiculo = new Library.ButtonDetail(ButtonType.Update);
            this.btn_UpdateVeiculo.Text = "ALTERAR";
            this.btn_UpdateVeiculo.Location = new Point(170, 180);
            this.btn_UpdateVeiculo.Size = new Size(140, 50);
            this.btn_UpdateVeiculo.BackColor = Color.DarkGray;
            this.btn_UpdateVeiculo.Click += new EventHandler(this.btn_UpdateVeiculoClick);
            this.Controls.Add(btn_UpdateVeiculo);

            this.btn_SairDetalhe = new Library.ButtonDetail(ButtonType.Sair);
            this.btn_SairDetalhe.Text = "SAIR";
            this.btn_SairDetalhe.Location = new Point(330, 180);
            this.btn_SairDetalhe.Size = new Size(140, 50);
            this.btn_SairDetalhe.BackColor = Color.DarkGray;
            this.btn_SairDetalhe.Click += new EventHandler(this.btn_SairDetalheClick);
            this.Controls.Add(btn_SairDetalhe);
        }
    }
}