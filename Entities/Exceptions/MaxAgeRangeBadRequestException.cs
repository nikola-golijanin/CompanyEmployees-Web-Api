namespace Entities.Exceptions;

public class MaxAgeRangeBadRequestException : BadRequestException
{
    public MaxAgeRangeBadRequestException()
        : base("Max age cant be less than min age.")
    {
    }
}