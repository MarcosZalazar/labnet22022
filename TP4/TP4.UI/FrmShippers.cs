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
    public partial class FrmShippers : Form, IValidaciones
    {
        private Shippers shipper;

        public FrmShippers(string operation, string operationButton, Shippers shipper)
        {
            InitializeComponent();
            this.Text = operation;
            this.btnShippersAcept.Text = operationButton;
            this.shipper = shipper;
            this.txtShippersId.Enabled = false;
        }

        public Shippers LoadedShipper
        {
            get
            {
                return this.shipper;
            }
        }

        private void FrmTransportista_Load(object sender, EventArgs e)
        {
            if (!(shipper is null))
            {
                this.txtShippersId.Text = shipper.ShipperID.ToString();
                this.txtShippersCompanyName.Text = shipper.CompanyName;
                this.txtShippersPhone.Text = shipper.Phone;
            }
        }

        private void btnShippersAcept_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.AllFieldsChecked())
                {
                    if (this.shipper is null)
                    {
                        this.shipper = new Shippers
                        {
                            CompanyName = this.txtShippersCompanyName.Text,
                            Phone = this.txtShippersPhone.Text
                        };
                    }
                    else
                    {
                        this.shipper.CompanyName = this.txtShippersCompanyName.Text;
                        this.shipper.Phone = this.txtShippersPhone.Text;
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

        private void btnShippersCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool AllFieldsChecked()
        {
            if (FieldIsNotEmpty(this.txtShippersCompanyName.Text))
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

        private void txtShippersCompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar caracteres alfanúmericos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtShippersPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 39) || (e.KeyChar >= 42 && e.KeyChar <= 44) || (e.KeyChar >= 46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter inválido para registrar un número de teléfono", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
