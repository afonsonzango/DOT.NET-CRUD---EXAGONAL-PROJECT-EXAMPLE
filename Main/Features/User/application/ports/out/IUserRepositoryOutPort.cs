using APPOINTMENT_SERVICE_API.Main.Features.User.domain.models;

public interface IUserRepositoryOutPort
{
    List<UserModel> FindAll();

    List<UserModel> FindAll(int page, int size, Guid? CompanyUuid);

    UserModel? FindById(long id);

    UserModel? FindByUuid(Guid uuid);

    UserModel Create(UserModel userModel);

    UserModel Update(UserModel userModel);

    void DeleteById(long id);

    UserModel? FindByEmail(string email);
}