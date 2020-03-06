using UnityEngine;

public class AddCounterActionBehaviour : ActionBehaviour
{
		[SerializeField]
		private int _addScore = 1;
		[SerializeField]
		private CounterScriptableObject _scoreCounter;

    public override void Execute()
    {
        _scoreCounter.AddValue(_addScore);
    }

}
