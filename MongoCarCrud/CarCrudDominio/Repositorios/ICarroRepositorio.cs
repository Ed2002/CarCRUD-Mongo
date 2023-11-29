using CarCrudDominio.Entidades;

namespace CarCrudDominio.Repositorios
{
    public interface ICarroRepositorio
    {
        Task Inserir(Carro carro);
        Task Alterar(Carro carro);
        List<Carro> Listar();
        Carro BuscarId(long id);
        Task Deletar(long Id);
    }
}
