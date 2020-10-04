namespace Atividade_Avaliativa_1___POO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAlterarMarcha = new System.Windows.Forms.Button();
            this.btnAcelerar1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnFrear1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1036, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Painel De Controle (Carro Padrão)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "________________________________________________________________________";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnAlterarMarcha);
            this.groupBox2.Controls.Add(this.btnAcelerar1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btnFrear1);
            this.groupBox2.Location = new System.Drawing.Point(38, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 286);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Métodos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(497, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 30);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAlterarMarcha
            // 
            this.btnAlterarMarcha.Location = new System.Drawing.Point(271, 208);
            this.btnAlterarMarcha.Name = "btnAlterarMarcha";
            this.btnAlterarMarcha.Size = new System.Drawing.Size(210, 49);
            this.btnAlterarMarcha.TabIndex = 23;
            this.btnAlterarMarcha.Text = "Alterar Marcha";
            this.btnAlterarMarcha.UseVisualStyleBackColor = true;
            this.btnAlterarMarcha.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAcelerar1
            // 
            this.btnAcelerar1.Location = new System.Drawing.Point(271, 29);
            this.btnAcelerar1.Name = "btnAcelerar1";
            this.btnAcelerar1.Size = new System.Drawing.Size(210, 49);
            this.btnAcelerar1.TabIndex = 20;
            this.btnAcelerar1.Text = "Acelerar";
            this.btnAcelerar1.UseVisualStyleBackColor = true;
            this.btnAcelerar1.Click += new System.EventHandler(this.btnAcelerar1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(222, 49);
            this.button5.TabIndex = 22;
            this.button5.Text = "Imprimir Dados";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFrear1
            // 
            this.btnFrear1.Location = new System.Drawing.Point(271, 117);
            this.btnFrear1.Name = "btnFrear1";
            this.btnFrear1.Size = new System.Drawing.Size(210, 49);
            this.btnFrear1.TabIndex = 21;
            this.btnFrear1.Text = "Frear";
            this.btnFrear1.UseVisualStyleBackColor = true;
            this.btnFrear1.Click += new System.EventHandler(this.btnFrear1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(429, 79);
            this.button2.TabIndex = 2;
            this.button2.Text = "Carro Personalizado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1058, 510);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículo ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAlterarMarcha;
        private System.Windows.Forms.Button btnAcelerar1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnFrear1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

