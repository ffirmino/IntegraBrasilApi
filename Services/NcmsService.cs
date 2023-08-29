using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.interfaces;

namespace IntegraBrasilApi.Services
{
    public class NcmsService : INcmsService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public NcmsService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<NcmsResponse>>> BuscarTodos()
        {
            var ncms = await _brasilApi.BuscarTodasNcms();
            return _mapper.Map<ResponseGenerico<List<NcmsResponse>>>(ncms);
        } 
        
        public async Task<ResponseGenerico<NcmsResponse>> BuscarNcms(string codigoNcms)
        {
            var ncms = await _brasilApi.BuscarNcms(codigoNcms);
            return _mapper.Map<ResponseGenerico<NcmsResponse>>(ncms);           
        }        
    }
}