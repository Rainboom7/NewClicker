using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using ActionBehaviour;
namespace OnMouseClick
{ 


    public class OnMouseClick : MonoBehaviour
    {
        public SpriteRenderer Sprite;
        public List<ActionBehaviour.ActionBehaviour> Actions;
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
            seq.OnComplete(() => ExecuteAllActions());

        }
        private void ExecuteAllActions()
        {

            foreach (var action in Actions)
            {
                action.Execute();
            }
        }
    }

}
