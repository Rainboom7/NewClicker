using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameOverWindow;
namespace Counter
{

    public class checkForGameOver : MonoBehaviour
    {
        public CounterUpdateView CounterUpdateView;
        public GameOverWindow.GameOverWindow GameOverWindow;
        // Start is called before the first frame update
        private void Start()
        {
            GameOverWindow.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (CounterUpdateView.GameIsOver())
                GameOverWindow.Show();
        }
    }

}