﻿    partial class AltaPublicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaPublicacion));
            this.topbar = new System.Windows.Forms.Panel();
            this.minimizingLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaEspectaculo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.calle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.piso = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.depto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cpostal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.listaFechasEspectaculo = new System.Windows.Forms.ListBox();
            this.btn_agregarFechaEspectaculo = new System.Windows.Forms.Button();
            this.btn_eliminarFechaSeleccionada = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.rubro = new System.Windows.Forms.ComboBox();
            this.grado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.filaUbicacion = new System.Windows.Forms.TextBox();
            this.asientoUbicacion = new System.Windows.Forms.TextBox();
            this.precioUbicacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tipoUbicacion = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_agregarUbicacion = new System.Windows.Forms.Button();
            this.btn_eliminarUbicacionSeleccionada = new System.Windows.Forms.Button();
            this.nroCalle = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.listaUbicaciones = new System.Windows.Forms.DataGridView();
            this.topbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaUbicaciones)).BeginInit();
            this.SuspendLayout();
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
            this.titleLabel.Size = new System.Drawing.Size(212, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Alta de publicación";
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
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidepanel.Controls.Add(this.label17);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(200, 646);
            this.sidepanel.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 55);
            this.label17.MaximumSize = new System.Drawing.Size(190, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 153);
            this.label17.TabIndex = 50;
            this.label17.Text = "A través de la funcionalidad Fechas de espectáculo, el usuario puede generar publ" +
    "icaciones cuya fecha de espectáculo aumente en forma incremental. Las mismas se " +
    "insertarán en forma de lote.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(210, 103);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(336, 44);
            this.descripcion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ubicaciones";
            // 
            // fechaEspectaculo
            // 
            this.fechaEspectaculo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaEspectaculo.Location = new System.Drawing.Point(608, 138);
            this.fechaEspectaculo.MaxDate = new System.DateTime(2100, 12, 18, 0, 0, 0, 0);
            this.fechaEspectaculo.MinDate = new System.DateTime(1990, 12, 3, 0, 0, 0, 0);
            this.fechaEspectaculo.Name = "fechaEspectaculo";
            this.fechaEspectaculo.Size = new System.Drawing.Size(344, 20);
            this.fechaEspectaculo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(604, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha de espectáculo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(206, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Datos de publicación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(206, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Rubro";
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(299, 479);
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(119, 20);
            this.calle.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(206, 478);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Calle";
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(299, 505);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(247, 20);
            this.piso.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(206, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "N° piso";
            // 
            // depto
            // 
            this.depto.Location = new System.Drawing.Point(299, 531);
            this.depto.Name = "depto";
            this.depto.Size = new System.Drawing.Size(247, 20);
            this.depto.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(206, 530);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 21);
            this.label14.TabIndex = 29;
            this.label14.Text = "Depto.";
            // 
            // cpostal
            // 
            this.cpostal.Location = new System.Drawing.Point(299, 557);
            this.cpostal.Name = "cpostal";
            this.cpostal.Size = new System.Drawing.Size(247, 20);
            this.cpostal.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(206, 556);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "C. postal";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightPink;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(958, 55);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(481, 67);
            this.btn_limpiar.TabIndex = 49;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(958, 564);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(481, 67);
            this.btn_guardar.TabIndex = 48;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // listaFechasEspectaculo
            // 
            this.listaFechasEspectaculo.FormattingEnabled = true;
            this.listaFechasEspectaculo.Location = new System.Drawing.Point(608, 237);
            this.listaFechasEspectaculo.Name = "listaFechasEspectaculo";
            this.listaFechasEspectaculo.Size = new System.Drawing.Size(344, 394);
            this.listaFechasEspectaculo.TabIndex = 50;
            // 
            // btn_agregarFechaEspectaculo
            // 
            this.btn_agregarFechaEspectaculo.BackColor = System.Drawing.Color.Gold;
            this.btn_agregarFechaEspectaculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarFechaEspectaculo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarFechaEspectaculo.Location = new System.Drawing.Point(608, 164);
            this.btn_agregarFechaEspectaculo.Name = "btn_agregarFechaEspectaculo";
            this.btn_agregarFechaEspectaculo.Size = new System.Drawing.Size(168, 67);
            this.btn_agregarFechaEspectaculo.TabIndex = 51;
            this.btn_agregarFechaEspectaculo.Text = "Agregar Fecha";
            this.btn_agregarFechaEspectaculo.UseVisualStyleBackColor = false;
            this.btn_agregarFechaEspectaculo.Click += new System.EventHandler(this.btn_agregarFechaEspectaculo_Click);
            // 
            // btn_eliminarFechaSeleccionada
            // 
            this.btn_eliminarFechaSeleccionada.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_eliminarFechaSeleccionada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarFechaSeleccionada.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarFechaSeleccionada.Location = new System.Drawing.Point(784, 164);
            this.btn_eliminarFechaSeleccionada.Name = "btn_eliminarFechaSeleccionada";
            this.btn_eliminarFechaSeleccionada.Size = new System.Drawing.Size(168, 67);
            this.btn_eliminarFechaSeleccionada.TabIndex = 52;
            this.btn_eliminarFechaSeleccionada.Text = "Eliminar Fecha elegida";
            this.btn_eliminarFechaSeleccionada.UseVisualStyleBackColor = false;
            this.btn_eliminarFechaSeleccionada.Click += new System.EventHandler(this.btn_eliminarFechaSeleccionada_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(552, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Fechas de espectáculo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 21);
            this.label10.TabIndex = 55;
            this.label10.Text = "Fecha de publicación";
            // 
            // fechaPublicacion
            // 
            this.fechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPublicacion.Location = new System.Drawing.Point(394, 363);
            this.fechaPublicacion.MaxDate = new System.DateTime(2109, 7, 5, 0, 0, 0, 0);
            this.fechaPublicacion.MinDate = new System.DateTime(1900, 2, 7, 0, 0, 0, 0);
            this.fechaPublicacion.Name = "fechaPublicacion";
            this.fechaPublicacion.Size = new System.Drawing.Size(152, 20);
            this.fechaPublicacion.TabIndex = 54;
            this.fechaPublicacion.Value = new System.DateTime(2018, 11, 25, 0, 0, 0, 0);
            // 
            // rubro
            // 
            this.rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(299, 389);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(247, 21);
            this.rubro.TabIndex = 56;
            // 
            // grado
            // 
            this.grado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grado.FormattingEnabled = true;
            this.grado.Location = new System.Drawing.Point(299, 583);
            this.grado.Name = "grado";
            this.grado.Size = new System.Drawing.Size(247, 21);
            this.grado.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Grado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "Estado";
            // 
            // estado
            // 
            this.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado.FormattingEnabled = true;
            this.estado.Location = new System.Drawing.Point(299, 613);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(247, 21);
            this.estado.TabIndex = 62;
            // 
            // filaUbicacion
            // 
            this.filaUbicacion.Location = new System.Drawing.Point(210, 199);
            this.filaUbicacion.Name = "filaUbicacion";
            this.filaUbicacion.Size = new System.Drawing.Size(46, 20);
            this.filaUbicacion.TabIndex = 64;
            // 
            // asientoUbicacion
            // 
            this.asientoUbicacion.Location = new System.Drawing.Point(262, 199);
            this.asientoUbicacion.Name = "asientoUbicacion";
            this.asientoUbicacion.Size = new System.Drawing.Size(53, 20);
            this.asientoUbicacion.TabIndex = 65;
            // 
            // precioUbicacion
            // 
            this.precioUbicacion.Location = new System.Drawing.Point(321, 198);
            this.precioUbicacion.Name = "precioUbicacion";
            this.precioUbicacion.Size = new System.Drawing.Size(96, 20);
            this.precioUbicacion.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Fila";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(259, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 69;
            this.label16.Text = "Asiento";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(318, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 70;
            this.label18.Text = "Precio";
            // 
            // tipoUbicacion
            // 
            this.tipoUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUbicacion.FormattingEnabled = true;
            this.tipoUbicacion.Location = new System.Drawing.Point(423, 198);
            this.tipoUbicacion.Name = "tipoUbicacion";
            this.tipoUbicacion.Size = new System.Drawing.Size(123, 21);
            this.tipoUbicacion.TabIndex = 71;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(420, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 16);
            this.label19.TabIndex = 72;
            this.label19.Text = "Tipo";
            // 
            // btn_agregarUbicacion
            // 
            this.btn_agregarUbicacion.BackColor = System.Drawing.Color.Gold;
            this.btn_agregarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarUbicacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarUbicacion.Location = new System.Drawing.Point(210, 226);
            this.btn_agregarUbicacion.Name = "btn_agregarUbicacion";
            this.btn_agregarUbicacion.Size = new System.Drawing.Size(168, 30);
            this.btn_agregarUbicacion.TabIndex = 73;
            this.btn_agregarUbicacion.Text = "Agregar Ubicación";
            this.btn_agregarUbicacion.UseVisualStyleBackColor = false;
            this.btn_agregarUbicacion.Click += new System.EventHandler(this.btn_agregarUbicacion_Click);
            // 
            // btn_eliminarUbicacionSeleccionada
            // 
            this.btn_eliminarUbicacionSeleccionada.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_eliminarUbicacionSeleccionada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarUbicacionSeleccionada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarUbicacionSeleccionada.Location = new System.Drawing.Point(384, 226);
            this.btn_eliminarUbicacionSeleccionada.Name = "btn_eliminarUbicacionSeleccionada";
            this.btn_eliminarUbicacionSeleccionada.Size = new System.Drawing.Size(162, 30);
            this.btn_eliminarUbicacionSeleccionada.TabIndex = 74;
            this.btn_eliminarUbicacionSeleccionada.Text = "Eliminar Ubicación elegida";
            this.btn_eliminarUbicacionSeleccionada.UseVisualStyleBackColor = false;
            this.btn_eliminarUbicacionSeleccionada.Click += new System.EventHandler(this.btn_eliminarUbicacionSeleccionada_Click);
            // 
            // nroCalle
            // 
            this.nroCalle.Location = new System.Drawing.Point(449, 478);
            this.nroCalle.MaxLength = 50;
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.Size = new System.Drawing.Size(97, 20);
            this.nroCalle.TabIndex = 76;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(421, 477);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 21);
            this.label23.TabIndex = 75;
            this.label23.Text = "N";
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(299, 446);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(247, 20);
            this.ciudad.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 79;
            this.label5.Text = "Ciudad";
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(299, 420);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(247, 20);
            this.localidad.TabIndex = 78;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(206, 419);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 21);
            this.label20.TabIndex = 77;
            this.label20.Text = "Localidad";
            // 
            // listaUbicaciones
            // 
            this.listaUbicaciones.AllowUserToAddRows = false;
            this.listaUbicaciones.AllowUserToDeleteRows = false;
            this.listaUbicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaUbicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.listaUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUbicaciones.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listaUbicaciones.Location = new System.Drawing.Point(210, 262);
            this.listaUbicaciones.MultiSelect = false;
            this.listaUbicaciones.Name = "listaUbicaciones";
            this.listaUbicaciones.ReadOnly = true;
            this.listaUbicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUbicaciones.Size = new System.Drawing.Size(336, 95);
            this.listaUbicaciones.TabIndex = 81;
            // 
            // AltaPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1451, 646);
            this.ControlBox = false;
            this.Controls.Add(this.listaUbicaciones);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.nroCalle);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btn_eliminarUbicacionSeleccionada);
            this.Controls.Add(this.btn_agregarUbicacion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tipoUbicacion);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.precioUbicacion);
            this.Controls.Add(this.asientoUbicacion);
            this.Controls.Add(this.filaUbicacion);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fechaPublicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_eliminarFechaSeleccionada);
            this.Controls.Add(this.btn_agregarFechaEspectaculo);
            this.Controls.Add(this.listaFechasEspectaculo);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cpostal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.depto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.calle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fechaEspectaculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaPublicacion";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.AltaPublicacion_Load);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaUbicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label closingLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label minimizingLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaEspectaculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox depto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cpostal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox listaFechasEspectaculo;
        private System.Windows.Forms.Button btn_agregarFechaEspectaculo;
        private System.Windows.Forms.Button btn_eliminarFechaSeleccionada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fechaPublicacion;
        private System.Windows.Forms.ComboBox rubro;
        private System.Windows.Forms.ComboBox grado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.TextBox filaUbicacion;
        private System.Windows.Forms.TextBox asientoUbicacion;
        private System.Windows.Forms.TextBox precioUbicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox tipoUbicacion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_agregarUbicacion;
        private System.Windows.Forms.Button btn_eliminarUbicacionSeleccionada;
        private System.Windows.Forms.TextBox nroCalle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView listaUbicaciones;

    }