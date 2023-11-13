namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ventana = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.BtnRepetir = new System.Windows.Forms.Button();
            this.PlaylistIcono = new System.Windows.Forms.PictureBox();
            this.CancionIcono = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayAnterior = new System.Windows.Forms.Button();
            this.PlaySiguiente = new System.Windows.Forms.Button();
            this.playbutton = new System.Windows.Forms.Button();
            this.pnlReproductor = new System.Windows.Forms.PictureBox();
            this.trespuntos = new System.Windows.Forms.Button();
            this.CerrarVentana = new System.Windows.Forms.Button();
            this.MinimizarVentana = new System.Windows.Forms.Button();
            this.TrackbarCancion = new XComponent.SliderBar.MACTrackBar();
            this.txtboxNombreCancion = new System.Windows.Forms.TextBox();
            this.txtboxCancion2 = new System.Windows.Forms.TextBox();
            this.txtboxCancion1 = new System.Windows.Forms.TextBox();
            this.TrackBarVolumen = new XComponent.SliderBar.MACTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancionIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // Ventana
            // 
            this.Ventana.BackColor = System.Drawing.Color.Black;
            this.Ventana.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ventana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Ventana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Ventana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ventana.Location = new System.Drawing.Point(-9, -7);
            this.Ventana.Name = "Ventana";
            this.Ventana.Size = new System.Drawing.Size(801, 34);
            this.Ventana.TabIndex = 0;
            this.Ventana.UseVisualStyleBackColor = false;
            this.Ventana.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAleatorio.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.aleatorio1;
            this.btnAleatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAleatorio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAleatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAleatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAleatorio.ForeColor = System.Drawing.Color.Yellow;
            this.btnAleatorio.Location = new System.Drawing.Point(240, 445);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAleatorio.Size = new System.Drawing.Size(17, 15);
            this.btnAleatorio.TabIndex = 18;
            this.btnAleatorio.UseVisualStyleBackColor = false;
            // 
            // BtnRepetir
            // 
            this.BtnRepetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnRepetir.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.repetir1;
            this.BtnRepetir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRepetir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnRepetir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnRepetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnRepetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRepetir.ForeColor = System.Drawing.Color.Yellow;
            this.BtnRepetir.Location = new System.Drawing.Point(400, 446);
            this.BtnRepetir.Name = "BtnRepetir";
            this.BtnRepetir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRepetir.Size = new System.Drawing.Size(17, 17);
            this.BtnRepetir.TabIndex = 17;
            this.BtnRepetir.UseVisualStyleBackColor = false;
            // 
            // PlaylistIcono
            // 
            this.PlaylistIcono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlaylistIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaylistIcono.Image = global::WindowsFormsApplication3.Properties.Resources.playlist;
            this.PlaylistIcono.Location = new System.Drawing.Point(672, 238);
            this.PlaylistIcono.Name = "PlaylistIcono";
            this.PlaylistIcono.Size = new System.Drawing.Size(44, 41);
            this.PlaylistIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlaylistIcono.TabIndex = 16;
            this.PlaylistIcono.TabStop = false;
            this.PlaylistIcono.MouseEnter += new System.EventHandler(this.PlaylistIcono_MouseEnter);
            this.PlaylistIcono.MouseLeave += new System.EventHandler(this.PlaylistIcono_MouseLeave);
            // 
            // CancionIcono
            // 
            this.CancionIcono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CancionIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancionIcono.Image = global::WindowsFormsApplication3.Properties.Resources.music;
            this.CancionIcono.Location = new System.Drawing.Point(672, 152);
            this.CancionIcono.Name = "CancionIcono";
            this.CancionIcono.Size = new System.Drawing.Size(41, 35);
            this.CancionIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CancionIcono.TabIndex = 15;
            this.CancionIcono.TabStop = false;
            this.CancionIcono.Click += new System.EventHandler(this.CancionIcono_Click);
            this.CancionIcono.MouseEnter += new System.EventHandler(this.CancionIcono_MouseEnter);
            this.CancionIcono.MouseLeave += new System.EventHandler(this.CancionIcono_MouseLeave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.cubo1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(648, 303);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(91, 118);
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.cubo1;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(648, 215);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(91, 87);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.cubo1;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(648, 127);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(91, 87);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::WindowsFormsApplication3.Properties.Resources.Catifygif1;
            this.pictureBox4.Location = new System.Drawing.Point(666, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.cubo1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(648, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 87);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.panel1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(658, 378);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // PlayAnterior
            // 
            this.PlayAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlayAnterior.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.siguientecancion_izquierda1;
            this.PlayAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayAnterior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlayAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlayAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlayAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAnterior.ForeColor = System.Drawing.Color.Yellow;
            this.PlayAnterior.Location = new System.Drawing.Point(272, 440);
            this.PlayAnterior.Name = "PlayAnterior";
            this.PlayAnterior.Size = new System.Drawing.Size(22, 23);
            this.PlayAnterior.TabIndex = 8;
            this.PlayAnterior.UseVisualStyleBackColor = false;
            // 
            // PlaySiguiente
            // 
            this.PlaySiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlaySiguiente.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.siguientecancion_derecha2;
            this.PlaySiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaySiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlaySiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlaySiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlaySiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaySiguiente.ForeColor = System.Drawing.Color.Yellow;
            this.PlaySiguiente.Location = new System.Drawing.Point(362, 440);
            this.PlaySiguiente.Name = "PlaySiguiente";
            this.PlaySiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlaySiguiente.Size = new System.Drawing.Size(22, 23);
            this.PlaySiguiente.TabIndex = 7;
            this.PlaySiguiente.UseVisualStyleBackColor = false;
            this.PlaySiguiente.MouseEnter += new System.EventHandler(this.PlaySiguiente_MouseEnter);
            this.PlaySiguiente.MouseLeave += new System.EventHandler(this.PlaySiguiente_MouseLeave);
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playbutton.BackgroundImage")));
            this.playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playbutton.FlatAppearance.BorderSize = 0;
            this.playbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbutton.ForeColor = System.Drawing.Color.Transparent;
            this.playbutton.Location = new System.Drawing.Point(299, 423);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(59, 56);
            this.playbutton.TabIndex = 6;
            this.playbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            this.playbutton.MouseEnter += new System.EventHandler(this.playbutton_MouseEnter);
            this.playbutton.MouseLeave += new System.EventHandler(this.playbutton_MouseLeave);
            // 
            // pnlReproductor
            // 
            this.pnlReproductor.BackColor = System.Drawing.Color.Transparent;
            this.pnlReproductor.Image = global::WindowsFormsApplication3.Properties.Resources.barrareproductor2;
            this.pnlReproductor.Location = new System.Drawing.Point(17, 413);
            this.pnlReproductor.Name = "pnlReproductor";
            this.pnlReproductor.Size = new System.Drawing.Size(640, 96);
            this.pnlReproductor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlReproductor.TabIndex = 5;
            this.pnlReproductor.TabStop = false;
            // 
            // trespuntos
            // 
            this.trespuntos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.trespuntos.FlatAppearance.BorderSize = 0;
            this.trespuntos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.trespuntos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.trespuntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trespuntos.Image = global::WindowsFormsApplication3.Properties.Resources._3botones3;
            this.trespuntos.Location = new System.Drawing.Point(9, 9);
            this.trespuntos.Name = "trespuntos";
            this.trespuntos.Size = new System.Drawing.Size(38, 20);
            this.trespuntos.TabIndex = 4;
            this.trespuntos.UseVisualStyleBackColor = true;
            // 
            // CerrarVentana
            // 
            this.CerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarVentana.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CerrarVentana.FlatAppearance.BorderSize = 0;
            this.CerrarVentana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CerrarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.CerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarVentana.Image = global::WindowsFormsApplication3.Properties.Resources.X2;
            this.CerrarVentana.Location = new System.Drawing.Point(715, 0);
            this.CerrarVentana.Name = "CerrarVentana";
            this.CerrarVentana.Size = new System.Drawing.Size(37, 20);
            this.CerrarVentana.TabIndex = 3;
            this.CerrarVentana.Text = " ";
            this.CerrarVentana.UseVisualStyleBackColor = true;
            this.CerrarVentana.Click += new System.EventHandler(this.button3_Click);
            // 
            // MinimizarVentana
            // 
            this.MinimizarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarVentana.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MinimizarVentana.FlatAppearance.BorderSize = 0;
            this.MinimizarVentana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MinimizarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.MinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizarVentana.Image = global::WindowsFormsApplication3.Properties.Resources._3;
            this.MinimizarVentana.Location = new System.Drawing.Point(683, 0);
            this.MinimizarVentana.Name = "MinimizarVentana";
            this.MinimizarVentana.Size = new System.Drawing.Size(38, 20);
            this.MinimizarVentana.TabIndex = 1;
            this.MinimizarVentana.UseVisualStyleBackColor = true;
            this.MinimizarVentana.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TrackbarCancion
            // 
            this.TrackbarCancion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TrackbarCancion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TrackbarCancion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackbarCancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.TrackbarCancion.IndentHeight = 6;
            this.TrackbarCancion.Location = new System.Drawing.Point(166, 476);
            this.TrackbarCancion.Maximum = 10;
            this.TrackbarCancion.Minimum = 0;
            this.TrackbarCancion.Name = "TrackbarCancion";
            this.TrackbarCancion.Size = new System.Drawing.Size(323, 25);
            this.TrackbarCancion.TabIndex = 19;
            this.TrackbarCancion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackbarCancion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.TrackbarCancion.TickHeight = 4;
            this.TrackbarCancion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackbarCancion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TrackbarCancion.TrackerSize = new System.Drawing.Size(13, 13);
            this.TrackbarCancion.TrackLineColor = System.Drawing.Color.DimGray;
            this.TrackbarCancion.TrackLineHeight = 3;
            this.TrackbarCancion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.TrackbarCancion.Value = 5;
            // 
            // txtboxNombreCancion
            // 
            this.txtboxNombreCancion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtboxNombreCancion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxNombreCancion.ForeColor = System.Drawing.SystemColors.Info;
            this.txtboxNombreCancion.Location = new System.Drawing.Point(31, 429);
            this.txtboxNombreCancion.Multiline = true;
            this.txtboxNombreCancion.Name = "txtboxNombreCancion";
            this.txtboxNombreCancion.Size = new System.Drawing.Size(134, 31);
            this.txtboxNombreCancion.TabIndex = 20;
            this.txtboxNombreCancion.Text = "asdasdasdsdasdasdasdadasdasdasdasdasd";
            // 
            // txtboxCancion2
            // 
            this.txtboxCancion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtboxCancion2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxCancion2.ForeColor = System.Drawing.SystemColors.Info;
            this.txtboxCancion2.Location = new System.Drawing.Point(487, 484);
            this.txtboxCancion2.Multiline = true;
            this.txtboxCancion2.Name = "txtboxCancion2";
            this.txtboxCancion2.Size = new System.Drawing.Size(22, 17);
            this.txtboxCancion2.TabIndex = 21;
            this.txtboxCancion2.Text = "--:--";
            this.txtboxCancion2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtboxCancion1
            // 
            this.txtboxCancion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtboxCancion1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxCancion1.ForeColor = System.Drawing.SystemColors.Info;
            this.txtboxCancion1.Location = new System.Drawing.Point(146, 484);
            this.txtboxCancion1.Multiline = true;
            this.txtboxCancion1.Name = "txtboxCancion1";
            this.txtboxCancion1.Size = new System.Drawing.Size(17, 21);
            this.txtboxCancion1.TabIndex = 22;
            this.txtboxCancion1.Text = "--:--";
            // 
            // TrackBarVolumen
            // 
            this.TrackBarVolumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TrackBarVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TrackBarVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackBarVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.TrackBarVolumen.IndentHeight = 6;
            this.TrackBarVolumen.Location = new System.Drawing.Point(543, 444);
            this.TrackBarVolumen.Maximum = 10;
            this.TrackBarVolumen.Minimum = 0;
            this.TrackBarVolumen.Name = "TrackBarVolumen";
            this.TrackBarVolumen.Size = new System.Drawing.Size(102, 22);
            this.TrackBarVolumen.TabIndex = 23;
            this.TrackBarVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.TrackBarVolumen.TickHeight = 4;
            this.TrackBarVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarVolumen.TrackerColor = System.Drawing.Color.LemonChiffon;
            this.TrackBarVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.TrackBarVolumen.TrackLineColor = System.Drawing.Color.DimGray;
            this.TrackBarVolumen.TrackLineHeight = 3;
            this.TrackBarVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrackBarVolumen.Value = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(751, 512);
            this.Controls.Add(this.TrackBarVolumen);
            this.Controls.Add(this.txtboxCancion1);
            this.Controls.Add(this.txtboxCancion2);
            this.Controls.Add(this.txtboxNombreCancion);
            this.Controls.Add(this.TrackbarCancion);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.BtnRepetir);
            this.Controls.Add(this.PlaylistIcono);
            this.Controls.Add(this.CancionIcono);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PlayAnterior);
            this.Controls.Add(this.PlaySiguiente);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.pnlReproductor);
            this.Controls.Add(this.trespuntos);
            this.Controls.Add(this.CerrarVentana);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.Ventana);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Catify";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancionIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlReproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ventana;
        private System.Windows.Forms.Button MinimizarVentana;
        private System.Windows.Forms.Button CerrarVentana;
        private System.Windows.Forms.Button trespuntos;
        private System.Windows.Forms.PictureBox pnlReproductor;
        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Button PlayAnterior;
        private System.Windows.Forms.Button PlaySiguiente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox CancionIcono;
        private System.Windows.Forms.PictureBox PlaylistIcono;
        private System.Windows.Forms.Button BtnRepetir;
        private System.Windows.Forms.Button btnAleatorio;
        private XComponent.SliderBar.MACTrackBar TrackbarCancion;
        private System.Windows.Forms.TextBox txtboxNombreCancion;
        private System.Windows.Forms.TextBox txtboxCancion2;
        private System.Windows.Forms.TextBox txtboxCancion1;
        private XComponent.SliderBar.MACTrackBar TrackBarVolumen;
    }
}

