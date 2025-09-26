using APPOINTMENT_SERVICE_API.Main.Features.User.domain.exceptions;
using APPOINTMENT_SERVICE_API.Main.Root.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.adapters.rest.exceptions;

public class UserConflictExceptionFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        if (context.Exception is UserConflictException ex)
        {
            context.Result = new ConflictObjectResult(new ErrorResponseDto("USER_CONFLICT", ex.Message));
            context.ExceptionHandled = true;
        }
    }
}