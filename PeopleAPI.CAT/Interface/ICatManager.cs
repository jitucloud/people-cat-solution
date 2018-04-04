using PeopleCAT.API.Online.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleCAT.API.Online.Interface
{
    /// <summary>
    /// Cat Manager Interface
    /// </summary>
    public interface ICatManager
    {
        Task<object> GetCatNameListByOwnerGender();

    }
}