using Evaluation.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation.Controllers;

[ApiController]
[Route("[controller]")]
public class UserMain : ControllerBase
{


            private readonly List<User> users = new()
        {
            new User {userId = 1001, name = "David", email = "Deloitte", phone = 2030},
            new User {userId = 1002,  name = "Guille", email = "Deloitte", phone = 2031},
            new User {userId = 1003,  name = "Oscar", email = "Deloitte", phone = 2032},
        };

    //Comienzan los metodos https
    [HttpPost("Add")]
    public User CreateUser(int id, string name, string email, int phone)
    {
        //Se inicializa el objeto
        User user = new User();
        {
            user.userId = id;
            user.name = name;
            user.email = email;
            user.phone = phone;
        };
        return user;
    }

    [HttpGet("Items")]
    public IEnumerable<User> GetUser()
    {
        return users;
    }


    // [HttpGet("Get{Id}")]
    // public UserMain GetUser(int Id)
    // {
    //     return users.Where(item => item.userId == Id).SingleOrDefault();
    // }


}
