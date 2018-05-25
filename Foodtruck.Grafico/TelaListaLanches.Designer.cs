namespace Foodtruck.Grafico
{
    partial class TelaListaLanches
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
            this.btAdicionar = new System.Windows.Forms.Button();
            this.brRemover = new System.Windows.Forms.Button();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 12);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // brRemover
            // 
            this.brRemover.Location = new System.Drawing.Point(94, 11);
            this.brRemover.Name = "brRemover";
            this.brRemover.Size = new System.Drawing.Size(75, 23);
            this.brRemover.TabIndex = 1;
            this.brRemover.Text = "Remover";
            this.brRemover.UseMnemonic = false;
            this.brRemover.UseVisualStyleBackColor = true;
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Location = new System.Drawing.Point(176, 10);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_Alterar.TabIndex = 2;
            this.bt_Alterar.Text = "Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 397);
            this.dataGridView1.TabIndex = 3;
            // 
            // TelaListaLanches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Alterar);
            this.Controls.Add(this.brRemover);
            this.Controls.Add(this.btAdicionar);
            this.Name = "TelaListaLanches";
            this.Text = "TelaListaLanches";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button brRemover;
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}