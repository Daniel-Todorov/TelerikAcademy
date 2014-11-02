//1. Create a simple WCF service. It should have a method 
//that accepts a DateTime parameter and returns the day 
//of week (in Bulgarian) as string. Test it with the 
//integrated WCF client.

namespace _01.ReturnDayOfTheWeekInBulgarian
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDayOfWeekService" in both code and config file together.
    [ServiceContract]
    public interface IDayOfWeekService
    {
        [OperationContract]
        string GetDayOfWeekInBulgarian(DateTime dateTime);
    }
}
