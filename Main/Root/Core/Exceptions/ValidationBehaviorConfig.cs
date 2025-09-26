using APPOINTMENT_SERVICE_API.Main.Root.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace APPOINTMENT_SERVICE_API.Main.Root.Core.Exceptions;

public static class ValidationBehaviorConfig
{
    public static void ConfigureCustomValidation(this IServiceCollection services)
    {
        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.InvalidModelStateResponseFactory = context =>
            {
                var errors = context.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(
                        kvp => kvp.Key,
                        kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToList()
                    );

                var errorResponse = new ErrorResponseDto(
                    "VALIDATION_ERROR",
                    "One or more validation errors occurred.",
                    errors
                );

                return new BadRequestObjectResult(errorResponse);
            };
        });
    }
}