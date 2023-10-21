using System;

public class GoldService: ServiceManager
{
    public bool _serviceCompleted;

     public GoldService()
    {
        ServiceName = " ";
        description = "";
    }

    public GoldService(string ServiceName, string description, int price)
    {

    }

    public void CreateService()
    {

    }
    public bool ServiceCompleted()
    {
        return true;
    }
    public string ServiceDetails()
    {
        return string.Empty;
    }
}