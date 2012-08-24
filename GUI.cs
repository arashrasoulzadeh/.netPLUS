using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace DNP
{
    class GUI
    {
        public static void msg (String message)
        {
            MessageBox.Show(message);
        }


        //effects class
        public static class effects
        {
            public static void Opacity(float Perc, Form frm)
            {
                frm.Opacity = Perc;
            }
            public static void FadeIn(Form frm)
            {
                float FadeIn;
                for (FadeIn = 0.0f; FadeIn <= 1.1; FadeIn += 0.1f)
                {
                    frm.Opacity = FadeIn;
                    frm.Refresh();
                    System.Threading.Thread.Sleep(100);
                }
            }
            public static void FadeOut(Form frm)
            {
                float FadeOut;
                for (FadeOut = 90; FadeOut >= 10; FadeOut += -10)
                {
                    frm.Opacity = FadeOut / 100;
                    frm.Refresh();
                    System.Threading.Thread.Sleep(100);
                }
            }

        }
    }
}
