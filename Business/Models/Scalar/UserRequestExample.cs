using Swashbuckle.AspNetCore.Filters;

namespace Business.Models.Scalar;

public class UserRequestExample : IExamplesProvider<UserRequest>
{
    public UserRequest GetExamples()
    {
        return new UserRequest()
        {
            UserName = "UserTeste",
            Age = 30,
            City = "São Paulo",
            Password = "123456"
        };
    }
}