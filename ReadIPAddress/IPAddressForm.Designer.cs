namespace ReadIPAddress
{
    partial class IPAddressForm
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
            this.btnIPAdress1 = new System.Windows.Forms.Button();
            this.btnIPAddress2 = new System.Windows.Forms.Button();
            this.btnIPAddress3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIPAdress1
            // 
            this.btnIPAdress1.BackColor = System.Drawing.Color.Silver;
            this.btnIPAdress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPAdress1.Location = new System.Drawing.Point(29, 83);
            this.btnIPAdress1.Name = "btnIPAdress1";
            this.btnIPAdress1.Size = new System.Drawing.Size(135, 45);
            this.btnIPAdress1.TabIndex = 1;
            this.btnIPAdress1.Text = "Get IP Address";
            this.btnIPAdress1.UseVisualStyleBackColor = false;
            this.btnIPAdress1.Click += new System.EventHandler(this.btnIPAdress1_Click);
            // 
            // btnIPAddress2
            // 
            this.btnIPAddress2.BackColor = System.Drawing.Color.Silver;
            this.btnIPAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPAddress2.Location = new System.Drawing.Point(214, 83);
            this.btnIPAddress2.Name = "btnIPAddress2";
            this.btnIPAddress2.Size = new System.Drawing.Size(135, 45);
            this.btnIPAddress2.TabIndex = 2;
            this.btnIPAddress2.Text = "Get Client IP";
            this.btnIPAddress2.UseVisualStyleBackColor = false;
            this.btnIPAddress2.Click += new System.EventHandler(this.btnIPAddress2_Click);
            // 
            // btnIPAddress3
            // 
            this.btnIPAddress3.BackColor = System.Drawing.Color.Silver;
            this.btnIPAddress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPAddress3.Location = new System.Drawing.Point(396, 83);
            this.btnIPAddress3.Name = "btnIPAddress3";
            this.btnIPAddress3.Size = new System.Drawing.Size(125, 45);
            this.btnIPAddress3.TabIndex = 4;
            this.btnIPAddress3.Text = "Get Host and IP ";
            this.btnIPAddress3.UseVisualStyleBackColor = false;
            this.btnIPAddress3.Click += new System.EventHandler(this.btnIPAddress3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your machine IP Address:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.ForeColor = System.Drawing.Color.Black;
            this.txtIPAddress.Location = new System.Drawing.Point(214, 181);
            this.txtIPAddress.Multiline = true;
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(307, 29);
            this.txtIPAddress.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Get Client IP Address";
            // 
            // IPAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(586, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIPAddress3);
            this.Controls.Add(this.btnIPAddress2);
            this.Controls.Add(this.btnIPAdress1);
            this.Name = "IPAddressForm";
            this.Text = "IPAddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIPAdress1;
        private System.Windows.Forms.Button btnIPAddress2;
        private System.Windows.Forms.Button btnIPAddress3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label1;
    }
}