using Newtonsoft.Json;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ProjetoModels.Tools
{
    public class GravarCursosApi
    {
        public string Add(Cursos curso)
        {
            var url = "https://localhost:44360/CursoController/cadastrarcurso";
            var httpClient = new HttpClient();
            var serializedObject = JsonConvert.SerializeObject(curso);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(url, content);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            return result.Result;
        }
        public string Deletar(string nome)
        {
            var url = "https://localhost:44360/CursoController/deletarcurso";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync(url + $"?nome={nome}");  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            //var resultado = JsonConvert.DeserializeObject<string>(result.Result);
            return result.ToString();
        }
        public List<Cursos> Result()
        {
            var url = "https://localhost:44360/CursoController/listarcurso";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var retorno = JsonConvert.DeserializeObject<List<Cursos>>(result.Result);
            return retorno;
        }
    }
}
