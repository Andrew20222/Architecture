using System;
using System.Collections;
using Scenes.Scripts;
using UnityEngine;

namespace Architecture
{
    public class Tester : MonoBehaviour
    {
        public static Scene Scene;
        public static InteractorsBase InteractorsBase;
        public static RepositoriesBase RepositoriesBase;
        private void Start()
        {
            var sceneConfig = new SceneConfigExample();
            var scene = new Scene(sceneConfig);

            StartCoroutine(scene.InitializeRoutine());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Scene.GetInteractor<BankInteractor>().AddCoins(this,1);
                Debug.Log(InteractorsBase.GetInteractor<BankInteractor>().Coins);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Scene.GetInteractor<BankInteractor>().SpendCoins(this,2);
                Debug.Log(InteractorsBase.GetInteractor<BankInteractor>().Coins);
            }
        }
    }
}
