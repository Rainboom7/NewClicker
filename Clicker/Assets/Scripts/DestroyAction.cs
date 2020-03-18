using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ActionBehaviour 
{

public class DestroyAction : ActionBehaviour
    {
        public override void Execute()
        {
            Destroy(gameObject);
        }
    }
}
