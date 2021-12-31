using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
  //Quem for implementar a classe vai poder passar o 
  //T que é um tipo generio.
  public interface IRepositorio<T>
  {

    List<T> Lista();
    T RetornaPorId(int id);
    void Insere(T entidade);
    void Excluir(int id);
    void Atualizar(int id, T entidade);
    int ProximoId();

  }
}