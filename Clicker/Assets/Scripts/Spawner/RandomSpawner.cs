using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RandomSpawner
{

    public class RandomSpawner : MonoBehaviour
    {
        private Vector3 _min;
        private Vector3 _randomPosition;
        private Vector3 _max;
        public float CenterDistanceX;
        public float CenterDistanceY;
        public float SpawnTime;
        [SerializeField]
        private GameObject Bubble;
       
    
        private void setRanges()
        {
            _min = gameObject.transform.position - new Vector3(CenterDistanceX, CenterDistanceY, 0);
            _max = gameObject.transform.position + new Vector3(CenterDistanceX, CenterDistanceY, 0);
        }

        public IEnumerator SpawnRoutine
        {
            get
            {
                yield return new WaitForSeconds(SpawnTime);
                while (true)
                {
                    float x = Random.Range(_min.x, _max.x);
                    float y = Random.Range(_min.y, _max.y);
                    float z = 0;
                    _randomPosition = new Vector3(x, y, z);
                    Instantiate(Bubble, _randomPosition, Quaternion.identity);
                    yield return new WaitForSeconds(SpawnTime);
                }
            }
        }
        
    }
    
		
}
