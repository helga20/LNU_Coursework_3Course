using ZNO.DAL.Repositories.Interface;

namespace ZNO.DAL.Interface
{
    public interface IUnitOfWork
    {
        IZmist Zmist { get; }
        ITopicRepository Topic { get; }
        ITimeRepository Time { get; }
    }
}
