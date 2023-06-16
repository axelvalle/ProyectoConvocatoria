namespace ProyectoConvocatoria
{
    partial class Clientes
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
            lbl1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            tbCliente = new System.Windows.Forms.DataGridView();
            IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DatosBancarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)tbCliente).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new System.Drawing.Point(17, 54);
            lbl1.Name = "lbl1";
            lbl1.Size = new System.Drawing.Size(74, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "ID Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(146, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(146, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Datos Bancarios";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(146, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 156);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Direccion";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(146, 203);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 206);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 20);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // tbCliente
            // 
            tbCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IDCliente, DatosBancarios, Direccion, Telefono });
            tbCliente.Location = new System.Drawing.Point(6, 259);
            tbCliente.Name = "tbCliente";
            tbCliente.RowHeadersWidth = 51;
            tbCliente.RowTemplate.Height = 29;
            tbCliente.Size = new System.Drawing.Size(557, 188);
            tbCliente.TabIndex = 8;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "ID Cliente";
            IDCliente.MinimumWidth = 6;
            IDCliente.Name = "IDCliente";
            IDCliente.Width = 125;
            // 
            // DatosBancarios
            // 
            DatosBancarios.HeaderText = "Datos Bancarios";
            DatosBancarios.MinimumWidth = 6;
            DatosBancarios.Name = "DatosBancarios";
            DatosBancarios.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(342, 206);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Agregar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(469, 206);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Reservar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(580, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbCliente);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(lbl1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)tbCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tbCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosBancarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}