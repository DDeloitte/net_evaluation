namespace Evaluation.Repositories
{
    //Clase que inicia las propiedades de usuarios
    public class User : IUser
    {
        //Private fields
        private int _userId;
        private string _userName;
        private string _userEmail;
        private int _phone;

        public int userId
        {
            set {_userId = value;}
            get {return _userId;}
        }

        public string name
        {
            set {_userName = value;}
            get {return _userName;}
        }

        public string email
        {
            set {_userEmail = value;}
            get {return _userEmail;}
        }

        public int phone
        {
            set {_phone = value;}
            get {return _phone;}
        }

        //Methods

        // public User GetUser(int _ID)
        // {
        //     return users.Where(item => item.userId == _ID).SingleOrDefault();
        // }
        

    }
}