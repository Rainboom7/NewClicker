using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace View
{
    public class  DefaultView : MonoBehaviour
    {

        public void Show()
        {
            gameObject.SetActive(true);
        }
        public void Hide()
        {
            gameObject.SetActive(false);

        }
    }
}