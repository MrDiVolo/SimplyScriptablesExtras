using UnityEditor;
using UnityEngine;

namespace SimplyTools.Scriptables.Extras
{
    [CustomPropertyDrawer(typeof(Vector3Ref))]
    public class SOVector3RefEditor : SOVariableRefEditor<Vector3, SOVector3> { }
}