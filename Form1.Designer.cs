namespace Proyecto
{
    partial class Form1
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
            but1 = new Button();
            txbID = new TextBox();
            label1 = new Label();
            Nombre = new Label();
            label2 = new Label();
            txbnombre = new TextBox();
            txbapellido = new TextBox();
            btnguardar = new Button();
            DgvEstudiantes = new DataGridView();
            button1 = new Button();
            BtnReporteExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // but1
            // 
            but1.Location = new Point(60, 309);
            but1.Name = "but1";
            but1.Size = new Size(75, 23);
            but1.TabIndex = 0;
            but1.Text = "Conexión";
            but1.UseVisualStyleBackColor = true;
            but1.Click += but1_Click;
            // 
            // txbID
            // 
            txbID.Location = new Point(97, 115);
            txbID.Name = "txbID";
            txbID.Size = new Size(100, 23);
            txbID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 118);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(62, 153);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 4;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 186);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // txbnombre
            // 
            txbnombre.Location = new Point(119, 150);
            txbnombre.Name = "txbnombre";
            txbnombre.Size = new Size(100, 23);
            txbnombre.TabIndex = 6;
            // 
            // txbapellido
            // 
            txbapellido.Location = new Point(119, 186);
            txbapellido.Name = "txbapellido";
            txbapellido.Size = new Size(100, 23);
            txbapellido.TabIndex = 7;
            txbapellido.TextChanged += txbapellido_TextChanged;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(61, 242);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 8;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // DgvEstudiantes
            // 
            DgvEstudiantes.AllowUserToOrderColumns = true;
            DgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEstudiantes.Location = new Point(307, 23);
            DgvEstudiantes.Name = "DgvEstudiantes";
            DgvEstudiantes.RowTemplate.Height = 25;
            DgvEstudiantes.Size = new Size(471, 333);
            DgvEstudiantes.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(156, 243);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnReporteExcel
            // 
            BtnReporteExcel.Location = new Point(153, 308);
            BtnReporteExcel.Name = "BtnReporteExcel";
            BtnReporteExcel.Size = new Size(132, 23);
            BtnReporteExcel.TabIndex = 11;
            BtnReporteExcel.Text = "Exportar a Excel";
            BtnReporteExcel.UseVisualStyleBackColor = true;
            BtnReporteExcel.Click += BtnReporteExcel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnReporteExcel);
            Controls.Add(button1);
            Controls.Add(DgvEstudiantes);
            Controls.Add(btnguardar);
            Controls.Add(txbapellido);
            Controls.Add(txbnombre);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(label1);
            Controls.Add(txbID);
            Controls.Add(but1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but1;
        private TextBox txbID;
        private Label label1;
        private Label Nombre;
        private Label label2;
        private TextBox txbnombre;
        private TextBox txbapellido;
        private Button btnguardar;
        private DataGridView DgvEstudiantes;
        private Button button1;
        private Button BtnReporteExcel;
    }
}