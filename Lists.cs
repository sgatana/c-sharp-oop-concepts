using System;
using System.Collections.Generic;

public class Lists {
  public static void WorkingWithStrings () {
    var names = new List<string> { "<name>", "Anna", "Stephen" };
    names.Add ("Jemmy");
    var index = names.IndexOf ("Jemmy");
    Console.WriteLine ($"The name {names[index]} is at index {index}");
    Console.WriteLine ($"names has {names.Count} elements");
    names.Sort ();
    foreach (var name in names) {
      Console.WriteLine ($"Hello {name}");
    }
  }

  public static void WorkingWithNumbers () {
    var fibonacciNumbers = new List<int> { 1, 1 };

    while (fibonacciNumbers.Count < 20) {
      var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
      var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

      fibonacciNumbers.Add (previous + previous2);
    }
    foreach (var item in fibonacciNumbers)
      Console.WriteLine (item);
  }
}