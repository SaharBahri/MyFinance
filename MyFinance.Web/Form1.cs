using MyFinance.Data;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyFinance.Data.MyFinanceContext;
namespace MyFinance.Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (var ctx = new MyFinanceContext()) {
                Product prd = new Product() { Name = "produit1", Price = 5000, Quantity = 100 };
                ctx.Products.Add(prd);
                ctx.SaveChanges();
            }


        }

        
    }
}
