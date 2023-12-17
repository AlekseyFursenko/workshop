namespace Domain.Model.Service;

public class Foo2 : IFoo
{
  private int count = 0;

  public int GetCount()
  {
    return --count;
  }
}