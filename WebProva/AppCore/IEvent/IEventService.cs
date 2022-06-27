using AppCore.Model;

namespace AppCore.IEvent
{
    public class IEventService
    {


        public interface IEvent
        {
            List<Event> GetCustomers();
            Customer GetCustomerById(int id);
            void SaveCustomer(Customer customer);
            void DeleteCustomer(int id);
        }


    }
}
