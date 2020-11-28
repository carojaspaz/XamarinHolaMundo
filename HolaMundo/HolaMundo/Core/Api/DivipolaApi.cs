using HolaMundo.Core.Api.Base;
using HolaMundo.Core.Helpers;
using HolaMundo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.Core.Api
{
    public class DivipolaApi : ApiBase
    {
        private List<EntityDivisionModel> _entityDivisions;
        public DivipolaApi():
            base(Constants.ApiConstants.urlBase)
        { }

        public async Task<List<EntityDivisionModel>> GetStatesAsync(string countryCode)
        {
            try
            {
                Settings.ServiceError = false;
                _entityDivisions = new List<EntityDivisionModel>();
                var response = await Client.GetAsync(GetUrlApi($"countries/states/{countryCode}/"));
                if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                {
                    Settings.ServiceError = true;
                    throw new Exception();
                }
                string statesList = await response.Content.ReadAsStringAsync();
                _entityDivisions = JsonConvert.DeserializeObject<List<EntityDivisionModel>>(statesList);
                return _entityDivisions;
            } catch (Exception ex)
            {
                return new List<EntityDivisionModel>();
            }
        }
    }
}
