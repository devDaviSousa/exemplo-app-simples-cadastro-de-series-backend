//Essa entidade é uma uma classe abstrata, vai conter uma propriedade que todo mundo que herdar ja vai ter o
//o id com defaul


namespace DIO.Series
{

  public abstract class EntidadeBase
  {
    public int Id { get; protected set; }
  }
}