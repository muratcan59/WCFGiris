using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace WCFGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            ProductService client = new ProductService();
            string msg = client.DoWork();
            MessageBox.Show(msg);
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            ProductService client = new ProductService();
            dgvListe.DataSource = client.GetProducts();
        }
    }
}
