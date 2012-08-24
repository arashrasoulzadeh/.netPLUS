using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DNP;
namespace DNP
{
    public partial class testarea : Form
    {
        public testarea()
        {
            InitializeComponent();
        }

        private void testarea_Load(object sender, EventArgs e)
        {
            GUI.effects.FadeIn(this);
        }
    }
}
