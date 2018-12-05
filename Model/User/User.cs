using System.Collections.Generic;
using Model.Context;

namespace Model.User
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public UserType UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public string LoginName { get; set; }
        public byte[] Photo { get; set; }
        public List<int> PrivateDecks { get; set; }
    }
}