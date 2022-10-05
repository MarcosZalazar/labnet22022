using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.Entities;
using TP4.Utils;

namespace TP4.UI
{
    public partial class FrmCategories : Form, IValidaciones
    {
        private Categories category;

        public FrmCategories(string operation, string operationButton, Categories category)
        {
            InitializeComponent();
            this.Text = operation;
            this.btnCategoryAccept.Text = operationButton;
            this.category = category;
            this.txtIdCategory.Enabled = false;
        }

        public Categories LoadedCategory
        {
            get
            {
                return this.category;
            }
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            if (!(category is null))
            {
                this.txtIdCategory.Text = category.CategoryID.ToString();
                this.txtCategoryName.Text = category.CategoryName;
                this.txtCategoryDescription.Text = category.Description;
            }
        }

        private void btnCategoryAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.AllFieldsChecked())
                {
                    if (this.category is null)
                    {
                        this.category = new Categories
                        {
                            CategoryName = this.txtCategoryName.Text,
                            Description = this.txtCategoryDescription.Text
                        };
                    }
                    else
                    {
                        this.category.CategoryName = this.txtCategoryName.Text;
                        this.category.Description = this.txtCategoryDescription.Text;
                    }

                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (FormFillingException fex)
            {
                MessageBox.Show(fex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique la correcta carga de los campos ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCategoryCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private bool AllFieldsChecked()
        {
            if (FieldIsNotEmpty(this.txtCategoryName.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FieldIsNotEmpty(string field)
        {
            if (field != String.Empty)
            {
                return true;
            }
            else
            {
                throw new FormFillingException("Existen campos vacios. Por favor, completarlos");
            }
        }

        private void txtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar caracteres alfanúmericos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtCategoryDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 43) || (e.KeyChar == 45) || (e.KeyChar >= 47 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar letras", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
