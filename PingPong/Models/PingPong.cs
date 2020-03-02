namespace PingPong.Models
{
  public class CheckPingPong
  {
    public string UserInput {get;}

    public CheckPingPong(string userInput)
    {
      UserInput = userInput;
    }
    
    public bool CheckNumber(string userInput)
    {
      int userInputNumber = int.Parse(userInput);
      
      if (userInputNumber % 3 == 0 && userInputNumber % 5 == 0)
      {
        return true;
      }

      else if (userInputNumber % 3 == 0)
      {
        return true;
      }
      else if (userInputNumber % 5 == 0)
      {
        return true;
      }
      return false;
    }
  }
}