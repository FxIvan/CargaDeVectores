namespace CargaDeVectores
{
    partial class frmCargaDeVectores
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
            btnCargar = new Button();
            btnSalir = new Button();
            lstUno = new ListBox();
            txtItem = new TextBox();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(38, 294);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(196, 28);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(38, 256);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(196, 29);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstUno
            // 
            lstUno.FormattingEnabled = true;
            lstUno.ItemHeight = 15;
            lstUno.Location = new Point(38, 12);
            lstUno.Name = "lstUno";
            lstUno.Size = new Size(196, 184);
            lstUno.TabIndex = 2;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(38, 216);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(196, 23);
            txtItem.TabIndex = 3;
            // 
            // frmCargaDeVectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 342);
            Controls.Add(txtItem);
            Controls.Add(lstUno);
            Controls.Add(btnSalir);
            Controls.Add(btnCargar);
            Name = "frmCargaDeVectores";
            Text = "Carga de vectores";
            Load += frmCargaDeVectores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargar;
        private Button btnSalir;
        private ListBox lstUno;
        private TextBox txtItem;
    }
}
