using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity;

namespace ChummerHub.Models.V1
{
    [DataContract]
    [Serializable]
    public class ResultAccountGetUserByEmail : ResultBase
    {
        public ApplicationUser MyApplicationUser { get; set; }

        public ResultAccountGetUserByEmail(ApplicationUser user)
        {
            MyApplicationUser = user;
        }

        public ResultAccountGetUserByEmail(Exception e) : base(e)
        {
            
        }
    }
}
