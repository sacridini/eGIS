namespace espaçoGIS
{
    partial class espacoGIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(espacoGIS));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análisesEspaciaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.carregarGIS_btn = new System.Windows.Forms.ToolStripButton();
            this.PostGisFunctions_btn = new System.Windows.Forms.ToolStripButton();
            this.sqlQuery_btn = new System.Windows.Forms.ToolStripButton();
            this.tutorial_btn = new System.Windows.Forms.ToolStripButton();
            this.status_pnl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.análisesEspaciaisToolStripMenuItem,
            this.janelaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolBoxToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // sToolBoxToolStripMenuItem
            // 
            this.sToolBoxToolStripMenuItem.Name = "sToolBoxToolStripMenuItem";
            this.sToolBoxToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.sToolBoxToolStripMenuItem.Text = "6S ToolBox";
            this.sToolBoxToolStripMenuItem.Click += new System.EventHandler(this.sToolBoxToolStripMenuItem_Click);
            // 
            // análisesEspaciaisToolStripMenuItem
            // 
            this.análisesEspaciaisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTAreaToolStripMenuItem});
            this.análisesEspaciaisToolStripMenuItem.Name = "análisesEspaciaisToolStripMenuItem";
            this.análisesEspaciaisToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.análisesEspaciaisToolStripMenuItem.Text = "Funções PostGIS";
            // 
            // sTAreaToolStripMenuItem
            // 
            this.sTAreaToolStripMenuItem.Name = "sTAreaToolStripMenuItem";
            this.sTAreaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sTAreaToolStripMenuItem.Text = "ST_Area";
            this.sTAreaToolStripMenuItem.Click += new System.EventHandler(this.sTAreaToolStripMenuItem_Click);
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarGIS_btn,
            this.PostGisFunctions_btn,
            this.sqlQuery_btn,
            this.tutorial_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1424, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // carregarGIS_btn
            // 
            this.carregarGIS_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carregarGIS_btn.Image = ((System.Drawing.Image)(resources.GetObject("carregarGIS_btn.Image")));
            this.carregarGIS_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.carregarGIS_btn.Name = "carregarGIS_btn";
            this.carregarGIS_btn.Size = new System.Drawing.Size(23, 22);
            this.carregarGIS_btn.Text = "Abrir novo SIG";
            this.carregarGIS_btn.Click += new System.EventHandler(this.carregarGIS_btn_Click);
            // 
            // PostGisFunctions_btn
            // 
            this.PostGisFunctions_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PostGisFunctions_btn.Image = ((System.Drawing.Image)(resources.GetObject("PostGisFunctions_btn.Image")));
            this.PostGisFunctions_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PostGisFunctions_btn.Name = "PostGisFunctions_btn";
            this.PostGisFunctions_btn.Size = new System.Drawing.Size(23, 22);
            this.PostGisFunctions_btn.Text = "toolStripButton1";
            this.PostGisFunctions_btn.Click += new System.EventHandler(this.PostGisFunctions_btn_Click);
            // 
            // sqlQuery_btn
            // 
            this.sqlQuery_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sqlQuery_btn.Image = ((System.Drawing.Image)(resources.GetObject("sqlQuery_btn.Image")));
            this.sqlQuery_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sqlQuery_btn.Name = "sqlQuery_btn";
            this.sqlQuery_btn.Size = new System.Drawing.Size(23, 22);
            this.sqlQuery_btn.Text = "PostNET";
            this.sqlQuery_btn.Click += new System.EventHandler(this.sqlQuery_btn_Click);
            // 
            // tutorial_btn
            // 
            this.tutorial_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tutorial_btn.Image = ((System.Drawing.Image)(resources.GetObject("tutorial_btn.Image")));
            this.tutorial_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tutorial_btn.Name = "tutorial_btn";
            this.tutorial_btn.Size = new System.Drawing.Size(23, 22);
            this.tutorial_btn.Text = "toolStripButton1";
            this.tutorial_btn.Click += new System.EventHandler(this.tutorial_btn_Click);
            // 
            // status_pnl
            // 
            this.status_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_pnl.Location = new System.Drawing.Point(0, 787);
            this.status_pnl.Name = "status_pnl";
            this.status_pnl.Size = new System.Drawing.Size(1424, 25);
            this.status_pnl.TabIndex = 8;
            // 
            // espacoGIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 812);
            this.Controls.Add(this.status_pnl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "espacoGIS";
            this.Text = "espaço GIS";
            this.Load += new System.EventHandler(this.espacoGIS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem análisesEspaciaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton carregarGIS_btn;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton PostGisFunctions_btn;
        private System.Windows.Forms.Panel status_pnl;
        private System.Windows.Forms.ToolStripMenuItem sTAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton sqlQuery_btn;
        private System.Windows.Forms.ToolStripButton tutorial_btn;
        private System.Windows.Forms.ToolStripMenuItem sToolBoxToolStripMenuItem;
    }
}

