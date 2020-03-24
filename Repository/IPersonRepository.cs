using System.Collections.Generic;
using aspnet_api.Model;

namespace aspnet_api.Repository
{
    public interface IPersonRepository
    {
        IEnumerable<Person> Get();

        Person Get(string guid);

        void Post(Person person);

        void Put(Person person);

        void Delete(string guid);
    }
}