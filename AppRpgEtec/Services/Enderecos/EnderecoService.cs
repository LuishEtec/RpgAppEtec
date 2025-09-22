using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppRpgEtec.Models;
using static System.Net.WebRequestMethods;

namespace AppRpgEtec.Services.Enderecos
{
    public class EnderecoService
    {
        private readonly Request _request;
        private const string _apiUrlBase = "https://rpgapi3ai2025.azurewebsites.net/Enderecos";
        //Azure: https://rpgapi3ai2025.azurewebsites.net/Enderecos
        //Somee: http://luizfernando.somee.com/RpgApi/Enderecos

        public EnderecoService()
        {
            _request = new Request();
        }
        public async Task<List<Endereco>>GetEnderecoByCep(string cep)
        {
            string url = $"https://nominatim.openstreetmap.org/search?format=json&q={cep}";
                return await
                _request.GetAsync<List<Endereco>>(url);
        }
        
    }
}
