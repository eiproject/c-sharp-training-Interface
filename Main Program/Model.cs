using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Program
{
  internal interface Geometry
  {
    internal string Name { get; }
  }

  internal interface Cube : Geometry
  {
    internal int SumVolume(int p, int l, int t);
    internal int SumSurfaceArea(int p, int l, int t);
  }

  class CubeFormula : Cube
  {
    string Geometry.Name => "Cube";

    int Cube.SumSurfaceArea(int p, int l, int t)
    {
      return (p * l + p * t + l * t) * 2;
    }

    int Cube.SumVolume(int p, int l, int t)
    {
      return p * l * t;
    }
  }
}
