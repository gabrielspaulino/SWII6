
namespace TP03
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
            this.labelUri = new System.Windows.Forms.Label();
            this.txtUri = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnObterLivros = new System.Windows.Forms.Button();
            this.btnLivrosPorId = new System.Windows.Forms.Button();
            this.btnIncluirLivro = new System.Windows.Forms.Button();
            this.btnAtualizaLivro = new System.Windows.Forms.Button();
            this.btnDeletaLivro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUri
            // 
            this.labelUri.AutoSize = true;
            this.labelUri.Location = new System.Drawing.Point(52, 44);
            this.labelUri.Name = "labelUri";
            this.labelUri.Size = new System.Drawing.Size(84, 15);
            this.labelUri.TabIndex = 0;
            this.labelUri.Text = "URI - Web API:";
            this.labelUri.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUri
            // 
            this.txtUri.Location = new System.Drawing.Point(145, 41);
            this.txtUri.Name = "txtUri";
            this.txtUri.Size = new System.Drawing.Size(569, 23);
            this.txtUri.TabIndex = 1;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(52, 81);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowTemplate.Height = 25;
            this.dgvDados.Size = new System.Drawing.Size(662, 301);
            this.dgvDados.TabIndex = 2;
            // 
            // btnObterLivros
            // 
            this.btnObterLivros.Location = new System.Drawing.Point(52, 389);
            this.btnObterLivros.Name = "btnObterLivros";
            this.btnObterLivros.Size = new System.Drawing.Size(127, 31);
            this.btnObterLivros.TabIndex = 3;
            this.btnObterLivros.Text = "Retomar Livros";
            this.btnObterLivros.UseVisualStyleBackColor = true;
            this.btnObterLivros.Click += new System.EventHandler(this.btnObterLivros_Click);
            // 
            // btnLivrosPorId
            // 
            this.btnLivrosPorId.Location = new System.Drawing.Point(188, 389);
            this.btnLivrosPorId.Name = "btnLivrosPorId";
            this.btnLivrosPorId.Size = new System.Drawing.Size(127, 31);
            this.btnLivrosPorId.TabIndex = 4;
            this.btnLivrosPorId.Text = "Obter Livro por ID";
            this.btnLivrosPorId.UseVisualStyleBackColor = true;
            this.btnLivrosPorId.Click += new System.EventHandler(this.btnLivrosPorId_Click);
            // 
            // btnIncluirLivro
            // 
            this.btnIncluirLivro.Location = new System.Drawing.Point(321, 389);
            this.btnIncluirLivro.Name = "btnIncluirLivro";
            this.btnIncluirLivro.Size = new System.Drawing.Size(127, 31);
            this.btnIncluirLivro.TabIndex = 5;
            this.btnIncluirLivro.Text = "Incluir Livro";
            this.btnIncluirLivro.UseVisualStyleBackColor = true;
            // 
            // btnAtualizaLivro
            // 
            this.btnAtualizaLivro.Location = new System.Drawing.Point(454, 388);
            this.btnAtualizaLivro.Name = "btnAtualizaLivro";
            this.btnAtualizaLivro.Size = new System.Drawing.Size(127, 31);
            this.btnAtualizaLivro.TabIndex = 6;
            this.btnAtualizaLivro.Text = "Atualizar Livro";
            this.btnAtualizaLivro.UseVisualStyleBackColor = true;
            // 
            // btnDeletaLivro
            // 
            this.btnDeletaLivro.Location = new System.Drawing.Point(587, 388);
            this.btnDeletaLivro.Name = "btnDeletaLivro";
            this.btnDeletaLivro.Size = new System.Drawing.Size(127, 31);
            this.btnDeletaLivro.TabIndex = 7;
            this.btnDeletaLivro.Text = "Deletar Livro";
            this.btnDeletaLivro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletaLivro);
            this.Controls.Add(this.btnAtualizaLivro);
            this.Controls.Add(this.btnIncluirLivro);
            this.Controls.Add(this.btnLivrosPorId);
            this.Controls.Add(this.btnObterLivros);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtUri);
            this.Controls.Add(this.labelUri);
            this.Name = "Form1";
            this.Text = "Consumindo Web API";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUri;
        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnObterLivros;
        private System.Windows.Forms.Button btnLivrosPorId;
        private System.Windows.Forms.Button btnIncluirLivro;
        private System.Windows.Forms.Button btnAtualizaLivro;
        private System.Windows.Forms.Button btnDeletaLivro;
    }
}

