using System;
using Models;
using Controllers;
using System.Windows.Forms;

namespace Locadora_Veiculos_Ltda
{
    public partial class VeiculoDetalhe : Form
    {
        public VeiculoDetalhe(Form parent, VeiculoModels Veiculo)
        {
            InitializeComponent(parent, Veiculo);
        }
        private void btn_SairDetalheClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
        private void btn_UpdateVeiculoClick(object sender, EventArgs e)
        {
            CadastroVeiculo btn_UpdateVeiculoClick = new CadastroVeiculo(this, idVeiculo);
            btn_UpdateVeiculoClick.Show();
        }
        private void btn_DeleteVeiculoClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Realmente Exluir Esse Veiculo?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    VeiculoController.DeleteVeiculo(idVeiculo);
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}