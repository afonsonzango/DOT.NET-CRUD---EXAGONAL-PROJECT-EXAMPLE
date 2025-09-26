using APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using Microsoft.AspNetCore.Mvc;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.adapters.rest.controllers;

[ApiController]
[Route("user")]
public class CreateUserController : ControllerBase
{
    private readonly IUserServiceInPort _userServices;
    
    public CreateUserController(IUserServiceInPort userServices)
    {
        _userServices = userServices;
    }
    
    [HttpPost("create")]
    public ActionResult<UserResponseDTO> CreateUser([FromBody] UserCreateRequestDTO userCreateRequestDto)
    {
        return _userServices.CreateUser(userCreateRequestDto);
    }
}