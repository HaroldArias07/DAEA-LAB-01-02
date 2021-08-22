using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string dni = txtDNI.Text;
            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string direction = txtDirection.Text;
            string number = txtNumber.Text;
            string email = txtEmail.Text;

            dataGridView1.Rows.Add(codigo, dni, name, lastname, direction, number, email);
        }
    }
}
