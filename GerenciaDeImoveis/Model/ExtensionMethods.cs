using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GerenciaDeImoveis.Model
{
    public static class ExtensionMethods
    {
        public static Font formatarLabel(Label l, int tamContainer)
        {
            float f = 17;
            Font font = new Font("Gill Sans MT", f);
            Size s = TextRenderer.MeasureText(l.Text, font);

            while (s.Width > tamContainer)
            {
                f -= 0.5F;
                font = new Font(l.Font.Name, f);
                s = TextRenderer.MeasureText(l.Text, font);
            }

            return font;
        }
    }
}
