namespace SistemaDeLogin
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtUsuario.Text) || String.IsNullOrWhiteSpace(txtSenha.Text))
			{
				MessageBox.Show("Preencha os campos em branco!");
			}
			else
			{
				ConexaoBanco conexaoBanco = new ConexaoBanco();
				
				if(conexaoBanco.verificaUsuario(txtUsuario.Text) == false)
				{
					conexaoBanco.cadastrar(txtUsuario.Text, txtSenha.Text);
					txtUsuario.Text = null; txtSenha.Text = null;
				}
				else
				{
					MessageBox.Show("Esse nome de usuário ja está em uso!");
				}
			}
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtUsuario.Text) || String.IsNullOrWhiteSpace(txtSenha.Text))
			{
				MessageBox.Show("Preencha os campos em branco!");
			}
			else
			{
				ConexaoBanco conexaoBanco = new ConexaoBanco();
				if(conexaoBanco.entrar(txtUsuario.Text, txtSenha.Text) == true)
				{
					frmSistema frmSistema= new frmSistema();
					frmSistema.Show();
				}
				else
				{
					MessageBox.Show("Usuário ou senha Inválido!");
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}