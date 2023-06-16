using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDAL _customerAccountDAL;

        public CustomerAccountManager(ICustomerAccountDAL customerAccountDAL)
        {
            _customerAccountDAL = customerAccountDAL;
        }

        public void TDelete(CustomerAccount entity)
        {
            _customerAccountDAL.Delete(entity);
        }

        public CustomerAccount TGetByID(int id)
        {
            return _customerAccountDAL.GetByID(id);
        }

        public List<CustomerAccount> TGetList()
        {
            return _customerAccountDAL.GetList();
        }

        public void TInsert(CustomerAccount entity)
        {
            _customerAccountDAL.Insert(entity);
        }

        public void TUpdate(CustomerAccount entity)
        {
            _customerAccountDAL.Update(entity);
        }
    }
}