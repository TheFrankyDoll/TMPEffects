using System.Globalization;
using UnityEditor;

namespace TMPEffects.SerializedCollections.Editor.Search
{
    internal class StringMatcher : Matcher
    {
        public override bool IsMatch(SerializedProperty property)
        {
            if ((property.propertyType is SerializedPropertyType.String || property.propertyType is SerializedPropertyType.Character) && property.stringValue.Contains(SearchString, System.StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }
    }
}