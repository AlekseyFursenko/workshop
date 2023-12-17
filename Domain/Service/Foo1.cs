namespace Domain.Model.Service;

public class Foo1 : IFoo
{
  private int count = 0;

  public int GetCount()
  {
    return ++count;
  }
}
