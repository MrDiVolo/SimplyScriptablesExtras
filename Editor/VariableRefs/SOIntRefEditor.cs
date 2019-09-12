using UnityEditor;

namespace SimplyTools.Scriptables.Extras
{
    [CustomPropertyDrawer(typeof(IntRef))]
    public class SOIntRefEditor : SOVariableRefEditor<int, SOInt> { }
}