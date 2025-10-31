using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace OnlineShop.Helpers
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field == null)
                return value.ToString();

            var attribute = field
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .Cast<DisplayAttribute>()
                .FirstOrDefault();

            return attribute?.Name ?? value.ToString();
        }
    }
}
