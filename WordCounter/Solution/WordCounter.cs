using System;
using System.Collections.Generic;

namespace WordCounter.Solution
{
  public class Counter
  {
    public string Sentence { get; set; }
    public static string KeyWord { get; set; }
    public Counter(string key, string sent)
    {
      Sentence = sent;
      KeyWord = key;
    }
    public static string Setup()
    {
      Console.WriteLine("Please enter a search word");
      string key = Console.ReadLine();
      int num;
      while (string.IsNullOrEmpty(key) || int.TryParse(key, out num))
      {
        Console.WriteLine("Please enter a word.");
        key = Console.ReadLine();
      }
      
      Console.WriteLine("Please enter a sentence to search");
      string sentence = Console.ReadLine();
      while (string.IsNullOrEmpty(sentence) || int.TryParse(sentence, out num))
      {
        Console.WriteLine("Please enter a sentence.");
        sentence = Console.ReadLine();
      }
      
      Counter myCounter = new Counter(key, sentence);
      return "found " + key + " " + myCounter.Count() + " times";
    }

    public static bool CheckInput(string input)
    {
      int num;
      if(string.IsNullOrEmpty(input) || int.TryParse(input, out num))
      {
        return false;
      }
      return true;
    }

    public int Count()
    {
      string[] splitSentence = Sentence.ToLower().Split(',',' ','.');
      string[] splitKeyWord = KeyWord.ToLower().Split(' ');
      int count = 0;
      for(int i = 0; i < splitSentence.Length; i++)
      {
        if(splitSentence[i] == splitKeyWord[0])
        {
          count += 1;
        }
      }
      return count;
    }
  }
}