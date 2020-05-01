namespace Scany
{
    partial class FormLogin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStat = new System.Windows.Forms.Label();
            this.btConn = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Watch Applemint", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtServer.Location = new System.Drawing.Point(120, 131);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(222, 28);
            this.txtServer.TabIndex = 1;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Watch Applemint", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPass.Location = new System.Drawing.Point(120, 211);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(222, 28);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Font = new System.Drawing.Font("Watch Applemint", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbServer.Location = new System.Drawing.Point(28, 132);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(60, 19);
            this.lbServer.TabIndex = 3;
            this.lbServer.Text = "Server:";
            this.lbServer.Click += new System.EventHandler(this.lbServer_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Watch Applemint", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbPass.Location = new System.Drawing.Point(28, 212);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(80, 19);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Password:";
            this.lbPass.Click += new System.EventHandler(this.lbPass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Watch Applemint", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(28, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbStat
            // 
            this.lbStat.AutoSize = true;
            this.lbStat.Font = new System.Drawing.Font("Watch Applemint", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStat.ForeColor = System.Drawing.Color.Crimson;
            this.lbStat.Location = new System.Drawing.Point(116, 48);
            this.lbStat.Name = "lbStat";
            this.lbStat.Size = new System.Drawing.Size(125, 19);
            this.lbStat.TabIndex = 6;
            this.lbStat.Text = "Not connected";
            this.lbStat.Click += new System.EventHandler(this.lbStat_Click);
            // 
            // btConn
            // 
            this.btConn.BackColor = System.Drawing.Color.LavenderBlush;
            this.btConn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConn.Font = new System.Drawing.Font("Watch Applemint", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btConn.Location = new System.Drawing.Point(120, 332);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(83, 41);
            this.btConn.TabIndex = 7;
            this.btConn.Text = "Connect";
            this.btConn.UseVisualStyleBackColor = false;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.LavenderBlush;
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Watch Applemint", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btClose.Location = new System.Drawing.Point(259, 332);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(83, 41);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(424, 455);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.lbStat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStat;
        private System.Windows.Forms.Button btConn;
        private System.Windows.Forms.Button btClose;
    }
}

