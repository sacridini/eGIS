namespace espaçoGIS
{
    partial class ConexaoDB
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.server_lbl = new System.Windows.Forms.Label();
            this.database_txt = new System.Windows.Forms.TextBox();
            this.port_lbl = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.user_lbl = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.database_lbl = new System.Windows.Forms.Label();
            this.server_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connect_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(460, 301);
            this.splitContainer1.SplitterDistance = 77;
            this.splitContainer1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connect_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.server_txt);
            this.groupBox1.Controls.Add(this.database_lbl);
            this.groupBox1.Controls.Add(this.port_txt);
            this.groupBox1.Controls.Add(this.password_lbl);
            this.groupBox1.Controls.Add(this.user_txt);
            this.groupBox1.Controls.Add(this.user_lbl);
            this.groupBox1.Controls.Add(this.password_txt);
            this.groupBox1.Controls.Add(this.port_lbl);
            this.groupBox1.Controls.Add(this.database_txt);
            this.groupBox1.Controls.Add(this.server_lbl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 301);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primeiro Passo";
            // 
            // server_lbl
            // 
            this.server_lbl.AutoSize = true;
            this.server_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_lbl.Location = new System.Drawing.Point(19, 46);
            this.server_lbl.Name = "server_lbl";
            this.server_lbl.Size = new System.Drawing.Size(54, 13);
            this.server_lbl.TabIndex = 16;
            this.server_lbl.Text = "Servidor";
            // 
            // database_txt
            // 
            this.database_txt.BackColor = System.Drawing.Color.DarkGray;
            this.database_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.database_txt.Location = new System.Drawing.Point(85, 188);
            this.database_txt.Name = "database_txt";
            this.database_txt.Size = new System.Drawing.Size(100, 20);
            this.database_txt.TabIndex = 15;
            // 
            // port_lbl
            // 
            this.port_lbl.AutoSize = true;
            this.port_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_lbl.Location = new System.Drawing.Point(33, 83);
            this.port_lbl.Name = "port_lbl";
            this.port_lbl.Size = new System.Drawing.Size(37, 13);
            this.port_lbl.TabIndex = 17;
            this.port_lbl.Text = "Porta";
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.DarkGray;
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txt.Location = new System.Drawing.Point(85, 153);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(100, 20);
            this.password_txt.TabIndex = 14;
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.Location = new System.Drawing.Point(22, 120);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(50, 13);
            this.user_lbl.TabIndex = 18;
            this.user_lbl.Text = "Usuário";
            // 
            // user_txt
            // 
            this.user_txt.BackColor = System.Drawing.Color.DarkGray;
            this.user_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_txt.Location = new System.Drawing.Point(85, 117);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(100, 20);
            this.user_txt.TabIndex = 13;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(27, 156);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(43, 13);
            this.password_lbl.TabIndex = 19;
            this.password_lbl.Text = "Senha";
            // 
            // port_txt
            // 
            this.port_txt.BackColor = System.Drawing.Color.DarkGray;
            this.port_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.port_txt.Location = new System.Drawing.Point(85, 80);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(100, 20);
            this.port_txt.TabIndex = 12;
            // 
            // database_lbl
            // 
            this.database_lbl.AutoSize = true;
            this.database_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_lbl.Location = new System.Drawing.Point(12, 193);
            this.database_lbl.Name = "database_lbl";
            this.database_lbl.Size = new System.Drawing.Size(61, 13);
            this.database_lbl.TabIndex = 20;
            this.database_lbl.Text = "Database";
            // 
            // server_txt
            // 
            this.server_txt.BackColor = System.Drawing.Color.DarkGray;
            this.server_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server_txt.Location = new System.Drawing.Point(85, 43);
            this.server_txt.Name = "server_txt";
            this.server_txt.Size = new System.Drawing.Size(100, 20);
            this.server_txt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Conectar ao PostGIS:";
            // 
            // connect_btn
            // 
            this.connect_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connect_btn.Location = new System.Drawing.Point(292, 266);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 22;
            this.connect_btn.Text = "Conectar";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // ConexaoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 301);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ConexaoDB";
            this.Text = "Conexão PostGIS";
            this.Load += new System.EventHandler(this.PostGisFunctions_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connect_btn;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox server_txt;
        private System.Windows.Forms.Label database_lbl;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label port_lbl;
        private System.Windows.Forms.TextBox database_txt;
        private System.Windows.Forms.Label server_lbl;
    }
}