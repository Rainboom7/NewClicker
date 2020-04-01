using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace View {
    public class ScoreView : DefaultView
    {
        [SerializeField]
        private Counter.CounterUpdateView _updateView;
        public void AddScore(int Score)
        {
            _updateView.UpdateCounter(Score);
        }
    }
}