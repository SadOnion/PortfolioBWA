using Portfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Portfolio.Shared
{
    public interface ITechData
    {
        Task<TechnologyModel[]> FetchTechnologies();
    }
    public class TechData : ITechData
    {
        public TechData(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        HttpClient httpClient;
        TechnologyModel[] techs;
        public async Task<TechnologyModel[]> FetchTechnologies()
        {
            if(techs == null)
            {
                techs = await httpClient.GetFromJsonAsync<TechnologyModel[]>("data/Techs.json");
            }
            
            return techs;
        }
    }
}
