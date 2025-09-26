using APPOINTMENT_SERVICE_API.Main.Features.User.domain.exceptions;
using APPOINTMENT_SERVICE_API.Main.Root.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.adapters.rest.exceptions;

public class UserNotFoundExceptionFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        if (context.Exception is UserNotFoundException ex)
        {
            context.Result = new NotFoundObjectResult(new ErrorResponseDto("USER_NOT_FOUND", ex.Message));
            context.ExceptionHandled = true;
        }
    }
}