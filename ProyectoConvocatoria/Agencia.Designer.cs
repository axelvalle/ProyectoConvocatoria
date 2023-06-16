namespace ProyectoConvocatoria
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            reservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            atencionAlClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { reservacionToolStripMenuItem, atencionAlClienteToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // reservacionToolStripMenuItem
            // 
            reservacionToolStripMenuItem.Name = "reservacionToolStripMenuItem";
            reservacionToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            reservacionToolStripMenuItem.Text = "Reservacion";
            reservacionToolStripMenuItem.Click += reservacionToolStripMenuItem_Click;
            // 
            // atencionAlClienteToolStripMenuItem
            // 
            atencionAlClienteToolStripMenuItem.Name = "atencionAlClienteToolStripMenuItem";
            atencionAlClienteToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            atencionAlClienteToolStripMenuItem.Text = "Atencion al  Cliente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Reservacion";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atencionAlClienteToolStripMenuItem;
    }
}
