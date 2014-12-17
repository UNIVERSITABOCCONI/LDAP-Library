﻿using System.DirectoryServices.Protocols;
using LDAPLibrary.Logger;

namespace LDAPLibrary.Interfarces
{
    public interface ILdapConfigRepository
    {
        //Configurations Patterns

        void BasicLdapConfig(ILdapUser adminUser, string server, string searchBaseDn, AuthType authType);

        void AdditionalLdapConfig(
            bool secureSocketLayerFlag, bool transportSocketLayerFlag, bool clientCertificateFlag,
            string clientCertificatePath,
            LoggerType writeLogFlag, string logPath, string userObjectClass, string matchFieldUsername);

        // Getters

        ILdapUser GetAdminUser();
        string GetServer();
        string GetSearchBaseDn();
        AuthType GetAuthType();
        bool GetSecureSocketLayerFlag();
        bool GetTransportSocketLayerFlag();
        bool GetClientCertificateFlag();
        string GetClientCertificatePath();
        LoggerType GetWriteLogFlag();
        string GetLogPath();
        string GetUserObjectClass();
        string GetMatchFieldName();
    }
}