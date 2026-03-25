namespace Sklad1
{
    partial class FormEditProduct
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
            panel1 = new Panel();
            lblTitle = new Label();
            lblArticle = new Label();
            txtArticle = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblPurchasePrice = new Label();
            txtPurchasePrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 511);
            panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(207, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(296, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Редактирование товара";
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblArticle.Location = new Point(219, 106);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(58, 17);
            lblArticle.TabIndex = 3;
            lblArticle.Text = "Артикул:";
            // 
            // txtArticle
            // 
            txtArticle.Location = new Point(219, 126);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(284, 23);
            txtArticle.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblName.Location = new Point(219, 178);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 17);
            lblName.TabIndex = 8;
            lblName.Text = "Название:";
            // 
            // txtName
            // 
            txtName.Location = new Point(219, 198);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 23);
            txtName.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCategory.Location = new Point(219, 253);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 17);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Категория:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(219, 273);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(284, 23);
            txtCategory.TabIndex = 11;
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPurchasePrice.Location = new Point(219, 319);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(91, 17);
            lblPurchasePrice.TabIndex = 12;
            lblPurchasePrice.Text = "Цена закупки:";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(219, 339);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(284, 23);
            txtPurchasePrice.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(230, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 42);
            btnSave.TabIndex = 14;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(370, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 42);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormEditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 511);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPurchasePrice);
            Controls.Add(lblPurchasePrice);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtArticle);
            Controls.Add(lblArticle);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "FormEditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblArticle;
        private TextBox txtArticle;
        private Label lblName;
        private TextBox txtName;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblPurchasePrice;
        private TextBox txtPurchasePrice;
        private Button btnSave;
        private Button btnCancel;
    }
}