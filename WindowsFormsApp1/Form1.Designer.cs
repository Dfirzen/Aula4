namespace WindowsFormsApp1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_nome = new System.Windows.Forms.TextBox();
            this.txtbox_endereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_usuario = new System.Windows.Forms.TextBox();
            this.txtbox_senha = new System.Windows.Forms.TextBox();
            this.txtbox_estado = new System.Windows.Forms.ComboBox();
            this.btenviar = new System.Windows.Forms.Button();
            this.btfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(130, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usúario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.Location = new System.Drawing.Point(206, 90);
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nome.TabIndex = 6;
            // 
            // txtbox_endereco
            // 
            this.txtbox_endereco.Location = new System.Drawing.Point(206, 157);
            this.txtbox_endereco.Name = "txtbox_endereco";
            this.txtbox_endereco.Size = new System.Drawing.Size(100, 20);
            this.txtbox_endereco.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Meu primeiro formulário";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(206, 235);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(100, 20);
            this.txtbox_email.TabIndex = 9;
            // 
            // txtbox_usuario
            // 
            this.txtbox_usuario.Location = new System.Drawing.Point(496, 150);
            this.txtbox_usuario.Name = "txtbox_usuario";
            this.txtbox_usuario.Size = new System.Drawing.Size(100, 20);
            this.txtbox_usuario.TabIndex = 10;
            // 
            // txtbox_senha
            // 
            this.txtbox_senha.Location = new System.Drawing.Point(496, 214);
            this.txtbox_senha.Name = "txtbox_senha";
            this.txtbox_senha.PasswordChar = '*';
            this.txtbox_senha.Size = new System.Drawing.Size(100, 20);
            this.txtbox_senha.TabIndex = 11;
            // 
            // txtbox_estado
            // 
            this.txtbox_estado.AutoCompleteCustomSource.AddRange(new string[] {
            "SP",
            "RJ",
            "MG",
            "BA",
            "AM",
            "CE"});
            this.txtbox_estado.FormattingEnabled = true;
            this.txtbox_estado.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "BA",
            "AM",
            "CE"});
            this.txtbox_estado.Location = new System.Drawing.Point(496, 90);
            this.txtbox_estado.Name = "txtbox_estado";
            this.txtbox_estado.Size = new System.Drawing.Size(121, 21);
            this.txtbox_estado.TabIndex = 12;
            // 
            // btenviar
            // 
            this.btenviar.Location = new System.Drawing.Point(626, 337);
            this.btenviar.Name = "btenviar";
            this.btenviar.Size = new System.Drawing.Size(105, 44);
            this.btenviar.TabIndex = 13;
            this.btenviar.Text = "Enviar";
            this.btenviar.UseVisualStyleBackColor = true;
            this.btenviar.Click += new System.EventHandler(this.btenviar_Click);
            // 
            // btfechar
            // 
            this.btfechar.Location = new System.Drawing.Point(491, 337);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(105, 44);
            this.btfechar.TabIndex = 14;
            this.btfechar.Text = "Fechar";
            this.btfechar.UseVisualStyleBackColor = true;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.btenviar);
            this.Controls.Add(this.txtbox_estado);
            this.Controls.Add(this.txtbox_senha);
            this.Controls.Add(this.txtbox_usuario);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_endereco);
            this.Controls.Add(this.txtbox_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_nome;
        private System.Windows.Forms.TextBox txtbox_endereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_usuario;
        private System.Windows.Forms.TextBox txtbox_senha;
        private System.Windows.Forms.ComboBox txtbox_estado;
        private System.Windows.Forms.Button btenviar;
        private System.Windows.Forms.Button btfechar;
    }
}

