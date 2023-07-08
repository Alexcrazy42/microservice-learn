using aspnet_docker.Models;
using aspnet_docker.Data.Interfaces;


namespace aspnet_docker.Data
{
    public class DatabaseStub : IDbContext
    {
        public List<Person> persons = new List<Person>()
        {
            new Person() {Id = 1, LastName = "������", FirstName = "����"},
            new Person() {Id = 2, LastName = "������", FirstName = "������"},
            new Person() {Id = 3, LastName = "�������", FirstName = "����"},
            new Person() {Id = 4, LastName = "�������", FirstName = "�����"}
        };

        public Person GetById(int id)
        {
            Person? personById = persons.Find(p => p.Id == id);
            return personById;
        }


    }
}


