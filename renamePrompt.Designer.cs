namespace docRenamer
{
    partial class renamePrompt
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.promptMsg = new System.Windows.Forms.Label();
            this.renameValue = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.promptMsg);
            this.flowLayoutPanel1.Controls.Add(this.renameValue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(343, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // promptMsg
            // 
            this.promptMsg.AutoSize = true;
            this.promptMsg.Location = new System.Drawing.Point(3, 0);
            this.promptMsg.Name = "promptMsg";
            this.promptMsg.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.promptMsg.Size = new System.Drawing.Size(132, 18);
            this.promptMsg.TabIndex = 0;
            this.promptMsg.Text = "Please provide new name:";
            // 
            // renameValue
            // 
            this.renameValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.renameValue.Location = new System.Drawing.Point(141, 3);
            this.renameValue.MaxLength = 78;
            this.renameValue.Name = "renameValue";
            this.renameValue.Size = new System.Drawing.Size(197, 20);
            this.renameValue.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(263, 70);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Ok";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // renamePrompt
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 96);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSubmit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "renamePrompt";
            this.ShowIcon = false;
            this.Text = "Rename Prompt";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label promptMsg;
        public System.Windows.Forms.TextBox renameValue;
        private System.Windows.Forms.Button btnSubmit;
    }
}