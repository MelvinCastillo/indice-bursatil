using System;
using System.DirectoryServices;
using System.Collections.Generic;

namespace BVRD.Security.Utils
{
    /// <summary>
    /// This class performs user authentication against Active Directory and
    /// Novell Edirectory.
    /// </summary>
    public class LDapAuthenticate
    {

        public string MSG { get; set; }

        /// <summary>
        /// string specifying user name
        /// </summary>
        private string strUser;

        /// <summary>
        /// string specifying user password
        /// </summary>
        private string strPass;

        /// <summary>
        /// string specifying user domain
        /// </summary>
        private string strDomain;

        /// <summary>
        /// AuthenticationTypes specifying the security 
        /// protocol to use, i.e. Secure, SSL
        /// </summary>
        private AuthenticationTypes atAuthentType;

        /// <summary>
        /// default constructor
        /// </summary>
        public LDapAuthenticate()
        {
        }

        /// <summary>
        /// function that sets the domain name
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>It returns true, if user passed 
        ///          something; otherwise, false</returns>
        public bool SetDomain(string strValue)
        {
            if (strValue.Length <= 0)
                return false;

            this.strDomain = "LDAP://" + strValue;
            return true;
        }

        /// <summary>
        /// function that sets user name
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>It returns true, if user passed 
        ///          something; otherwise, false</returns>
        public bool SetUser(string strValue)
        {
            if (strValue.Length <= 0)
                return false;

            this.strUser = strValue;
            return true;
        }

        /// <summary>
        /// function that sets user password
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>It returns true, if user passed 
        ///          something; otherwise, false</returns>
        public bool SetPass(string strValue)
        {
            if (strValue.Length <= 0)
                return false;

            this.strPass = strValue;
            return true;
        }

        /// <summary>
        /// function that sets user authentication type
        /// </summary>
        /// <param name="bValue"></param>
        public void SetAuthenticationType(bool bValue)
        {
            // set ssl to true if true is found
            if (bValue)
                atAuthentType = AuthenticationTypes.SecureSocketsLayer;
            // otherwise set it to secure  
            else
                atAuthentType = AuthenticationTypes.Secure;
        }

        /// <summary>
        /// function that performs login task
        /// and welcomes user if they are verified
        /// </summary>
        public bool Login()
        {            
            using (DirectoryEntry deDirEntry = new DirectoryEntry(this.strDomain,
                                                                 this.strUser,
                                                                 this.strPass,
                                                                 this.atAuthentType))
            {                
                try
                {
                    if (!string.IsNullOrEmpty(deDirEntry.Name))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }                    
                }
                catch (Exception ex)
                {
                    MSG = ex.Message.ToString();
                    return false;
                }
            }
        }

        public List<Users> GetADUsers()
        {
            try
            {
                List<Users> lstADUsers = new List<Users>();
                string DomainPath = this.strDomain;
                DirectoryEntry searchRoot = new DirectoryEntry(DomainPath);
                DirectorySearcher search = new DirectorySearcher(searchRoot);
                search.Filter = "(&(objectClass=user)(objectCategory=person))";
                search.PropertiesToLoad.Add("samaccountname");
                search.PropertiesToLoad.Add("mail");
                search.PropertiesToLoad.Add("usergroup");
                search.PropertiesToLoad.Add("displayname");
                SearchResult result;
                SearchResultCollection resultCol = search.FindAll();
                if (resultCol != null)
                {
                    for (int counter = 0; counter < resultCol.Count; counter++)
                    {
                        string UserNameEmailString = string.Empty;
                        result = resultCol[counter];
                        if (result.Properties.Contains("samaccountname") &&
                                 result.Properties.Contains("mail") &&
                            result.Properties.Contains("displayname"))
                        {
                            Users objSurveyUsers = new Users();
                            objSurveyUsers.Email = (String)result.Properties["mail"][0] +
                              "^" + (String)result.Properties["displayname"][0];
                            objSurveyUsers.UserName = (String)result.Properties["samaccountname"][0];
                            objSurveyUsers.DisplayName = (String)result.Properties["displayname"][0];

                            lstADUsers.Add(objSurveyUsers);
                        }
                    }
                }
                return lstADUsers;
            }
            catch (Exception ex)
            {
                MSG = ex.Message.ToString();
                return null;
            }
        }
    }

    public class Users
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public bool isMapped { get; set; }
    }



}
