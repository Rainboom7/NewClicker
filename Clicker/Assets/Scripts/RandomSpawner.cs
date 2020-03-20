﻿using System.Collections;
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
        private float _timer;
        void Start()
        {
            setRanges();
        }
        private void FixedUpdate()
        {
            _timer -= Time.fixedDeltaTime;

            if (_timer > 0)
                return;

            _timer += SpawnTime;
            RandomInstantiate();
        }

        private void setRanges()
        {
            _min = gameObject.transform.position - new Vector3(CenterDistanceX, CenterDistanceY, 0);
            _max = gameObject.transform.position + new Vector3(CenterDistanceX, CenterDistanceY, 0);
        }
        private void RandomInstantiate()
        {
            float x = Random.Range(_min.x, _max.x);
            float y = Random.Range(_min.y, _max.y);
            float z = 0;
            _randomPosition = new Vector3(x, y, z);
            Instantiate(Bubble, _randomPosition, Quaternion.identity);

        }
    }
}
