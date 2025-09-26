using APPOINTMENT_SERVICE_API.Main.Features.User.domain.exceptions;
using APPOINTMENT_SERVICE_API.Main.Root.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.adapters.rest.exceptions;

public class UserIdNotValidExceptionFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        if (context.Exception is UserIdNotValidException ex)
        {
            context.Result = new BadRequestObjectResult(new ErrorResponseDto("USER_ID_NOT_VALID", ex.Message));
            context.ExceptionHandled = true;
        }
    }
}