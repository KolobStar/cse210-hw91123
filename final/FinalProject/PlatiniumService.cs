using System;

public class PlatiniumService: ServiceManager
{
    public bool _serviceCompleted;

     public PlatiniumService()
    {
        ServiceName = " ";
        description = "";
    }

    public PlatiniumService(string ServiceName, string description, int price)
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