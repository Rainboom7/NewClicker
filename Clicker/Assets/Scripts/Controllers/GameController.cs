using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Controller {

    [CreateAssetMenu(menuName = "Game Controller")]
    public class GameController : ScriptableObject
    {
        public event Action EndGameEvent;
        public event Action<int> ChangeScoreEvent;
        private int _score;
        private View.GameView _view;
                

        public void AddScore(int value)
        {
            _score += value;
            ChangeScoreEvent?.Invoke(_score);
        }
        public void NewGame()
        {
            _score = 0;
            _view?.StartGame();
        }
        public int GetScore()
        {
            return _score;
        }

       
        public void OnOpen(View.GameView view)
        {
            view.PlayerDeadEvent += OnPlayerDead;
            _view = view;
        }

        public void OnClose(View.GameView view)
        {
            view.PlayerDeadEvent -= OnPlayerDead;
            _view = null;
        }

        public void OnPlayerDead()
        { 
            _view?.StopGame();
        }

       
    }

}
