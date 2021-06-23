using System;

namespace Main_Program
{
  class Program
  {
    static void Run()
    {
      // basic interface
      Cube App = new CubeFormula();
      int p = 2;
      int l = 3;
      int t = 4;
      int V = App.SumVolume(p, l, t);
      int A = App.SumSurfaceArea(p, l, t);
      Console.WriteLine(V);
      Console.WriteLine(A);

      // interface extending
      string objectName = App.Name;
      Console.WriteLine(objectName);

      // explicit interface communication
      SumArea S = new SumArea();
      Console.WriteLine(S.AreaSize(1, 2)); // 3 (Not using interface)
      /*(Triangle)S.AreaSize(1, 2);*/

      Rectangle R = new SumArea();
      Console.WriteLine(R.AreaSize(2, 3)); // 6

      Triangle T = new SumArea();
      Console.WriteLine(T.AreaSize(2, 3)); // 3

      // virtual and interface
      SumWeigth W = new SumWeigth();
      Console.WriteLine(W.Weight(3, 4)); // 12 (Not using interface)

      SumArea A1 = new SumArea();
      Console.WriteLine(A1.Weight(3, 4)); // 0 (Not using interface)

      SumArea W0 = new SumArea();
      Console.WriteLine(((Triangle)W0).Weight(3, 4)); // 0
      Console.WriteLine(W0.Weight(3, 4)); // 0 (Not using interface)

      Triangle W1 = new SumArea();
      Console.WriteLine(W1.Weight(3, 4)); // 0

      Triangle W2 = new SumWeigth();
      Console.WriteLine(W2.Weight(3, 4)); // 12
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Interface!");
      Run();
    }
  }
}
