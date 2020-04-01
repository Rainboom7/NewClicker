using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace View
{

    public class GameOverWindow : MonoBehaviour
    {

        [SerializeField]
        private Counter.CounterUpdateView _counter;

        public void Show(int Count)
        {
            _counter.UpdateCounter(Count);
            gameObject.SetActive(true);
        }
        private void Awake()
        {
            gameObject.SetActive(false);
        }



        public void OnRestartButtonClick()
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }

}