using CarCrudDominio.Entidades;

namespace CarCrudDominio.Repositorios
{
    public interface IMarcaRepositorio
    {
        Task Inserir(Marca marca);
        Task Alterar(Marca marca);
        Task Deletar(long Id);
        List<Marca> Listar();
        Marca BuscarId(long Id);
    }
}
