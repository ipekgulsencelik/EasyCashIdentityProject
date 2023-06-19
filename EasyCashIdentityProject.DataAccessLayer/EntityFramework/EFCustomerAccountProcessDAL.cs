using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Repository;
using EasyCashIdentityProject.EntityLayer.Concrete;

namespace EasyCashIdentityProject.DataAccessLayer.EntityFramework
{
    public class EFCustomerAccountProcessDAL : GenericRepository<CustomerAccountProcess>, ICustomerAccountProcessDAL
    {
    }
}
