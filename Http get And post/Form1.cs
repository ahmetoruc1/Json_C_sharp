using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Http_get_And_post
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="New York")
            {
                JsonVerisi jveri = new JsonVerisi();
                jveri.ShowDialog();
            }
            else
            {
                MessageBox.Show("TextBox A New York Giriniz", "Textbox Boş",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
