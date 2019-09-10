using UnityEngine;

namespace SimplyTools.Scriptables.Extras
{
    /// <summary>
    /// Sets the value of a given <see cref="SOTransform"/>
    /// to the <see cref="Transform"/> this scripts is attached to
    /// </summary>
    public class SOTransformRegister : RegisterToSOVariable<SOTransform, Transform>
    {
        protected override Transform Value => transform;
    }
}