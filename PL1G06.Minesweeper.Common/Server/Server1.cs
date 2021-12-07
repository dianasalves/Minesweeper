using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace PL1G06.Minesweeper.Common.Server
{
	public class Server1
	{
		public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		//função para fazer o registo do utilizador
		public XDocument PostRegisto(string fotografia, string username, string password, string nome, string email, string pais)
		{
			try
			{
				// Com o acesso usa HTTPS e o servidor usar cerificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado.
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				// prepara o pedido para o servidor com o url adequado (para registos)
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/registo");

				// prepara os dados do pedido a partir de uma string só com a estrutura do XML (sem dados)
				XDocument xmlPedido = XDocument.Parse("<registo><nomeabreviado></nomeabreviado><username></username><password></password><email></email><fotografia></fotografia><pais></pais></registo>");

				//preenche os dados do xml
				
				xmlPedido.Element("registo").Element("nomeabreviado").Value = nome;
				xmlPedido.Element("registo").Element("username").Value = username;
				xmlPedido.Element("registo").Element("password").Value = password;
				xmlPedido.Element("registo").Element("email").Value = email;
				xmlPedido.Element("registo").Element("fotografia").Value = fotografia;
				xmlPedido.Element("registo").Element("pais").Value = pais;

				string mensagem = xmlPedido.Root.ToString();

				byte[] data = Encoding.Default.GetBytes(mensagem);

				request.Method = "POST";  //metodo usado para receber o pedido
				request.ContentType = "text/xml;charset=utf-8"; //tipo de dados que e enviado com o pedido
				request.ContentLength = mensagem.Length;   // comprimento dos dados enviados no pedido 

				Stream newStream = request.GetRequestStream(); //obtem a referencia do stream associado ao pedido
				newStream.Write(data, 0, data.Length);   //permite escrever os dados que vão ser enviados para o servidor
				newStream.Close();

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();  //faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); //obterm o stream associado à resposta
				StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8); //canaliza o stream para um leitor de stream de nível superior com o formato de codificação necessário
				string resultado = readStream.ReadToEnd();
				response.Close();
				readStream.Close();

				//converte o objeto xml para facilitar a extração da informação
				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch(Exception e)
			{
				throw e;
			}
		}

		//Função para fazer o login do utilizador
		public XDocument PostLogins(string username, string password)
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/autentica");

				// Com o acesso usa HTTPS e o servidor usar cerificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado. 
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				// prepara os dados do pedido a partir de uma string só com a estrutura do XML (sem dados) 
				XDocument xmlPedido = XDocument.Parse("<credenciais><username></username><password></password></credenciais>");

				xmlPedido.Element("credenciais").Element("username").Value = username;
				xmlPedido.Element("credenciais").Element("password").Value = password;

				string mensagem = xmlPedido.Root.ToString();

				byte[] data = Encoding.Default.GetBytes(mensagem);
				request.Method = "POST";// método usado para enviar o pedido 
				request.ContentType = "application/xml"; // tipo de dados que é enviado com o pedido 
				request.ContentLength = data.Length; // comprimento dos dados enviado no pedido 

				Stream newStream = request.GetRequestStream(); // obtem a referência do stream associado ao pedido... 
				newStream.Write(data, 0, data.Length);// ... que permite escrever os dados a ser enviados ao servidor 
				newStream.Close();

				HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); // obtem o stream associado à resposta. 
				StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8); // Canaliza o stream para um leitor de stream de nível superior com o formato de codificação necessário. 
				string resultado = readStream.ReadToEnd();
				response.Close();
				readStream.Close();

				// converte para objeto XML para facilitar a extração da informação e ... 
				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		//Função para regitar os resultados do jogador  
		public XDocument PostRegistarResultado(string id, string nivel, string tempo, string vitoria)
		{
			try
            {
				// Com o acesso usa HTTPS e o servidor usar cerificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado. 
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				// prepara o pedido para o servidor com o url adequado (para registo do jogo)
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/resultado/" + id);

				// prepara os dados do pedido a partir de uma string só com a estrutura do XML (sem dados) 
				XDocument xmlPedido = XDocument.Parse("<resultado_jogo><nivel></nivel><tempo></tempo><vitoria></vitoria></resultado_jogo>");

				xmlPedido.Element("resultado_jogo").Element("nivel").Value = nivel;           //nivel do jogo (Facil ou Medio)
				xmlPedido.Element("resultado_jogo").Element("tempo").Value = tempo;           //tempo gasto no jogo, em segundos
				xmlPedido.Element("resultado_jogo").Element("vitoria").Value = vitoria;       //vitoria (True ou False)

				string mensagem = xmlPedido.Root.ToString();

				byte[] data = Encoding.Default.GetBytes(mensagem);
				request.Method = "POST";// método usado para enviar o pedido 
				request.ContentType = "text/xml;charset=utf-8"; // tipo de dados que é enviado com o pedido 
				request.ContentLength = mensagem.Length; // comprimento dos dados enviado no pedido 

				Stream newStream = request.GetRequestStream(); // obtem a referência do stream associado ao pedido... 
				newStream.Write(data, 0, data.Length);// ... que permite escrever os dados a ser enviados ao servidor 
				newStream.Close();

				HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); // obtem o stream associado à resposta. 
				StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8); // Canaliza o stream para um leitor de stream de nível superior com o formato de codificação necessário. 
				string resultado = readStream.ReadToEnd();
				response.Close();
				readStream.Close();

				// converte para objeto XML para facilitar a extração da informação e ... 
				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		//Função para pedir a consulta do perfil do jogador ao servidor::
		public XDocument GetPerfil(string username)
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/perfil/" + username);

				// Com o acesso usa HTTPS e o servidor usar cerificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado. 
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				request.Method = "GET";

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();   //faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); //obtém o stream associado à resposta
				StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8); //canaliza o stream para um leitor de stream de nível superiror com o formato de codificaçõa necessário

				string resultado = reader.ReadToEnd();
				response.Close();
				reader.Close();

				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		//função para pedir novo jogo ao servidor
		public XDocument GetPedirNovoJogo(string nivel, string id)
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/novo/" + nivel + "/" + id);

				// Com o acesso usa HTTPS e o servidor usar cerificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado. 
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				request.Method = "GET";

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();   //faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); //obtém o stream associado à resposta
				StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8); //canaliza o stream para um leitor de stream de nível superiror com o formato de codificaçõa necessário

				string resultado = reader.ReadToEnd();
				response.Close();
				reader.Close();

				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		public XDocument GetConsultarTOP10()
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/top10");

				// Com o acesso usa HTTPS e o servidor usar cerificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado. 
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				request.Method = "GET";

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();   //faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); //obtém o stream associado à resposta
				StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8); //canaliza o stream para um leitor de stream de nível superiror com o formato de codificaçõa necessário

				string resultado = reader.ReadToEnd();
				response.Close();
				reader.Close();

				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
