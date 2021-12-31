//IMPORTANTE COLOCAR ESSES USING
using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{

  public class SerieRepositorio : IRepositorio<Serie>
  {
    //=======Variavel que vai ser a lista de Serie
    private List<Serie> listaSerie = new List<Serie>();

    //=========Metodos
    public void Atualizar(int id, Serie objeto)
    {
      listaSerie[id] = objeto;
    }

    public void Excluir(int id)
    {
      listaSerie[id].Excluir();
    }

    public void Insere(Serie objeto)
    {
      listaSerie.Add(objeto);
    }

    public List<Serie> Lista()
    {
      return listaSerie;
    }

    public int ProximoId()
    {
      return listaSerie.Count;
    }

    public Serie RetornaPorId(int id)
    {
      return listaSerie[id];
    }
  }
}