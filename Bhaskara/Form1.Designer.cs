namespace Bhaskara
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.numUDA = new System.Windows.Forms.NumericUpDown();
            this.numUDB = new System.Windows.Forms.NumericUpDown();
            this.numUDC = new System.Windows.Forms.NumericUpDown();
            this.btmCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(73, 45);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(72, 84);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 17);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "b";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(73, 123);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(15, 17);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "c";
            // 
            // numUDA
            // 
            this.numUDA.Location = new System.Drawing.Point(95, 43);
            this.numUDA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDA.Name = "numUDA";
            this.numUDA.Size = new System.Drawing.Size(120, 22);
            this.numUDA.TabIndex = 3;
            // 
            // numUDB
            // 
            this.numUDB.Location = new System.Drawing.Point(95, 82);
            this.numUDB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDB.Name = "numUDB";
            this.numUDB.Size = new System.Drawing.Size(120, 22);
            this.numUDB.TabIndex = 4;
            // 
            // numUDC
            // 
            this.numUDC.Location = new System.Drawing.Point(94, 121);
            this.numUDC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDC.Name = "numUDC";
            this.numUDC.Size = new System.Drawing.Size(120, 22);
            this.numUDC.TabIndex = 5;
            // 
            // btmCalcular
            // 
            this.btmCalcular.Location = new System.Drawing.Point(262, 84);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(75, 23);
            this.btmCalcular.TabIndex = 6;
            this.btmCalcular.Text = "calcular";
            this.btmCalcular.UseVisualStyleBackColor = true;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 220);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.numUDC);
            this.Controls.Add(this.numUDB);
            this.Controls.Add(this.numUDA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.NumericUpDown numUDA;
        private System.Windows.Forms.NumericUpDown numUDB;
        private System.Windows.Forms.NumericUpDown numUDC;
        private System.Windows.Forms.Button btmCalcular;
    }
}

