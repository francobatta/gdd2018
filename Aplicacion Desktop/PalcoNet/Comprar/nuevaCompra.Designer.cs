partial class nuevaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevaCompra));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.minimizingLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closingLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ListaEsp = new System.Windows.Forms.DataGridView();
            this.ListaUbi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tipoUbi = new System.Windows.Forms.ComboBox();
            this.agregarTipo = new System.Windows.Forms.Button();
            this.eliminarTipo = new System.Windows.Forms.Button();
            this.ListaCat = new System.Windows.Forms.ListBox();
            this.Descripcionl = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.filtrar = new System.Windows.Forms.Button();
            this.Emaill = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Carrito = new System.Windows.Forms.ListBox();
            this.eliminarCarrito = new System.Windows.Forms.Button();
            this.Compra = new System.Windows.Forms.Button();
            this.fechaIN = new System.Windows.Forms.DateTimePicker();
            this.FechaOut = new System.Windows.Forms.DateTimePicker();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaUbi)).BeginInit();
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
            this.sidepanel.Size = new System.Drawing.Size(200, 617);
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
            this.label17.Size = new System.Drawing.Size(165, 34);
            this.label17.TabIndex = 51;
            this.label17.Text = "Usted puede realizar sus compras aqui";
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
            this.titleLabel.Size = new System.Drawing.Size(102, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Comprar";
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
            // ListaEsp
            // 
            this.ListaEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaEsp.Location = new System.Drawing.Point(288, 213);
            this.ListaEsp.Name = "ListaEsp";
            this.ListaEsp.Size = new System.Drawing.Size(617, 88);
            this.ListaEsp.TabIndex = 2;
            this.ListaEsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEsp_CellContentClick);
            // 
            // ListaUbi
            // 
            this.ListaUbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaUbi.Location = new System.Drawing.Point(288, 332);
            this.ListaUbi.Name = "ListaUbi";
            this.ListaUbi.Size = new System.Drawing.Size(617, 91);
            this.ListaUbi.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(930, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 87);
            this.button2.TabIndex = 5;
            this.button2.Text = "Agregar carrito";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tipoUbi
            // 
            this.tipoUbi.FormattingEnabled = true;
            this.tipoUbi.Location = new System.Drawing.Point(288, 82);
            this.tipoUbi.Name = "tipoUbi";
            this.tipoUbi.Size = new System.Drawing.Size(121, 21);
            this.tipoUbi.TabIndex = 6;
            this.tipoUbi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // agregarTipo
            // 
            this.agregarTipo.Location = new System.Drawing.Point(415, 82);
            this.agregarTipo.Name = "agregarTipo";
            this.agregarTipo.Size = new System.Drawing.Size(87, 23);
            this.agregarTipo.TabIndex = 8;
            this.agregarTipo.Text = "Agregar";
            this.agregarTipo.UseVisualStyleBackColor = true;
            this.agregarTipo.Click += new System.EventHandler(this.agregarTipo_Click);
            // 
            // eliminarTipo
            // 
            this.eliminarTipo.Location = new System.Drawing.Point(508, 82);
            this.eliminarTipo.Name = "eliminarTipo";
            this.eliminarTipo.Size = new System.Drawing.Size(75, 23);
            this.eliminarTipo.TabIndex = 9;
            this.eliminarTipo.Text = "Eliminar";
            this.eliminarTipo.UseVisualStyleBackColor = true;
            this.eliminarTipo.Click += new System.EventHandler(this.eliminarTipo_Click);
            // 
            // ListaCat
            // 
            this.ListaCat.FormattingEnabled = true;
            this.ListaCat.Location = new System.Drawing.Point(288, 109);
            this.ListaCat.Name = "ListaCat";
            this.ListaCat.Size = new System.Drawing.Size(292, 56);
            this.ListaCat.TabIndex = 10;
            // 
            // Descripcionl
            // 
            this.Descripcionl.AutoSize = true;
            this.Descripcionl.Location = new System.Drawing.Point(285, 187);
            this.Descripcionl.Name = "Descripcionl";
            this.Descripcionl.Size = new System.Drawing.Size(63, 13);
            this.Descripcionl.TabIndex = 11;
            this.Descripcionl.Text = "Descripcion";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(355, 187);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(100, 20);
            this.Descripcion.TabIndex = 12;
            this.Descripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // filtrar
            // 
            this.filtrar.Location = new System.Drawing.Point(1022, 78);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(195, 87);
            this.filtrar.TabIndex = 13;
            this.filtrar.Text = "Filtrar";
            this.filtrar.UseVisualStyleBackColor = true;
            this.filtrar.Click += new System.EventHandler(this.filtrar_Click);
            // 
            // Emaill
            // 
            this.Emaill.AutoSize = true;
            this.Emaill.Location = new System.Drawing.Point(285, 576);
            this.Emaill.Name = "Emaill";
            this.Emaill.Size = new System.Drawing.Size(32, 13);
            this.Emaill.TabIndex = 14;
            this.Emaill.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(355, 573);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 15;
            // 
            // Carrito
            // 
            this.Carrito.FormattingEnabled = true;
            this.Carrito.Location = new System.Drawing.Point(288, 467);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(617, 69);
            this.Carrito.TabIndex = 16;
            // 
            // eliminarCarrito
            // 
            this.eliminarCarrito.Location = new System.Drawing.Point(930, 467);
            this.eliminarCarrito.Name = "eliminarCarrito";
            this.eliminarCarrito.Size = new System.Drawing.Size(195, 64);
            this.eliminarCarrito.TabIndex = 17;
            this.eliminarCarrito.Text = "Eliminar";
            this.eliminarCarrito.UseVisualStyleBackColor = true;
            this.eliminarCarrito.Click += new System.EventHandler(this.eliminarCarrito_Click);
            // 
            // Compra
            // 
            this.Compra.Location = new System.Drawing.Point(930, 550);
            this.Compra.Name = "Compra";
            this.Compra.Size = new System.Drawing.Size(195, 64);
            this.Compra.TabIndex = 18;
            this.Compra.Text = "Compra";
            this.Compra.UseVisualStyleBackColor = true;
            this.Compra.Click += new System.EventHandler(this.Compra_Click);
            // 
            // fechaIN
            // 
            this.fechaIN.Location = new System.Drawing.Point(682, 109);
            this.fechaIN.Name = "fechaIN";
            this.fechaIN.Size = new System.Drawing.Size(200, 20);
            this.fechaIN.TabIndex = 19;
            this.fechaIN.Value = new System.DateTime(2018, 11, 20, 0, 0, 0, 0);
            // 
            // FechaOut
            // 
            this.FechaOut.Location = new System.Drawing.Point(682, 144);
            this.FechaOut.Name = "FechaOut";
            this.FechaOut.Size = new System.Drawing.Size(200, 20);
            this.FechaOut.TabIndex = 20;
            this.FechaOut.Value = new System.DateTime(2018, 11, 20, 0, 0, 0, 0);
            // 
            // nuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1451, 617);
            this.ControlBox = false;
            this.Controls.Add(this.FechaOut);
            this.Controls.Add(this.fechaIN);
            this.Controls.Add(this.Compra);
            this.Controls.Add(this.eliminarCarrito);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Emaill);
            this.Controls.Add(this.filtrar);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Descripcionl);
            this.Controls.Add(this.ListaCat);
            this.Controls.Add(this.eliminarTipo);
            this.Controls.Add(this.agregarTipo);
            this.Controls.Add(this.tipoUbi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaUbi);
            this.Controls.Add(this.ListaEsp);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nuevaCompra";
            this.Load += new System.EventHandler(this.nuevaCompra_Load);
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaUbi)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView ListaEsp;
        private System.Windows.Forms.DataGridView ListaUbi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox tipoUbi;
        private System.Windows.Forms.Button agregarTipo;
        private System.Windows.Forms.Button eliminarTipo;
        private System.Windows.Forms.ListBox ListaCat;
        private System.Windows.Forms.Label Descripcionl;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Button filtrar;
        private System.Windows.Forms.Label Emaill;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.ListBox Carrito;
        private System.Windows.Forms.Button eliminarCarrito;
        private System.Windows.Forms.Button Compra;
        private System.Windows.Forms.DateTimePicker fechaIN;
        private System.Windows.Forms.DateTimePicker FechaOut;

    }