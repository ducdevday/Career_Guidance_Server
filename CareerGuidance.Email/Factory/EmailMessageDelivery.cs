using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
using CareerGuidance.Setting;
using CareerGuidance.Shared.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Email.Factory
{
    public class EmailMessageDelivery : IMessageDelivery
    {
        private EnviromentSetting _setting = EnviromentSetting.Instance;
        private User? _user = null;
        private Template? _template = null;
        private string _sender = string.Empty;
        private string _recipient = string.Empty;
        private string _displayName = string.Empty;
        private string _subject = string.Empty;
        private string _body = string.Empty;
        public MessageDeliveryMode _deliveryMode;
        private List<ExternalField> _externalFields = new List<ExternalField>();

        public EmailMessageDelivery()
        {
        }

        public User User => _user;

        public Template Template => _template;

        public string Sender => _sender;

        public string DisplayName => _displayName;

        public string Subject => _subject;

        public string Body => _body;

        public string Recipient => _recipient;

        public MessageDeliveryMode Mode => _deliveryMode;

        public List<ExternalField> ExternalFields => _externalFields;

        public async Task Send()
        {
            if (string.IsNullOrEmpty(_sender))
            {
                throw new InvalidOperationException("Sender cannot be null or empty.");
            }
            if (string.IsNullOrEmpty(_recipient))
            {
                throw new InvalidOperationException("Recipient cannot be null or empty.");
            }

            switch (_deliveryMode)
            {
                case MessageDeliveryMode.Template:
                    if (_template == null)
                        throw new ArgumentNullException(nameof(_template), "Template cannot be null");
                    if(_user == null)
                        throw new ArgumentNullException(nameof(_user), "User cannot be null");

                    var activeVersion = _template.TemplateVersions?.FirstOrDefault();
                    if(activeVersion == null) throw new ArgumentException(nameof(_template), "Template must have at least one active version.");
                    
                    _subject = activeVersion.Subject;
                    _body = activeVersion.Body;

                    if (string.IsNullOrEmpty(_subject))
                        throw new ArgumentNullException(nameof(_template), "Subject cannot be null");
                    if (string.IsNullOrEmpty(_body))
                        throw new ArgumentNullException(nameof(_template), "Body cannot be null");

                    activeVersion?.TemplateFields?.ForEach(field =>
                    {
                        string value = string.Empty;
                        switch (field.Type) {
                            case NotificationFieldType.UserFirstName:
                                value = _user.FirstName;
                                break;
                            case NotificationFieldType.UserLastName:
                                value = _user.LastName;
                                break;
                            case NotificationFieldType.UserFullName:
                                value = $"{_user.LastName}{(string.IsNullOrWhiteSpace(_user.MiddleName) ? "" : " " + _user.MiddleName)} {_user.FirstName}";
                                break;
                            case NotificationFieldType.CompanyName:
                                value = NotificationConstant.COMPANY_SHOTNAME;
                                break;
                            case NotificationFieldType.CurrentDateTime:
                                value = DateTime.UtcNow.ToString();
                                break;
                            case NotificationFieldType.CurrentTime:
                                value = DateTime.UtcNow.ToShortTimeString();
                                break;
                            case NotificationFieldType.CurrentDate:
                                value = DateTime.UtcNow.ToShortDateString();
                                break;
                        }
                        if (field.IsSubject)
                        {
                            _subject = _subject.Replace($"[{field.Name}]", value);
                        }
                        else if (field.IsBody)
                        {
                            _body = _body.Replace($"[{field.Name}]", value);
                        }

                    });
                    if (_externalFields != null && _externalFields.Any()) { 
                        foreach(var item in _externalFields)
                        {
                            if (item.IsSubject)
                            {
                                _subject = _subject.Replace($"[{item.Name}]", item.Value);
                            }
                            else if (item.IsBody)
                            {
                                _body = _body.Replace($"[{item.Name}]", item.Value);
                            }
                        }
                    }
                    break;

                case MessageDeliveryMode.NoTemplate:
                    throw new NotImplementedException();
            }

            using MailMessage message = new MailMessage
            {
                From = new MailAddress(_sender, _displayName),
                Subject = _subject,
                Body = _body,
                IsBodyHtml = true
            };
            message.To.Add(new MailAddress(_recipient));

            using SmtpClient smtpClient = new SmtpClient(_setting.SmtpServer) { 
                Port = _setting.SmtpPort,
                Credentials = new System.Net.NetworkCredential(_setting.SmtpEmail, _setting.SmtpAppPassword),
                EnableSsl = true
            };
            await smtpClient.SendMailAsync(message);
        }

        public IMessageDelivery SetBody(string body)
        {
            _body = body;
            return this;
        }

        public IMessageDelivery SetDisplayName(string displayName)
        {
            _displayName = displayName;
            return this;
        }

        public IMessageDelivery SetExternalFields(List<ExternalField> fields)
        {
            _externalFields = fields;
            return this;
        }

        public IMessageDelivery SetMode(MessageDeliveryMode mode)
        {
            _deliveryMode = mode;
            return this;
        }

        public IMessageDelivery SetRecipient(string recipient)
        {
            _recipient = recipient;
            return this;
        }

        public IMessageDelivery SetSender(string sender)
        {
            _sender = sender;
            return this;
        }

        public IMessageDelivery SetSubject(string subject)
        {
            _subject = subject;
            return this;
        }

        public IMessageDelivery SetTemplate(Template template)
        {
            _template = template;
            return this;
        }

        public IMessageDelivery SetUser(User user)
        {
            _user = user;
            return this;
        }
    }
}
