using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;


namespace IntegraBrasilApi.interfaces
{
    public interface ITaxasService
    { 
        Task<ResponseGenerico<List<TaxasModel>>> BuscarTodasTaxas();       
        Task<ResponseGenerico<TaxasResponse>> BuscarTaxas(string sigla);
    }
}