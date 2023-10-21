using System;

public class PlumbingService: ServiceManager
{
    public bool _serviceCompleted;

     public PlumbingService()
    {
        ServiceName = " ";
        description = "";
    }

    public PlumbingService(string ServiceName, string description, int price)
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