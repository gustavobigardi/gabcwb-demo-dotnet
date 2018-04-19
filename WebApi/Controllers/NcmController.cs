using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class NcmController : Controller
    {
        private readonly NcmService _service;

        public NcmController(NcmService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Ncm>> List()
        {
            return await _service.ListNcm();
        }

        [HttpGet("{code}")]
        public async Task<Ncm> Get(string code)
        {
            var ncm = await _service.GetByFullCode(code);
            TelemetryClient client = new TelemetryClient();
            if (ncm != null) {
                Dictionary<string, string> dados = new Dictionary<string, string>();
                dados["DadosCotacao"] = JsonConvert.SerializeObject(ncm);
                client.TrackEvent("Dapper", dados);
            }
            else {
                client.TrackMetric("NCM_NOT_FOUND", 1);
            }

            return ncm;
        }
    }
}