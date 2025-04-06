using Swashbuckle.AspNetCore.Filters;

namespace Business.Models.Scalar;

public class DeleteUserRequestExample : IExamplesProvider<DeleteUserRequest>
{
    public DeleteUserRequest GetExamples()
    {
        return new DeleteUserRequest()
        {
            UserId = 1234
        };
    }
}