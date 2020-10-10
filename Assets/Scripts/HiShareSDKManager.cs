using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HiShareSDK
{
    public class HiShareSDKManager : MonoSingleton<HiShareSDKManager>
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

    }
}