using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc2020
{
  class Program
  {
    static void Main(string[] args)
    {
      Day1();
    }


    static void Day1()
    {
      List<int> inputs = GetInputs("./inputs/day1").Select(x => int.Parse(x)).ToList();

      // Part 1
      bool found = false;
      var enum1 = inputs.GetEnumerator();
      var enum2 = inputs.GetEnumerator();
      while (!found && enum1.MoveNext())
      {
        while (!found && enum2.MoveNext())
        {
          if (enum1.Current + enum2.Current == 2020)
          {
            found = true;
            Console.WriteLine(enum1.Current * enum2.Current);
          }
        }
        enum2 = inputs.GetEnumerator();
      }

      // Part 2
      found = false;
      enum1 = inputs.GetEnumerator();
      enum2 = inputs.GetEnumerator();
      var enum3 = inputs.GetEnumerator();
      while (!found && enum1.MoveNext())
      {
        while (!found && enum2.MoveNext())
        {
          while (!found && enum3.MoveNext())
          {
            if (enum1.Current + enum2.Current + enum3.Current == 2020)
            {
              found = true;
              Console.WriteLine(enum1.Current * enum2.Current * enum3.Current);
            }
          }
          enum3 = inputs.GetEnumerator();
        }
        enum2 = inputs.GetEnumerator();
      }
    }

    static List<string> GetInputs(string path)
    {
      List<string> inputs = new List<string>();
      try
      {
        using StreamReader sr = new StreamReader(path);
        string line;
        while ((line = sr.ReadLine()) != null)
        {
          inputs.Add(line);
        }
      }
      catch (IOException e)
      {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
      }
      return inputs;
    }
  }
}
