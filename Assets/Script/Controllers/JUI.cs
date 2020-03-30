using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JLibrary.JUI
{
    public class JUI : MonoBehaviour
    {
        public Transform Transform { get; private set; }
        public GameObject GameObject { get; private set; }

        public WhichElement WhichElementEnum { get; protected set; }
        protected virtual void Awake()
        {
            Transform = transform;
            GameObject = gameObject;
        }
        private void OnDisable()
        {

        }
    }
}

