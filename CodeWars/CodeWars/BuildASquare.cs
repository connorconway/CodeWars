namespace CodeWars
{
  //http://www.codewars.com/kata/build-a-square/train/csharp
  public static class BuildASquare
  {
    public static string GenerateShape(int n)
    {
      var shape = string.Empty;
      var completed = 0;

      while (completed < n)
      {
        for (var i = 0; i < n; i++)
        {
          shape += "+";
        }

        completed += 1;
        if (completed < n) shape += "\n";
      }
      
      return shape;
    }
  }
}