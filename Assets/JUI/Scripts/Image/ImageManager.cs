using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JLibrary.JUI
{
    [RequireComponent(typeof(Image))]
    public class ImageManager : JUI
    {
        public Image ImageComponent { get; set; }
        public Sprite Sprite
        {
            get => ImageComponent.sprite;
            set => ImageComponent.sprite = value;
        }

        public Material Material
        {
            get => ImageComponent.material;
            set => ImageComponent.material = value;
        }

        protected override void Awake()
        {
            base.Awake();
            Initialize();
        }

        public void Initialize()
        {
            ImageComponent = GetComponent<Image>();
        }
    }
}

