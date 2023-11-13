using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using InstantGamesBridge;

public class Interface : MonoBehaviour
{
    public UnityEvent gameer, menue, andlevel;
    public static Interface rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    void Start()
    {
        Menu();
    }

    public void Menu()
    {
        menue.Invoke();
        Time.timeScale = 0;
    }


    public void Game()
    {
        gameer.Invoke();
        Time.timeScale = 1; 
    }
    public void Andlevel()
    {
        andlevel.Invoke();
        Time.timeScale = 0;
    }
}
