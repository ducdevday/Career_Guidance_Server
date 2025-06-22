using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Setting
{
    public class EnviromentSetting
    {
        private static Lazy<EnviromentSetting> _instance = new Lazy<EnviromentSetting>(() => new EnviromentSetting());
        private string _connectionString = string.Empty;
        private static string _issuer = string.Empty;
        private static string _audience = string.Empty;
        private static string _secretKey = string.Empty;
        private static string _smtpServer = string.Empty;
        private static int _smtpPort = 587;
        private static string _smtpEmail = string.Empty;
        private static string _smtpAppPassword = string.Empty;

        private EnviromentSetting()
        {
        }

        public static EnviromentSetting Instance
        {
            get { return _instance.Value; }
        }

        public string ConnectionString
        {
            get { 
                if(!string.IsNullOrEmpty(_connectionString)) 
                    return _connectionString;
                _connectionString = Environment.GetEnvironmentVariable("CareerGuidanceConnectionString") ?? throw new InvalidCastException("Connection String Not Found");
                return _connectionString;
            }
        }

        public string SecretKey
        {
            get { 
                if(!string.IsNullOrEmpty(_secretKey)) 
                    return _secretKey;
                _secretKey = Environment.GetEnvironmentVariable("SecretKey") ?? throw new InvalidCastException("Secret Key Not Found");
                return _secretKey;
            }
        } 

        public string SmtpServer
        {
            get { 
                if(!string.IsNullOrEmpty(_smtpServer)) 
                    return _smtpServer;
                _smtpServer = Environment.GetEnvironmentVariable("SmtpServer") ?? throw new InvalidCastException("SMTP Server Not Found");
                return _smtpServer;
            }
        }

        public int SmtpPort
        {
            get
            {
                if (!string.IsNullOrEmpty(_smtpServer))
                    return _smtpPort;
                _smtpPort = int.TryParse(Environment.GetEnvironmentVariable("SmtpPort"), out int port) ? port : 587;
                return _smtpPort;
            }
        }

        public string SmtpEmail
        {
            get { 
                if(!string.IsNullOrEmpty(_smtpEmail)) 
                    return _smtpEmail;
                _smtpEmail = Environment.GetEnvironmentVariable("SmtpEmail") ?? throw new InvalidCastException("SMTP Email Not Found");
                return _smtpEmail;
            }
        }

        public string SmtpAppPassword
        {
            get { 
                if(!string.IsNullOrEmpty(_smtpAppPassword)) 
                    return _smtpAppPassword;
                _smtpAppPassword = Environment.GetEnvironmentVariable("SmtpAppPassword") ?? throw new InvalidCastException("SMTP App Password Not Found");
                return _smtpAppPassword;
            }
        } 

        public string Issuer
        {
            get
            {
                if (!string.IsNullOrEmpty(_issuer))
                    return _issuer;
                _issuer = Environment.GetEnvironmentVariable("CareerGuidanceIssuer") ?? throw new InvalidCastException("Issuer Not Found");
                return _issuer;
            }
        }

        public string Audience
        {
            get
            {
                if (!string.IsNullOrEmpty(_audience))
                    return _audience;
                _audience = Environment.GetEnvironmentVariable("CareerGuidanceAudience") ?? throw new InvalidCastException("Audience Not Found");
                return _audience;
            }
        }
    }
}
