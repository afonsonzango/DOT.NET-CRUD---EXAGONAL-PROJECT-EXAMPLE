using APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using Microsoft.AspNetCore.Mvc;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.adapters.rest.controllers;

[ApiController]
[Route("user")]
public class GetUserByIdController : ControllerBase
{
    private readonly IUserServiceInPort _userServices;

    public GetUserByIdController(IUserServiceInPort userServices)
    {
        _userServices = userServices;
    }

    [HttpGet("get/{id}")]
    public ActionResult<UserResponseDTO> GetUserById(string id)
    {
        return _userServices.GetUserById(id);
    }
}