using UnityEditor;
using UnityEngine;

namespace SimplyTools.Scriptables.Extras
{
    [CustomPropertyDrawer(typeof(KeyCodeRef))]
    public class SOKeyCodeRefEditor : SOVariableRefEditor<KeyCode, SOKeyCode> { }
}