using APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using Microsoft.AspNetCore.Mvc;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.adapters.rest.controllers;

[ApiController]
[Route("user")]
public class GetUsersController : ControllerBase
{
    private readonly IUserServiceInPort _userServices;

    public GetUsersController(IUserServiceInPort userServices)
    {
        _userServices = userServices;
    }

    [HttpGet("all")]
    public ActionResult<PaginatedUsersResponseDTO> GetUsers([FromQuery] PaginationUserRequestDTO paginationUserRequestDto)
    {
        return _userServices.GetAllUsers(paginationUserRequestDto.Page, paginationUserRequestDto.Size, paginationUserRequestDto.CompanyUuid);
    }
}