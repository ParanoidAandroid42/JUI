using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JLibrary.JUI
{
    [RequireComponent(typeof(Text))]
    public class TextManager : JUI
    {
        public Text TextComponent { get; set; }
        public string Text
        {
            get => TextComponent.text;
            set => TextComponent.text = value;
        }
        public int FontSize
        {
            get => TextComponent.fontSize;
            set => TextComponent.fontSize = value;
        }

        protected override void Awake()
        {
            base.Awake();
            Initialize();
        }
        private void Initialize()
        {
            TextComponent = GetComponent<Text>();
        }
    }
}

