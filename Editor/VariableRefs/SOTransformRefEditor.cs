using UnityEditor;
using UnityEngine;

namespace SimplyTools.Scriptables.Extras
{
    [CustomPropertyDrawer(typeof(TransformRef))]
    public class SOTransformRefEditor : SOVariableRefEditor<Transform, SOTransform> { }
}