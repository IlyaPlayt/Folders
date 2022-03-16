using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class IconInfo : ScriptableObject
    {
        [SerializeField] private string iconName;
        [SerializeField] private string prefName;

        public string IconName => iconName;

        public string PrefName => prefName;
    }
}