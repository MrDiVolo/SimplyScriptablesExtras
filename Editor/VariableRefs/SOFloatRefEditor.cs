using UnityEditor;

namespace SimplyTools.Scriptables.Extras
{
    [CustomPropertyDrawer(typeof(FloatRef))]
    public class SOFloatRefEditor : SOVariableRefEditor<float, SOFloat> { }
}