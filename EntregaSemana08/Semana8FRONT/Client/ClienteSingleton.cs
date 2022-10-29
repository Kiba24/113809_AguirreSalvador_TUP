using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8FRONT.Client
{
    internal class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient httpClient;

        private  ClienteSingleton()
        {
            httpClient = new HttpClient();
        }

        public static ClienteSingleton GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new ClienteSingleton();
            }
            return instancia;
        }

        //Metodos del cliente

        public async Task<string> GetCarrerasAsync(string url)
        {
            var result = await httpClient.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
            {
                content = await result.Content.ReadAsStringAsync();
            }
            return content;
        }
        
        public async Task<string> getDetallesAsync(string url)
        {
            var result = await httpClient.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
            {
                content = await result.Content.ReadAsStringAsync();
            }

            return content;
        }

        public async Task<string> PostAsync(string url, string data)
        {
            //Solo se le agrega un paso en el que le decimos que es un json el conentido
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await httpClient.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

    }
}
