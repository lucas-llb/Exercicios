using Newtonsoft.Json;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ProjetoModels.Tools
{
    public class GravarNotasApi
    {
        public string Add(Notas nota)
        {
            var url = "https://localhost:5001/NotasController/cadastrarnota";
            var httpClient = new HttpClient();
            var serializedObject = JsonConvert.SerializeObject(nota);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(url, content);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            return result.Result;
        }
        public string Deletar(int id)
        {
            var url = "https://localhost:5001/NotasController/deletarnotas";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync(url + $"?id={id}");  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<string>(result.Result);
            return resultado;
        }
        public List<Notas> Result()
        {
            var url = "https://localhost:5001/NotasController/listarnotas";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var retorno = JsonConvert.DeserializeObject<List<Notas>>(result.Result);
            return retorno;
        }
    }
}
