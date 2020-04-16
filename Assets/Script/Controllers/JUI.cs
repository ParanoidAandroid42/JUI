using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JLibrary.JUI
{
    public class JUI : MonoBehaviour
    {
        public Transform Transform { get; private set; }
        public WhichElement WhichElementEnum { get; protected set; }

        protected virtual void Awake()
        {
            Transform = transform;
        }
        public bool GetActive()
        {
            return enabled;
        }

        public void SetActive(bool value)
        {
            enabled = value;
        }
    }
}

