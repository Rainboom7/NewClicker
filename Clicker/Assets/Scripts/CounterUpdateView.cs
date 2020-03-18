using UnityEngine;
using UnityEngine.UI;
namespace Counter
{

    public class CounterUpdateView : MonoBehaviour
    {

        public Text CountText;
        [SerializeField]
        private CounterScriptableObject _counterScriptableObject;
        static private bool _gameOver = false;
        private void Start()
        {
            _counterScriptableObject.ResetCounter();
            _counterScriptableObject.UpdateScore += UpdateCounter;
            _counterScriptableObject.GameOver += GameOver;
        }

        private void OnEnable()
        {
            _gameOver = false;
            UpdateCounter(_counterScriptableObject.Count);
        }

        private void UpdateCounter(int count)
        {
            CountText.text = count.ToString();
        }
        public void GameOver()
        {
            _gameOver = true;
        }
        public bool GameIsOver()
        {
            return _gameOver;
        }

    }
}
