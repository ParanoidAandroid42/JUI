using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JLibrary.JUI
{
    public class JUI : MonoBehaviour
    {
        public Transform Transform { get; private set; }

        [HideInInspector] public WhichElement WhichElementEnum;
        public bool Active
        {
            get => enabled;
            set => enabled = value;
        }

        protected virtual void Awake()
        {
            Transform = transform;
        }

    }
}

