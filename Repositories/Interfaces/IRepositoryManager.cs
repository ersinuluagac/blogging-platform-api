namespace Repositories.Interfaces
{
    public interface IRepositoryManager
    {
        IArticleRepository Article { get; }
        void Save();
    }
}
