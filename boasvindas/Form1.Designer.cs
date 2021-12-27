namespace boasvindas
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
            this.btnBoasVindas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBoasVindas
            // 
            this.btnBoasVindas.Location = new System.Drawing.Point(150, 60);
            this.btnBoasVindas.Name = "btnBoasVindas";
            this.btnBoasVindas.Size = new System.Drawing.Size(112, 34);
            this.btnBoasVindas.TabIndex = 0;
            this.btnBoasVindas.Text = "Clique aqui";
            this.btnBoasVindas.UseVisualStyleBackColor = true;
            this.btnBoasVindas.Click += new System.EventHandler(this.btnBoasVindas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem vindo ao c#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.AutoSize = true;
            this.TxtNome.Location = new System.Drawing.Point(35, 203);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(158, 25);
            this.TxtNome.TabIndex = 2;
            this.TxtNome.Text = "Digite o seu nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 413);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoasVindas);
            this.Name = "Form1";
            this.Text = "Aula 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBoasVindas;
        private Label label1;
        private Label TxtNome;
    }
}