namespace ConFin
{
    partial class FrmPrincipal
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
            this.buttonConexao = new System.Windows.Forms.Button();
            this.buttonExecuta = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonInclui = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConexao
            // 
            this.buttonConexao.Location = new System.Drawing.Point(12, 12);
            this.buttonConexao.Name = "buttonConexao";
            this.buttonConexao.Size = new System.Drawing.Size(75, 23);
            this.buttonConexao.TabIndex = 0;
            this.buttonConexao.Text = "Conexão";
            this.buttonConexao.UseVisualStyleBackColor = true;
            this.buttonConexao.Click += new System.EventHandler(this.buttonConexao_Click);
            // 
            // buttonExecuta
            // 
            this.buttonExecuta.Location = new System.Drawing.Point(12, 51);
            this.buttonExecuta.Name = "buttonExecuta";
            this.buttonExecuta.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuta.TabIndex = 1;
            this.buttonExecuta.Text = "Listar";
            this.buttonExecuta.UseVisualStyleBackColor = true;
            this.buttonExecuta.Click += new System.EventHandler(this.buttonExecuta_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // buttonInclui
            // 
            this.buttonInclui.Location = new System.Drawing.Point(93, 51);
            this.buttonInclui.Name = "buttonInclui";
            this.buttonInclui.Size = new System.Drawing.Size(75, 23);
            this.buttonInclui.TabIndex = 3;
            this.buttonInclui.Text = "Inclui";
            this.buttonInclui.UseVisualStyleBackColor = true;
            this.buttonInclui.Click += new System.EventHandler(this.buttonInclui_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(174, 51);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 4;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(255, 51);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 5;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 233);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInclui);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonExecuta);
            this.Controls.Add(this.buttonConexao);
            this.Name = "FrmPrincipal";
            this.Text = "ConFin - Controle Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConexao;
        private System.Windows.Forms.Button buttonExecuta;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonInclui;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
    }
}

