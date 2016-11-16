using System.Collections.Generic;

namespace Work.Objects
{
  public class Job
  {
    private string _Company;
    private string _Position;
    private int _Time;
    private static List<Job> _instances = new List<Job> {};

    public Job (string newCompany, string newPosition, int newTime)
    {
      _Company = newCompany;
      _Position = newPosition;
      _Time = newTime;
    }

    public string GetCompany()
    {
     return _Company;
    }
    public void SetCompany(string newCompany)
    {
      _Company = newCompany;
    }

    public string GetPosition()
    {
      return _Position;
    }
    public void SetPosition(string newPosition)
    {
      _Position = newPosition;
    }

    public int GetTime()
    {
      return _Time;
    }
    public void SetTime(int newTime)
    {
      _Time = newTime;
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
