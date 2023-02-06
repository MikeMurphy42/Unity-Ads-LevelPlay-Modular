using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IronSource.Agent.init ("1885bb835");
        IronSource.Agent.validateIntegration();
    }

    private void OnEnable()
    {
        IronSourceEvents.onSdkInitializationCompletedEvent += SdkInitializationCompletedEvent;
        
        IronSourceEvents.onBannerAdLoadedEvent += BannerAdLoadedEvent;
        IronSourceEvents.onBannerAdLoadFailedEvent += BannerAdLoadFailedEvent;        
        IronSourceEvents.onBannerAdClickedEvent += BannerAdClickedEvent; 
        IronSourceEvents.onBannerAdScreenPresentedEvent += BannerAdScreenPresentedEvent; 
        IronSourceEvents.onBannerAdScreenDismissedEvent += BannerAdScreenDismissedEvent;
        IronSourceEvents.onBannerAdLeftApplicationEvent += BannerAdLeftApplicationEvent;
        
        //Add AdInfo Banner Events
        IronSourceBannerEvents.onAdLoadedEvent += BannerOnAdLoadedEvent;
        IronSourceBannerEvents.onAdLoadFailedEvent += BannerOnAdLoadFailedEvent;
        IronSourceBannerEvents.onAdClickedEvent += BannerOnAdClickedEvent;
        IronSourceBannerEvents.onAdScreenPresentedEvent += BannerOnAdScreenPresentedEvent;
        IronSourceBannerEvents.onAdScreenDismissedEvent += BannerOnAdScreenDismissedEvent;
        IronSourceBannerEvents.onAdLeftApplicationEvent += BannerOnAdLeftApplicationEvent;
    }

    void OnApplicationPause(bool isPaused) {                 
        IronSource.Agent.onApplicationPause(isPaused);
    }

    public void LoadBanner()
    {
        IronSource.Agent.loadBanner(IronSourceBannerSize.BANNER, IronSourceBannerPosition.BOTTOM);
    }

    public void DestroyBanner()
    {
        IronSource.Agent.destroyBanner();
    }

    private void SdkInitializationCompletedEvent(){  }
    
    //Invoked once the banner has loaded
    void BannerAdLoadedEvent() {
    }
//Invoked when the banner loading process has failed.
//@param description - string - contains information about the failure.
    void BannerAdLoadFailedEvent (IronSourceError error) {
    }
// Invoked when end user clicks on the banner ad
    void BannerAdClickedEvent () {
    }
//Notifies the presentation of a full screen content following user click
    void BannerAdScreenPresentedEvent () {
    }
//Notifies the presented screen has been dismissed
    void BannerAdScreenDismissedEvent() {
    }
//Invoked when the user leaves the app
    void BannerAdLeftApplicationEvent() {
    }


    /************* Banner AdInfo Delegates *************/
//Invoked once the banner has loaded
    void BannerOnAdLoadedEvent(IronSourceAdInfo adInfo) 
    {
    }
//Invoked when the banner loading process has failed.
    void BannerOnAdLoadFailedEvent(IronSourceError ironSourceError) 
    {
    }
// Invoked when end user clicks on the banner ad
    void BannerOnAdClickedEvent(IronSourceAdInfo adInfo) 
    {
    }
//Notifies the presentation of a full screen content following user click
    void BannerOnAdScreenPresentedEvent(IronSourceAdInfo adInfo) 
    {
    }
//Notifies the presented screen has been dismissed
    void BannerOnAdScreenDismissedEvent(IronSourceAdInfo adInfo) 
    {
    }
//Invoked when the user leaves the app
    void BannerOnAdLeftApplicationEvent(IronSourceAdInfo adInfo) 
    {
    }
    // Banner callbacks
    
    //Full Size Callbacks
}
