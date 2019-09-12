using UnityEditor;

namespace SimplyTools.Scriptables.Extras
{
    [CustomPropertyDrawer(typeof(BoolRef))]
    public class SOBoolRefEditor : SOVariableRefEditor<bool, SOBool> { }
}