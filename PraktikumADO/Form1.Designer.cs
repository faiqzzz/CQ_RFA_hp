namespace PraktikumADO
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitungDosen = new System.Windows.Forms.Button();
            this.btnUpdateSKS = new System.Windows.Forms.Button();
            this.btnInsertProdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(58, 237);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(322, 237);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(75, 23);
            this.btnHitungMhs.TabIndex = 1;
            this.btnHitungMhs.Text = "HitungMhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(461, 237);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(75, 23);
            this.btnHitungMK.TabIndex = 2;
            this.btnHitungMK.Text = "HitungMK";
            this.btnHitungMK.UseVisualStyleBackColor = true;
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(58, 292);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(139, 117);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 25);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Hasil";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(210, 121);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(447, 20);
            this.txtHasil.TabIndex = 5;
            this.txtHasil.Click += new System.EventHandler(this.txtHasil_TextChanged);
            this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged);
            // 
            // btnHitungDosen
            // 
            this.btnHitungDosen.Location = new System.Drawing.Point(597, 237);
            this.btnHitungDosen.Name = "btnHitungDosen";
            this.btnHitungDosen.Size = new System.Drawing.Size(75, 23);
            this.btnHitungDosen.TabIndex = 6;
            this.btnHitungDosen.Text = "HitungDosen";
            this.btnHitungDosen.UseVisualStyleBackColor = true;
            this.btnHitungDosen.Click += new System.EventHandler(this.btnHitungDosen_Click);
            // 
            // btnUpdateSKS
            // 
            this.btnUpdateSKS.Location = new System.Drawing.Point(385, 292);
            this.btnUpdateSKS.Name = "btnUpdateSKS";
            this.btnUpdateSKS.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSKS.TabIndex = 7;
            this.btnUpdateSKS.Text = "Update SKS";
            this.btnUpdateSKS.UseVisualStyleBackColor = true;
            this.btnUpdateSKS.Click += new System.EventHandler(this.btnUpdateSKS_Click);
            // 
            // btnInsertProdi
            // 
            this.btnInsertProdi.Location = new System.Drawing.Point(544, 292);
            this.btnInsertProdi.Name = "btnInsertProdi";
            this.btnInsertProdi.Size = new System.Drawing.Size(75, 23);
            this.btnInsertProdi.TabIndex = 8;
            this.btnInsertProdi.Text = "Insert Prodi";
            this.btnInsertProdi.UseVisualStyleBackColor = true;
            this.btnInsertProdi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertProdi);
            this.Controls.Add(this.btnUpdateSKS);
            this.Controls.Add(this.btnHitungDosen);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitungDosen;
        private System.Windows.Forms.Button btnUpdateSKS;
        private System.Windows.Forms.Button btnInsertProdi;
    }
}

