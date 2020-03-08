using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForGameOver : MonoBehaviour
{
    public CounterUpdateView counterUpdateView;
    public GameOverWindow GameOverWindow;
    // Start is called before the first frame update
    private void Start()
    {
        GameOverWindow.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (counterUpdateView.GameIsOver())
            GameOverWindow.Show();
    }
}
