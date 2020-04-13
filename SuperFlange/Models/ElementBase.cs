using SuperFlange.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SuperFlange.Models
{
    public class ElementBase : Model
    {
        public IEnumerable<MeasureProperty> RequiredProperties
        {
            get
            {
                List<MeasureProperty> requiredProperties = new List<MeasureProperty>();
                PropertyInfo[] properties = GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in properties)
                {
                    Measure measureAttribute = propertyInfo.GetCustomAttribute(typeof(Measure)) as Measure;

                    if (measureAttribute != null && measureAttribute.IsRequired)
                    {
                        requiredProperties.Add(new MeasureProperty(this, propertyInfo, measureAttribute));
                    }
                }

                return requiredProperties.OrderBy(p => p.Measure.Order);
            }
        }
    }

    public class MeasureProperty
    {
        public PropertyInfo PropertyInfo { get; }

        public ElementBase Element { get; }

        public Measure Measure { get; }

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
        public string Units => Measure.Units;

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

        public MeasureProperty(ElementBase element, PropertyInfo propertyInfo, Measure measure)
        {
            Element = element;
            PropertyInfo = propertyInfo;
            Measure = measure;
        }
    }

    public class Measure : Attribute
    {
        public string Name { get; }
        public string Units { get; }
        public bool IsRequired { get; }
        public int Order { get; }

        public Measure(int order, string name = null, string units = null, bool isRequired = false)
        {
            Name = name;
            Units = units;
            IsRequired = isRequired;
            Order = order;
        }
    }
}