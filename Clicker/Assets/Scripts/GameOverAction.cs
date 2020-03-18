using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Counter;
namespace ActionBehaviour
{

    public class GameOverAction : ActionBehaviour
    {

        public CounterScriptableObject ScoreCounter;

        public override void Execute()
        {

            ScoreCounter.SetGameOVer();
        }
    }
}
