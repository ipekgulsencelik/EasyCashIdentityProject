using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDAL _customerAccountProcessDAL;

        public CustomerAccountProcessManager(ICustomerAccountProcessDAL customerAccountProcessDAL)
        {
            _customerAccountProcessDAL = customerAccountProcessDAL;
        }

        public void TDelete(CustomerAccountProcess entity)
        {
            _customerAccountProcessDAL.Delete(entity);
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            return _customerAccountProcessDAL.GetByID(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
            return _customerAccountProcessDAL.GetList();
        }

        public void TInsert(CustomerAccountProcess entity)
        {
            _customerAccountProcessDAL.Insert(entity);
        }

        public void TUpdate(CustomerAccountProcess entity)
        {
            _customerAccountProcessDAL.Update(entity);
        }
    }
}