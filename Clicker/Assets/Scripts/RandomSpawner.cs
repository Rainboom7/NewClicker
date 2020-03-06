﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    private Vector3 Min;
    private float _x;
    private float _y;
    private float _z;
    private Vector3 _randomPosition;
    private Vector3 Max;
    public float _centerDistanceX;
    public float _centerDistanceY;
    public float spawntime ;
    public GameObject bubble;
    // Start is called before the first frame update
    void Start()
    {
        setRanges();
        InvokeRepeating("RandomInstantiate", spawntime, spawntime);


    }

    // Update is called once per frame

    private void setRanges()
    {
        Min = gameObject.transform.position - new Vector3(_centerDistanceX, _centerDistanceY,0);
        Max = gameObject.transform.position + new Vector3(_centerDistanceX, _centerDistanceY,0);
    }
    private void RandomInstantiate() {
        _x = Random.Range(Min.x, Max.x);
        _y = Random.Range(Min.y, Max.y);
        _z = 0;
        _randomPosition = new Vector3(_x, _y, _z);
        Instantiate(bubble, _randomPosition, Quaternion.identity);

    }
}
