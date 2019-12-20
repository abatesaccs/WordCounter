using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    public string Sentence { get; set; }
    public string KeyWord { get; set; }
    public Counter(string key, string sentence)
    {
      Sentence = sentence;
      KeyWord = key
    }
    public int Count()
    {
      string[] splitSentence = sentence.ToLower().Split(',',' ','.');
      // string[] splitText = keyWord.ToLower().Split(',',' ','.');
      int count = 0;
      for(int i = 0; i < splitSentence.Length; i++)
      {
        if(splitSentence[i] == splitText[0])
        {
          count += 1;
        }
        else 
        {
          break;
        }
      //     bool found = true;
      //     int j = 0;
      //     for(j = 0; j < splitText.Length; j++){
      //       if(splitSentence[i++] != splitText[j])
      //       {
      //         found = false;
      //         break;
      //       }
      //     }
      //     if(found){
      //       Console.WriteLine("Index J {0} ",j);
      //       count++;
      //       // i= index >i ? index-1 : i;
      //     }
      //   }
      // }
      // Console.WriteLine("Total found " + count);
    }
    return count;
  }
}