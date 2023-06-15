
namespace CxPVista
{
    partial class Puesto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.dtgPuesto = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(40, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(65, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(65, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salario";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtid.Location = new System.Drawing.Point(92, 195);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 25);
            this.txtid.TabIndex = 8;
            this.txtid.Tag = "ID_TIPO_PUESTO";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtnombre.Location = new System.Drawing.Point(187, 257);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(164, 25);
            this.txtnombre.TabIndex = 9;
            this.txtnombre.Tag = "NOMBRE_PUESTO";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtSalario.Location = new System.Drawing.Point(187, 287);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(164, 25);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.Tag = "SALARIO";
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // dtgPuesto
            // 
            this.dtgPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPuesto.Location = new System.Drawing.Point(24, 331);
            this.dtgPuesto.Name = "dtgPuesto";
            this.dtgPuesto.Size = new System.Drawing.Size(801, 226);
            this.dtgPuesto.TabIndex = 15;
            this.dtgPuesto.Tag = "tipo_puesto";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(126, 3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 16;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Puesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(848, 579);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dtgPuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Puesto";
            this.Text = "Puesto";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DataGridView dtgPuesto;
        private NavegadorVista.Navegador navegador1;
   
    }
}