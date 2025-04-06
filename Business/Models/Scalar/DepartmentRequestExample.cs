using Swashbuckle.AspNetCore.Filters;

namespace Business.Models.Scalar;

public class DepartmentRequestExample : IExamplesProvider<DepartmentRequest>
{
    public DepartmentRequest GetExamples()
    {
        return new DepartmentRequest()
        {
            Name = "Software Factory",
            Sector = "Technology",
            NumberOfEmployees = 300
        };
    }
}