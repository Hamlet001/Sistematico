namespace Presentation
{
    partial class Form1
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
            this.catalogoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // catalogoProductoToolStripMenuItem
            // 
            this.catalogoProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.productosViewToolStripMenuItem});
            this.catalogoProductoToolStripMenuItem.Name = "catalogoProductoToolStripMenuItem";
            this.catalogoProductoToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.catalogoProductoToolStripMenuItem.Text = "Catalogo";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.productoToolStripMenuItem.Text = "Productos";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // productosViewToolStripMenuItem
            // 
            this.productosViewToolStripMenuItem.Name = "productosViewToolStripMenuItem";
            this.productosViewToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.productosViewToolStripMenuItem.Text = "Clientes";
            this.productosViewToolStripMenuItem.Click += new System.EventHandler(this.productosViewToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoProductoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1331, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1331, 640);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "APP DE REGISTRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem catalogoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosViewToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}

