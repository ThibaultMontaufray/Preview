namespace Tools4Libraries
{
    using System.Xml;

    public static class Params
    {
        private const string CONFIGFILE = @"../../../configmanagers.xml";
        //private const string CONFIGFILE = @"D:\DEV\_Assistant\Assistant\configmanagers.xml";

        #region Attribute
        private static string _webProxyHost;
        private static string _webProxyLogin;
        private static string _webProxyPassword;
        private static string _webProxyPort;
        private static string _webHttpLogin;
        private static string _webHttpPassword;
        private static string _communicationSlackUrl;
        private static string _communicationSlackToken;
        private static string _communicationSlackAccount;
        private static string _communicationSlackTopic;
        private static string _communicationMailLogin;
        private static string _communicationMailPassword;
        private static string _communicationMailSmtpPort;
        private static string _communicationMailSmtpHost;
        private static string _logisticSncfToken;
        private static string _databaseLogin;
        private static string _databasePassword;
        private static string _databaseHost;
        private static string _databaseName;
        private static string _githubLogin;
        private static string _githubPassword;
        private static string _githubHost;
        private static string _jiraLogin;
        private static string _jiraPassword;
        private static string _jiraHost;
        private static string _sonarLogin;
        private static string _sonarPassword;
        private static string _sonarHost;
        private static string _teamcityLogin;
        private static string _teamcityPassword;
        private static string _teamcityHost;
        private static string _jenkinsLogin;
        private static string _jenkinsPassword;
        private static string _jenkinsHost;
        private static string _dockerLogin;
        private static string _dockerPassword;
        private static string _dockerHost;
        #endregion

        #region Properties
        public static string WebProxyHost { get { return _webProxyHost; } }
        public static string WebProxyLogin { get { return _webProxyLogin; } }
        public static string WebProxyPassword { get { return _webProxyPassword; } }
        public static string WebProxyPort { get { return _webProxyPort; } }
        public static string WebHttpLogin { get { return _webHttpLogin; } }
        public static string WebHttpPassword { get { return _webHttpPassword; } }
        public static string CommunicationSlackUrl { get { return _communicationSlackUrl; } }
        public static string CommunicationSlackAccount { get { return _communicationSlackAccount; } }
        public static string CommunicationSlackTopic { get { return _communicationSlackTopic; } }
        public static string CommunicationSlackToken { get { return _communicationSlackToken; } }
        public static string CommunicationMailLogin { get { return _communicationMailLogin; } }
        public static string CommunicationMailPassword { get { return _communicationMailPassword; } }
        public static string CommunicationMailSmtpPort { get { return _communicationMailSmtpPort; } }
        public static string CommunicationMailSmtpHost { get { return _communicationMailSmtpHost; } }
        public static string LogisticSncfToken { get { return _logisticSncfToken; } }
        public static string DatabaseHost { get { return _databaseHost; } }
        public static string DatabaseLogin { get { return _databaseLogin; } }
        public static string DatabaseName { get { return _databaseName; } }
        public static string DatabasePassword { get { return _databasePassword; } }
        public static string GithubHost { get { return _githubHost; } }
        public static string GithubLogin { get { return _githubLogin; } }
        public static string GithubPassword { get { return _githubPassword; } }
        public static string SonarHost { get { return _sonarHost; } }
        public static string SonarLogin { get { return _sonarLogin; } }
        public static string SonarPassword { get { return _sonarPassword; } }
        public static string JiraHost { get { return _jiraHost; } }
        public static string JiraLogin { get { return _jiraLogin; } }
        public static string JiraPassword { get { return _jiraPassword; } }
        public static string TeamCityHost { get { return _teamcityHost; } }
        public static string TeamCityLogin { get { return _teamcityLogin; } }
        public static string TeamCityPassword { get { return _teamcityPassword; } }
        public static string JenkinsHost { get { return _jenkinsHost; } }
        public static string JenkinsLogin { get { return _jenkinsLogin; } }
        public static string JenkinsPassword { get { return _jenkinsPassword; } }
        public static string DockerHost { get { return _dockerHost; } }
        public static string DockerLogin { get { return _dockerLogin; } }
        public static string DockerPassword { get { return _dockerPassword; } }
        #endregion

        #region Constructor
        static Params()
        {
            LoadXmlParamsFile();
        }
        #endregion

        #region Methods private
        private static void LoadXmlParamsFile()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(CONFIGFILE);

            _webProxyHost = xml.SelectNodes("/configmanager/web/proxy/host").Count > 0 ? xml.SelectNodes("/configmanager/web/proxy/host")[0].InnerText : string.Empty;
            _webProxyLogin = xml.SelectNodes("/configmanager/web/proxy/login").Count > 0 ? xml.SelectNodes("/configmanager/web/proxy/login")[0].InnerText : string.Empty;
            _webProxyPassword = xml.SelectNodes("/configmanager/web/proxy/password").Count > 0 ? xml.SelectNodes("/configmanager/web/proxy/password")[0].InnerText : string.Empty;
            _webProxyPort = xml.SelectNodes("/configmanager/web/proxy/port").Count > 0 ? xml.SelectNodes("/configmanager/web/proxy/port")[0].InnerText : string.Empty;
            _webHttpLogin = xml.SelectNodes("/configmanager/web/http/login").Count > 0 ? xml.SelectNodes("/configmanager/web/http/login")[0].InnerText : string.Empty;
            _webHttpPassword = xml.SelectNodes("/configmanager/web/http/password").Count > 0 ? xml.SelectNodes("/configmanager/web/http/password")[0].InnerText : string.Empty;
            _communicationSlackToken = xml.SelectNodes("/configmanager/communication/slack/token").Count > 0 ? xml.SelectNodes("/configmanager/communication/slack/token")[0].InnerText : string.Empty;
            _communicationSlackUrl = xml.SelectNodes("/configmanager/communication/slack/url").Count > 0 ? xml.SelectNodes("/configmanager/communication/slack/url")[0].InnerText : string.Empty;
            _communicationSlackAccount = xml.SelectNodes("/configmanager/communication/slack/account").Count > 0 ? xml.SelectNodes("/configmanager/communication/slack/account")[0].InnerText : string.Empty;
            _communicationSlackTopic = xml.SelectNodes("/configmanager/communication/slack/topic").Count > 0 ? xml.SelectNodes("/configmanager/communication/slack/topic")[0].InnerText : string.Empty;
            _communicationMailLogin = xml.SelectNodes("/configmanager/communication/mail/login").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/login")[0].InnerText : string.Empty;
            _communicationMailPassword = xml.SelectNodes("/configmanager/communication/mail/password").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/password")[0].InnerText : string.Empty;
            _communicationMailSmtpPort = xml.SelectNodes("/configmanager/communication/mail/smtp").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/smtp")[0].Attributes.GetNamedItem("port").Value : string.Empty;
            _communicationMailSmtpHost = xml.SelectNodes("/configmanager/communication/mail/smtp").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/smtp")[0].Attributes.GetNamedItem("host").Value : string.Empty;
            _logisticSncfToken = xml.SelectNodes("/configmanager/logistic/sncfkey").Count > 0 ? xml.SelectNodes("/configmanager/logistic/sncfkey")[0].InnerText : string.Empty;
            _databaseHost = xml.SelectNodes("/configmanager/database/host").Count > 0 ? xml.SelectNodes("/configmanager/database/host")[0].InnerText : string.Empty;
            _databasePassword = xml.SelectNodes("/configmanager/database/password").Count > 0 ? xml.SelectNodes("/configmanager/database/password")[0].InnerText : string.Empty;
            _databaseLogin = xml.SelectNodes("/configmanager/database/login").Count > 0 ? xml.SelectNodes("/configmanager/database/login")[0].InnerText : string.Empty;
            _databaseName = xml.SelectNodes("/configmanager/database/name").Count > 0 ? xml.SelectNodes("/configmanager/database/name")[0].InnerText : string.Empty;
            _githubHost = xml.SelectNodes("/configmanager/github/host").Count > 0 ? xml.SelectNodes("/configmanager/github/host")[0].InnerText : string.Empty;
            _githubPassword = xml.SelectNodes("/configmanager/github/password").Count > 0 ? xml.SelectNodes("/configmanager/github/password")[0].InnerText : string.Empty;
            _githubLogin = xml.SelectNodes("/configmanager/github/login").Count > 0 ? xml.SelectNodes("/configmanager/github/login")[0].InnerText : string.Empty;
            _jiraHost = xml.SelectNodes("/configmanager/jira/host").Count > 0 ? xml.SelectNodes("/configmanager/jira/host")[0].InnerText : string.Empty;
            _jiraPassword = xml.SelectNodes("/configmanager/jira/password").Count > 0 ? xml.SelectNodes("/configmanager/jira/password")[0].InnerText : string.Empty;
            _jiraLogin = xml.SelectNodes("/configmanager/jira/login").Count > 0 ? xml.SelectNodes("/configmanager/jira/login")[0].InnerText : string.Empty;
            _sonarHost = xml.SelectNodes("/configmanager/sonar/host").Count > 0 ? xml.SelectNodes("/configmanager/sonar/host")[0].InnerText : string.Empty;
            _sonarPassword = xml.SelectNodes("/configmanager/sonar/password").Count > 0 ? xml.SelectNodes("/configmanager/sonar/password")[0].InnerText : string.Empty;
            _sonarLogin = xml.SelectNodes("/configmanager/sonar/login").Count > 0 ? xml.SelectNodes("/configmanager/sonar/login")[0].InnerText : string.Empty;
            _teamcityHost = xml.SelectNodes("/configmanager/teamcity/host").Count > 0 ? xml.SelectNodes("/configmanager/teamcity/host")[0].InnerText : string.Empty;
            _teamcityPassword = xml.SelectNodes("/configmanager/teamcity/password").Count > 0 ? xml.SelectNodes("/configmanager/teamcity/password")[0].InnerText : string.Empty;
            _teamcityLogin = xml.SelectNodes("/configmanager/teamcity/login").Count > 0 ? xml.SelectNodes("/configmanager/teamcity/login")[0].InnerText : string.Empty;
            _jenkinsHost = xml.SelectNodes("/configmanager/jenkins/host").Count > 0 ? xml.SelectNodes("/configmanager/jenkins/host")[0].InnerText : string.Empty;
            _jenkinsPassword = xml.SelectNodes("/configmanager/jenkins/password").Count > 0 ? xml.SelectNodes("/configmanager/jenkins/password")[0].InnerText : string.Empty;
            _jenkinsLogin = xml.SelectNodes("/configmanager/jenkins/login").Count > 0 ? xml.SelectNodes("/configmanager/jenkins/login")[0].InnerText : string.Empty;
            _dockerHost = xml.SelectNodes("/configmanager/docker/host").Count > 0 ? xml.SelectNodes("/configmanager/docker/host")[0].InnerText : string.Empty;
            _dockerPassword = xml.SelectNodes("/configmanager/docker/password").Count > 0 ? xml.SelectNodes("/configmanager/docker/password")[0].InnerText : string.Empty;
            _dockerLogin = xml.SelectNodes("/configmanager/docker/login").Count > 0 ? xml.SelectNodes("/configmanager/docker/login")[0].InnerText : string.Empty;
        }
        #endregion
    }
}
