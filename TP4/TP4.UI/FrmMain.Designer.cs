namespace TP4.UI
{
    partial class FrmMain
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
            this.lblCategorySubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnInfoCategory = new System.Windows.Forms.Button();
            this.btnInfoAllCategories = new System.Windows.Forms.Button();
            this.lblShipper = new System.Windows.Forms.Label();
            this.lstShippers = new System.Windows.Forms.ListBox();
            this.btnAddShipper = new System.Windows.Forms.Button();
            this.btnUpdateShipper = new System.Windows.Forms.Button();
            this.btnDeleteShipper = new System.Windows.Forms.Button();
            this.btnInfoShipper = new System.Windows.Forms.Button();
            this.btnInfoAllShipper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategorySubtitle
            // 
            this.lblCategorySubtitle.AutoSize = true;
            this.lblCategorySubtitle.Location = new System.Drawing.Point(22, 45);
            this.lblCategorySubtitle.Name = "lblCategorySubtitle";
            this.lblCategorySubtitle.Size = new System.Drawing.Size(57, 13);
            this.lblCategorySubtitle.TabIndex = 0;
            this.lblCategorySubtitle.Text = "Categorias";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(277, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Consultas de informacion de la base de datos Northwind";
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(25, 75);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(731, 108);
            this.lstCategories.TabIndex = 2;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(25, 204);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(99, 48);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Agregar";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(182, 204);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(99, 48);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Modificar";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(340, 204);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(99, 48);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Eliminar";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnInfoCategory
            // 
            this.btnInfoCategory.Location = new System.Drawing.Point(504, 204);
            this.btnInfoCategory.Name = "btnInfoCategory";
            this.btnInfoCategory.Size = new System.Drawing.Size(99, 48);
            this.btnInfoCategory.TabIndex = 6;
            this.btnInfoCategory.Text = "Informacion de la categoría";
            this.btnInfoCategory.UseVisualStyleBackColor = true;
            this.btnInfoCategory.Click += new System.EventHandler(this.btnInfoCategory_Click);
            // 
            // btnInfoAllCategories
            // 
            this.btnInfoAllCategories.Location = new System.Drawing.Point(657, 204);
            this.btnInfoAllCategories.Name = "btnInfoAllCategories";
            this.btnInfoAllCategories.Size = new System.Drawing.Size(99, 48);
            this.btnInfoAllCategories.TabIndex = 7;
            this.btnInfoAllCategories.Text = "Informacion de todas las categorías";
            this.btnInfoAllCategories.UseVisualStyleBackColor = true;
            this.btnInfoAllCategories.Click += new System.EventHandler(this.btnInfoAllCategories_Click);
            // 
            // lblShipper
            // 
            this.lblShipper.AutoSize = true;
            this.lblShipper.Location = new System.Drawing.Point(25, 276);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(73, 13);
            this.lblShipper.TabIndex = 8;
            this.lblShipper.Text = "Transportistas";
            // 
            // lstShippers
            // 
            this.lstShippers.FormattingEnabled = true;
            this.lstShippers.Location = new System.Drawing.Point(25, 309);
            this.lstShippers.Name = "lstShippers";
            this.lstShippers.Size = new System.Drawing.Size(731, 108);
            this.lstShippers.TabIndex = 9;
            // 
            // btnAddShipper
            // 
            this.btnAddShipper.Location = new System.Drawing.Point(25, 440);
            this.btnAddShipper.Name = "btnAddShipper";
            this.btnAddShipper.Size = new System.Drawing.Size(99, 48);
            this.btnAddShipper.TabIndex = 10;
            this.btnAddShipper.Text = "Agregar";
            this.btnAddShipper.UseVisualStyleBackColor = true;
            this.btnAddShipper.Click += new System.EventHandler(this.btnAddShipper_Click);
            // 
            // btnUpdateShipper
            // 
            this.btnUpdateShipper.Location = new System.Drawing.Point(182, 440);
            this.btnUpdateShipper.Name = "btnUpdateShipper";
            this.btnUpdateShipper.Size = new System.Drawing.Size(99, 48);
            this.btnUpdateShipper.TabIndex = 11;
            this.btnUpdateShipper.Text = "Modificar";
            this.btnUpdateShipper.UseVisualStyleBackColor = true;
            this.btnUpdateShipper.Click += new System.EventHandler(this.btnUpdateShipper_Click);
            // 
            // btnDeleteShipper
            // 
            this.btnDeleteShipper.Location = new System.Drawing.Point(340, 440);
            this.btnDeleteShipper.Name = "btnDeleteShipper";
            this.btnDeleteShipper.Size = new System.Drawing.Size(99, 48);
            this.btnDeleteShipper.TabIndex = 12;
            this.btnDeleteShipper.Text = "Eliminar";
            this.btnDeleteShipper.UseVisualStyleBackColor = true;
            this.btnDeleteShipper.Click += new System.EventHandler(this.btnDeleteShipper_Click);
            // 
            // btnInfoShipper
            // 
            this.btnInfoShipper.Location = new System.Drawing.Point(504, 440);
            this.btnInfoShipper.Name = "btnInfoShipper";
            this.btnInfoShipper.Size = new System.Drawing.Size(99, 48);
            this.btnInfoShipper.TabIndex = 13;
            this.btnInfoShipper.Text = "Informacion del transportista";
            this.btnInfoShipper.UseVisualStyleBackColor = true;
            this.btnInfoShipper.Click += new System.EventHandler(this.btnInfoShipper_Click);
            // 
            // btnInfoAllShipper
            // 
            this.btnInfoAllShipper.Location = new System.Drawing.Point(657, 440);
            this.btnInfoAllShipper.Name = "btnInfoAllShipper";
            this.btnInfoAllShipper.Size = new System.Drawing.Size(99, 48);
            this.btnInfoAllShipper.TabIndex = 14;
            this.btnInfoAllShipper.Text = "Informacion de todos los transportistas";
            this.btnInfoAllShipper.UseVisualStyleBackColor = true;
            this.btnInfoAllShipper.Click += new System.EventHandler(this.btnInfoAllShipper_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 512);
            this.Controls.Add(this.btnInfoAllShipper);
            this.Controls.Add(this.btnInfoShipper);
            this.Controls.Add(this.btnDeleteShipper);
            this.Controls.Add(this.btnUpdateShipper);
            this.Controls.Add(this.btnAddShipper);
            this.Controls.Add(this.lstShippers);
            this.Controls.Add(this.lblShipper);
            this.Controls.Add(this.btnInfoAllCategories);
            this.Controls.Add(this.btnInfoCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCategorySubtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorySubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnInfoCategory;
        private System.Windows.Forms.Button btnInfoAllCategories;
        private System.Windows.Forms.Label lblShipper;
        private System.Windows.Forms.ListBox lstShippers;
        private System.Windows.Forms.Button btnAddShipper;
        private System.Windows.Forms.Button btnUpdateShipper;
        private System.Windows.Forms.Button btnDeleteShipper;
        private System.Windows.Forms.Button btnInfoShipper;
        private System.Windows.Forms.Button btnInfoAllShipper;
    }
}

