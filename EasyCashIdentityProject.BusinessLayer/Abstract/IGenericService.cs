namespace EasyCashIdentityProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        T TGetByID(int id);
        List<T> TGetList();
    }
}
