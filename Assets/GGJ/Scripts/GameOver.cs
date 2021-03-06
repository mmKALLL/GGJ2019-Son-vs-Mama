﻿using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace GGJ.Scripts
{
    public class GameOver : MonoBehaviour
    {
        [Inject] ZenjectSceneLoader sceneLoader;

        [SerializeField] Button button = default;

        void Start()
        {
            button.OnClickAsObservable()
                .Subscribe(_ => sceneLoader.LoadScene("Title"));
        }
    }
}