using Course.Contracts.course;
using Course.Model;

namespace Course.Services.Auth;



public interface IAuthService{

    void Register(User register);
}