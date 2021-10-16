using System;
using System.Windows.Forms;

namespace ReverseConditional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        MessageBox.Show("Save it!");
                    }
                    else
                    {
                        ShowError("TextBox3 is blank");
                    }
                }
                else
                {
                    ShowError("TextBox2 is blank");
                }
            }
            else
            {
                ShowError("TextBox1 is blank");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                ShowError("TextBox1 is blank");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                ShowError("TextBox2 is blank");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                ShowError("TextBox3 is blank");
                return;
            }

            MessageBox.Show("Save it!");
        }

        internal static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
