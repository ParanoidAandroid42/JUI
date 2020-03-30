using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace JLibrary.JUI
{
    [RequireComponent(typeof(Image))]
    public class JImage : ImageManager
    {
        public Image ImageObj { get; set; }

        private new void Awake()
        {
            base.Awake();
            ImageObj = GetComponent<Image>();
            WhichElementEnum = WhichElement.Image;
        }
    }
}



