using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudOperationWithWCFService.ServiceReference1;

namespace CrudOperationWithWCFService
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
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        private void button1_Click(object sender, EventArgs e)
        {
            InsertEmployee u = new InsertEmployee();
            u.Name = textBox1.Text;
            u.Salary = Convert.ToInt32(textBox2.Text);
            u.CityName = textBox3.Text;
            string res = client.Insert(u);
            lblmsg.Text = res.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblcity_Click(object sender, EventArgs e)
        {

        }
    }
}

