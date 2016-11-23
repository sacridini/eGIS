namespace espaçoGIS
{
    partial class sqlQuery
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
            this.sqlQuery_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.from_btn = new System.Windows.Forms.Button();
            this.where_btn = new System.Windows.Forms.Button();
            this.iqual_btn = new System.Windows.Forms.Button();
            this.and_btn = new System.Windows.Forms.Button();
            this.like_btn = new System.Windows.Forms.Button();
            this.notIqual_btn = new System.Windows.Forms.Button();
            this.menorQ_btn = new System.Windows.Forms.Button();
            this.maiorQ_btn = new System.Windows.Forms.Button();
            this.not_btn = new System.Windows.Forms.Button();
            this.or_btn = new System.Windows.Forms.Button();
            this.menorOuIqual_btn = new System.Windows.Forms.Button();
            this.maiorOuIqual_btn = new System.Windows.Forms.Button();
            this.porcentagem_btn = new System.Windows.Forms.Button();
            this.operadores_logicos_grpbox = new System.Windows.Forms.GroupBox();
            this.sum_btn = new System.Windows.Forms.Button();
            this.stArea_btn = new System.Windows.Forms.Button();
            this.stDistance_btn = new System.Windows.Forms.Button();
            this.stCentroid_btn = new System.Windows.Forms.Button();
            this.stTransform_btn = new System.Windows.Forms.Button();
            this.stAsText_btn = new System.Windows.Forms.Button();
            this.stWithin_btn = new System.Windows.Forms.Button();
            this.stCrosses_btn = new System.Windows.Forms.Button();
            this.stContains_btn = new System.Windows.Forms.Button();
            this.stDwithin_btn = new System.Windows.Forms.Button();
            this.stTouches_btn = new System.Windows.Forms.Button();
            this.stintersects_btn = new System.Windows.Forms.Button();
            this.stLength_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.limpar_btn = new System.Windows.Forms.Button();
            this.rows_listbox = new System.Windows.Forms.ListBox();
            this.coluna_listbox = new System.Windows.Forms.ListBox();
            this.tables_cbx = new System.Windows.Forms.ComboBox();
            this.getColunas_btn = new System.Windows.Forms.Button();
            this.getUniqueValues_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.operadores_logicos_grpbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlQuery_txt
            // 
            this.sqlQuery_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlQuery_txt.Location = new System.Drawing.Point(12, 37);
            this.sqlQuery_txt.Multiline = true;
            this.sqlQuery_txt.Name = "sqlQuery_txt";
            this.sqlQuery_txt.Size = new System.Drawing.Size(774, 69);
            this.sqlQuery_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta Espacial em SQL:";
            // 
            // select_btn
            // 
            this.select_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.select_btn.Location = new System.Drawing.Point(6, 19);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(75, 23);
            this.select_btn.TabIndex = 2;
            this.select_btn.Text = "SELECT";
            this.select_btn.UseVisualStyleBackColor = false;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // from_btn
            // 
            this.from_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.from_btn.Location = new System.Drawing.Point(6, 41);
            this.from_btn.Name = "from_btn";
            this.from_btn.Size = new System.Drawing.Size(75, 23);
            this.from_btn.TabIndex = 5;
            this.from_btn.Text = "FROM";
            this.from_btn.UseVisualStyleBackColor = false;
            this.from_btn.Click += new System.EventHandler(this.from_btn_Click);
            // 
            // where_btn
            // 
            this.where_btn.BackColor = System.Drawing.Color.LightYellow;
            this.where_btn.Location = new System.Drawing.Point(21, 381);
            this.where_btn.Name = "where_btn";
            this.where_btn.Size = new System.Drawing.Size(75, 23);
            this.where_btn.TabIndex = 6;
            this.where_btn.Text = "WHERE";
            this.where_btn.UseVisualStyleBackColor = false;
            this.where_btn.Click += new System.EventHandler(this.where_btn_Click);
            // 
            // iqual_btn
            // 
            this.iqual_btn.BackColor = System.Drawing.Color.LightYellow;
            this.iqual_btn.Location = new System.Drawing.Point(6, 20);
            this.iqual_btn.Name = "iqual_btn";
            this.iqual_btn.Size = new System.Drawing.Size(36, 27);
            this.iqual_btn.TabIndex = 13;
            this.iqual_btn.Text = "=";
            this.iqual_btn.UseVisualStyleBackColor = false;
            this.iqual_btn.Click += new System.EventHandler(this.iqual_btn_Click);
            // 
            // and_btn
            // 
            this.and_btn.BackColor = System.Drawing.Color.LightYellow;
            this.and_btn.Location = new System.Drawing.Point(91, 53);
            this.and_btn.Name = "and_btn";
            this.and_btn.Size = new System.Drawing.Size(36, 27);
            this.and_btn.TabIndex = 15;
            this.and_btn.Text = "And";
            this.and_btn.UseVisualStyleBackColor = false;
            this.and_btn.Click += new System.EventHandler(this.and_btn_Click);
            // 
            // like_btn
            // 
            this.like_btn.BackColor = System.Drawing.Color.LightYellow;
            this.like_btn.Location = new System.Drawing.Point(91, 20);
            this.like_btn.Name = "like_btn";
            this.like_btn.Size = new System.Drawing.Size(36, 27);
            this.like_btn.TabIndex = 16;
            this.like_btn.Text = "Like";
            this.like_btn.UseVisualStyleBackColor = false;
            this.like_btn.Click += new System.EventHandler(this.like_btn_Click);
            // 
            // notIqual_btn
            // 
            this.notIqual_btn.BackColor = System.Drawing.Color.LightYellow;
            this.notIqual_btn.Location = new System.Drawing.Point(48, 20);
            this.notIqual_btn.Name = "notIqual_btn";
            this.notIqual_btn.Size = new System.Drawing.Size(36, 27);
            this.notIqual_btn.TabIndex = 17;
            this.notIqual_btn.Text = "<>";
            this.notIqual_btn.UseVisualStyleBackColor = false;
            this.notIqual_btn.Click += new System.EventHandler(this.notIqual_btn_Click);
            // 
            // menorQ_btn
            // 
            this.menorQ_btn.BackColor = System.Drawing.Color.LightYellow;
            this.menorQ_btn.Location = new System.Drawing.Point(6, 86);
            this.menorQ_btn.Name = "menorQ_btn";
            this.menorQ_btn.Size = new System.Drawing.Size(36, 27);
            this.menorQ_btn.TabIndex = 18;
            this.menorQ_btn.Text = "<";
            this.menorQ_btn.UseVisualStyleBackColor = false;
            this.menorQ_btn.Click += new System.EventHandler(this.menorQ_btn_Click);
            // 
            // maiorQ_btn
            // 
            this.maiorQ_btn.BackColor = System.Drawing.Color.LightYellow;
            this.maiorQ_btn.Location = new System.Drawing.Point(6, 53);
            this.maiorQ_btn.Name = "maiorQ_btn";
            this.maiorQ_btn.Size = new System.Drawing.Size(36, 27);
            this.maiorQ_btn.TabIndex = 19;
            this.maiorQ_btn.Text = ">";
            this.maiorQ_btn.UseVisualStyleBackColor = false;
            this.maiorQ_btn.Click += new System.EventHandler(this.maiorQ_btn_Click);
            // 
            // not_btn
            // 
            this.not_btn.BackColor = System.Drawing.Color.LightYellow;
            this.not_btn.Location = new System.Drawing.Point(91, 119);
            this.not_btn.Name = "not_btn";
            this.not_btn.Size = new System.Drawing.Size(36, 27);
            this.not_btn.TabIndex = 20;
            this.not_btn.Text = "Not";
            this.not_btn.UseVisualStyleBackColor = false;
            this.not_btn.Click += new System.EventHandler(this.not_btn_Click);
            // 
            // or_btn
            // 
            this.or_btn.BackColor = System.Drawing.Color.LightYellow;
            this.or_btn.Location = new System.Drawing.Point(91, 86);
            this.or_btn.Name = "or_btn";
            this.or_btn.Size = new System.Drawing.Size(36, 27);
            this.or_btn.TabIndex = 21;
            this.or_btn.Text = "Or";
            this.or_btn.UseVisualStyleBackColor = false;
            this.or_btn.Click += new System.EventHandler(this.or_btn_Click);
            // 
            // menorOuIqual_btn
            // 
            this.menorOuIqual_btn.BackColor = System.Drawing.Color.LightYellow;
            this.menorOuIqual_btn.Location = new System.Drawing.Point(48, 86);
            this.menorOuIqual_btn.Name = "menorOuIqual_btn";
            this.menorOuIqual_btn.Size = new System.Drawing.Size(36, 27);
            this.menorOuIqual_btn.TabIndex = 22;
            this.menorOuIqual_btn.Text = "< = ";
            this.menorOuIqual_btn.UseVisualStyleBackColor = false;
            this.menorOuIqual_btn.Click += new System.EventHandler(this.menorOuIqual_btn_Click);
            // 
            // maiorOuIqual_btn
            // 
            this.maiorOuIqual_btn.BackColor = System.Drawing.Color.LightYellow;
            this.maiorOuIqual_btn.Location = new System.Drawing.Point(48, 53);
            this.maiorOuIqual_btn.Name = "maiorOuIqual_btn";
            this.maiorOuIqual_btn.Size = new System.Drawing.Size(36, 27);
            this.maiorOuIqual_btn.TabIndex = 23;
            this.maiorOuIqual_btn.Text = "> = ";
            this.maiorOuIqual_btn.UseVisualStyleBackColor = false;
            this.maiorOuIqual_btn.Click += new System.EventHandler(this.maiorOuIqual_btn_Click);
            // 
            // porcentagem_btn
            // 
            this.porcentagem_btn.BackColor = System.Drawing.Color.LightYellow;
            this.porcentagem_btn.Location = new System.Drawing.Point(6, 119);
            this.porcentagem_btn.Name = "porcentagem_btn";
            this.porcentagem_btn.Size = new System.Drawing.Size(36, 27);
            this.porcentagem_btn.TabIndex = 24;
            this.porcentagem_btn.Text = "%";
            this.porcentagem_btn.UseVisualStyleBackColor = false;
            this.porcentagem_btn.Click += new System.EventHandler(this.porcentagem_btn_Click);
            // 
            // operadores_logicos_grpbox
            // 
            this.operadores_logicos_grpbox.Controls.Add(this.sum_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.iqual_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.porcentagem_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.and_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.maiorOuIqual_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.like_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.menorOuIqual_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.notIqual_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.or_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.menorQ_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.not_btn);
            this.operadores_logicos_grpbox.Controls.Add(this.maiorQ_btn);
            this.operadores_logicos_grpbox.Location = new System.Drawing.Point(198, 48);
            this.operadores_logicos_grpbox.Name = "operadores_logicos_grpbox";
            this.operadores_logicos_grpbox.Size = new System.Drawing.Size(133, 154);
            this.operadores_logicos_grpbox.TabIndex = 25;
            this.operadores_logicos_grpbox.TabStop = false;
            this.operadores_logicos_grpbox.Text = "Operadores";
            // 
            // sum_btn
            // 
            this.sum_btn.BackColor = System.Drawing.Color.LightYellow;
            this.sum_btn.Location = new System.Drawing.Point(48, 119);
            this.sum_btn.Name = "sum_btn";
            this.sum_btn.Size = new System.Drawing.Size(36, 27);
            this.sum_btn.TabIndex = 25;
            this.sum_btn.Text = "Sum";
            this.sum_btn.UseVisualStyleBackColor = false;
            this.sum_btn.Click += new System.EventHandler(this.sum_btn_Click);
            // 
            // stArea_btn
            // 
            this.stArea_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stArea_btn.Location = new System.Drawing.Point(6, 19);
            this.stArea_btn.Name = "stArea_btn";
            this.stArea_btn.Size = new System.Drawing.Size(89, 23);
            this.stArea_btn.TabIndex = 26;
            this.stArea_btn.Text = "ST_Area";
            this.stArea_btn.UseVisualStyleBackColor = false;
            this.stArea_btn.Click += new System.EventHandler(this.stArea_btn_Click);
            // 
            // stDistance_btn
            // 
            this.stDistance_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stDistance_btn.Location = new System.Drawing.Point(101, 77);
            this.stDistance_btn.Name = "stDistance_btn";
            this.stDistance_btn.Size = new System.Drawing.Size(89, 23);
            this.stDistance_btn.TabIndex = 27;
            this.stDistance_btn.Text = "ST_Distance";
            this.stDistance_btn.UseVisualStyleBackColor = false;
            this.stDistance_btn.Click += new System.EventHandler(this.stDistance_btn_Click);
            // 
            // stCentroid_btn
            // 
            this.stCentroid_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stCentroid_btn.Location = new System.Drawing.Point(6, 77);
            this.stCentroid_btn.Name = "stCentroid_btn";
            this.stCentroid_btn.Size = new System.Drawing.Size(89, 23);
            this.stCentroid_btn.TabIndex = 28;
            this.stCentroid_btn.Text = "ST_Centroid";
            this.stCentroid_btn.UseVisualStyleBackColor = false;
            this.stCentroid_btn.Click += new System.EventHandler(this.stCentroid_btn_Click);
            // 
            // stTransform_btn
            // 
            this.stTransform_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stTransform_btn.Location = new System.Drawing.Point(291, 48);
            this.stTransform_btn.Name = "stTransform_btn";
            this.stTransform_btn.Size = new System.Drawing.Size(89, 23);
            this.stTransform_btn.TabIndex = 29;
            this.stTransform_btn.Text = "ST_Transform";
            this.stTransform_btn.UseVisualStyleBackColor = false;
            this.stTransform_btn.Click += new System.EventHandler(this.stTransform_btn_Click);
            // 
            // stAsText_btn
            // 
            this.stAsText_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stAsText_btn.Location = new System.Drawing.Point(6, 48);
            this.stAsText_btn.Name = "stAsText_btn";
            this.stAsText_btn.Size = new System.Drawing.Size(89, 23);
            this.stAsText_btn.TabIndex = 30;
            this.stAsText_btn.Text = "ST_Astext";
            this.stAsText_btn.UseVisualStyleBackColor = false;
            this.stAsText_btn.Click += new System.EventHandler(this.stAsText_btn_Click);
            // 
            // stWithin_btn
            // 
            this.stWithin_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stWithin_btn.Location = new System.Drawing.Point(291, 77);
            this.stWithin_btn.Name = "stWithin_btn";
            this.stWithin_btn.Size = new System.Drawing.Size(89, 23);
            this.stWithin_btn.TabIndex = 31;
            this.stWithin_btn.Text = "ST_Within";
            this.stWithin_btn.UseVisualStyleBackColor = false;
            this.stWithin_btn.Click += new System.EventHandler(this.stWithin_btn_Click);
            // 
            // stCrosses_btn
            // 
            this.stCrosses_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stCrosses_btn.Location = new System.Drawing.Point(101, 48);
            this.stCrosses_btn.Name = "stCrosses_btn";
            this.stCrosses_btn.Size = new System.Drawing.Size(89, 23);
            this.stCrosses_btn.TabIndex = 32;
            this.stCrosses_btn.Text = "ST_Crosses";
            this.stCrosses_btn.UseVisualStyleBackColor = false;
            this.stCrosses_btn.Click += new System.EventHandler(this.stCrosses_btn_Click);
            // 
            // stContains_btn
            // 
            this.stContains_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stContains_btn.Location = new System.Drawing.Point(101, 19);
            this.stContains_btn.Name = "stContains_btn";
            this.stContains_btn.Size = new System.Drawing.Size(89, 23);
            this.stContains_btn.TabIndex = 33;
            this.stContains_btn.Text = "ST_Contains";
            this.stContains_btn.UseVisualStyleBackColor = false;
            this.stContains_btn.Click += new System.EventHandler(this.stContains_btn_Click);
            // 
            // stDwithin_btn
            // 
            this.stDwithin_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stDwithin_btn.Location = new System.Drawing.Point(196, 19);
            this.stDwithin_btn.Name = "stDwithin_btn";
            this.stDwithin_btn.Size = new System.Drawing.Size(89, 23);
            this.stDwithin_btn.TabIndex = 34;
            this.stDwithin_btn.Text = "ST_DWithin";
            this.stDwithin_btn.UseVisualStyleBackColor = false;
            this.stDwithin_btn.Click += new System.EventHandler(this.stDwithin_btn_Click);
            // 
            // stTouches_btn
            // 
            this.stTouches_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stTouches_btn.Location = new System.Drawing.Point(291, 19);
            this.stTouches_btn.Name = "stTouches_btn";
            this.stTouches_btn.Size = new System.Drawing.Size(89, 23);
            this.stTouches_btn.TabIndex = 35;
            this.stTouches_btn.Text = "ST_Touches";
            this.stTouches_btn.UseVisualStyleBackColor = false;
            this.stTouches_btn.Click += new System.EventHandler(this.stTouches_btn_Click);
            // 
            // stintersects_btn
            // 
            this.stintersects_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stintersects_btn.Location = new System.Drawing.Point(196, 48);
            this.stintersects_btn.Name = "stintersects_btn";
            this.stintersects_btn.Size = new System.Drawing.Size(89, 23);
            this.stintersects_btn.TabIndex = 36;
            this.stintersects_btn.Text = "ST_Intersects";
            this.stintersects_btn.UseVisualStyleBackColor = false;
            this.stintersects_btn.Click += new System.EventHandler(this.stintersects_btn_Click);
            // 
            // stLength_btn
            // 
            this.stLength_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.stLength_btn.Location = new System.Drawing.Point(196, 77);
            this.stLength_btn.Name = "stLength_btn";
            this.stLength_btn.Size = new System.Drawing.Size(89, 23);
            this.stLength_btn.TabIndex = 37;
            this.stLength_btn.Text = "ST_Length";
            this.stLength_btn.UseVisualStyleBackColor = false;
            this.stLength_btn.Click += new System.EventHandler(this.stLength_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stArea_btn);
            this.groupBox1.Controls.Add(this.stLength_btn);
            this.groupBox1.Controls.Add(this.stDistance_btn);
            this.groupBox1.Controls.Add(this.stintersects_btn);
            this.groupBox1.Controls.Add(this.stCentroid_btn);
            this.groupBox1.Controls.Add(this.stTouches_btn);
            this.groupBox1.Controls.Add(this.stTransform_btn);
            this.groupBox1.Controls.Add(this.stDwithin_btn);
            this.groupBox1.Controls.Add(this.stAsText_btn);
            this.groupBox1.Controls.Add(this.stContains_btn);
            this.groupBox1.Controls.Add(this.stWithin_btn);
            this.groupBox1.Controls.Add(this.stCrosses_btn);
            this.groupBox1.Location = new System.Drawing.Point(148, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 111);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funções de Operações Espaciais:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.select_btn);
            this.groupBox2.Location = new System.Drawing.Point(15, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 51);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operador de Seleção:";
            // 
            // buscar_btn
            // 
            this.buscar_btn.BackColor = System.Drawing.SystemColors.Control;
            this.buscar_btn.Location = new System.Drawing.Point(711, 112);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(75, 23);
            this.buscar_btn.TabIndex = 40;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = false;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 493);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 150);
            this.dataGridView1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Não sabe SQL? Siga esta ordem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSalmon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightYellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(278, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "+";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(318, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "+";
            // 
            // limpar_btn
            // 
            this.limpar_btn.BackColor = System.Drawing.SystemColors.Control;
            this.limpar_btn.Location = new System.Drawing.Point(630, 112);
            this.limpar_btn.Name = "limpar_btn";
            this.limpar_btn.Size = new System.Drawing.Size(75, 23);
            this.limpar_btn.TabIndex = 59;
            this.limpar_btn.Text = "Limpar";
            this.limpar_btn.UseVisualStyleBackColor = false;
            this.limpar_btn.Click += new System.EventHandler(this.limpar_btn_Click);
            // 
            // rows_listbox
            // 
            this.rows_listbox.FormattingEnabled = true;
            this.rows_listbox.Location = new System.Drawing.Point(337, 55);
            this.rows_listbox.Name = "rows_listbox";
            this.rows_listbox.Size = new System.Drawing.Size(183, 147);
            this.rows_listbox.TabIndex = 60;
            this.rows_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rows_listbox_MouseDoubleClick);
            // 
            // coluna_listbox
            // 
            this.coluna_listbox.FormattingEnabled = true;
            this.coluna_listbox.Location = new System.Drawing.Point(9, 55);
            this.coluna_listbox.Name = "coluna_listbox";
            this.coluna_listbox.Size = new System.Drawing.Size(183, 147);
            this.coluna_listbox.TabIndex = 61;
            this.coluna_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.coluna_listbox_MouseDoubleClick);
            // 
            // tables_cbx
            // 
            this.tables_cbx.FormattingEnabled = true;
            this.tables_cbx.Location = new System.Drawing.Point(87, 42);
            this.tables_cbx.Name = "tables_cbx";
            this.tables_cbx.Size = new System.Drawing.Size(141, 21);
            this.tables_cbx.TabIndex = 62;
            // 
            // getColunas_btn
            // 
            this.getColunas_btn.BackColor = System.Drawing.Color.LightYellow;
            this.getColunas_btn.Location = new System.Drawing.Point(76, 26);
            this.getColunas_btn.Name = "getColunas_btn";
            this.getColunas_btn.Size = new System.Drawing.Size(116, 23);
            this.getColunas_btn.TabIndex = 65;
            this.getColunas_btn.Text = "Obter Colunas";
            this.getColunas_btn.UseVisualStyleBackColor = false;
            this.getColunas_btn.Click += new System.EventHandler(this.getColunas_btn_Click);
            // 
            // getUniqueValues_btn
            // 
            this.getUniqueValues_btn.BackColor = System.Drawing.Color.LightYellow;
            this.getUniqueValues_btn.Location = new System.Drawing.Point(404, 26);
            this.getUniqueValues_btn.Name = "getUniqueValues_btn";
            this.getUniqueValues_btn.Size = new System.Drawing.Size(116, 23);
            this.getUniqueValues_btn.TabIndex = 64;
            this.getUniqueValues_btn.Text = "Obter Valores Únicos";
            this.getUniqueValues_btn.UseVisualStyleBackColor = false;
            this.getUniqueValues_btn.Click += new System.EventHandler(this.getUniqueValues_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Coluna:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Tabela:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.from_btn);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tables_cbx);
            this.groupBox3.Location = new System.Drawing.Point(546, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 94);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nome da Tabela:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(337, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "Linha:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.operadores_logicos_grpbox);
            this.groupBox4.Controls.Add(this.rows_listbox);
            this.groupBox4.Controls.Add(this.coluna_listbox);
            this.groupBox4.Controls.Add(this.getUniqueValues_btn);
            this.groupBox4.Controls.Add(this.getColunas_btn);
            this.groupBox4.Location = new System.Drawing.Point(119, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(554, 211);
            this.groupBox4.TabIndex = 68;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Condicionais: (Opcional)";
            // 
            // sqlQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 643);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.limpar_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.where_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sqlQuery_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "sqlQuery";
            this.Text = "Gerador de consultas SQL (PostNET)";
            this.operadores_logicos_grpbox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqlQuery_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button from_btn;
        private System.Windows.Forms.Button where_btn;
        private System.Windows.Forms.Button iqual_btn;
        private System.Windows.Forms.Button and_btn;
        private System.Windows.Forms.Button like_btn;
        private System.Windows.Forms.Button notIqual_btn;
        private System.Windows.Forms.Button menorQ_btn;
        private System.Windows.Forms.Button maiorQ_btn;
        private System.Windows.Forms.Button not_btn;
        private System.Windows.Forms.Button or_btn;
        private System.Windows.Forms.Button menorOuIqual_btn;
        private System.Windows.Forms.Button maiorOuIqual_btn;
        private System.Windows.Forms.Button porcentagem_btn;
        private System.Windows.Forms.GroupBox operadores_logicos_grpbox;
        private System.Windows.Forms.Button stArea_btn;
        private System.Windows.Forms.Button stDistance_btn;
        private System.Windows.Forms.Button stCentroid_btn;
        private System.Windows.Forms.Button stTransform_btn;
        private System.Windows.Forms.Button stAsText_btn;
        private System.Windows.Forms.Button stWithin_btn;
        private System.Windows.Forms.Button stCrosses_btn;
        private System.Windows.Forms.Button stContains_btn;
        private System.Windows.Forms.Button sum_btn;
        private System.Windows.Forms.Button stDwithin_btn;
        private System.Windows.Forms.Button stTouches_btn;
        private System.Windows.Forms.Button stintersects_btn;
        private System.Windows.Forms.Button stLength_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button limpar_btn;
        private System.Windows.Forms.ListBox rows_listbox;
        private System.Windows.Forms.ListBox coluna_listbox;
        private System.Windows.Forms.ComboBox tables_cbx;
        private System.Windows.Forms.Button getColunas_btn;
        private System.Windows.Forms.Button getUniqueValues_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}