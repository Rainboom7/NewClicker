using UnityEngine;
using UnityEngine.UI;
namespace Counter
{

    public class CounterUpdateView : MonoBehaviour
    {

        public Text CountText;
        [SerializeField]
        private CounterScriptableObject _counterScriptableObject;
        private void Start()
        {
            _counterScriptableObject.ResetCounter();
            _counterScriptableObject.UpdateScore += UpdateCounter;
      
        }

        private void OnEnable()
        {

            UpdateCounter(_counterScriptableObject.Count);
        }

        public void UpdateCounter(int count)
        {
            CountText.text = count.ToString();
        }
      

    }
}
