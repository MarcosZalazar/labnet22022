using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.Logic;
using TP4.Entities;
using System.Data.Entity;

namespace TP4.UI
{
    public partial class FrmMain : Form
    {
        private ShippersLogic shippersLogic;
        private CategoriesLogic categoriesLogic;

        public FrmMain()
        {
            InitializeComponent();
            this.shippersLogic = new ShippersLogic();
            this.categoriesLogic = new CategoriesLogic();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            this.lstShippers.DataSource = null;
            this.lstCategories.DataSource = null;
            this.lstShippers.DataSource = shippersLogic.GetAll();
            this.lstCategories.DataSource = categoriesLogic.GetAll();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories("Agregar categorias", "Agregar", null);
            DialogResult resultado = frmCategories.ShowDialog();

            try
            {
                if (!(frmCategories.LoadedCategory is null) && resultado == DialogResult.OK)
                {
                    this.categoriesLogic.Add(frmCategories.LoadedCategory);
                    this.RefreshList();
                    MessageBox.Show("Categoría agregada", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo realizar la carga de la categoría. Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            Categories categoriesToUpdate = (Categories)this.lstCategories.SelectedItem;

            try
            {
                if (!(categoriesToUpdate is null))
                {
                    FrmCategories frmUpdateCategories = new FrmCategories("Modificar categorías", "Modificar", categoriesToUpdate);
                    frmUpdateCategories.ShowDialog();

                    if (frmUpdateCategories.DialogResult == DialogResult.OK)
                    {
                        this.categoriesLogic.Update(frmUpdateCategories.LoadedCategory);
                        this.RefreshList();
                        MessageBox.Show("Categoría modificada", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo realizar la modificación de la categoría Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            Categories selectedCategory = (Categories)this.lstCategories.SelectedItem;

            try
            {
                if (!(selectedCategory is null))
                {
                    int idCategory = selectedCategory.CategoryID;
                    this.categoriesLogic.Delete(idCategory);
                    this.RefreshList();
                    MessageBox.Show("Categoría eliminada", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("No se puede eliminar el registro ya que es usado por la entidad 'Productos'." +
                                "Para eliminar el registro, elimine primero los productos relacionados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo eliminar la categóría. Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfoCategory_Click(object sender, EventArgs e)
        {
            Categories selectedCategory = (Categories)this.lstCategories.SelectedItem;

            try
            {
                if (!(selectedCategory is null))
                {
                    FrmReport frmReport = new FrmReport(selectedCategory.ToString());
                    frmReport.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo mostrar la información de la categoría. Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfoAllCategories_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            try
            {
                if (!(categoriesLogic.GetAll() is null))
                {
                    var information = categoriesLogic.GetAll();
                    foreach (Categories category in information)
                    {
                        message.AppendLine(category.ToString());
                    }
                    FrmReport frmReport = new FrmReport(message.ToString());
                    frmReport.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo mostrar la información del transportista. Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddShipper_Click(object sender, EventArgs e)
        {
            FrmShippers frmTransportista = new FrmShippers("Agregar transportista", "Agregar", null);
            DialogResult resultado = frmTransportista.ShowDialog();

            try
            {
                if (!(frmTransportista.LoadedShipper is null) && resultado == DialogResult.OK)
                {
                    this.shippersLogic.Add(frmTransportista.LoadedShipper);
                    this.RefreshList();
                    MessageBox.Show("Transportista agregado", "Transportistas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo realizar la carga del transportista. Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateShipper_Click(object sender, EventArgs e)
        {
            Shippers shipperToUpdate = (Shippers)this.lstShippers.SelectedItem;

            try
            {
                if (!(shipperToUpdate is null))
                {
                    FrmShippers frmUpdateShipper= new FrmShippers("Modificar transportista", "Modificar", shipperToUpdate);
                    frmUpdateShipper.ShowDialog();

                    if (frmUpdateShipper.DialogResult == DialogResult.OK)
                    {
                        this.shippersLogic.Update(frmUpdateShipper.LoadedShipper);
                        this.RefreshList();
                        MessageBox.Show("Transportista modificado", "Transportista", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo realizar la modificación del transportista. Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteShipper_Click(object sender, EventArgs e)
        {
            Shippers selectedShipper = (Shippers)this.lstShippers.SelectedItem;

            try
            {
                if (!(selectedShipper is null))
                {
                    int idShipper = selectedShipper.ShipperID;
                    this.shippersLogic.Delete(idShipper);
                    this.RefreshList();
                    MessageBox.Show("Transportista eliminado", "Transportista", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException) 
            {
                MessageBox.Show("No se puede eliminar el registro ya que es usado en las órdenes de pagos." +
                                "Para eliminar el registro, elimine primero las ordenes de pagos relacionadas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo eliminar al transportista. Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfoShipper_Click(object sender, EventArgs e)
        {
            Shippers selectedShipper = (Shippers)this.lstShippers.SelectedItem;

            try
            {
                if (!(selectedShipper is null))
                {
                    FrmReport frmReport = new FrmReport(selectedShipper.ToString());
                    frmReport.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo mostrar la información del transportista. Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfoAllShipper_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            try
            {
                if (!(shippersLogic.GetAll() is null))
                {
                    var information = shippersLogic.GetAll();
                    foreach (Shippers shipper in information)
                    {
                        message.AppendLine(shipper.ToString());
                    }
                    FrmReport frmReport = new FrmReport(message.ToString());
                    frmReport.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudo mostrar la información del transportista. Intente nuevamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}
