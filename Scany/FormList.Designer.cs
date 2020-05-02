namespace Scany
{
    partial class FormList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            this.dataDevices = new System.Windows.Forms.DataGridView();
            this.btRefresh = new System.Windows.Forms.Button();
            this.checkAuto = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstconnect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastconnect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDevices
            // 
            this.dataDevices.AllowUserToAddRows = false;
            this.dataDevices.AllowUserToDeleteRows = false;
            this.dataDevices.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataDevices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Watch Applemint", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIP,
            this.cMac,
            this.cFirstconnect,
            this.cLastconnect});
            this.dataDevices.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataDevices.Location = new System.Drawing.Point(12, 12);
            this.dataDevices.Name = "dataDevices";
            this.dataDevices.Size = new System.Drawing.Size(634, 492);
            this.dataDevices.TabIndex = 0;
            this.dataDevices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDevices_CellContentClick);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.LavenderBlush;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("Watch Applemint", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btRefresh.Location = new System.Drawing.Point(12, 533);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(88, 31);
            this.btRefresh.TabIndex = 1;
            this.btRefresh.Text = "Update";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // checkAuto
            // 
            this.checkAuto.AutoSize = true;
            this.checkAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAuto.Font = new System.Drawing.Font("Watch Applemint", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAuto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkAuto.Location = new System.Drawing.Point(117, 538);
            this.checkAuto.Name = "checkAuto";
            this.checkAuto.Size = new System.Drawing.Size(113, 23);
            this.checkAuto.TabIndex = 2;
            this.checkAuto.Text = "Auto update";
            this.checkAuto.UseVisualStyleBackColor = true;
            this.checkAuto.CheckedChanged += new System.EventHandler(this.checkAuto_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 300000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cIP
            // 
            this.cIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            this.cIP.DefaultCellStyle = dataGridViewCellStyle2;
            this.cIP.Frozen = true;
            this.cIP.HeaderText = "IP";
            this.cIP.Name = "cIP";
            this.cIP.ReadOnly = true;
            this.cIP.Width = 43;
            // 
            // cMac
            // 
            this.cMac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightPink;
            this.cMac.DefaultCellStyle = dataGridViewCellStyle3;
            this.cMac.Frozen = true;
            this.cMac.HeaderText = "Mac";
            this.cMac.Name = "cMac";
            this.cMac.ReadOnly = true;
            this.cMac.Width = 56;
            // 
            // cFirstconnect
            // 
            this.cFirstconnect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink;
            this.cFirstconnect.DefaultCellStyle = dataGridViewCellStyle4;
            this.cFirstconnect.Frozen = true;
            this.cFirstconnect.HeaderText = "First connect";
            this.cFirstconnect.Name = "cFirstconnect";
            this.cFirstconnect.ReadOnly = true;
            this.cFirstconnect.Width = 108;
            // 
            // cLastconnect
            // 
            this.cLastconnect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightPink;
            this.cLastconnect.DefaultCellStyle = dataGridViewCellStyle5;
            this.cLastconnect.HeaderText = "Last connected";
            this.cLastconnect.Name = "cLastconnect";
            this.cLastconnect.ReadOnly = true;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(658, 588);
            this.ControlBox = false;
            this.Controls.Add(this.checkAuto);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.dataDevices);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormList";
            this.Text = "Devices";
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDevices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDevices;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.CheckBox checkAuto;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstconnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastconnect;
    }
}