namespace espaçoGIS
{
    partial class espaço
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(espaço));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.map1 = new DotSpatial.Controls.Map();
            this.carregar_btn = new System.Windows.Forms.ToolStripButton();
            this.ZoomIn_btn = new System.Windows.Forms.ToolStripButton();
            this.ZoomOut_btn = new System.Windows.Forms.ToolStripButton();
            this.ZoomToExtent_btn = new System.Windows.Forms.ToolStripButton();
            this.Info_btn = new System.Windows.Forms.ToolStripButton();
            this.ClearLayers_btn = new System.Windows.Forms.ToolStripButton();
            this.pan_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Salvar_btn = new System.Windows.Forms.ToolStripButton();
            this.seleção_btn = new System.Windows.Forms.ToolStripButton();
            this.None_btn = new System.Windows.Forms.ToolStripButton();
            this.snapshot_btn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.legend1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.map1);
            this.splitContainer1.Size = new System.Drawing.Size(974, 607);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 2;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 189, 607);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(189, 607);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.VerticalScrollEnabled = true;
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollectAfterDraw = false;
            this.map1.CollisionDetection = false;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.IsZoomedToMaxExtent = false;
            this.map1.Legend = this.legend1;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(781, 607);
            this.map1.TabIndex = 0;
            this.map1.ZoomOutFartherThanMaxExtent = false;
            // 
            // carregar_btn
            // 
            this.carregar_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carregar_btn.Image = ((System.Drawing.Image)(resources.GetObject("carregar_btn.Image")));
            this.carregar_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.carregar_btn.Name = "carregar_btn";
            this.carregar_btn.Size = new System.Drawing.Size(23, 22);
            this.carregar_btn.Text = "Abrir Camada";
            this.carregar_btn.Click += new System.EventHandler(this.carregar_btn_Click);
            // 
            // ZoomIn_btn
            // 
            this.ZoomIn_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomIn_btn.Image = ((System.Drawing.Image)(resources.GetObject("ZoomIn_btn.Image")));
            this.ZoomIn_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomIn_btn.Name = "ZoomIn_btn";
            this.ZoomIn_btn.Size = new System.Drawing.Size(23, 22);
            this.ZoomIn_btn.Text = "Mais Zoom";
            this.ZoomIn_btn.Click += new System.EventHandler(this.ZoomIn_btn_Click);
            // 
            // ZoomOut_btn
            // 
            this.ZoomOut_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomOut_btn.Image = ((System.Drawing.Image)(resources.GetObject("ZoomOut_btn.Image")));
            this.ZoomOut_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomOut_btn.Name = "ZoomOut_btn";
            this.ZoomOut_btn.Size = new System.Drawing.Size(23, 22);
            this.ZoomOut_btn.Text = "Menos Zoom";
            this.ZoomOut_btn.Click += new System.EventHandler(this.ZoomOut_btn_Click);
            // 
            // ZoomToExtent_btn
            // 
            this.ZoomToExtent_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomToExtent_btn.Image = ((System.Drawing.Image)(resources.GetObject("ZoomToExtent_btn.Image")));
            this.ZoomToExtent_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomToExtent_btn.Name = "ZoomToExtent_btn";
            this.ZoomToExtent_btn.Size = new System.Drawing.Size(23, 22);
            this.ZoomToExtent_btn.Text = "Zoom para Camada";
            this.ZoomToExtent_btn.Click += new System.EventHandler(this.ZoomToExtent_btn_Click);
            // 
            // Info_btn
            // 
            this.Info_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Info_btn.Image = ((System.Drawing.Image)(resources.GetObject("Info_btn.Image")));
            this.Info_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Info_btn.Name = "Info_btn";
            this.Info_btn.Size = new System.Drawing.Size(23, 22);
            this.Info_btn.Text = "Informações";
            this.Info_btn.Click += new System.EventHandler(this.Info_btn_Click);
            // 
            // ClearLayers_btn
            // 
            this.ClearLayers_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearLayers_btn.Image = ((System.Drawing.Image)(resources.GetObject("ClearLayers_btn.Image")));
            this.ClearLayers_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearLayers_btn.Name = "ClearLayers_btn";
            this.ClearLayers_btn.Size = new System.Drawing.Size(23, 22);
            this.ClearLayers_btn.Text = "Limpar tudo";
            this.ClearLayers_btn.Click += new System.EventHandler(this.ClearLayers_btn_Click);
            // 
            // pan_btn
            // 
            this.pan_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pan_btn.Image = ((System.Drawing.Image)(resources.GetObject("pan_btn.Image")));
            this.pan_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pan_btn.Name = "pan_btn";
            this.pan_btn.Size = new System.Drawing.Size(23, 22);
            this.pan_btn.Text = "Pan";
            this.pan_btn.Click += new System.EventHandler(this.pan_btn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregar_btn,
            this.Salvar_btn,
            this.ZoomIn_btn,
            this.ZoomOut_btn,
            this.ZoomToExtent_btn,
            this.Info_btn,
            this.seleção_btn,
            this.None_btn,
            this.pan_btn,
            this.ClearLayers_btn,
            this.snapshot_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Salvar_btn
            // 
            this.Salvar_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Salvar_btn.Image = ((System.Drawing.Image)(resources.GetObject("Salvar_btn.Image")));
            this.Salvar_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Salvar_btn.Name = "Salvar_btn";
            this.Salvar_btn.Size = new System.Drawing.Size(23, 22);
            this.Salvar_btn.Text = "Salvar Camada";
            this.Salvar_btn.Click += new System.EventHandler(this.Salvar_btn_Click);
            // 
            // seleção_btn
            // 
            this.seleção_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.seleção_btn.Image = ((System.Drawing.Image)(resources.GetObject("seleção_btn.Image")));
            this.seleção_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.seleção_btn.Name = "seleção_btn";
            this.seleção_btn.Size = new System.Drawing.Size(23, 22);
            this.seleção_btn.Text = "Selecionar";
            this.seleção_btn.Click += new System.EventHandler(this.seleção_btn_Click);
            // 
            // None_btn
            // 
            this.None_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.None_btn.Image = ((System.Drawing.Image)(resources.GetObject("None_btn.Image")));
            this.None_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.None_btn.Name = "None_btn";
            this.None_btn.Size = new System.Drawing.Size(23, 22);
            this.None_btn.Text = "None";
            // 
            // snapshot_btn
            // 
            this.snapshot_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.snapshot_btn.Image = ((System.Drawing.Image)(resources.GetObject("snapshot_btn.Image")));
            this.snapshot_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.snapshot_btn.Name = "snapshot_btn";
            this.snapshot_btn.Size = new System.Drawing.Size(23, 22);
            this.snapshot_btn.Text = "toolStripButton1";
            // 
            // espaço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 632);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "espaço";
            this.Text = "espaço";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.Map map1;
        private System.Windows.Forms.ToolStripButton carregar_btn;
        private System.Windows.Forms.ToolStripButton ZoomIn_btn;
        private System.Windows.Forms.ToolStripButton ZoomOut_btn;
        private System.Windows.Forms.ToolStripButton ZoomToExtent_btn;
        private System.Windows.Forms.ToolStripButton Info_btn;
        private System.Windows.Forms.ToolStripButton ClearLayers_btn;
        private System.Windows.Forms.ToolStripButton pan_btn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Salvar_btn;
        private System.Windows.Forms.ToolStripButton seleção_btn;
        private System.Windows.Forms.ToolStripButton None_btn;
        private System.Windows.Forms.ToolStripButton snapshot_btn;
    }
}