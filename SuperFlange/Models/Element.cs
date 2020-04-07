using SuperFlange.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace SuperFlange.Models
{
    public class Element : Model
    {
        public Material Material { get; set; }
        public List<Point> Points { get; set; }

        public List<ElementProperty> RequiredProperties
        {
            get
            {
                List<ElementProperty> elementProperties = new List<ElementProperty>();
                PropertyInfo[] properties = GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in properties)
                {
                    if (propertyInfo.CustomAttributes.Any(a => a.AttributeType == typeof(RequiredProperty)))
                    {
                        elementProperties.Add(new ElementProperty(this, propertyInfo));
                    }
                }

                return elementProperties;
            }
        }
    }

    public class ElementProperty
    {
        public PropertyInfo PropertyInfo { get; }

        public Element Element { get; }

        public string DataTemplateKey
        {
            get
            {
                if (PropertyInfo.PropertyType.IsEnum)
                    return "EnumPropertyEntryDataTemplate";

                return "StringPropertyEntryDataTemplate";
            }
        }

        public string Name => PropertyInfo.Name;
        public string DisplayName => PropertyInfo.Name.SplitCamelCase();
        public string Units { get; }

        public object Value
        {
            get => PropertyInfo.GetValue(Element);
            set 
            {
                if (PropertyInfo.PropertyType.IsEnum)
                    PropertyInfo.SetValue(Element, Enum.Parse(PropertyInfo.PropertyType, value.ToString().Replace(" ", "")));
                
                else
                    PropertyInfo.SetValue(Element, Convert.ChangeType(value, PropertyInfo.PropertyType));
            } 
        }

        public ElementProperty(Element element, PropertyInfo propertyInfo)
        {
            Element = element;
            PropertyInfo = propertyInfo;
            Units = (Attribute.GetCustomAttribute(PropertyInfo, typeof(Units)) as Units)?.Name;
        }
    }

    public class RequiredProperty : Attribute
    {

    }

    [Measure("")]
    public class Units : Attribute
    {
        public string Name { get; }

        public Units(string name)
        {
            Name = name;
        }
    }

    public class Measure : Attribute
    {
        public string Name { get; }
        public string Units { get; }

        public Measure(string name = null, string units = null)
        {

        }
    }
}
