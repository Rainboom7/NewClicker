using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using ActionBehaviour;
namespace ActionBehaviour
{


    public class OnMouseClick : MonoBehaviour
    {
        public SpriteRenderer Sprite;
        public List<ActionBehaviour> Actions;
        [SerializeField]
        private Controller.GameController _gameController;
        public int Score;
        private void OnMouseDown()
        {
            if (Input.GetMouseButtonDown(0))
            {
                AnimateExplosion();

            }
        }
        private void AnimateExplosion()
        {

            var seq = DOTween.Sequence();
            seq.Append(gameObject.transform.DOScaleX(0, 0.3f));
            seq.Join(gameObject.transform.DOScaleY(0, 0.3f));
            seq.Join(Sprite.DOFade(0, 0.3f));
            seq.OnComplete(() => DestroyAndAddScore());

        }
        private void DestroyAndAddScore()
        {

            _gameController.AddScore(Score);
            foreach (var action in Actions)
            {
                action.Execute();
            }
        }
    }

}
