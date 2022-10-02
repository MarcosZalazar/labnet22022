using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5.Logic;

namespace TP5.UI
{
    public partial class FormPrincipal : Form
    {
        private CustomersLogic customersLogic;
        private ProductsLogic productsLogic;

        public FormPrincipal()
        {
            InitializeComponent();
            this.customersLogic = new CustomersLogic();
            this.productsLogic = new ProductsLogic();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text=this.customersLogic.ReturnACustomer();
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.productsLogic.ReturnAnOutOfStockList();
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.productsLogic.ReturnAStockListWithPricesAbove3Dollars();
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.customersLogic.ReturnAllCustomersFromRegionWA();
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.productsLogic.ReturnFirstItemOrNullWithId789();
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.customersLogic.ReturnAllCustomers();
        }

        private void btnQuery7_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.customersLogic.ReturnAllCustomersFromWAWithOrderDateGreaterThanYear1997();
        }

        private void btnQuery8_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.customersLogic.ReturnFirstThreeCustomersFromWA();
        }

        private void btnQuery9_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.productsLogic.ReturnProductsListOrderedByName();
        }

        private void btnQuery10_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.productsLogic.ReturnProductsListOrderedByUnitsInStockDesc();
        }

        private void btnQuery11_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.productsLogic.ReturnProductsCategories();
        }

        private void btnQuery12_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.productsLogic.ReturnFirstProductFromAProductsList();
        }

        private void btnQuery13_Click(object sender, EventArgs e)
        {
            this.rtbReport.Text = this.customersLogic.ReturnNumberOfOrdersPerCustomer();
        }
    }
}
