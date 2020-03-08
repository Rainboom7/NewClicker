using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverWindow : MonoBehaviour
{

    [SerializeField]
    private Text _scoreText;


    public void Show()
    {
        gameObject.SetActive(true);
    }
    private void Awake()
    {
        gameObject.SetActive(false);
    }



    public void OnRestartButtonClick()
		{
        gameObject.SetActive(false);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
