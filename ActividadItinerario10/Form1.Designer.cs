namespace ActividadItinerario10
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtSueldoBruto = new TextBox();
            dataGridView1 = new DataGridView();
            btnBorrador = new Button();
            btnConfirmar = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 56);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 106);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 156);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Sueldo Bruto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(238, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(238, 102);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 4;
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.Location = new Point(239, 148);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.Size = new Size(100, 23);
            txtSueldoBruto.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(430, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(335, 150);
            dataGridView1.TabIndex = 6;
            // 
            // btnBorrador
            // 
            btnBorrador.Location = new Point(60, 290);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(144, 38);
            btnBorrador.TabIndex = 7;
            btnBorrador.Text = "AGREGAR BORRADOR EMPLEADO";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += button1_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(327, 290);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 38);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(583, 290);
            button3.Name = "button3";
            button3.Size = new Size(75, 38);
            button3.TabIndex = 9;
            button3.Text = "LISTAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btnConfirmar);
            Controls.Add(btnBorrador);
            Controls.Add(dataGridView1);
            Controls.Add(txtSueldoBruto);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtSueldoBruto;
        private DataGridView dataGridView1;
        private Button btnBorrador;
        private Button btnConfirmar;
        private Button button3;
    }
}
