namespace InventoryClient
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            lblName = new System.Windows.Forms.Label();
            lblCode = new System.Windows.Forms.Label();
            lblBrand = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtCode = new System.Windows.Forms.TextBox();
            txtBrand = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(16, 132);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(852, 356);
            dataGridView1.TabIndex = 10;
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(16, 16);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblCode.AutoSize = true;
            lblCode.Location = new System.Drawing.Point(226, 16);
            lblCode.Name = "lblCode";
            lblCode.Size = new System.Drawing.Size(35, 15);
            lblCode.TabIndex = 2;
            lblCode.Text = "Code";
            lblBrand.AutoSize = true;
            lblBrand.Location = new System.Drawing.Point(436, 16);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new System.Drawing.Size(38, 15);
            lblBrand.TabIndex = 4;
            lblBrand.Text = "Brand";
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(646, 16);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(59, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Unit price";
            txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            txtName.Location = new System.Drawing.Point(16, 40);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(190, 23);
            txtName.TabIndex = 1;
            txtCode.Location = new System.Drawing.Point(226, 40);
            txtCode.Name = "txtCode";
            txtCode.Size = new System.Drawing.Size(190, 23);
            txtCode.TabIndex = 3;
            txtBrand.Location = new System.Drawing.Point(436, 40);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new System.Drawing.Size(190, 23);
            txtBrand.TabIndex = 5;
            txtPrice.Location = new System.Drawing.Point(646, 40);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(120, 23);
            txtPrice.TabIndex = 7;
            btnLoad.Location = new System.Drawing.Point(16, 84);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(100, 30);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Refresh items";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            btnAdd.Location = new System.Drawing.Point(126, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(100, 30);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 501);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(txtPrice);
            Controls.Add(txtBrand);
            Controls.Add(txtCode);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(lblBrand);
            Controls.Add(lblCode);
            Controls.Add(lblName);
            Controls.Add(dataGridView1);
            MinimumSize = new System.Drawing.Size(900, 540);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}