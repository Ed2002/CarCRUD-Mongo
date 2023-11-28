using CarCrudDominio.Entidades;

namespace CarCrudDominio.Repositorios
{
    public interface IModeloRepositorio
    {
        Task Inserir(Modelo modelo);
        Task Alterar(Modelo modelo);
        List<Modelo> Listar();
        Modelo BuscarId(long id);
    }
}
