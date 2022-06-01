using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DissidiaWebUI.Helpers
{
    public static class EnumExtensions
    {
        public static string ToDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
