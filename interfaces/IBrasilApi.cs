using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
        Task<ResponseGenerico<TaxasModel>> BuscarTaxas(string sigla);
        Task<ResponseGenerico<List<TaxasModel>>> BuscarTodasTaxas();
        Task<ResponseGenerico<NcmsModel>> BuscarNcms(string codigoNcms);
        Task<ResponseGenerico<List<NcmsModel>>> BuscarTodasNcms();
        
    }
}