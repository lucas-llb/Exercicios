using Newtonsoft.Json;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ProjetoModels.Tools
{
    public class GravarAlunoApi
    {
        public string Add(Alunos alunos)
        {
            var url = "https://localhost:44360/AlunoController/cadastraraluno";
            var httpClient = new HttpClient();
            var serializedObject = JsonConvert.SerializeObject(alunos);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(url, content);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            //var resultado = JsonConvert.DeserializeObject<string>(result.Result);
            return result.ToString();
        } 
        public string Deletar(string cpf)
        {
            var url = "https://localhost:44360/AlunoController/deletaraluno";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync(url+ $"?cpf={cpf}");  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
           //var resultado = JsonConvert.DeserializeObject<string>(result.Result);
            return result.ToString();
        }
        public List<Alunos> Result()
        {
            var url = "https://localhost:44360/AlunoController/listaraluno";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var retorno = JsonConvert.DeserializeObject<List<Alunos>>(result.Result);
            return retorno;
        }
    }
}
