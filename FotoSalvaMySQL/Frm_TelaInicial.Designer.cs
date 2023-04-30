namespace FotoSalvaMySQL
{
    partial class Frm_TelaInicial
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
            this.Pb_foto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.TextBox();
            this.Btn_AdicionarFoto = new System.Windows.Forms.Button();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_foto
            // 
            this.Pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_foto.Location = new System.Drawing.Point(103, 74);
            this.Pb_foto.Name = "Pb_foto";
            this.Pb_foto.Size = new System.Drawing.Size(204, 239);
            this.Pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_foto.TabIndex = 0;
            this.Pb_foto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.Location = new System.Drawing.Point(103, 28);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(204, 20);
            this.Lbl_Nome.TabIndex = 2;
            // 
            // Btn_AdicionarFoto
            // 
            this.Btn_AdicionarFoto.Location = new System.Drawing.Point(154, 319);
            this.Btn_AdicionarFoto.Name = "Btn_AdicionarFoto";
            this.Btn_AdicionarFoto.Size = new System.Drawing.Size(89, 23);
            this.Btn_AdicionarFoto.TabIndex = 3;
            this.Btn_AdicionarFoto.Text = "Adicionar  foto";
            this.Btn_AdicionarFoto.UseVisualStyleBackColor = true;
            this.Btn_AdicionarFoto.Click += new System.EventHandler(this.Btn_AdicionarFoto_Click);
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Location = new System.Drawing.Point(154, 391);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Enviar.TabIndex = 4;
            this.Btn_Enviar.Text = "Enviar";
            this.Btn_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.Btn_AdicionarFoto);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pb_foto);
            this.Name = "Frm_TelaInicial";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_foto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lbl_Nome;
        private System.Windows.Forms.Button Btn_AdicionarFoto;
        private System.Windows.Forms.Button Btn_Enviar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

