using APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using Microsoft.AspNetCore.Mvc;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.adapters.rest.controllers;

[ApiController]
[Route("user")]
public class UpdateUserController : ControllerBase
{
    private readonly IUserServiceInPort _userServices;

    public UpdateUserController(IUserServiceInPort userServices)
    {
        _userServices = userServices;
    }

    [HttpPut("update/{id}")]
    public ActionResult<UserResponseDTO> UpdateUser(long id, [FromBody] UserUpdateRequestDTO userUpdateRequestDTO)
    {
        return _userServices.UpdateUser(id, userUpdateRequestDTO);
    }
}