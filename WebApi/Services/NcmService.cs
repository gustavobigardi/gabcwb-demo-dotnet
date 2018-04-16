using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class NcmService
    {
        private readonly NcmRepository _repository;

        public NcmService(NcmRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Ncm>> ListNcm() 
        {
            return await _repository.List();
        }

        public async Task<Ncm> GetByFullCode(string code)
        {
            return await _repository.GetByFullCode(code);
        }
    }
}