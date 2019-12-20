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
    public void Test_Name_Result()
    {
      Counter myCounter = new Counter("hello", "Hello hello HeLlO helo hellllo");
      Assert.AreEqual(3, myCounter.Count());
    }
  }
}