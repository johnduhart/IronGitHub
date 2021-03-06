﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IronGitHub.Entities
{
    [DataContract]
    public enum RepositoryTypes
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "forks")]
        Forks,
        [EnumMember(Value = "sources")]
        Sources,
        [EnumMember(Value = "member")]
        Member,
    }

    public static class RepositoryTypeExtensions
    {
        public static string ToParameterValue(this RepositoryTypes? type)
        {
            if (type == null)
                return null;
            return CustomEnumValueSerializer<RepositoryTypes>.ToJsonValue(type.Value);
        }
    }
}
