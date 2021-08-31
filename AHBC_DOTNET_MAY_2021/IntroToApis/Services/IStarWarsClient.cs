using IntroToApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToApis.Services
{
    public interface IStarWarsClient
    {
        //We need the actual model
        Task<StarWarsPeopleResponse> GetPeopleAsync();

        //Task<Plantet> GetPlanet();
    }
}
