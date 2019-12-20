using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Solution;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTester
  {
    [TestMethod]
    public void WordCounter_singleMatch_True()
    {
      Counter myCounter = new Counter("hello", "hello");
      Assert.AreEqual(1, myCounter.Count());
    }

    [TestMethod]
    public void WordCounter_singleMatchWithIncorrectWords_True()
    {
      Counter myCounter = new Counter("hello", "hello helo");
      Assert.AreEqual(1, myCounter.Count());
    }
    
    [TestMethod]
    public void WordCounter_MultipleMatchWithCapitals_True()
    {
      Counter myCounter = new Counter("hello", "hello helo Hello HElLo");
      Assert.AreEqual(3, myCounter.Count());
    }
  }
}