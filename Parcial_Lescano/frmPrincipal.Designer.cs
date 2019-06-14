namespace Parcial_Lescano
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.lblBusqueda = new System.Windows.Forms.ToolStripLabel();
            this.txtBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVerHechizos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAsociarHechizo = new System.Windows.Forms.ToolStripButton();
            this.dgvMagos = new System.Windows.Forms.DataGridView();
            this.tspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).BeginInit();
            this.SuspendLayout();
            // 
            // tspMenu
            // 
            this.tspMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tspMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBusqueda,
            this.txtBusqueda,
            this.toolStripSeparator2,
            this.btnVerHechizos,
            this.toolStripSeparator1,
            this.btnAsociarHechizo});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tspMenu.Size = new System.Drawing.Size(800, 25);
            this.tspMenu.TabIndex = 0;
            this.tspMenu.Text = "toolStrip1";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(73, 22);
            this.lblBusqueda.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 25);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnVerHechizos
            // 
            this.btnVerHechizos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnVerHechizos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHechizos.Image = ((System.Drawing.Image)(resources.GetObject("btnVerHechizos.Image")));
            this.btnVerHechizos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerHechizos.Name = "btnVerHechizos";
            this.btnVerHechizos.Size = new System.Drawing.Size(89, 22);
            this.btnVerHechizos.Text = "Ver hechizos";
            this.btnVerHechizos.Click += new System.EventHandler(this.btnVerHechizos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAsociarHechizo
            // 
            this.btnAsociarHechizo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAsociarHechizo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociarHechizo.Image = ((System.Drawing.Image)(resources.GetObject("btnAsociarHechizo.Image")));
            this.btnAsociarHechizo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAsociarHechizo.Name = "btnAsociarHechizo";
            this.btnAsociarHechizo.Size = new System.Drawing.Size(114, 22);
            this.btnAsociarHechizo.Text = "Asociar hechizos";
            this.btnAsociarHechizo.Click += new System.EventHandler(this.btnAsociarHechizo_Click);
            // 
            // dgvMagos
            // 
            this.dgvMagos.AllowUserToAddRows = false;
            this.dgvMagos.AllowUserToDeleteRows = false;
            this.dgvMagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMagos.Location = new System.Drawing.Point(12, 29);
            this.dgvMagos.MultiSelect = false;
            this.dgvMagos.Name = "dgvMagos";
            this.dgvMagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagos.Size = new System.Drawing.Size(776, 409);
            this.dgvMagos.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMagos);
            this.Controls.Add(this.tspMenu);
            this.Name = "frmPrincipal";
            this.Text = "TEMA 1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.DataGridView dgvMagos;
        private System.Windows.Forms.ToolStripTextBox txtBusqueda;
        private System.Windows.Forms.ToolStripLabel lblBusqueda;
        private System.Windows.Forms.ToolStripButton btnVerHechizos;
        private System.Windows.Forms.ToolStripButton btnAsociarHechizo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}