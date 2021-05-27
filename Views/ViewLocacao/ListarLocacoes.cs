using System;
using System.Windows.Forms;

namespace Locadora_Veiculos_Ltda
{
    public partial class ListaLocacao : Form
    {
        public ListaLocacao(Form parent)
        {
            InitializeComponent(parent);
        }

        private void btn_ListaSairClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}