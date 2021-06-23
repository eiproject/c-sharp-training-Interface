using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Program
{
  internal interface Triangle
  {
    int AreaSize(int a, int t);
    int Weight(int p, int v);
    /*internal virtual void Weight() { }*/
  }
  interface Rectangle
  {
    int AreaSize(int p, int l);
  }

  class SumArea : Triangle, Rectangle
  {
    internal int AreaSize(int a, int t)
    {
      return a + t;
    }

    int Triangle.AreaSize(int a, int t)
    {
      return a * t / 2;
    }

    int Rectangle.AreaSize(int p, int l)
    {
      return p * l;
    }
    public virtual int Weight(int p, int v) { return 0; }
  }

  class SumWeigth : SumArea
  {
    public override int Weight(int p, int v)
    {
      return p * v;
    }
  }


}
