using UnityEditor;

namespace SimplyTools.Scriptables.Extras
{
    [CustomPropertyDrawer(typeof(StringRef))]
    public class SOStringRefEditor : SOVariableRefEditor<string, SOString> { }
}