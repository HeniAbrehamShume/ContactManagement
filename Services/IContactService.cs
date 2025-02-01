using System.Collections.Generic;
using ContactM.Models;

namespace ContactM.Services
{
    //contact interface
    public interface IContactService
    {
        Task<List<Contact>> GetAllAsync(int pageNumber, int pageSize);
        Task<Contact> GetByIdAsync(int id);
        Task<Contact> AddAsync(Contact newContact);
       
    }
}
