using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace JLibrary.JUI
{
    [RequireComponent(typeof(Button))]
    public class ButtonManager : JUI
    {
        public UnityEvent OnClick;
        private Button ButtonObj { get; set; }
        public bool Interactable { get { return ButtonObj.interactable; } }

        private new void Awake()
        {
            base.Awake();
            ButtonObj = GetComponent<Button>();
            ButtonObj.onClick.AddListener(ButtonOnClick);
            WhichElementEnum = WhichElement.Button;
        }

        private void ButtonOnClick()
        {
            OnClick?.Invoke();
        }
    }
}

