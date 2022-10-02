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
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            var queryHelpMessage = new ToolTip();

            queryHelpMessage.SetToolTip(this.btnQuery1, " Query para devolver objeto customer");
            queryHelpMessage.SetToolTip(this.btnQuery2, " Query para devolver todos los productos sin stock");
            queryHelpMessage.SetToolTip(this.btnQuery3, " Query para devolver todos los productos que tienen " +
                                                          "stock y que cuestan más de 3 por unidad");
            queryHelpMessage.SetToolTip(this.btnQuery4, " Query para devolver todos los customers de la Región WA");
            queryHelpMessage.SetToolTip(this.btnQuery5, " Query para devolver el primer elemento o nulo de una " +
                                                        " lista de productos donde el ID de producto sea igual a 789");
            queryHelpMessage.SetToolTip(this.btnQuery6, " Query para devolver los nombre de los Customers. Mostrarlos " +
                                                        " en Mayuscula y en Minuscula");
            queryHelpMessage.SetToolTip(this.btnQuery7, " Query para devolver Join entre Customers y Orders donde los customers " +
                                                        " sean de la Región WA y la fecha de orden sea mayor a 1 / 1 / 1997");
            queryHelpMessage.SetToolTip(this.btnQuery8, " Query para devolver los primeros 3 Customers de la  Región WA");
            queryHelpMessage.SetToolTip(this.btnQuery9, " Query para devolver lista de productos ordenados por nombre");
            queryHelpMessage.SetToolTip(this.btnQuery10," Query para devolver lista de productos ordenados por unit in " +
                                                        " stock de mayor a menor");
            queryHelpMessage.SetToolTip(this.btnQuery11," Query para devolver las distintas categorías asociadas a los productos");
            queryHelpMessage.SetToolTip(this.btnQuery12, " Query para devolver el primer elemento de una lista de productos");
            queryHelpMessage.SetToolTip(this.btnQuery13, " Query para devolver los customer con la cantidad de ordenes asociadas");
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
