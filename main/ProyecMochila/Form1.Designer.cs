namespace ProyecMochila
{
    partial class INTERFAZ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INTERFAZ));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.REINICIAR = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.lbxMostrar = new System.Windows.Forms.ListBox();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TOP_WRAPPER = new System.Windows.Forms.Panel();
            this.BTN_MINIMIZAR = new System.Windows.Forms.Button();
            this.SIDE_WRAPPER = new System.Windows.Forms.Panel();
            this.txtPESO = new System.Windows.Forms.TextBox();
            this.txtBENEFICIO = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAñadirElemento = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WRAPPER_MOCHILA = new System.Windows.Forms.Panel();
            this.LABEL_BENEFICIO = new System.Windows.Forms.Label();
            this.LABEL_PESO = new System.Windows.Forms.Label();
            this.LABEL_ELEMENTOSENLAMOCHILA = new System.Windows.Forms.Label();
            this.LABEL_PESOMAXIMO = new System.Windows.Forms.Label();
            this.IMAGEN_MOCHILA = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbxELEMENTOS = new System.Windows.Forms.ListBox();
            this.TOP_WRAPPER.SuspendLayout();
            this.SIDE_WRAPPER.SuspendLayout();
            this.WRAPPER_MOCHILA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN_MOCHILA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESO MÁXIMO:";
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoMaximo.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoMaximo.ForeColor = System.Drawing.Color.Black;
            this.txtPesoMaximo.Location = new System.Drawing.Point(185, 73);
            this.txtPesoMaximo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(156, 24);
            this.txtPesoMaximo.TabIndex = 5;
            this.txtPesoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesoMaximo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesoMaximo_KeyUp);
            // 
            // REINICIAR
            // 
            this.REINICIAR.BackColor = System.Drawing.Color.Red;
            this.REINICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.REINICIAR.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REINICIAR.ForeColor = System.Drawing.Color.White;
            this.REINICIAR.Location = new System.Drawing.Point(17, 623);
            this.REINICIAR.Margin = new System.Windows.Forms.Padding(2);
            this.REINICIAR.Name = "REINICIAR";
            this.REINICIAR.Size = new System.Drawing.Size(399, 28);
            this.REINICIAR.TabIndex = 19;
            this.REINICIAR.Text = "REINICIAR";
            this.REINICIAR.UseVisualStyleBackColor = false;
            this.REINICIAR.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpezar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.ForeColor = System.Drawing.Color.White;
            this.btnEmpezar.Location = new System.Drawing.Point(83, 336);
            this.btnEmpezar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(258, 33);
            this.btnEmpezar.TabIndex = 22;
            this.btnEmpezar.Text = "RESOLVER";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.BtnEmpezar_Click);
            // 
            // lbxMostrar
            // 
            this.lbxMostrar.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMostrar.FormattingEnabled = true;
            this.lbxMostrar.ItemHeight = 20;
            this.lbxMostrar.Location = new System.Drawing.Point(17, 382);
            this.lbxMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.lbxMostrar.Name = "lbxMostrar";
            this.lbxMostrar.Size = new System.Drawing.Size(399, 224);
            this.lbxMostrar.TabIndex = 23;
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SALIR.ForeColor = System.Drawing.Color.White;
            this.BTN_SALIR.Location = new System.Drawing.Point(1263, 4);
            this.BTN_SALIR.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(30, 32);
            this.BTN_SALIR.TabIndex = 24;
            this.BTN_SALIR.Text = "X";
            this.BTN_SALIR.UseVisualStyleBackColor = false;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(320, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 34);
            this.label8.TabIndex = 25;
            this.label8.Text = "BACKTRACKING";
            // 
            // TOP_WRAPPER
            // 
            this.TOP_WRAPPER.BackColor = System.Drawing.Color.Black;
            this.TOP_WRAPPER.Controls.Add(this.BTN_MINIMIZAR);
            this.TOP_WRAPPER.Controls.Add(this.BTN_SALIR);
            this.TOP_WRAPPER.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOP_WRAPPER.Location = new System.Drawing.Point(0, 0);
            this.TOP_WRAPPER.Margin = new System.Windows.Forms.Padding(2);
            this.TOP_WRAPPER.Name = "TOP_WRAPPER";
            this.TOP_WRAPPER.Size = new System.Drawing.Size(1300, 40);
            this.TOP_WRAPPER.TabIndex = 26;
            // 
            // BTN_MINIMIZAR
            // 
            this.BTN_MINIMIZAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BTN_MINIMIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_MINIMIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MINIMIZAR.ForeColor = System.Drawing.Color.White;
            this.BTN_MINIMIZAR.Location = new System.Drawing.Point(1229, 4);
            this.BTN_MINIMIZAR.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_MINIMIZAR.Name = "BTN_MINIMIZAR";
            this.BTN_MINIMIZAR.Size = new System.Drawing.Size(30, 32);
            this.BTN_MINIMIZAR.TabIndex = 25;
            this.BTN_MINIMIZAR.Text = "_";
            this.BTN_MINIMIZAR.UseVisualStyleBackColor = false;
            this.BTN_MINIMIZAR.Click += new System.EventHandler(this.BTN_MINIMIZAR_Click);
            // 
            // SIDE_WRAPPER
            // 
            this.SIDE_WRAPPER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SIDE_WRAPPER.Controls.Add(this.txtPESO);
            this.SIDE_WRAPPER.Controls.Add(this.txtBENEFICIO);
            this.SIDE_WRAPPER.Controls.Add(this.label14);
            this.SIDE_WRAPPER.Controls.Add(this.label13);
            this.SIDE_WRAPPER.Controls.Add(this.label12);
            this.SIDE_WRAPPER.Controls.Add(this.btnAñadirElemento);
            this.SIDE_WRAPPER.Controls.Add(this.label11);
            this.SIDE_WRAPPER.Controls.Add(this.label10);
            this.SIDE_WRAPPER.Controls.Add(this.lbxMostrar);
            this.SIDE_WRAPPER.Controls.Add(this.label1);
            this.SIDE_WRAPPER.Controls.Add(this.btnEmpezar);
            this.SIDE_WRAPPER.Controls.Add(this.REINICIAR);
            this.SIDE_WRAPPER.Controls.Add(this.txtPesoMaximo);
            this.SIDE_WRAPPER.Dock = System.Windows.Forms.DockStyle.Right;
            this.SIDE_WRAPPER.Location = new System.Drawing.Point(866, 40);
            this.SIDE_WRAPPER.Name = "SIDE_WRAPPER";
            this.SIDE_WRAPPER.Size = new System.Drawing.Size(434, 660);
            this.SIDE_WRAPPER.TabIndex = 27;
            // 
            // txtPESO
            // 
            this.txtPESO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPESO.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPESO.ForeColor = System.Drawing.Color.Black;
            this.txtPESO.Location = new System.Drawing.Point(185, 196);
            this.txtPESO.Margin = new System.Windows.Forms.Padding(2);
            this.txtPESO.Name = "txtPESO";
            this.txtPESO.Size = new System.Drawing.Size(156, 24);
            this.txtPESO.TabIndex = 34;
            this.txtPESO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBENEFICIO
            // 
            this.txtBENEFICIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBENEFICIO.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBENEFICIO.ForeColor = System.Drawing.Color.Black;
            this.txtBENEFICIO.Location = new System.Drawing.Point(185, 233);
            this.txtBENEFICIO.Margin = new System.Windows.Forms.Padding(2);
            this.txtBENEFICIO.Name = "txtBENEFICIO";
            this.txtBENEFICIO.Size = new System.Drawing.Size(156, 24);
            this.txtBENEFICIO.TabIndex = 33;
            this.txtBENEFICIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(79, 234);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "Beneficio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(79, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 23);
            this.label13.TabIndex = 31;
            this.label13.Text = "Peso:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(147, 162);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 23);
            this.label12.TabIndex = 30;
            this.label12.Text = "ELEMENTO:";
            // 
            // btnAñadirElemento
            // 
            this.btnAñadirElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnAñadirElemento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirElemento.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirElemento.ForeColor = System.Drawing.Color.White;
            this.btnAñadirElemento.Location = new System.Drawing.Point(83, 273);
            this.btnAñadirElemento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirElemento.Name = "btnAñadirElemento";
            this.btnAñadirElemento.Size = new System.Drawing.Size(258, 33);
            this.btnAñadirElemento.TabIndex = 29;
            this.btnAñadirElemento.Text = "AÑADIR ELEMENTO";
            this.btnAñadirElemento.UseVisualStyleBackColor = false;
            this.btnAñadirElemento.Click += new System.EventHandler(this.btnAñadirElemento_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 34);
            this.label11.TabIndex = 28;
            this.label11.Text = "MOCHILA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(395, 34);
            this.label10.TabIndex = 27;
            this.label10.Text = "ELEMENTOS DE LA MOCHILA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(297, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 34);
            this.label9.TabIndex = 26;
            this.label9.Text = "(Problema de la mochila)";
            // 
            // WRAPPER_MOCHILA
            // 
            this.WRAPPER_MOCHILA.BackColor = System.Drawing.Color.White;
            this.WRAPPER_MOCHILA.Controls.Add(this.lbxELEMENTOS);
            this.WRAPPER_MOCHILA.Controls.Add(this.LABEL_BENEFICIO);
            this.WRAPPER_MOCHILA.Controls.Add(this.LABEL_PESO);
            this.WRAPPER_MOCHILA.Controls.Add(this.LABEL_ELEMENTOSENLAMOCHILA);
            this.WRAPPER_MOCHILA.Controls.Add(this.LABEL_PESOMAXIMO);
            this.WRAPPER_MOCHILA.Controls.Add(this.label9);
            this.WRAPPER_MOCHILA.Controls.Add(this.label8);
            this.WRAPPER_MOCHILA.Controls.Add(this.IMAGEN_MOCHILA);
            this.WRAPPER_MOCHILA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WRAPPER_MOCHILA.Location = new System.Drawing.Point(0, 40);
            this.WRAPPER_MOCHILA.Name = "WRAPPER_MOCHILA";
            this.WRAPPER_MOCHILA.Size = new System.Drawing.Size(866, 660);
            this.WRAPPER_MOCHILA.TabIndex = 28;
            // 
            // LABEL_BENEFICIO
            // 
            this.LABEL_BENEFICIO.AutoSize = true;
            this.LABEL_BENEFICIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LABEL_BENEFICIO.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_BENEFICIO.Location = new System.Drawing.Point(12, 292);
            this.LABEL_BENEFICIO.Name = "LABEL_BENEFICIO";
            this.LABEL_BENEFICIO.Size = new System.Drawing.Size(16, 26);
            this.LABEL_BENEFICIO.TabIndex = 30;
            this.LABEL_BENEFICIO.Text = ".";
            // 
            // LABEL_PESO
            // 
            this.LABEL_PESO.AutoSize = true;
            this.LABEL_PESO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LABEL_PESO.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_PESO.Location = new System.Drawing.Point(12, 250);
            this.LABEL_PESO.Name = "LABEL_PESO";
            this.LABEL_PESO.Size = new System.Drawing.Size(16, 26);
            this.LABEL_PESO.TabIndex = 29;
            this.LABEL_PESO.Text = ".";
            // 
            // LABEL_ELEMENTOSENLAMOCHILA
            // 
            this.LABEL_ELEMENTOSENLAMOCHILA.AutoSize = true;
            this.LABEL_ELEMENTOSENLAMOCHILA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LABEL_ELEMENTOSENLAMOCHILA.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_ELEMENTOSENLAMOCHILA.Location = new System.Drawing.Point(12, 209);
            this.LABEL_ELEMENTOSENLAMOCHILA.Name = "LABEL_ELEMENTOSENLAMOCHILA";
            this.LABEL_ELEMENTOSENLAMOCHILA.Size = new System.Drawing.Size(14, 23);
            this.LABEL_ELEMENTOSENLAMOCHILA.TabIndex = 28;
            this.LABEL_ELEMENTOSENLAMOCHILA.Text = ".";
            // 
            // LABEL_PESOMAXIMO
            // 
            this.LABEL_PESOMAXIMO.AutoSize = true;
            this.LABEL_PESOMAXIMO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LABEL_PESOMAXIMO.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_PESOMAXIMO.Location = new System.Drawing.Point(649, 621);
            this.LABEL_PESOMAXIMO.Name = "LABEL_PESOMAXIMO";
            this.LABEL_PESOMAXIMO.Size = new System.Drawing.Size(155, 30);
            this.LABEL_PESOMAXIMO.TabIndex = 27;
            this.LABEL_PESOMAXIMO.Text = "Peso máximo:";
            // 
            // IMAGEN_MOCHILA
            // 
            this.IMAGEN_MOCHILA.Image = global::ProyecMochila.Properties.Resources.MOCHILA1_GIF;
            this.IMAGEN_MOCHILA.Location = new System.Drawing.Point(142, 84);
            this.IMAGEN_MOCHILA.Name = "IMAGEN_MOCHILA";
            this.IMAGEN_MOCHILA.Size = new System.Drawing.Size(597, 547);
            this.IMAGEN_MOCHILA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMAGEN_MOCHILA.TabIndex = 0;
            this.IMAGEN_MOCHILA.TabStop = false;
            this.IMAGEN_MOCHILA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IMAGEN_MOCHILA_MouseDown);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TOP_WRAPPER;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lbxELEMENTOS
            // 
            this.lbxELEMENTOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxELEMENTOS.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxELEMENTOS.FormattingEnabled = true;
            this.lbxELEMENTOS.ItemHeight = 20;
            this.lbxELEMENTOS.Location = new System.Drawing.Point(11, 336);
            this.lbxELEMENTOS.Margin = new System.Windows.Forms.Padding(2);
            this.lbxELEMENTOS.Name = "lbxELEMENTOS";
            this.lbxELEMENTOS.Size = new System.Drawing.Size(202, 220);
            this.lbxELEMENTOS.TabIndex = 35;
            // 
            // INTERFAZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.WRAPPER_MOCHILA);
            this.Controls.Add(this.SIDE_WRAPPER);
            this.Controls.Add(this.TOP_WRAPPER);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "INTERFAZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La mochila";
            this.TOP_WRAPPER.ResumeLayout(false);
            this.SIDE_WRAPPER.ResumeLayout(false);
            this.SIDE_WRAPPER.PerformLayout();
            this.WRAPPER_MOCHILA.ResumeLayout(false);
            this.WRAPPER_MOCHILA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN_MOCHILA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Button REINICIAR;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.ListBox lbxMostrar;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel TOP_WRAPPER;
        private System.Windows.Forms.Button BTN_MINIMIZAR;
        private System.Windows.Forms.Panel SIDE_WRAPPER;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel WRAPPER_MOCHILA;
        private System.Windows.Forms.PictureBox IMAGEN_MOCHILA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LABEL_PESOMAXIMO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPESO;
        private System.Windows.Forms.TextBox txtBENEFICIO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAñadirElemento;
        private System.Windows.Forms.Label LABEL_BENEFICIO;
        private System.Windows.Forms.Label LABEL_PESO;
        private System.Windows.Forms.Label LABEL_ELEMENTOSENLAMOCHILA;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ListBox lbxELEMENTOS;
    }
}

