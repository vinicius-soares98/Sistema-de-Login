using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace SistemaDeLogin
{
	public class ConexaoBanco
	{
		SqlConnection conexao;
		SqlCommand comando;
		SqlDataReader dr;
		string strSQL;
		string path = @"Server=localhost\SQLEXPRESS;Database=Sistema;Trusted_Connection=True;";
		string confirmaUsuario, confrimaSenha;

		public void cadastrar(string usuario, string senha)
		{
			Criptografia criptografia = new Criptografia(SHA512.Create());
			string senhaCriptografada = criptografia.CriptografarSenha(senha);
			try
			{
				conexao = new SqlConnection(path);
				strSQL = $"INSERT INTO Usuarios (usuario, senha) VALUES ('{usuario}', '{senhaCriptografada}')";
				comando = new SqlCommand(strSQL, conexao);
				conexao.Open();
				comando.ExecuteNonQuery();
				MessageBox.Show("Cadastrado!");
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				conexao.Close();
			}
		}
		public bool entrar(string usuario, string senha)
		{
			Criptografia criptografia = new Criptografia(SHA512.Create());
			string senhaCriptografada = criptografia.CriptografarSenha(senha);
			try
			{
				conexao = new SqlConnection(path);
				strSQL = $"SELECT * FROM Usuarios";
				comando = new SqlCommand(strSQL, conexao);
				conexao.Open();
				dr = comando.ExecuteReader();
				while (dr.Read())
				{
					confirmaUsuario = (string)dr["usuario"];
					confrimaSenha = (string)dr["senha"];
				}
				if (usuario == confirmaUsuario && senhaCriptografada == confrimaSenha)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return false;
			}
			finally 
			{ 
				conexao.Close(); 
			}			
		}
		public bool verificaUsuario(string usuario)
		{
			strSQL = $"SELECT COUNT(1) FROM Usuarios WHERE usuario = '{usuario}'";
			conexao = new SqlConnection(path);
			comando = new SqlCommand(strSQL, conexao);
			conexao.Open();

			var result = comando.ExecuteScalar();
			if (result != null)
			{
				return (int)result > 0;
			}
			else
			{
				return false;
			}
		}				
	}
}
