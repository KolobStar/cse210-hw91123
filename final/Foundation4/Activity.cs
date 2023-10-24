public class Activity
{
    private string _date;
    private int _length;
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public virtual double GetDistance()
    {
        return GetSpeed() / 60 * GetLength();
    }
    public virtual double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
    public virtual double GetPace()
    {
        return _length / GetDistance();
    }
    public virtual void DisplaySummary()
    {
        return;
    }
}