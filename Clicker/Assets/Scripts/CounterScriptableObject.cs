using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
namespace Counter
    {

    public class CounterScriptableObject : ScriptableObject
    {
        [SerializeField]
        private int _count = 0;

        public int Count => _count;


        public event Action<int> UpdateScore;
        public event Action GameOver;
        public void OnEnable()
        {
            _count = 0;
            UpdateScore = null;
            GameOver = null;

        }


        public void AddValue(int count)
        {
            _count += count;
            UpdateScore?.Invoke(_count);
        }
        public void SetGameOVer() {
            GameOver?.Invoke();

        }

#if UNITY_EDITOR
        [MenuItem("Assets/Create/CounterScriptableObject")]
        public static void CreateMyAsset()
        {
            CounterScriptableObject asset = CreateInstance<CounterScriptableObject>();
            AssetDatabase.CreateAsset(asset, "Assets/Counters/NewCounterScriptableObject.asset");
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }
#endif
    }
}