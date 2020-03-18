using UnityEngine;
using Counter;
namespace ActionBehaviour
{

    public class AddCounterActionBehaviour : ActionBehaviour
    {
        [SerializeField]
        private int _addScore = 1;

        public CounterScriptableObject _scoreCounter;

        public override void Execute()
        {
            _scoreCounter.AddValue(_addScore);
        }

    }
}