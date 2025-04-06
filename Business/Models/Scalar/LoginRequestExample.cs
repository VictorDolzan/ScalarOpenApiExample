using Swashbuckle.AspNetCore.Filters;

namespace Business.Models.Scalar;

public class LoginRequestExample : IExamplesProvider<LoginRequest>
{
    public LoginRequest GetExamples()
    {
        return new LoginRequest()
        {
            UserName = "Admin",
            Password = "123456"
        };
    }
}