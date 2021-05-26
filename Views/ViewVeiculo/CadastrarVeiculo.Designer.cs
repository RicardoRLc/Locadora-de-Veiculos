using System;
using System.Drawing;
using System.Windows.Forms;

namespace Locadora_Veiculos_Ltda
{
    partial class CadastroVeiculo : Form
    {
        Library.Label lbl_Marca;
        Library.Label lbl_Modelo;
        Library.Label lbl_AnoFab;
        Library.Label lbl_ValorLocacaoVeiculo;
        Library.Label lbl_EstoqueVeiculo;
        
        Library.RichTextBox rtxt_Marca;
        Library.RichTextBox rtxt_Modelo;
        Library.MaskedTextBox mtxt_AnoFab;
        ComboBox cb_ValorLocacaoVeiculo;
        NumericUpDown num_EstoqueVeiculo;

        Library.Button btn_Confirmar;
        Library.Button btn_Cancelar;
        Form parent;

        public void InitializeComponent(Form parent, bool isUpdate)
        {
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(360, 370);
            this.parent = parent;

            if (isUpdate)
            {
                this.Load += new EventHandler(this.LoadForm);
            }

            this.lbl_Marca = new Library.Label();
            this.lbl_Marca.Text = "Marca :";
            this.lbl_Marca.Location = new Point(20, 20);
            this.Controls.Add(lbl_Marca);

            this.lbl_Modelo = new Library.Label();
            this.lbl_Modelo.Text = "Modelo:";
            this.lbl_Modelo.Location = new Point(20, 60);
            this.Controls.Add(lbl_Modelo);

            this.lbl_AnoFab = new Library.Label();
            this.lbl_AnoFab.Text = "Ano fabrica :";
            this.lbl_AnoFab.Location = new Point(20, 100);
            this.Controls.Add(lbl_AnoFab);

            this.lbl_ValorLocacaoVeiculo = new Library.Label();
            this.lbl_ValorLocacaoVeiculo.Text = "Valor da Locação :";
            this.lbl_ValorLocacaoVeiculo.Location = new Point(20, 140);
            this.Controls.Add(lbl_ValorLocacaoVeiculo);

            this.lbl_EstoqueVeiculo = new Library.Label();
            this.lbl_EstoqueVeiculo.Text = "Qtde Estoque:";
            this.lbl_EstoqueVeiculo.Location = new Point(20, 180);
            this.Controls.Add(lbl_EstoqueVeiculo);

            this.rtxt_Marca = new Library.RichTextBox();
            this.rtxt_Marca.Size = new Size(170, 20);
            this.Controls.Add(rtxt_Marca);

            this.rtxt_Modelo = new Library.RichTextBox();
            this.rtxt_Modelo.Location = new Point(150, 60);
            this.rtxt_Modelo.Size = new Size(170, 20);
            this.Controls.Add(rtxt_Modelo);

            this.mtxt_AnoFab = new Library.MaskedTextBox();
            this.mtxt_AnoFab.Mask = "0000";
            this.mtxt_AnoFab.Location = new Point(150, 100);
            this.Controls.Add(mtxt_AnoFab);

            this.cb_ValorLocacaoVeiculo = new ComboBox();
            this.cb_ValorLocacaoVeiculo.Items.Add("R$ 50,00");
            this.cb_ValorLocacaoVeiculo.Items.Add("R$ 100,00");
            this.cb_ValorLocacaoVeiculo.Items.Add("R$ 150,00");
            this.cb_ValorLocacaoVeiculo.Items.Add("R$ 200,00");
            this.cb_ValorLocacaoVeiculo.Items.Add("R$ 250,00");
            this.cb_ValorLocacaoVeiculo.AutoCompleteMode = AutoCompleteMode.Append;
            this.cb_ValorLocacaoVeiculo.Location = new Point(150, 140);
            this.cb_ValorLocacaoVeiculo.Size = new Size(170, 20);
            this.Controls.Add(cb_ValorLocacaoVeiculo);
            
            this.num_EstoqueVeiculo = new NumericUpDown();
            this.num_EstoqueVeiculo.Location = new Point(150, 180);
            this.num_EstoqueVeiculo.Size = new Size(50, 20);
            this.num_EstoqueVeiculo.Minimum = 1;
            this.num_EstoqueVeiculo.Maximum = 50;
            this.Controls.Add(num_EstoqueVeiculo);

            this.btn_Confirmar = new Library.Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(10, 230);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.btn_Cancelar = new Library.Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(180, 230);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);
        }
    }
}