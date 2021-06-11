using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistanceManager : MonoBehaviour {
    public static string nickname;
    public static int bestScore = 0;
    public static PersistanceManager instance;

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
        }
        else 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}