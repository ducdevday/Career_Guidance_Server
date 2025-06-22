using CareerGuidance.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Email.Factory
{
    public class PushMessageDelivery : IMessageDelivery
    {
        public PushMessageDelivery()
        {

        }

        public User User => throw new NotImplementedException();

        public Template Template => throw new NotImplementedException();

        public string Sender => throw new NotImplementedException();

        public string DisplayName => throw new NotImplementedException();

        public string Subject => throw new NotImplementedException();

        public string Recipient => throw new NotImplementedException();

        public MessageDeliveryMode Mode => throw new NotImplementedException();

        public List<ExternalField> ExternalFields => throw new NotImplementedException();

        public string Body => throw new NotImplementedException();

        public Task Send()
        {
            throw new NotImplementedException();
        }

        public IMessageDelivery SetBody(string body)
        {
            throw new NotImplementedException();
        }

        public IMessageDelivery SetDisplayName(string displayName)
        {
            throw new NotImplementedException();
        }

        public IMessageDelivery SetExternalFields(List<ExternalField> fields)
        {
            throw new NotImplementedException();
        }

        public IMessageDelivery SetMode(MessageDeliveryMode mode)
        {
            throw new NotImplementedException();
        }

        public IMessageDelivery SetRecipient(string recipient)
        {
            throw new NotImplementedException();
        }

        public IMessageDelivery SetSender(string sender)
        {
            throw new NotImplementedException();
        }

        public IMessageDelivery SetSubject(string subject)
        {
            throw new NotImplementedException();
        }

        public IMessageDelivery SetTemplate(Template template)
        {
            throw new NotImplementedException();
        }

        public IMessageDelivery SetUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
