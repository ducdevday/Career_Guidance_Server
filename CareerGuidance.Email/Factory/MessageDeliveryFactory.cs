using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Email.Factory
{
    public class MessageDeliveryFactory
    {
        public MessageDeliveryFactory()
        {

        }

        public IMessageDelivery Create(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Email:
                    return new EmailMessageDelivery();
                case NotificationType.SMS:
                    throw new NotImplementedException();

                case NotificationType.Push:
                    throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }
    }
}
