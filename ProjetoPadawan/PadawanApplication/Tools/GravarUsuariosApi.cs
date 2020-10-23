using Newtonsoft.Json;
using ProjetoModels.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ProjetoModels.Tools
{
    public class GravarUsuariosApi
    { 
        public string Add(Usuarios usuarios)
        {
            var url = "https://localhost:44360/UsuarioController/cadastrausuario";
            var httpClient = new HttpClient();
            var serializedObject = JsonConvert.SerializeObject(usuarios);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(url, content);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            return result.ToString();
        }
        public string Deletar(string usuario)
        {
            var url = "https://localhost:44360/UsuarioController/deletarusuario";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync(url + $"?cpf={usuario}");  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            //var resultado = JsonConvert.DeserializeObject<string>(result.Result);
            return result.ToString();
        }
        public List<Usuarios> Result()
        {
            var url = "https://localhost:44360/UsuarioController/verificausuario";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var retorno = JsonConvert.DeserializeObject<List<Usuarios>>(result.Result);
            return retorno;
        }
    }
}
