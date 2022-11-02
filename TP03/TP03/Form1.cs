using System;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Json;
using System.Collections.Generic;

namespace TP03
{
    public partial class Form1 : Form
    {
        string URI = "";
        int codigoLivro = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void GetAllLivros()
        {
            URI = txtUri.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var LivroJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Livro[]>(LivroJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o Livro : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetLivroById(int codLivro)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URI = txtUri.Text + "/" + codLivro.ToString();
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var LivroJsonString = await response.Content.ReadAsStringAsync();
                    bsDados.DataSource = JsonConvert.DeserializeObject<Livro>(LivroJsonString);
                    dgvDados.DataSource = bsDados;
                }
                else
                {
                    MessageBox.Show("Falha ao obter o Livro : " + response.StatusCode);
                }
            }
        }

        private async void AddLivro()
        {
            URI = txtUri.Text;
            Livro livro = new Livro();
            List<String> atributos = InputBoxAddLivro();
            livro.Titulo = atributos[0];
            livro.Subtitulo = atributos[1];
            livro.Resumo = atributos[2];
            livro.Autor = atributos[3];
            using (var client = new HttpClient())
            {
                var serializedLivro = JsonConvert.SerializeObject(livro);
                var content = new StringContent(serializedLivro, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
            GetAllLivros();
        }

        private async void UpdateLivro(int codLivro)
        {
            URI = txtUri.Text;
            Livro livro = new Livro();
            List<String> atributos = InputBoxAddLivro();
            livro.Id = codLivro;
            livro.Titulo = atributos[0];
            livro.Subtitulo = atributos[1];
            livro.Resumo = atributos[2];
            livro.Autor = atributos[3];

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + livro.Id, livro);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Livro atualizado");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o Livro : " + responseMessage.StatusCode);
                }
            }
            GetAllLivros();
        }

        private async void DeleteLivro(int codLivro)
        {
            URI = txtUri.Text;
            int LivroId = codLivro;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, LivroId));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Livro excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o Livro  : " + responseMessage.StatusCode);
                }
            }
            GetAllLivros();
        }

        private void InputBox()
        {
            // usando a função VB.Net para exibir um prompt para o usuário informar a senha
            string Prompt = "Informe o código do Livro.";
            string Titulo = "Livro";
            string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "9", 600, 350);
            // verifica se o resultado é uma string vazia o que indica que foi cancelado.
            if (Resultado != "")
            {
                codigoLivro = Convert.ToInt32(Resultado);
            }
            else
            {
                codigoLivro = -1;
            }
        }

        private List<string> InputBoxAddLivro()
        {
            // usando a função VB.Net para exibir um prompt para o usuário informar a senha
            string Prompt = "Título do Livro";
            string Titulo = "Adicionar Livro";
            List<string> Atributos = new List<string>();
            Atributos.Add(Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "9", 600, 350));
            Prompt = "Subtítulo do Livro";
            Atributos.Add(Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "9", 600, 350));
            Prompt = "Resumo do Livro";
            Atributos.Add(Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "9", 600, 350));
            Prompt = "Autor do Livro";
            Atributos.Add(Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "9", 600, 350));
            return Atributos;
        }
        private void btnObterLivros_Click(object sender, EventArgs e)
        {
            GetAllLivros();
        }

        private void btnLivrosPorId_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoLivro != -1)
            {
                GetLivroById(codigoLivro);
            }
        }

        private void btnIncluirLivro_Click(object sender, EventArgs e)
        {
            AddLivro();
        }

        private void btnAtualizaLivro_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoLivro != -1)
            {
                UpdateLivro(codigoLivro);
            }
        }

        private void btnDeletarLivro_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoLivro != -1)
            {
                DeleteLivro(codigoLivro);
            }
        }
    }
}
