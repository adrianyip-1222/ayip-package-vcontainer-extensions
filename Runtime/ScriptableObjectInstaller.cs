using UnityEngine;
using VContainer;

namespace AYip.VContainer
{
    public abstract class ScriptableObjectInstaller : ScriptableObject, IInstaller
    {
        public abstract void Install(IContainerBuilder builder);
    }
}