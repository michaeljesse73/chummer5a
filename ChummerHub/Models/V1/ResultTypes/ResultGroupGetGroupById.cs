using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity;

namespace ChummerHub.Models.V1
{
    public class ResultGroupGetGroupById : ResultBase
    {
        public SINnerGroup MyGroup { get; set; }

        public ResultGroupGetGroupById()
        {
            MyGroup = new SINnerGroup();
        }

        public ResultGroupGetGroupById(SINnerGroup group)
        {
            MyGroup = group;
        }

        public ResultGroupGetGroupById(Exception e) : base(e)
        {

        }
    }
}
