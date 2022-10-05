namespace TP4.UI
{
    partial class FrmCategories
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
            this.lblIdCategory = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.txtIdCategory = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.btnCategoryAccept = new System.Windows.Forms.Button();
            this.btnCategoryCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdCategory
            // 
            this.lblIdCategory.AutoSize = true;
            this.lblIdCategory.Location = new System.Drawing.Point(29, 23);
            this.lblIdCategory.Name = "lblIdCategory";
            this.lblIdCategory.Size = new System.Drawing.Size(91, 13);
            this.lblIdCategory.TabIndex = 0;
            this.lblIdCategory.Text = "Id de la categoría";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(29, 57);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(119, 13);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Nombre de la categoría";
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Location = new System.Drawing.Point(30, 93);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(63, 13);
            this.lblCategoryDescription.TabIndex = 2;
            this.lblCategoryDescription.Text = "Descripción";
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.Location = new System.Drawing.Point(162, 20);
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.Size = new System.Drawing.Size(212, 20);
            this.txtIdCategory.TabIndex = 4;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(162, 54);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ShortcutsEnabled = false;
            this.txtCategoryName.Size = new System.Drawing.Size(212, 20);
            this.txtCategoryName.TabIndex = 5;
            this.txtCategoryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoryName_KeyPress);
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(162, 92);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.ShortcutsEnabled = false;
            this.txtCategoryDescription.Size = new System.Drawing.Size(212, 20);
            this.txtCategoryDescription.TabIndex = 6;
            this.txtCategoryDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoryDescription_KeyPress);
            // 
            // btnCategoryAccept
            // 
            this.btnCategoryAccept.Location = new System.Drawing.Point(84, 145);
            this.btnCategoryAccept.Name = "btnCategoryAccept";
            this.btnCategoryAccept.Size = new System.Drawing.Size(101, 50);
            this.btnCategoryAccept.TabIndex = 7;
            this.btnCategoryAccept.Text = "Aceptar";
            this.btnCategoryAccept.UseVisualStyleBackColor = true;
            this.btnCategoryAccept.Click += new System.EventHandler(this.btnCategoryAccept_Click);
            // 
            // btnCategoryCancel
            // 
            this.btnCategoryCancel.Location = new System.Drawing.Point(248, 145);
            this.btnCategoryCancel.Name = "btnCategoryCancel";
            this.btnCategoryCancel.Size = new System.Drawing.Size(101, 50);
            this.btnCategoryCancel.TabIndex = 8;
            this.btnCategoryCancel.Text = "Cancelar";
            this.btnCategoryCancel.UseVisualStyleBackColor = true;
            this.btnCategoryCancel.Click += new System.EventHandler(this.btnCategoryCancel_Click);
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 209);
            this.Controls.Add(this.btnCategoryCancel);
            this.Controls.Add(this.btnCategoryAccept);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtIdCategory);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblIdCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.TextBox txtIdCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Button btnCategoryAccept;
        private System.Windows.Forms.Button btnCategoryCancel;
    }
}