using UnityEngine;
using VContainer;

namespace AYip.VContainer
{
    public abstract class MonoInstaller : MonoBehaviour, IInstaller
    {
        public abstract void Installer(IContainerBuilder builder);
    }
}