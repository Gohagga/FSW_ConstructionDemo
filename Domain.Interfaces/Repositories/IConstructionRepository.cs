using Domain.Entities.Construction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IConstructionRepository
    {
        Trail GetTrailById(string id);

        Task<Trail> GetTrailByIdAsync(string id);
    }
}
