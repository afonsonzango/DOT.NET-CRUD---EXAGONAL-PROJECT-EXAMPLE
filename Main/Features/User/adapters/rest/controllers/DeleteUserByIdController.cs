using Microsoft.AspNetCore.Mvc;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.adapters.rest.controllers;

[ApiController]
[Route("user")]
public class DeleteUserByIdController : ControllerBase
{
    private readonly IUserServiceInPort _userServices;

    public DeleteUserByIdController(IUserServiceInPort userServices)
    {
        _userServices = userServices;
    }

    [HttpDelete("delete/{id}")]
    public ActionResult DeleteUserById(long id)
    {
        _userServices.DeleteUser(id);
        return NoContent();
    }
}