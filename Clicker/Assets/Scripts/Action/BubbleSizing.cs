using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using ActionBehaviour;
using System;

namespace ActionBehaviour
{


    public class BubbleSizing : MonoBehaviour
    {
        [SerializeField]
        private float _timer=0;
        [SerializeField]
        private Controller.GameController _gameController;
        public bool GameOver = false;
        private Animator _animator;
        private bool isCoroutineExecuting=false;

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void FixedUpdate()
        {
            if (_timer > 0)
                _timer -= Time.deltaTime;
            else { StartCoroutine(ExecuteAfterTime(0.5f, _gameController.OnPlayerDead));
                _animator.SetBool("GameOver", true); }
           
        }
        IEnumerator ExecuteAfterTime(float time, Action task)
        {
            if (isCoroutineExecuting)
                yield break;
            isCoroutineExecuting = true;
            yield return new WaitForSeconds(time);
            task();
            isCoroutineExecuting = false;
        }

    }
}


