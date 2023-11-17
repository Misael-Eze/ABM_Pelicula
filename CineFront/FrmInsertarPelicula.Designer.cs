namespace CineFront
{
    partial class FrmInsertarPelicula
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPelicula = new Label();
            lblTitulo = new Label();
            lblDirector = new Label();
            lblGenero = new Label();
            lblIdioma = new Label();
            lblDuracion = new Label();
            lblClasificacion = new Label();
            lblSala = new Label();
            lblDia = new Label();
            lblHora = new Label();
            txtTitulo = new TextBox();
            txtDirector = new TextBox();
            cboGenero = new ComboBox();
            cboIdioma = new ComboBox();
            cboClasificacion = new ComboBox();
            cboSala = new ComboBox();
            nudDuracion = new NumericUpDown();
            dtpDia = new DateTimePicker();
            dtpHora = new DateTimePicker();
            btnCancelar = new Button();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            SuspendLayout();
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(13, 9);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(48, 15);
            lblPelicula.TabIndex = 0;
            lblPelicula.Text = "Pelicula";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(72, 83);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo:";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(60, 120);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(52, 15);
            lblDirector.TabIndex = 2;
            lblDirector.Text = "Director:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(64, 156);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 3;
            lblGenero.Text = "Genero:";
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Location = new Point(65, 188);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(47, 15);
            lblIdioma.TabIndex = 4;
            lblIdioma.Text = "Idioma:";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(54, 221);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(58, 15);
            lblDuracion.TabIndex = 5;
            lblDuracion.Text = "Duracion:";
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.Location = new Point(35, 248);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(77, 15);
            lblClasificacion.TabIndex = 6;
            lblClasificacion.Text = "Clasificacion:";
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Location = new Point(449, 83);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(31, 15);
            lblSala.TabIndex = 7;
            lblSala.Text = "Sala:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(453, 117);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(27, 15);
            lblDia.TabIndex = 8;
            lblDia.Text = "Dia:";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(444, 148);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(36, 15);
            lblHora.TabIndex = 9;
            lblHora.Text = "Hora:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(115, 76);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(219, 23);
            txtTitulo.TabIndex = 10;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(115, 112);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(219, 23);
            txtDirector.TabIndex = 11;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(115, 148);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(121, 23);
            cboGenero.TabIndex = 12;
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(115, 180);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(121, 23);
            cboIdioma.TabIndex = 13;
            // 
            // cboClasificacion
            // 
            cboClasificacion.FormattingEnabled = true;
            cboClasificacion.Location = new Point(115, 240);
            cboClasificacion.Name = "cboClasificacion";
            cboClasificacion.Size = new Size(121, 23);
            cboClasificacion.TabIndex = 14;
            // 
            // cboSala
            // 
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(494, 75);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(84, 23);
            cboSala.TabIndex = 15;
            // 
            // nudDuracion
            // 
            nudDuracion.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuracion.Location = new Point(115, 213);
            nudDuracion.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(120, 23);
            nudDuracion.TabIndex = 16;
            // 
            // dtpDia
            // 
            dtpDia.Format = DateTimePickerFormat.Short;
            dtpDia.Location = new Point(494, 109);
            dtpDia.Name = "dtpDia";
            dtpDia.Size = new Size(121, 23);
            dtpDia.TabIndex = 17;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(495, 140);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(83, 23);
            dtpHora.TabIndex = 18;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(387, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(503, 283);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FrmInsertarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(dtpHora);
            Controls.Add(dtpDia);
            Controls.Add(nudDuracion);
            Controls.Add(cboSala);
            Controls.Add(cboClasificacion);
            Controls.Add(cboIdioma);
            Controls.Add(cboGenero);
            Controls.Add(txtDirector);
            Controls.Add(txtTitulo);
            Controls.Add(lblHora);
            Controls.Add(lblDia);
            Controls.Add(lblSala);
            Controls.Add(lblClasificacion);
            Controls.Add(lblDuracion);
            Controls.Add(lblIdioma);
            Controls.Add(lblGenero);
            Controls.Add(lblDirector);
            Controls.Add(lblTitulo);
            Controls.Add(lblPelicula);
            Name = "FrmInsertarPelicula";
            Text = "Insertar Pelicula";
            Load += this.FrmInsertarPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPelicula;
        private Label lblTitulo;
        private Label lblDirector;
        private Label lblGenero;
        private Label lblIdioma;
        private Label lblDuracion;
        private Label lblClasificacion;
        private Label lblSala;
        private Label lblDia;
        private Label lblHora;
        private TextBox txtTitulo;
        private TextBox txtDirector;
        private ComboBox cboGenero;
        private ComboBox cboIdioma;
        private ComboBox cboClasificacion;
        private ComboBox cboSala;
        private NumericUpDown nudDuracion;
        private DateTimePicker dtpDia;
        private DateTimePicker dtpHora;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}
