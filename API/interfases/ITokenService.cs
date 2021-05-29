using API.Entities;

namespace API.interfases
{
    public interface ITokenService
    {
       string CreateToken(AppUser user);
    }
}