using UnityEditor;
using UnityEngine;

namespace SimplyTools.Scriptables.Extras
{
    [CustomPropertyDrawer(typeof(Vector2Ref))]
    public class SOVector2RefEditor : SOVariableRefEditor<Vector2, SOVector2> { }
}