﻿using System;

using UnityEngine;
using UnityEngine.UI;

using TMPro;

namespace BoneLib.BoneMenu.UI
{
    [MelonLoader.RegisterTypeInIl2Cpp]
    public class UIElement : MonoBehaviour
    {
        public UIElement(IntPtr ptr) : base(ptr) { }

        protected MenuElement _element;

        protected virtual TextMeshPro _nameText { get => GetTextMesh("Name"); }
        protected virtual TextMeshPro _valueText { get => GetTextMesh("Value"); }

        public void AssignElement(MenuElement element)
        {
            _element = element;
            _element.SetNameTextMesh(_nameText);
            _element.SetValueTextMesh(_valueText);

            _nameText.text = _element.Name;
            _nameText.color = _element.Color;
        }

        public TextMeshPro GetTextMesh(string path)
        {
            if(transform.Find(path) == null)
            {
                return null;
            }

            return transform.Find(path).GetComponent<TextMeshPro>();
        }
    }
}