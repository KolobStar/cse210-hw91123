using System;

public class BasicService: ServiceManager
{
    public bool _serviceCompleted;

     public BasicService()
    {
        ServiceName = "Basic Service ";
        description = "This service includes vase cleaning without cleaning chemicals included.";
    }

    public BasicService(string ServiceName, string description, int price)
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