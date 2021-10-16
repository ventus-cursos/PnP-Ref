using System;
using System.Windows.Forms;

namespace Ventus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Are you sure?"))
                Util.ShowError("Sorry Dave, I can't do that.");
        }
    }
}
