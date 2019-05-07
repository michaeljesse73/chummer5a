using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity;

namespace ChummerHub.Models.V1
{
    public class ResultSinnerGetOwnedSINByAlias : ResultBase
    {
        public List<SINner> MySINners { get; set; }

        public ResultSinnerGetOwnedSINByAlias()
        {
            MySINners = new List<SINner>();
        }

        public ResultSinnerGetOwnedSINByAlias(List<SINner> list)
        {
            MySINners = list;
        }

        public ResultSinnerGetOwnedSINByAlias(Exception e) : base(e)
        {

        }
    }
}
