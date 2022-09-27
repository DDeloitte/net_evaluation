namespace Evaluation.Repositories
{
    //Clase que establece las propiedades de los usuarios
    public interface IUser
    {
        int userId {set; get;}
        string name {set; get;}
        //rivate enum UserType {set; get;}
        string email {set; get;}
        int phone {set; get;}
    }
}