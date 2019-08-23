using Northwind.DataAccessLayer.Concrete.EntityFramework;
using Nortwind.BussinesLogicLayer.Abstract;
using Nortwind.BussinesLogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinformUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDAL());
        }
        private IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {

            dgwProduct.DataSource = _productService.GetAll();
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}