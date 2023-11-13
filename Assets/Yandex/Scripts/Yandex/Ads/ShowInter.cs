using UnityEngine;
using InstantGamesBridge;
using InstantGamesBridge.Modules.Advertisement;
using pEventBus;




public class ShowInter : MonoBehaviour, IEventReceiver<ShowInterAds>
{
    public bool showADS;
    public AudioSource sorse;
    public Data data;
    private float scale = 1;

    void Start()
    {
        Bridge.advertisement.interstitialStateChanged += Interstitial;
        EventBus.Register(this);

        EventBus<ShowInterAds>.Raise(new ShowInterAds()
        {

        });
    }
    private void Awake()
    {
        if (showADS)
        {
            ShowADS();
        }
    }
    void OnDestroy()
    {
        Bridge.advertisement.interstitialStateChanged -= Interstitial;
        EventBus.UnRegister(this);
    }

    public void ShowADS()
    {
        if (showADS)
        {
            var ignoreDelay = false;
            Bridge.advertisement.ShowInterstitial(ignoreDelay, success =>
            {

            });
        }
            
    }

    public void OnEvent(ShowInterAds e)
    {
        var ignoreDelay = false;
        Bridge.advertisement.ShowInterstitial(ignoreDelay, success =>
        {

        });
    }

    private void Interstitial(InterstitialState state)
    {
        if (state == InterstitialState.Closed)
        {
            Time.timeScale = scale;
            sorse.mute = !data.soundOn;
        }


        if (state == InterstitialState.Opened)
        {
            scale = Time.timeScale;
            Time.timeScale = 0;
            sorse.mute = true;
        }
    }
}