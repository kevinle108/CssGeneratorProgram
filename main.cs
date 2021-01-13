using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    StreamReader file = new StreamReader("input.txt");
    StreamWriter sw = new StreamWriter("output.txt");
    int counter = 0;
   string line;
    var list = new List<string>();
    while ((line = file.ReadLine()) != null) {
      if (line == "") {
        continue; // do nothing;
      } else {
        counter++;
        string[] split = line.Split("src=");
        int lengthOfSplit = split.Length;
        string txt = "img[src=";
        txt += split[lengthOfSplit - 1];
        txt = txt.Replace('>', ']');
        txt += ":hover";
        list.Add(txt);
        //sw.WriteLine(txt);
        //Console.WriteLine();
      }
    }
    file.Close();
    string joined = list.Aggregate((i, j) => i + ",\n" + j);
    sw.WriteLine(joined);
    sw.Close();;
   //  Console.WriteLine("Done reading input");
    Console.WriteLine($"{counter} lines read.");
  }
}