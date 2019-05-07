using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chummer;

namespace SINners.Models
{
    public partial class SINnerSearchGroup
    {

        public SINnerSearchGroup(SINnerGroup myGroup)
        {
            MyMembers = new List<SINnerSearchGroupMember>();
            
            Id = myGroup.Id;
            MyParentGroupId = myGroup.MyParentGroupId;
            IsPublic = myGroup.IsPublic;
            MySettings = myGroup.MySettings;
            Groupname = myGroup.Groupname;
            //PasswordHash = myGroup.PasswordHash;
            Language = myGroup.Language;
            MyGroups = myGroup.MyGroups;
            MyAdminIdentityRole = myGroup.MyAdminIdentityRole;
        }

        public override string ToString()
        {
            return GroupDisplayname;
        }

        public string GroupDisplayname
        {
            get
            {
                string ret = Groupname;
                if (!(String.IsNullOrEmpty(Language)))
                {
                    //if ((this.MyMembers != null)
                    //    && (this.MyMembers.Any()))
                    //{
                    //    ret += ": " + MyMembers.Count + " members";
                    //}
                }
                return ret;
            }
        }
    }
}
