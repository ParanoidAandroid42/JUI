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
        public Button ButtonComponent { get; set; }
        public bool Interactable
        {
            get => ButtonComponent.interactable;
            set => ButtonComponent.interactable = value;
        }

        protected override void Awake()
        {
            base.Awake();
            Initialize();
        }
        private void Initialize()
        {
            ButtonComponent = GetComponent<Button>();
            ButtonComponent.onClick.AddListener(ButtonOnClick);
        }

        private void ButtonOnClick() => OnClick?.Invoke();
    }
}

