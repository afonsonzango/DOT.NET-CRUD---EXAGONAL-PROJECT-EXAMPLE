using APPOINTMENT_SERVICE_API.Main.Features.User.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.models;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Connection;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.repository;

public class UserRepository : IUserRepositoryOutPort
{
    private readonly DatabaseConfig _context;
    private readonly UserMapper _userMapper;

    public UserRepository(DatabaseConfig context, UserMapper userMapper)
    {
        _context = context;
        _userMapper = userMapper;
    }

    public List<UserModel> FindAll()
    {
        return _context.Users
            .ToList()
            .Select(_userMapper.ToModel)
            .ToList();
    }
    
    public List<UserModel> FindAll(int page, int size)
    {
        return _context.Users
            .Skip(page * size)
            .Take(size)
            .ToList()
            .Select(_userMapper.ToModel)
            .ToList();
    }
    
    public UserModel? FindById(long id)
    {
        var entity = _context.Users.Find(id);
        return entity == null ? null : _userMapper.ToModel(entity);
    }

    public UserModel? FindByUuid(Guid uuid)
    {
        var entity = _context.Users.FirstOrDefault(u => u.Uuid == uuid);
        return entity == null ? null : _userMapper.ToModel(entity);
    }
    
    public UserModel? FindByEmail(string email)
    {
        var entity = _context.Users.FirstOrDefault(u => u.Email == email);
        return entity != null ? _userMapper.ToModel(entity) : null;
    }
    
    public UserModel Create(UserModel userModel)
    {
        var entity = _userMapper.ToEntity(userModel);
        _context.Users.Add(entity);
        _context.SaveChanges();
        return _userMapper.ToModel(entity);
    }

    public UserModel Update(UserModel userModel)
    {
        var entity = _context.Users.Find(userModel.Id);
        if (entity == null)
        {
            throw new Exception($"User with id {userModel.Id} not found");
        }

        entity.Name = userModel.Name;
        entity.Email = userModel.Email;
        entity.UpdatedOn = DateTime.UtcNow;

        _context.SaveChanges();

        return _userMapper.ToModel(entity);
    }
    
    public void DeleteById(long id)
    {
        var entity = _context.Users.Find(id);
        if (entity != null)
        {
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
    }
}