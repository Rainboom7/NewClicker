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
        public SpriteRenderer BubbleSprite;
        private Vector3 _currentScale;
        [SerializeField]
        private Controller.GameController _gameController;

        private void Rescale()
        {
            transform.localScale += _currentScale * 0.01f;
        }
        private void OnEnable()
        {
            _currentScale = transform.localScale;
      
        }
        private void FixedUpdate()
        {
            Rescale();
            if (transform.localScale.x >= _currentScale.x * 1.6f)
            {
                AnimateBubbleExplosion();
                _gameController.OnPlayerDead();
                   

            }
        }
        private void AnimateBubbleExplosion()
        {
            var seq = DOTween.Sequence();
            seq.Append(gameObject.transform.DOScaleX(1.2f, 0.06f));
            seq.Join(gameObject.transform.DOScaleY(1.2f, 0.06f));

        }

    }
}


