using Domain.Entities.Construction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.A1HR.Construction
{
    public interface IConstructionService
    {
        Trail GetTrailById(string id);
        Task<Trail> GetTrailByIdAsync(string id);
    }
}
