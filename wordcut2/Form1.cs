using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wordcut2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureShowCut1.Init("WWWWWDDD", "我我我我我");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GdiplusMethods.IsChineseLetter("ccc我iwiwi", 2);
        }
    }
}
