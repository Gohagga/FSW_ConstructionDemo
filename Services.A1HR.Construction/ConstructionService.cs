using Domain.Entities.Construction;
using Domain.Interfaces.Repositories;
using Services.Interfaces.A1HR.Construction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.A1HR.Construction
{
    public class ConstructionService : IConstructionService
    {
        private readonly IConstructionRepository _repository;

        public ConstructionService(IConstructionRepository repository)
        {
            _repository = repository;
        }
        public Trail GetTrailById(string id)
        {
            return _repository.GetTrailById(id);
        }

        public async Task<Trail> GetTrailByIdAsync(string id)
        {
            return await _repository.GetTrailByIdAsync(id);
        }
    }
}
