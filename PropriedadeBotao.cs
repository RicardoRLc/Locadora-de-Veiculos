using System.Windows.Forms;
using System.Drawing;

namespace View{

    public class PropriedadeBotao : Button {
        public PropriedadeBotao(Point Location, Size Size, string Text){
            this.Location = Location;
            this.Size = Size;
            this.Text = Text;
        }
    }


}

