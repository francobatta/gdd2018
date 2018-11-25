    partial class ListadoEstadistico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEstadistico));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.minimizingLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closingLabel = new System.Windows.Forms.Label();
            this.Combobox_listado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listado_estadistico = new System.Windows.Forms.DataGridView();
            this.primerTrimestre = new System.Windows.Forms.RadioButton();
            this.segundoTrimestre = new System.Windows.Forms.RadioButton();
            this.tercerTrimestre = new System.Windows.Forms.RadioButton();
            this.cuartoTrimestre = new System.Windows.Forms.RadioButton();
            this.comboAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_listado = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listado_estadistico)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidepanel.Controls.Add(this.label17);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(200, 400);
            this.sidepanel.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 56);
            this.label17.MaximumSize = new System.Drawing.Size(190, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 51);
            this.label17.TabIndex = 52;
            this.label17.Text = "Usted puede ver los distintos tipos de listados en esta pantalla";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(146)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 49);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(162, 24);
            this.title.TabIndex = 2;
            this.title.Text = "PalcoNet FRBA";
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.topbar.Controls.Add(this.minimizingLabel);
            this.topbar.Controls.Add(this.titleLabel);
            this.topbar.Controls.Add(this.closingLabel);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(200, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(945, 49);
            this.topbar.TabIndex = 1;
            // 
            // minimizingLabel
            // 
            this.minimizingLabel.AutoSize = true;
            this.minimizingLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizingLabel.ForeColor = System.Drawing.Color.White;
            this.minimizingLabel.Location = new System.Drawing.Point(868, 9);
            this.minimizingLabel.Name = "minimizingLabel";
            this.minimizingLabel.Size = new System.Drawing.Size(34, 25);
            this.minimizingLabel.TabIndex = 4;
            this.minimizingLabel.Text = "__";
            this.minimizingLabel.Click += new System.EventHandler(this.minimizingLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(6, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(189, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Listado Estadistico";
            // 
            // closingLabel
            // 
            this.closingLabel.AutoSize = true;
            this.closingLabel.BackColor = System.Drawing.Color.Transparent;
            this.closingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closingLabel.ForeColor = System.Drawing.Color.White;
            this.closingLabel.Location = new System.Drawing.Point(905, 9);
            this.closingLabel.Name = "closingLabel";
            this.closingLabel.Size = new System.Drawing.Size(26, 25);
            this.closingLabel.TabIndex = 2;
            this.closingLabel.Text = "X";
            this.closingLabel.Click += new System.EventHandler(this.closingLabel_Click);
            // 
            // Combobox_listado
            // 
            this.Combobox_listado.FormattingEnabled = true;
            this.Combobox_listado.Location = new System.Drawing.Point(210, 86);
            this.Combobox_listado.Name = "Combobox_listado";
            this.Combobox_listado.Size = new System.Drawing.Size(318, 21);
            this.Combobox_listado.TabIndex = 15;
            this.Combobox_listado.SelectedIndexChanged += new System.EventHandler(this.Combobox_listado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(206, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Elija el tipo de listado estadistico";
            // 
            // listado_estadistico
            // 
            this.listado_estadistico.AllowUserToAddRows = false;
            this.listado_estadistico.AllowUserToDeleteRows = false;
            this.listado_estadistico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listado_estadistico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listado_estadistico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado_estadistico.Location = new System.Drawing.Point(210, 126);
            this.listado_estadistico.MultiSelect = false;
            this.listado_estadistico.Name = "listado_estadistico";
            this.listado_estadistico.ReadOnly = true;
            this.listado_estadistico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listado_estadistico.Size = new System.Drawing.Size(921, 127);
            this.listado_estadistico.TabIndex = 17;
            // 
            // primerTrimestre
            // 
            this.primerTrimestre.AutoSize = true;
            this.primerTrimestre.Enabled = false;
            this.primerTrimestre.Location = new System.Drawing.Point(685, 86);
            this.primerTrimestre.Name = "primerTrimestre";
            this.primerTrimestre.Size = new System.Drawing.Size(100, 17);
            this.primerTrimestre.TabIndex = 18;
            this.primerTrimestre.TabStop = true;
            this.primerTrimestre.Text = "Primer Trimestre";
            this.primerTrimestre.UseVisualStyleBackColor = true;
            this.primerTrimestre.CheckedChanged += new System.EventHandler(this.primerTrimestre_CheckedChanged);
            // 
            // segundoTrimestre
            // 
            this.segundoTrimestre.AutoSize = true;
            this.segundoTrimestre.Enabled = false;
            this.segundoTrimestre.Location = new System.Drawing.Point(790, 86);
            this.segundoTrimestre.Name = "segundoTrimestre";
            this.segundoTrimestre.Size = new System.Drawing.Size(114, 17);
            this.segundoTrimestre.TabIndex = 19;
            this.segundoTrimestre.TabStop = true;
            this.segundoTrimestre.Text = "Segundo Trimestre";
            this.segundoTrimestre.UseVisualStyleBackColor = true;
            this.segundoTrimestre.CheckedChanged += new System.EventHandler(this.segundoTrimestre_CheckedChanged);
            // 
            // tercerTrimestre
            // 
            this.tercerTrimestre.AutoSize = true;
            this.tercerTrimestre.Enabled = false;
            this.tercerTrimestre.Location = new System.Drawing.Point(910, 86);
            this.tercerTrimestre.Name = "tercerTrimestre";
            this.tercerTrimestre.Size = new System.Drawing.Size(102, 17);
            this.tercerTrimestre.TabIndex = 20;
            this.tercerTrimestre.TabStop = true;
            this.tercerTrimestre.Text = "Tercer Trimestre";
            this.tercerTrimestre.UseVisualStyleBackColor = true;
            this.tercerTrimestre.CheckedChanged += new System.EventHandler(this.tercerTrimestre_CheckedChanged);
            // 
            // cuartoTrimestre
            // 
            this.cuartoTrimestre.AutoSize = true;
            this.cuartoTrimestre.Enabled = false;
            this.cuartoTrimestre.Location = new System.Drawing.Point(1018, 86);
            this.cuartoTrimestre.Name = "cuartoTrimestre";
            this.cuartoTrimestre.Size = new System.Drawing.Size(102, 17);
            this.cuartoTrimestre.TabIndex = 21;
            this.cuartoTrimestre.TabStop = true;
            this.cuartoTrimestre.Text = "Cuarto Trimestre";
            this.cuartoTrimestre.UseVisualStyleBackColor = true;
            this.cuartoTrimestre.CheckedChanged += new System.EventHandler(this.cuartoTrimestre_CheckedChanged);
            // 
            // comboAnio
            // 
            this.comboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnio.Enabled = false;
            this.comboAnio.FormattingEnabled = true;
            this.comboAnio.Location = new System.Drawing.Point(605, 85);
            this.comboAnio.Name = "comboAnio";
            this.comboAnio.Size = new System.Drawing.Size(74, 21);
            this.comboAnio.TabIndex = 22;
            this.comboAnio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(564, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Año:";
            // 
            // btn_listado
            // 
            this.btn_listado.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_listado.Enabled = false;
            this.btn_listado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listado.Location = new System.Drawing.Point(650, 289);
            this.btn_listado.Name = "btn_listado";
            this.btn_listado.Size = new System.Drawing.Size(481, 67);
            this.btn_listado.TabIndex = 49;
            this.btn_listado.Text = "Obtener listado!";
            this.btn_listado.UseVisualStyleBackColor = false;
            this.btn_listado.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1145, 400);
            this.ControlBox = false;
            this.Controls.Add(this.btn_listado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAnio);
            this.Controls.Add(this.cuartoTrimestre);
            this.Controls.Add(this.tercerTrimestre);
            this.Controls.Add(this.segundoTrimestre);
            this.Controls.Add(this.primerTrimestre);
            this.Controls.Add(this.listado_estadistico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Combobox_listado);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoEstadistico";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listado_estadistico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closingLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label minimizingLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox Combobox_listado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listado_estadistico;
        private System.Windows.Forms.RadioButton primerTrimestre;
        private System.Windows.Forms.RadioButton segundoTrimestre;
        private System.Windows.Forms.RadioButton tercerTrimestre;
        private System.Windows.Forms.RadioButton cuartoTrimestre;
        private System.Windows.Forms.ComboBox comboAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_listado;

    }