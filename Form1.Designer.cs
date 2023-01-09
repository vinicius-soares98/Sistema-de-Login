namespace SistemaDeLogin
{
	partial class frmLogin
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
			this.pnlEsquerda = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlCima = new System.Windows.Forms.Panel();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.pnlBaixo = new System.Windows.Forms.Panel();
			this.pnlDireita = new System.Windows.Forms.Panel();
			this.pnlEsquerda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlEsquerda
			// 
			this.pnlEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.pnlEsquerda.Controls.Add(this.button1);
			this.pnlEsquerda.Controls.Add(this.pictureBox1);
			this.pnlEsquerda.Controls.Add(this.label1);
			this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlEsquerda.Location = new System.Drawing.Point(0, 0);
			this.pnlEsquerda.Name = "pnlEsquerda";
			this.pnlEsquerda.Size = new System.Drawing.Size(121, 356);
			this.pnlEsquerda.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = global::SistemaDeLogin.Properties.Resources.icons8_shutdown_25px;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(0, 321);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 35);
			this.button1.TabIndex = 2;
			this.button1.Text = "Fechar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SistemaDeLogin.Properties.Resources.icons8_user_group_90px;
			this.pictureBox1.Location = new System.Drawing.Point(12, 157);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 107);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(5, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// pnlCima
			// 
			this.pnlCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.pnlCima.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCima.Location = new System.Drawing.Point(121, 0);
			this.pnlCima.Name = "pnlCima";
			this.pnlCima.Size = new System.Drawing.Size(440, 21);
			this.pnlCima.TabIndex = 1;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblUsuario.Location = new System.Drawing.Point(202, 94);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(77, 25);
			this.lblUsuario.TabIndex = 2;
			this.lblUsuario.Text = "Usuário";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(202, 122);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(267, 23);
			this.txtUsuario.TabIndex = 3;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(202, 176);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(267, 23);
			this.txtSenha.TabIndex = 5;
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSenha.Location = new System.Drawing.Point(202, 148);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(64, 25);
			this.lblSenha.TabIndex = 4;
			this.lblSenha.Text = "Senha";
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnEntrar.FlatAppearance.BorderSize = 0;
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnEntrar.Location = new System.Drawing.Point(202, 205);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(128, 30);
			this.btnEntrar.TabIndex = 6;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnCadastrar.FlatAppearance.BorderSize = 0;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCadastrar.Location = new System.Drawing.Point(341, 205);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(128, 30);
			this.btnCadastrar.TabIndex = 7;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// pnlBaixo
			// 
			this.pnlBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.pnlBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBaixo.Location = new System.Drawing.Point(121, 335);
			this.pnlBaixo.Name = "pnlBaixo";
			this.pnlBaixo.Size = new System.Drawing.Size(440, 21);
			this.pnlBaixo.TabIndex = 8;
			// 
			// pnlDireita
			// 
			this.pnlDireita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlDireita.Location = new System.Drawing.Point(540, 21);
			this.pnlDireita.Name = "pnlDireita";
			this.pnlDireita.Size = new System.Drawing.Size(21, 314);
			this.pnlDireita.TabIndex = 9;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 356);
			this.Controls.Add(this.pnlDireita);
			this.Controls.Add(this.pnlBaixo);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.pnlCima);
			this.Controls.Add(this.pnlEsquerda);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.pnlEsquerda.ResumeLayout(false);
			this.pnlEsquerda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel pnlEsquerda;
		private Label label1;
		private Panel pnlCima;
		private PictureBox pictureBox1;
		private Button button1;
		private Label lblUsuario;
		private TextBox txtUsuario;
		private TextBox txtSenha;
		private Label lblSenha;
		private Button btnEntrar;
		private Button btnCadastrar;
		private Panel pnlBaixo;
		private Panel pnlDireita;
	}
}