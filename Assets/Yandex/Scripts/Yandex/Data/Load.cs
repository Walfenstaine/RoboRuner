using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using pEventBus;
using UnityEngine;

public class Load : MonoBehaviour, IEventReceiver<OnLoadIsComplete>
{
    public Animator anim;
    public Data data;

    public void Set()
    {
        SceneManager.LoadScene(data.lvl);
    }

    public void OnEvent(OnLoadIsComplete e)
    {
        anim.SetFloat("Speed",1);
    }

    void Start()
    {
        EventBus.Register(this);
        SaveAndLoad.Instance.Load();
    }

    private void OnDestroy()
    {
        EventBus.UnRegister(this);
    }
}
