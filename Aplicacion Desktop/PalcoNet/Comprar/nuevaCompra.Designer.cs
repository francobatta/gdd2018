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
            this.comprar_seleccionadas = new System.Windows.Forms.Button();
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
            this.listaUbicaciones = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listaUbicacionesAComprar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_agregarUbicacion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.importeTotal = new System.Windows.Forms.Label();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUbicacionesAComprar)).BeginInit();
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
            this.sidepanel.Size = new System.Drawing.Size(200, 742);
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
            this.btn_seleccionar.Location = new System.Drawing.Point(957, 236);
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
            this.listadoPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoPublicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listadoPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoPublicaciones.Location = new System.Drawing.Point(210, 236);
            this.listadoPublicaciones.MultiSelect = false;
            this.listadoPublicaciones.Name = "listadoPublicaciones";
            this.listadoPublicaciones.ReadOnly = true;
            this.listadoPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoPublicaciones.Size = new System.Drawing.Size(742, 226);
            this.listadoPublicaciones.TabIndex = 10;
            // 
            // comprar_seleccionadas
            // 
            this.comprar_seleccionadas.BackColor = System.Drawing.Color.LightPink;
            this.comprar_seleccionadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprar_seleccionadas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprar_seleccionadas.Location = new System.Drawing.Point(957, 663);
            this.comprar_seleccionadas.Name = "comprar_seleccionadas";
            this.comprar_seleccionadas.Size = new System.Drawing.Size(481, 67);
            this.comprar_seleccionadas.TabIndex = 11;
            this.comprar_seleccionadas.Text = "Comprar ubicaciones seleccionadas";
            this.comprar_seleccionadas.UseVisualStyleBackColor = false;
            this.comprar_seleccionadas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(957, 163);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(481, 67);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar publicaciones";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(316, 145);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(317, 64);
            this.descripcion.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 75);
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
            this.btn_limpiar.Location = new System.Drawing.Point(958, 62);
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
            this.right.Location = new System.Drawing.Point(609, 468);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 48);
            this.right.TabIndex = 51;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.Location = new System.Drawing.Point(459, 468);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 48);
            this.left.TabIndex = 52;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // righttight
            // 
            this.righttight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.righttight.Location = new System.Drawing.Point(877, 468);
            this.righttight.Name = "righttight";
            this.righttight.Size = new System.Drawing.Size(75, 48);
            this.righttight.TabIndex = 53;
            this.righttight.Text = ">>>";
            this.righttight.UseVisualStyleBackColor = true;
            this.righttight.Click += new System.EventHandler(this.righttight_Click);
            // 
            // leftleft
            // 
            this.leftleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftleft.Location = new System.Drawing.Point(210, 468);
            this.leftleft.Name = "leftleft";
            this.leftleft.Size = new System.Drawing.Size(75, 48);
            this.leftleft.TabIndex = 54;
            this.leftleft.Text = "<<<";
            this.leftleft.UseVisualStyleBackColor = true;
            this.leftleft.Click += new System.EventHandler(this.leftleft_Click);
            // 
            // nPag
            // 
            this.nPag.AutoSize = true;
            this.nPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPag.Location = new System.Drawing.Point(560, 479);
            this.nPag.Name = "nPag";
            this.nPag.Size = new System.Drawing.Size(26, 25);
            this.nPag.TabIndex = 55;
            this.nPag.Text = "--";
            // 
            // fechaFin
            // 
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin.Location = new System.Drawing.Point(740, 187);
            this.fechaFin.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.fechaFin.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(211, 20);
            this.fechaFin.TabIndex = 56;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(751, 161);
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
            this.label3.Location = new System.Drawing.Point(639, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Fecha inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(639, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha final";
            // 
            // rubro
            // 
            this.rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(380, 75);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(154, 21);
            this.rubro.TabIndex = 60;
            // 
            // idPublicacionElegida
            // 
            this.idPublicacionElegida.AutoSize = true;
            this.idPublicacionElegida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPublicacionElegida.Location = new System.Drawing.Point(932, 133);
            this.idPublicacionElegida.Name = "idPublicacionElegida";
            this.idPublicacionElegida.Size = new System.Drawing.Size(19, 25);
            this.idPublicacionElegida.TabIndex = 61;
            this.idPublicacionElegida.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(747, 137);
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
            this.btn_eliminarRubro.Location = new System.Drawing.Point(380, 99);
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
            this.btn_agregarRubro.Location = new System.Drawing.Point(206, 99);
            this.btn_agregarRubro.Name = "btn_agregarRubro";
            this.btn_agregarRubro.Size = new System.Drawing.Size(168, 30);
            this.btn_agregarRubro.TabIndex = 82;
            this.btn_agregarRubro.Text = "Agregar rubro";
            this.btn_agregarRubro.UseVisualStyleBackColor = false;
            this.btn_agregarRubro.Click += new System.EventHandler(this.btn_agregarRubro_Click);
            // 
            // listadoRubros
            // 
            this.listadoRubros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listadoRubros.FormattingEnabled = true;
            this.listadoRubros.Location = new System.Drawing.Point(540, 61);
            this.listadoRubros.Name = "listadoRubros";
            this.listadoRubros.Size = new System.Drawing.Size(412, 69);
            this.listadoRubros.TabIndex = 84;
            // 
            // listaUbicaciones
            // 
            this.listaUbicaciones.AllowUserToAddRows = false;
            this.listaUbicaciones.AllowUserToDeleteRows = false;
            this.listaUbicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaUbicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.listaUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUbicaciones.Location = new System.Drawing.Point(210, 548);
            this.listaUbicaciones.MultiSelect = false;
            this.listaUbicaciones.Name = "listaUbicaciones";
            this.listaUbicaciones.ReadOnly = true;
            this.listaUbicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUbicaciones.Size = new System.Drawing.Size(741, 155);
            this.listaUbicaciones.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 21);
            this.label6.TabIndex = 86;
            this.label6.Text = "Listado de publicaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(435, 21);
            this.label7.TabIndex = 87;
            this.label7.Text = "Listado de ubicaciones para publicación seleccionada";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(479, 709);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(472, 20);
            this.email.TabIndex = 88;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 52);
            this.label17.MaximumSize = new System.Drawing.Size(190, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 136);
            this.label17.TabIndex = 51;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 709);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 21);
            this.label8.TabIndex = 89;
            this.label8.Text = "Mail del comprador para factura";
            // 
            // listaUbicacionesAComprar
            // 
            this.listaUbicacionesAComprar.AllowUserToAddRows = false;
            this.listaUbicacionesAComprar.AllowUserToDeleteRows = false;
            this.listaUbicacionesAComprar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaUbicacionesAComprar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.listaUbicacionesAComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUbicacionesAComprar.Location = new System.Drawing.Point(958, 390);
            this.listaUbicacionesAComprar.MultiSelect = false;
            this.listaUbicacionesAComprar.Name = "listaUbicacionesAComprar";
            this.listaUbicacionesAComprar.ReadOnly = true;
            this.listaUbicacionesAComprar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUbicacionesAComprar.Size = new System.Drawing.Size(480, 155);
            this.listaUbicacionesAComprar.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1284, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 62);
            this.button1.TabIndex = 92;
            this.button1.Text = "Eliminar ubicación elegida";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_agregarUbicacion
            // 
            this.btn_agregarUbicacion.BackColor = System.Drawing.Color.Gold;
            this.btn_agregarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarUbicacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarUbicacion.Location = new System.Drawing.Point(959, 551);
            this.btn_agregarUbicacion.Name = "btn_agregarUbicacion";
            this.btn_agregarUbicacion.Size = new System.Drawing.Size(319, 64);
            this.btn_agregarUbicacion.TabIndex = 91;
            this.btn_agregarUbicacion.Text = "Agregar ubicación";
            this.btn_agregarUbicacion.UseVisualStyleBackColor = false;
            this.btn_agregarUbicacion.Click += new System.EventHandler(this.btn_agregarUbicacion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(954, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 21);
            this.label9.TabIndex = 93;
            this.label9.Text = "Listado de ubicaciones a comprar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(957, 618);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 21);
            this.label10.TabIndex = 94;
            this.label10.Text = "Importe total ($):";
            // 
            // importeTotal
            // 
            this.importeTotal.AutoSize = true;
            this.importeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTotal.Location = new System.Drawing.Point(1107, 618);
            this.importeTotal.Name = "importeTotal";
            this.importeTotal.Size = new System.Drawing.Size(19, 25);
            this.importeTotal.TabIndex = 95;
            this.importeTotal.Text = "-";
            // 
            // NuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1451, 742);
            this.ControlBox = false;
            this.Controls.Add(this.importeTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregarUbicacion);
            this.Controls.Add(this.listaUbicacionesAComprar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listaUbicaciones);
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
            this.Controls.Add(this.comprar_seleccionadas);
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
            this.sidepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUbicacionesAComprar)).EndInit();
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
        private System.Windows.Forms.Button comprar_seleccionadas;
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
        private System.Windows.Forms.DataGridView listaUbicaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView listaUbicacionesAComprar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_agregarUbicacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label importeTotal;

    }