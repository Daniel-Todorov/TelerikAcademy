namespace BullsAndCows.Wcf
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    using BullsAndCows.Wcf.Models;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsers" in both code and config file together.
    [ServiceContract]
    public interface IUsers
    {
        //Available at http://localhost:59131/users.svc/{id}
        [OperationContract]
        [WebGet(UriTemplate = "/{id}")]
        LargeUserModel GetUserById(string id);

        //Available at http://localhost:59131/users.svc or http://localhost:59131/users.svc?page={number}
        [OperationContract]
        [WebGet(UriTemplate = "?page={page}")]
        ICollection<TinyUserModel> GetUserByPage(int page = 0);
    }
}
