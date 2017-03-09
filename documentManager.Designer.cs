namespace docRenamer
{
    partial class documentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(documentManager));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.supplierPacklist = new System.Windows.Forms.Label();
            this.rawMaterialCerts = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerPurchaseOrders = new System.Windows.Forms.Label();
            this.fileActionsSupplierPacklist = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radCopy = new System.Windows.Forms.RadioButton();
            this.radMove = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DsnStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vmfgStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sand7StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.fileActionsSupplierPacklist.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.supplierPacklist, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rawMaterialCerts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.customerPurchaseOrders, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.14481F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.85519F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 195);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // supplierPacklist
            // 
            this.supplierPacklist.AllowDrop = true;
            this.supplierPacklist.AutoSize = true;
            this.supplierPacklist.BackColor = System.Drawing.Color.DarkRed;
            this.supplierPacklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierPacklist.ForeColor = System.Drawing.Color.White;
            this.supplierPacklist.Location = new System.Drawing.Point(3, 95);
            this.supplierPacklist.Name = "supplierPacklist";
            this.supplierPacklist.Size = new System.Drawing.Size(100, 100);
            this.supplierPacklist.TabIndex = 2;
            this.supplierPacklist.Tag = "1";
            this.supplierPacklist.Text = "Supplier Packlists";
            this.supplierPacklist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rawMaterialCerts
            // 
            this.rawMaterialCerts.AllowDrop = true;
            this.rawMaterialCerts.AutoSize = true;
            this.rawMaterialCerts.BackColor = System.Drawing.Color.Blue;
            this.rawMaterialCerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawMaterialCerts.ForeColor = System.Drawing.Color.White;
            this.rawMaterialCerts.Location = new System.Drawing.Point(109, 0);
            this.rawMaterialCerts.Name = "rawMaterialCerts";
            this.rawMaterialCerts.Size = new System.Drawing.Size(100, 95);
            this.rawMaterialCerts.TabIndex = 1;
            this.rawMaterialCerts.Text = "Raw Material Certs";
            this.rawMaterialCerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(109, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 100);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier RFQs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerPurchaseOrders
            // 
            this.customerPurchaseOrders.AllowDrop = true;
            this.customerPurchaseOrders.AutoSize = true;
            this.customerPurchaseOrders.BackColor = System.Drawing.Color.Green;
            this.customerPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerPurchaseOrders.ForeColor = System.Drawing.Color.White;
            this.customerPurchaseOrders.Location = new System.Drawing.Point(3, 0);
            this.customerPurchaseOrders.Name = "customerPurchaseOrders";
            this.customerPurchaseOrders.Size = new System.Drawing.Size(100, 95);
            this.customerPurchaseOrders.TabIndex = 0;
            this.customerPurchaseOrders.Text = "Customer Purchase Orders";
            this.customerPurchaseOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileActionsSupplierPacklist
            // 
            this.fileActionsSupplierPacklist.Controls.Add(this.flowLayoutPanel1);
            this.fileActionsSupplierPacklist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileActionsSupplierPacklist.Location = new System.Drawing.Point(0, 228);
            this.fileActionsSupplierPacklist.Name = "fileActionsSupplierPacklist";
            this.fileActionsSupplierPacklist.Size = new System.Drawing.Size(212, 45);
            this.fileActionsSupplierPacklist.TabIndex = 3;
            this.fileActionsSupplierPacklist.TabStop = false;
            this.fileActionsSupplierPacklist.Text = "File Actions";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radCopy);
            this.flowLayoutPanel1.Controls.Add(this.radMove);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 26);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radCopy
            // 
            this.radCopy.AutoSize = true;
            this.radCopy.Location = new System.Drawing.Point(3, 3);
            this.radCopy.Name = "radCopy";
            this.radCopy.Size = new System.Drawing.Size(49, 17);
            this.radCopy.TabIndex = 0;
            this.radCopy.TabStop = true;
            this.radCopy.Text = "Copy";
            this.radCopy.UseVisualStyleBackColor = true;
            // 
            // radMove
            // 
            this.radMove.AutoSize = true;
            this.radMove.Location = new System.Drawing.Point(58, 3);
            this.radMove.Name = "radMove";
            this.radMove.Size = new System.Drawing.Size(52, 17);
            this.radMove.TabIndex = 1;
            this.radMove.TabStop = true;
            this.radMove.Text = "Move";
            this.radMove.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(212, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DsnStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // DsnStripMenuItem1
            // 
            this.DsnStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vmfgStripMenuItem,
            this.sand7StripMenuItem});
            this.DsnStripMenuItem1.Name = "DsnStripMenuItem1";
            this.DsnStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.DsnStripMenuItem1.Text = "DSN";
            // 
            // vmfgStripMenuItem
            // 
            this.vmfgStripMenuItem.CheckOnClick = true;
            this.vmfgStripMenuItem.Name = "vmfgStripMenuItem";
            this.vmfgStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.vmfgStripMenuItem.Text = "VMFG";
            this.vmfgStripMenuItem.Click += new System.EventHandler(this.vmfgStripMenuItem_Click);
            // 
            // sand7StripMenuItem
            // 
            this.sand7StripMenuItem.CheckOnClick = true;
            this.sand7StripMenuItem.Name = "sand7StripMenuItem";
            this.sand7StripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sand7StripMenuItem.Text = "SAND7";
            this.sand7StripMenuItem.Click += new System.EventHandler(this.sand7StripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(91, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.logToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.logToolStripMenuItem.Text = "&Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // documentManager
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 273);
            this.Controls.Add(this.fileActionsSupplierPacklist);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(320, 400);
            this.MinimumSize = new System.Drawing.Size(220, 300);
            this.Name = "documentManager";
            this.Text = "Document Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.documentManager_FormClosing);
            this.Load += new System.EventHandler(this.documentManager_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.fileActionsSupplierPacklist.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label rawMaterialCerts;
        private System.Windows.Forms.Label supplierPacklist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label customerPurchaseOrders;
        private System.Windows.Forms.GroupBox fileActionsSupplierPacklist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DsnStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vmfgStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sand7StripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radCopy;
        private System.Windows.Forms.RadioButton radMove;
    }
}

