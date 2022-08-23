using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions4DD : MonoBehaviour
{
    public static Instructions4DD Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
