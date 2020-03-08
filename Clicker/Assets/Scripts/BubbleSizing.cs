using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class BubbleSizing : MonoBehaviour
{
    public SpriteRenderer _bubbleSprite;
    private Vector3 currentScale;
    public GameOverAction gameOverAction;

    private void Rescale()
    {
        transform.localScale += currentScale * 0.01f;
    }
    private void OnEnable()
    {
        currentScale = transform.localScale;
    }
    private void FixedUpdate()
    {
        Rescale();
        if (transform.localScale.x >= currentScale.x * 1.6f)
        {
            AnimateBubbleExplosion();
            gameOverAction?.Execute();

        }
    }
    private void AnimateBubbleExplosion()
    {
        var seq = DOTween.Sequence();
        seq.Append(gameObject.transform.DOScaleX(1.2f, 0.06f));
        seq.Join(gameObject.transform.DOScaleY(1.2f, 0.06f));

    }

}


