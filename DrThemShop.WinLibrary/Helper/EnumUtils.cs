using DrThemShop.WinLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace DrThemShop.WinLibrary.Helper
{
    public static class EnumHelper
    {
        public static string GetEnumDescription(Enum value, string defaultValue)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null &&
                attributes.Length > 0)
            {
                return attributes[0].Description;
            }

            return defaultValue;
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null &&
                attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public static List<SelectDisplayItem<T>> GetList<T>()
        {
            List<SelectDisplayItem<T>> result = new List<SelectDisplayItem<T>>();
            var temps = Enum.GetValues(typeof(T));
            foreach (var enumValue in temps)
            {
                SelectDisplayItem<T> displayItem = new SelectDisplayItem<T>()
                {
                    ID = (T)enumValue,
                    Name = GetEnumDescription((Enum)enumValue)
                };
                result.Add(displayItem);
            }

            return result;
        }

        public static T FromString<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}
