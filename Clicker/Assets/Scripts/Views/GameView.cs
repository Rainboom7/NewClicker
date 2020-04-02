using Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace View
{
    public class GameView : DefaultView
    {
        public GameController Controller;
        public Vector3 StartPosition = new Vector3(0f, 0f, -5f);
        public event Action PlayerDeadEvent;
        [SerializeField]
        private RandomSpawner.RandomSpawner _randomSpawner;
        [SerializeField]
        private MenuView _menu;
        [SerializeField]
        private ScoreView _score;
        [SerializeField]
        private View.GameOverWindow _endGameScreen;
        private Coroutine _spawnRoutine;


        private void OnEnable()
        {
            _menu.PlayEvent += Controller.NewGame;
            Controller.ChangeScoreEvent += _score.AddScore;
            Controller.OnOpen(this);

        }
       

        private void OnDisable()
        {
            Controller.OnClose(this);
        }


        public void StartGame()
        {
            
            _spawnRoutine = StartCoroutine(_randomSpawner.SpawnRoutine);
            _score.Show();
        }

        public void StopGame()
        {
            if (_spawnRoutine != null)
            {
                StopCoroutine(_randomSpawner.SpawnRoutine);
                _spawnRoutine = null;
            }
            _score.Hide();
            _endGameScreen.Show(Controller.GetScore());
            _menu.PlayEvent -= Controller.NewGame;
            Controller.ChangeScoreEvent -= _score.AddScore;

        }

        private void OnPlayerDead()
        {
            PlayerDeadEvent?.Invoke();
        }

    }

}