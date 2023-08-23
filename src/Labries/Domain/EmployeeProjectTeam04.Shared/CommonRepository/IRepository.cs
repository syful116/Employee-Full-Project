using EmployeeProjectTeam04.Shared.Common;

namespace EmployeeProjectTeam04.Shared.CommonRepository;


public interface IRepository<in TEntity, IModel, T>
        where TEntity : class, IEntity<T>, new()
        where IModel : class, IVm<T>
        where T : IEquatable<T>
{
    public Task<IModel> GetById(T id);
    public Task<IEnumerable<IModel>> GetList();
    public Task<IModel> Delete(T id);
    public Task<IModel> Update(T id, TEntity entity);
    public Task<IModel> Add(TEntity entity);
}
