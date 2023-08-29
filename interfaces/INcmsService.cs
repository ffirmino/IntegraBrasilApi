using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.interfaces
{
    public interface INcmsService
    {
        Task<ResponseGenerico<List<NcmsResponse>>> BuscarTodos();
        Task<ResponseGenerico<NcmsResponse>> BuscarNcms(string codigoNcms);
    }
}