using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSizing : MonoBehaviour
{
    private Vector3 currentScale;
    public List<ActionBehaviour> actions;
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
        if (transform.localScale.x >= currentScale.x * 1.5f) {
            foreach (var action in actions)
            {
                action.Execute();

            }
        }
    }
}
