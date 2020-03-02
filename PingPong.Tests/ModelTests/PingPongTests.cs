using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;

namespace PingPong.Tests
{
  [TestClass]
  public class CheckPingPongTests
  {
    [TestMethod]
    public void CheckNumber_CreateInstanceOfCheckPingPong_CheckPingPong()
    {
      CheckPingPong newPingPong = new CheckPingPong("1");
      Assert.AreEqual(typeof(CheckPingPong), newPingPong.GetType());
    }

    [TestMethod]
    public void CheckNumber_UserInputIsDivisibleBy3_True()
    {
      CheckPingPong newPingPong = new CheckPingPong("6");
      Assert.AreEqual(true, newPingPong.CheckNumber("6"));
    }

    [TestMethod]
    public void CheckNumber_UserInputIsDivisibleBy5_True()
    {
      CheckPingPong newPingPong = new CheckPingPong("10");
      Assert.AreEqual(true, newPingPong.CheckNumber("10"));
    }

    public void CheckNumber_UserInputIsDivisibleBy3and5_True()
    {
      CheckPingPong newPingPong = new CheckPingPong("15");
      Assert.AreEqual(true, newPingPong.CheckNumber("15"));
    }
  }
}