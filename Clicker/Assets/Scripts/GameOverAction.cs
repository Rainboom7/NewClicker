using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverAction : ActionBehaviour
{
  
    public CounterScriptableObject _scoreCounter;

    public override void Execute()
    {

        _scoreCounter.SetGameOVer() ;
    }
}
