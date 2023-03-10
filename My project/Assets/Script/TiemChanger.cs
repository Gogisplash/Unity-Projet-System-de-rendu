using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Script
{
    public class TiemChanger : MonoBehaviour
    {
        [SerializeField] private Material skybox;
        private float _elapsedTime = 0f;
        private float _timeScale = 2.5f;
        private static readonly int Rotation = Shader.PropertyToID("_Rotation");

        //pour cycle jour nuit
        //private static readonly int Exposure = Shader.PropertyToID("_Exposure");


        void Update()
        {
            _elapsedTime += Time.deltaTime;
            skybox.SetFloat(Rotation, _elapsedTime * _timeScale);

            //pour cycle jour nuit
            //skybox.SetFloat(Exposure, Mathf.Clamp(Mathf.Sin(_elapsedTime), 0.15f, 1f));
        }
    }
}

