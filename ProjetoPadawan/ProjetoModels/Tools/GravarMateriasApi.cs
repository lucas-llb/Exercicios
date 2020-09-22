using Newtonsoft.Json;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ProjetoModels.Tools
{
    public class GravarMateriasApi
    {
        public string Add(Materias materia)
        {
            var url = "https://localhost:44360/MateriaController/cadastrarmateria";
            var httpClient = new HttpClient();
            var serializedObject = JsonConvert.SerializeObject(materia);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(url, content);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            return result.Result;
        }
        public string Deletar(string nome)
        {
            var url = "https://localhost:44360/MateriaController/deletarmateria";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync(url + $"?nome={nome}");  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            //var resultado = JsonConvert.DeserializeObject<string>(result.Result);
            return result.ToString();
        }
        public List<Materias> Result()
        {
            var url = "https://localhost:44360/MateriaController/listarmaterias";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var retorno = JsonConvert.DeserializeObject<List<Materias>>(result.Result);
            return retorno;
        }
    }
}
