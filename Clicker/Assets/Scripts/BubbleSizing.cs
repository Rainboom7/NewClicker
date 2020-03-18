using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using ActionBehaviour;
namespace BubbleSizing
{


    public class BubbleSizing : MonoBehaviour
    {
        public SpriteRenderer BubbleSprite;
        private Vector3 _currentScale;
        public GameOverAction GameOverAction;

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
                GameOverAction?.Execute();

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


