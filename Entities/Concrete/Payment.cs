﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment
    {
        public int Id { get; set; }
        public int CreditCardId { get; set; }
        public int CustomerId { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
