partial class NuevaTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaTarjeta));
            this.topbar = new System.Windows.Forms.Panel();
            this.minimizingLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nroTarje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.codS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_asociar = new System.Windows.Forms.Button();
            this.userNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaVto = new System.Windows.Forms.DateTimePicker();
            this.topbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.topbar.Controls.Add(this.minimizingLabel);
            this.topbar.Controls.Add(this.titleLabel);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(200, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(376, 49);
            this.topbar.TabIndex = 1;
            // 
            // minimizingLabel
            // 
            this.minimizingLabel.AutoSize = true;
            this.minimizingLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizingLabel.ForeColor = System.Drawing.Color.White;
            this.minimizingLabel.Location = new System.Drawing.Point(304, 12);
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
            this.titleLabel.Size = new System.Drawing.Size(228, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Asociar nueva tarjeta";
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
            this.sidepanel.Size = new System.Drawing.Size(200, 327);
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
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nro. de tarjeta";
            // 
            // nroTarje
            // 
            this.nroTarje.Location = new System.Drawing.Point(210, 99);
            this.nroTarje.MaxLength = 50;
            this.nroTarje.Name = "nroTarje";
            this.nroTarje.Size = new System.Drawing.Size(352, 20);
            this.nroTarje.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(206, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Datos de tarjeta";
            // 
            // codS
            // 
            this.codS.Location = new System.Drawing.Point(210, 146);
            this.codS.MaxLength = 10;
            this.codS.Name = "codS";
            this.codS.PasswordChar = '*';
            this.codS.Size = new System.Drawing.Size(352, 20);
            this.codS.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Cód. de seguridad";
            // 
            // titular
            // 
            this.titular.Location = new System.Drawing.Point(210, 198);
            this.titular.MaxLength = 50;
            this.titular.Name = "titular";
            this.titular.Size = new System.Drawing.Size(352, 20);
            this.titular.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nombre del titular";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightPink;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(210, 274);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(109, 41);
            this.btn_limpiar.TabIndex = 58;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_asociar
            // 
            this.btn_asociar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(146)))), ((int)(((byte)(29)))));
            this.btn_asociar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asociar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asociar.Location = new System.Drawing.Point(325, 274);
            this.btn_asociar.Name = "btn_asociar";
            this.btn_asociar.Size = new System.Drawing.Size(237, 41);
            this.btn_asociar.TabIndex = 57;
            this.btn_asociar.Text = "Asociar tarjeta";
            this.btn_asociar.UseVisualStyleBackColor = false;
            this.btn_asociar.Click += new System.EventHandler(this.btn_asociar_Click);
            // 
            // userNombre
            // 
            this.userNombre.AutoSize = true;
            this.userNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNombre.Location = new System.Drawing.Point(438, 55);
            this.userNombre.Name = "userNombre";
            this.userNombre.Size = new System.Drawing.Size(20, 21);
            this.userNombre.TabIndex = 59;
            this.userNombre.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "Fecha vto.";
            // 
            // fechaVto
            // 
            this.fechaVto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVto.Location = new System.Drawing.Point(325, 225);
            this.fechaVto.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.fechaVto.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaVto.Name = "fechaVto";
            this.fechaVto.Size = new System.Drawing.Size(237, 20);
            this.fechaVto.TabIndex = 60;
            // 
            // NuevaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(576, 327);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaVto);
            this.Controls.Add(this.userNombre);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_asociar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titular);
            this.Controls.Add(this.codS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nroTarje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaTarjeta";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.NuevaTarjeta_Load);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label minimizingLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nroTarje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox codS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_asociar;
        private System.Windows.Forms.Label userNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaVto;

    }