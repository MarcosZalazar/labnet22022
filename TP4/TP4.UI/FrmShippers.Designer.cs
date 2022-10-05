namespace TP4.UI
{
    partial class FrmShippers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblShippersId = new System.Windows.Forms.Label();
            this.lblShippersCompanyName = new System.Windows.Forms.Label();
            this.lblShippersPhone = new System.Windows.Forms.Label();
            this.txtShippersId = new System.Windows.Forms.TextBox();
            this.txtShippersCompanyName = new System.Windows.Forms.TextBox();
            this.txtShippersPhone = new System.Windows.Forms.TextBox();
            this.btnShippersAcept = new System.Windows.Forms.Button();
            this.btnShippersCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShippersId
            // 
            this.lblShippersId.AutoSize = true;
            this.lblShippersId.Location = new System.Drawing.Point(23, 22);
            this.lblShippersId.Name = "lblShippersId";
            this.lblShippersId.Size = new System.Drawing.Size(93, 13);
            this.lblShippersId.TabIndex = 0;
            this.lblShippersId.Text = "Id del transportista";
            // 
            // lblShippersCompanyName
            // 
            this.lblShippersCompanyName.AutoSize = true;
            this.lblShippersCompanyName.Location = new System.Drawing.Point(23, 60);
            this.lblShippersCompanyName.Name = "lblShippersCompanyName";
            this.lblShippersCompanyName.Size = new System.Drawing.Size(119, 13);
            this.lblShippersCompanyName.TabIndex = 1;
            this.lblShippersCompanyName.Text = "Nombre de la compañia";
            // 
            // lblShippersPhone
            // 
            this.lblShippersPhone.AutoSize = true;
            this.lblShippersPhone.Location = new System.Drawing.Point(24, 96);
            this.lblShippersPhone.Name = "lblShippersPhone";
            this.lblShippersPhone.Size = new System.Drawing.Size(49, 13);
            this.lblShippersPhone.TabIndex = 2;
            this.lblShippersPhone.Text = "Teléfono";
            // 
            // txtShippersId
            // 
            this.txtShippersId.Location = new System.Drawing.Point(163, 20);
            this.txtShippersId.Name = "txtShippersId";
            this.txtShippersId.Size = new System.Drawing.Size(203, 20);
            this.txtShippersId.TabIndex = 3;
            // 
            // txtShippersCompanyName
            // 
            this.txtShippersCompanyName.Location = new System.Drawing.Point(163, 57);
            this.txtShippersCompanyName.Name = "txtShippersCompanyName";
            this.txtShippersCompanyName.ShortcutsEnabled = false;
            this.txtShippersCompanyName.Size = new System.Drawing.Size(203, 20);
            this.txtShippersCompanyName.TabIndex = 4;
            this.txtShippersCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShippersCompanyName_KeyPress);
            // 
            // txtShippersPhone
            // 
            this.txtShippersPhone.Location = new System.Drawing.Point(163, 94);
            this.txtShippersPhone.Name = "txtShippersPhone";
            this.txtShippersPhone.ShortcutsEnabled = false;
            this.txtShippersPhone.Size = new System.Drawing.Size(203, 20);
            this.txtShippersPhone.TabIndex = 5;
            this.txtShippersPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShippersPhone_KeyPress);
            // 
            // btnShippersAcept
            // 
            this.btnShippersAcept.Location = new System.Drawing.Point(79, 136);
            this.btnShippersAcept.Name = "btnShippersAcept";
            this.btnShippersAcept.Size = new System.Drawing.Size(102, 46);
            this.btnShippersAcept.TabIndex = 6;
            this.btnShippersAcept.Text = "Aceptar";
            this.btnShippersAcept.UseVisualStyleBackColor = true;
            this.btnShippersAcept.Click += new System.EventHandler(this.btnShippersAcept_Click);
            // 
            // btnShippersCancel
            // 
            this.btnShippersCancel.Location = new System.Drawing.Point(234, 136);
            this.btnShippersCancel.Name = "btnShippersCancel";
            this.btnShippersCancel.Size = new System.Drawing.Size(96, 46);
            this.btnShippersCancel.TabIndex = 25;
            this.btnShippersCancel.Text = "Cancelar";
            this.btnShippersCancel.UseVisualStyleBackColor = true;
            this.btnShippersCancel.Click += new System.EventHandler(this.btnShippersCancel_Click);
            // 
            // FrmTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 210);
            this.Controls.Add(this.btnShippersCancel);
            this.Controls.Add(this.btnShippersAcept);
            this.Controls.Add(this.txtShippersPhone);
            this.Controls.Add(this.txtShippersCompanyName);
            this.Controls.Add(this.txtShippersId);
            this.Controls.Add(this.lblShippersPhone);
            this.Controls.Add(this.lblShippersCompanyName);
            this.Controls.Add(this.lblShippersId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportista";
            this.Load += new System.EventHandler(this.FrmTransportista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShippersId;
        private System.Windows.Forms.Label lblShippersCompanyName;
        private System.Windows.Forms.Label lblShippersPhone;
        private System.Windows.Forms.TextBox txtShippersId;
        private System.Windows.Forms.TextBox txtShippersCompanyName;
        private System.Windows.Forms.TextBox txtShippersPhone;
        private System.Windows.Forms.Button btnShippersAcept;
        private System.Windows.Forms.Button btnShippersCancel;
    }
}