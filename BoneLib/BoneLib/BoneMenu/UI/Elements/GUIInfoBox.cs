using Il2CppTMPro;
using UnityEngine;

namespace BoneLib.BoneMenu.UI
{
    [MelonLoader.RegisterTypeInIl2Cpp]
    public class GUIInfoBox : MonoBehaviour
    {
        public GUIInfoBox(System.IntPtr ptr) : base(ptr) { }

        private TextMeshProUGUI _headerText;
        private TextMeshProUGUI _descriptionText;
        private Element _element;

        public void Show()
        {
            gameObject.SetActive(!gameObject.activeInHierarchy);
        }

        public void AssignElement(Element element)
        {
            _element = element;

            if (_element.HasTooltip)
            {
                _headerText.text = $"(!) INFO - {_element.ElementName}";
                _descriptionText.text = _element.ElementTooltip;
            }
        }
    }
}