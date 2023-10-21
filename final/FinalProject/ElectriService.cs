using System;

public class ElecticService: ServiceManager
{
    public bool _serviceCompleted;

     public ElecticService()
    {
        ServiceName = " ";
        description = "";
    }

    public ElecticService(string ServiceName, string description, int price)
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