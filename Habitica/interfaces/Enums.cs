using System;
using System.Collections.Generic;
using System.Text;

namespace Habitica.interfaces
{
    public enum Attribute
    {
        Strength,
        Intelligence,
        Perception,
        Constitution
    }

    public class MapAttributes
    {
        public static Attribute? MapPerKey(string input)
        {
            Dictionary<string, Attribute> attributeMap = new Dictionary<string, Attribute>
        {
            { "str", Attribute.Strength },
            { "int", Attribute.Intelligence },
            { "per", Attribute.Perception },
            { "con", Attribute.Constitution }
        };
            if (attributeMap.ContainsKey(input))
            {
                Attribute attribute = attributeMap[input];
                return attribute;
            }
            return null;
        }

        public static string MapPerAttribute(Attribute attribute)
        {


            Dictionary<Attribute, string> attributeValueMap = new Dictionary<Attribute, string>
        {
            { Attribute.Strength ,"str"},
            {  Attribute.Intelligence ,"int"},
            {  Attribute.Perception,"per" },
            {  Attribute.Constitution,"con" }
        };
            return attributeValueMap[attribute];
        }
    }

}
