namespace Recibo_Marcenaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Rg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.teste = new System.Windows.Forms.Label();
            this.txt_Referente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(92, 108);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(381, 27);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rg:";
            // 
            // txt_Rg
            // 
            this.txt_Rg.Location = new System.Drawing.Point(513, 108);
            this.txt_Rg.Name = "txt_Rg";
            this.txt_Rg.Size = new System.Drawing.Size(220, 27);
            this.txt_Rg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(92, 177);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(641, 27);
            this.txt_Endereco.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Recebido: R$";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(152, 248);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(101, 27);
            this.txt_Valor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(152, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(452, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vasco Marcenaria - Recibo de Pagamento";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Location = new System.Drawing.Point(610, 314);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(123, 42);
            this.btn_Exportar.TabIndex = 11;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // teste
            // 
            this.teste.AutoSize = true;
            this.teste.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teste.Location = new System.Drawing.Point(12, 369);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(197, 17);
            this.teste.TabIndex = 12;
            this.teste.Text = "2022-®VascoMarcenaria";
            // 
            // txt_Referente
            // 
            this.txt_Referente.Location = new System.Drawing.Point(424, 248);
            this.txt_Referente.Name = "txt_Referente";
            this.txt_Referente.Size = new System.Drawing.Size(309, 27);
            this.txt_Referente.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Referente:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 395);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Referente);
            this.Controls.Add(this.teste);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Rg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VascoMarcenaria-Recibos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_Nome;
        private Label label2;
        private TextBox txt_Rg;
        private Label label3;
        private TextBox txt_Endereco;
        private Label label4;
        private TextBox txt_Valor;
        private Label label5;
        private Button btn_Exportar;
        private Label teste;
        private TextBox txt_Referente;
        private Label label7;
    }
}