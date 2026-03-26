namespace Sklad1.Forms
{
    partial class FormProduct
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
            lblName = new Label();
            lblCategory = new Label();
            lblPurchasePrice = new Label();
            txtArticle = new TextBox();
            txtName = new TextBox();
            txtPurchasePrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            txtCategory = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 511);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(211, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(297, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Создание товара";
            // 
            // lblArticle
            // 
            lblArticle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblArticle.AutoSize = true;
            lblArticle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblArticle.Location = new Point(219, 83);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(58, 17);
            lblArticle.TabIndex = 2;
            lblArticle.Text = "Артикул:";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblName.Location = new Point(219, 139);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 17);
            lblName.TabIndex = 3;
            lblName.Text = "Название:";
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCategory.Location = new Point(219, 198);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 17);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Категория:";
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPurchasePrice.Location = new Point(219, 258);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(91, 17);
            lblPurchasePrice.TabIndex = 5;
            lblPurchasePrice.Text = "Цена закупки:";
            // 
            // txtArticle
            // 
            txtArticle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtArticle.Location = new Point(219, 103);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(284, 23);
            txtArticle.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(219, 159);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 23);
            txtName.TabIndex = 7;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPurchasePrice.Location = new Point(219, 278);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(284, 23);
            txtPurchasePrice.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(230, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 42);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(370, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 42);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCategory.Location = new Point(219, 218);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(284, 23);
            txtCategory.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblQuantity.Location = new Point(219, 321);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(81, 17);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Количество:";
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.Location = new Point(219, 341);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(284, 23);
            txtQuantity.TabIndex = 13;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 511);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPurchasePrice);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(txtArticle);
            Controls.Add(lblPurchasePrice);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Controls.Add(lblArticle);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание товара";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblArticle;
        private Label lblName;
        private Label lblCategory;
        private Label lblPurchasePrice;
        private TextBox txtArticle;
        private TextBox txtName;
        private TextBox txtPurchasePrice;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtCategory;
        private Label lblQuantity;
        private TextBox txtQuantity;
    }
}