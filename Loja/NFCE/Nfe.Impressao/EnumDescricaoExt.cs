using System;
using System.ComponentModel;
using System.Reflection;

namespace NFe.Utils
{
    public static class EnumDescricaoExt
    {
        public static string Descricao(this Enum value)
        {
            if (value == null)
                return null;

            var members = value.GetType().GetMember(value.ToString());
            if (members.Length == 0)
                return value.ToString();

            var attribute = members[0].GetCustomAttribute<DescriptionAttribute>(false);
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
