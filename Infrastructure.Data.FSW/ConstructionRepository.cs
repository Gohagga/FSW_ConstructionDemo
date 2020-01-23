using Domain.Entities.Construction;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.FSW
{
    public class ConstructionRepository : IConstructionRepository
    {
        public Trail GetTrailById(string id)
        {
            Trail retVal = null;

            // Use reference to RI, nuget package or helper to perform necessary communication with RI
            retVal = new Trail() { Id = "RI:///0.123" };

            return retVal;
        }

        public async Task<Trail> GetTrailByIdAsync(string id)
        {
            Trail retVal = null;

            // Use reference to RI, nuget package or helper to perform necessary communication with RI
            if (id == "123") {
                retVal = await Task.FromResult(new Trail() { Id = "RI:///0.123" });
            }

            return retVal;
        }
    }
}
