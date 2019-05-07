using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity;

namespace ChummerHub.Models.V1
{
    public class ResultAccountGetSinnersByAuthorization : ResultBase
    {
        public SINSearchGroupResult MySINSearchGroupResult { get; set; }

        public ResultAccountGetSinnersByAuthorization()
        {
            MySINSearchGroupResult = new SINSearchGroupResult();
        }

        public ResultAccountGetSinnersByAuthorization(SINSearchGroupResult ssg)
        {
            MySINSearchGroupResult = ssg;
        }

        public ResultAccountGetSinnersByAuthorization(Exception e) : base(e)
        {

        }
    }
}
