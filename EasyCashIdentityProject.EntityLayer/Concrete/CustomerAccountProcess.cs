﻿namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
        public string Description { get; set; }

        public int? SenderID { get; set; }
        public CustomerAccount SenderCustomer { get; set; }

        public int? ReceiverID { get; set; }
        public CustomerAccount ReceiverCustomer { get; set; }
    }
}
