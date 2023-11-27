using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_new
{
    public partial class ResponseForm : Form
    {
        public ResponseForm()
        {
            InitializeComponent();
        }

        public void setLabelText(string data)
        {
            temp.Text = data;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            IndexForm new_mainform = new IndexForm();
            this.Hide();
            new_mainform.ShowDialog();
        }
    }
}
