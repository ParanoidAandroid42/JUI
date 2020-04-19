using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JLibrary.JUI
{
    public class Elements
    {
        public Dictionary<WhichElement, JUI> WhichElement;
        public Elements() 
        {
            WhichElement = new Dictionary<WhichElement, JUI>();
        }
    }
}

