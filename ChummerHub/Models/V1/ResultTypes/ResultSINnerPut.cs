using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity;

namespace ChummerHub.Models.V1
{
    public class ResultSINnerPut : ResultBase
    {
        public SINner MySINner { get; set; }

        public ResultSINnerPut()
        {
            MySINner = new SINner();
        }

        public ResultSINnerPut(SINner sin)
        {
            MySINner = sin;
        }

        public ResultSINnerPut(Exception e) : base(e)
        {

        }
    }
}
