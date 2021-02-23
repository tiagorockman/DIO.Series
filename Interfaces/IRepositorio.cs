using System.Collections.Generic;
namespace DIO.Series.Interfaces
{
    //T - tipo Generico
    public interface IRepositorio<T>
    {
        //Métodos implementados pelo repositorio
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}