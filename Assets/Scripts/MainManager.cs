using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public ParticleSystem explosion;
    public static MainManager Instance;

    private bool isGameOn;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GameStart()
    {
        isGameOn = true;
    }

    public void GameEnd()
    {
        isGameOn = false;
    }

    public bool GetIsGameOn()
    {
        return isGameOn;
    }

}
