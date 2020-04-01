using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace View {
    public class MenuView : DefaultView
    {
        public event Action PlayEvent;
        public void ActionPlay() { 
            PlayEvent?.Invoke();
            gameObject.SetActive(false);
        }
    } }
