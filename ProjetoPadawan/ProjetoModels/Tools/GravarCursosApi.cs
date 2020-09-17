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
            var url = "https://localhost:5001/CursoController/cadastrarcurso";
            var httpClient = new HttpClient();
            var serializedObject = JsonConvert.SerializeObject(curso);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(url, content);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            return result.Result;
        }
    }
}
