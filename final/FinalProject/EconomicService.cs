using System;

public class EconomicService: ServiceManager
{
    public bool _serviceCompleted;

     public EconomicService()
    {
        ServiceName = " ";
        description = "";
    }

    public EconomicService(string ServiceName, string description, int price)
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