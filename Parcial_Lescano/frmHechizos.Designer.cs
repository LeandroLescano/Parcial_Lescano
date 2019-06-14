namespace Parcial_Lescano
{
    partial class frmHechizos
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
            this.dgvHechizos = new System.Windows.Forms.DataGridView();
            this.lblMago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHechizos
            // 
            this.dgvHechizos.AllowUserToAddRows = false;
            this.dgvHechizos.AllowUserToDeleteRows = false;
            this.dgvHechizos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHechizos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHechizos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHechizos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHechizos.Location = new System.Drawing.Point(12, 37);
            this.dgvHechizos.MultiSelect = false;
            this.dgvHechizos.Name = "dgvHechizos";
            this.dgvHechizos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHechizos.Size = new System.Drawing.Size(584, 311);
            this.dgvHechizos.TabIndex = 0;
            // 
            // lblMago
            // 
            this.lblMago.AutoSize = true;
            this.lblMago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMago.Location = new System.Drawing.Point(12, 9);
            this.lblMago.Name = "lblMago";
            this.lblMago.Size = new System.Drawing.Size(136, 17);
            this.lblMago.TabIndex = 1;
            this.lblMago.Text = "Hechizos del mago: ";
            // 
            // frmHechizos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 360);
            this.Controls.Add(this.lblMago);
            this.Controls.Add(this.dgvHechizos);
            this.Name = "frmHechizos";
            this.Text = "Hechizos";
            this.Load += new System.EventHandler(this.Hechizos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHechizos;
        private System.Windows.Forms.Label lblMago;
    }
}