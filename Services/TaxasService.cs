using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.interfaces;
using IntegraBrasilApi.Models;


namespace IntegraBrasilApi.Services
{
    public class TaxasService : ITaxasService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public TaxasService(IMapper mapper, IBrasilApi brasilApi)
        {
             _mapper = mapper;
            _brasilApi = brasilApi;
        }        

        public async Task<ResponseGenerico<TaxasResponse>> BuscarTaxas(string sigla)
        {
            var taxas = await _brasilApi.BuscarTaxas(sigla);
            return _mapper.Map<ResponseGenerico<TaxasResponse>>(taxas);
            
        }

        public async Task<ResponseGenerico<List<TaxasModel>>> BuscarTodasTaxas()
        {
           var taxas = await _brasilApi.BuscarTodasTaxas();
            return taxas;
        }
    }
}