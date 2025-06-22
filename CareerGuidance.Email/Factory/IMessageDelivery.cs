using CareerGuidance.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Email.Factory
{
    public interface IMessageDelivery
    {
        public User User { get;}
        public Template Template { get;}
        public string Sender { get; }
        public string DisplayName { get; }
        public string Subject { get; }
        public string Body { get; }
        public string Recipient { get; }
        public MessageDeliveryMode Mode { get; }
        public List<ExternalField> ExternalFields { get; }

        public IMessageDelivery SetUser(User user);
        public IMessageDelivery SetTemplate(Template template);
        public IMessageDelivery SetSender(string sender);
        public IMessageDelivery SetDisplayName(string displayName);
        public IMessageDelivery SetSubject(string subject);
        public IMessageDelivery SetBody(string body);
        public IMessageDelivery SetRecipient(string recipient);
        public IMessageDelivery SetMode(MessageDeliveryMode mode);
        public IMessageDelivery SetExternalFields(List<ExternalField> fields);
        public Task Send();
    }

    public struct ExternalField
    {
        public string Name;
        public string Value;
        public bool IsBody;
        public bool IsSubject;
    }

    public enum MessageDeliveryMode { 
        Template,
        NoTemplate
    }
}
