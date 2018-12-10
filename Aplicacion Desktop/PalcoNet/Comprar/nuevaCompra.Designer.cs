partial class NuevaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaCompra));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.minimizingLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closingLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.listadoPublicaciones = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.righttight = new System.Windows.Forms.Button();
            this.leftleft = new System.Windows.Forms.Button();
            this.nPag = new System.Windows.Forms.Label();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rubro = new System.Windows.Forms.ComboBox();
            this.idPublicacionElegida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminarRubro = new System.Windows.Forms.Button();
            this.btn_agregarRubro = new System.Windows.Forms.Button();
            this.listadoRubros = new System.Windows.Forms.ListBox();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(200, 617);
            this.sidepanel.TabIndex = 0;
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
            this.topbar.Size = new System.Drawing.Size(1251, 49);
            this.topbar.TabIndex = 1;
            // 
            // minimizingLabel
            // 
            this.minimizingLabel.AutoSize = true;
            this.minimizingLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizingLabel.ForeColor = System.Drawing.Color.White;
            this.minimizingLabel.Location = new System.Drawing.Point(1181, 12);
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
            this.titleLabel.Size = new System.Drawing.Size(96, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Compra";
            // 
            // closingLabel
            // 
            this.closingLabel.AutoSize = true;
            this.closingLabel.BackColor = System.Drawing.Color.Transparent;
            this.closingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closingLabel.ForeColor = System.Drawing.Color.White;
            this.closingLabel.Location = new System.Drawing.Point(1213, 12);
            this.closingLabel.Name = "closingLabel";
            this.closingLabel.Size = new System.Drawing.Size(26, 25);
            this.closingLabel.TabIndex = 2;
            this.closingLabel.Text = "X";
            this.closingLabel.Click += new System.EventHandler(this.closingLabel_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(206, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(208, 21);
            this.label.TabIndex = 7;
            this.label.Text = "Parámetros de búsqueda";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BackColor = System.Drawing.Color.LightCyan;
            this.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccionar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.Location = new System.Drawing.Point(958, 279);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(481, 67);
            this.btn_seleccionar.TabIndex = 9;
            this.btn_seleccionar.Text = "Seleccionar publicación";
            this.btn_seleccionar.UseVisualStyleBackColor = false;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // listadoPublicaciones
            // 
            this.listadoPublicaciones.AllowUserToAddRows = false;
            this.listadoPublicaciones.AllowUserToDeleteRows = false;
            this.listadoPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoPublicaciones.Location = new System.Drawing.Point(210, 251);
            this.listadoPublicaciones.MultiSelect = false;
            this.listadoPublicaciones.Name = "listadoPublicaciones";
            this.listadoPublicaciones.ReadOnly = true;
            this.listadoPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoPublicaciones.Size = new System.Drawing.Size(742, 312);
            this.listadoPublicaciones.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(958, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(481, 67);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dar de baja";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(958, 206);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(481, 67);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar ";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(317, 180);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(317, 64);
            this.descripcion.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rubros disponibles";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightPink;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(958, 52);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(481, 67);
            this.btn_limpiar.TabIndex = 50;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.Location = new System.Drawing.Point(609, 569);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 48);
            this.right.TabIndex = 51;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.Location = new System.Drawing.Point(459, 569);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 48);
            this.left.TabIndex = 52;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            // 
            // righttight
            // 
            this.righttight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.righttight.Location = new System.Drawing.Point(877, 569);
            this.righttight.Name = "righttight";
            this.righttight.Size = new System.Drawing.Size(75, 48);
            this.righttight.TabIndex = 53;
            this.righttight.Text = ">>>";
            this.righttight.UseVisualStyleBackColor = true;
            // 
            // leftleft
            // 
            this.leftleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftleft.Location = new System.Drawing.Point(210, 569);
            this.leftleft.Name = "leftleft";
            this.leftleft.Size = new System.Drawing.Size(75, 48);
            this.leftleft.TabIndex = 54;
            this.leftleft.Text = "<<<";
            this.leftleft.UseVisualStyleBackColor = true;
            // 
            // nPag
            // 
            this.nPag.AutoSize = true;
            this.nPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPag.Location = new System.Drawing.Point(560, 580);
            this.nPag.Name = "nPag";
            this.nPag.Size = new System.Drawing.Size(26, 25);
            this.nPag.TabIndex = 55;
            this.nPag.Text = "--";
            // 
            // fechaFin
            // 
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin.Location = new System.Drawing.Point(741, 222);
            this.fechaFin.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.fechaFin.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(211, 20);
            this.fechaFin.TabIndex = 56;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(752, 196);
            this.fechaInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.fechaInicio.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(200, 20);
            this.fechaInicio.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Fecha inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha final";
            // 
            // rubro
            // 
            this.rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(380, 116);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(154, 21);
            this.rubro.TabIndex = 60;
            // 
            // idPublicacionElegida
            // 
            this.idPublicacionElegida.AutoSize = true;
            this.idPublicacionElegida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPublicacionElegida.Location = new System.Drawing.Point(933, 168);
            this.idPublicacionElegida.Name = "idPublicacionElegida";
            this.idPublicacionElegida.Size = new System.Drawing.Size(19, 25);
            this.idPublicacionElegida.TabIndex = 61;
            this.idPublicacionElegida.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "ID publicación elegida";
            // 
            // btn_eliminarRubro
            // 
            this.btn_eliminarRubro.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_eliminarRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarRubro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarRubro.Location = new System.Drawing.Point(380, 140);
            this.btn_eliminarRubro.Name = "btn_eliminarRubro";
            this.btn_eliminarRubro.Size = new System.Drawing.Size(154, 30);
            this.btn_eliminarRubro.TabIndex = 83;
            this.btn_eliminarRubro.Text = "Eliminar rubro elegido";
            this.btn_eliminarRubro.UseVisualStyleBackColor = false;
            this.btn_eliminarRubro.Click += new System.EventHandler(this.btn_eliminarRubro_Click);
            // 
            // btn_agregarRubro
            // 
            this.btn_agregarRubro.BackColor = System.Drawing.Color.Gold;
            this.btn_agregarRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarRubro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarRubro.Location = new System.Drawing.Point(206, 140);
            this.btn_agregarRubro.Name = "btn_agregarRubro";
            this.btn_agregarRubro.Size = new System.Drawing.Size(168, 30);
            this.btn_agregarRubro.TabIndex = 82;
            this.btn_agregarRubro.Text = "Agregar rubro";
            this.btn_agregarRubro.UseVisualStyleBackColor = false;
            this.btn_agregarRubro.Click += new System.EventHandler(this.btn_agregarRubro_Click);
            // 
            // listadoRubros
            // 
            this.listadoRubros.FormattingEnabled = true;
            this.listadoRubros.Location = new System.Drawing.Point(540, 74);
            this.listadoRubros.Name = "listadoRubros";
            this.listadoRubros.Size = new System.Drawing.Size(412, 95);
            this.listadoRubros.TabIndex = 84;
            // 
            // NuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1451, 617);
            this.ControlBox = false;
            this.Controls.Add(this.listadoRubros);
            this.Controls.Add(this.btn_eliminarRubro);
            this.Controls.Add(this.btn_agregarRubro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idPublicacionElegida);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.nPag);
            this.Controls.Add(this.leftleft);
            this.Controls.Add(this.righttight);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listadoPublicaciones);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaCompra";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.NuevaCompra_Load);
            this.sidepanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).EndInit();
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
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.DataGridView listadoPublicaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button righttight;
        private System.Windows.Forms.Button leftleft;
        private System.Windows.Forms.Label nPag;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rubro;
        private System.Windows.Forms.Label idPublicacionElegida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminarRubro;
        private System.Windows.Forms.Button btn_agregarRubro;
        private System.Windows.Forms.ListBox listadoRubros;

    }