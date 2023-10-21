using System;

public class HVACService: ServiceManager
{
    public bool _serviceCompleted;

     public HVACService()
    {
        ServiceName = " ";
        description = "";
    }

    public HVACService(string ServiceName, string description, int price)
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