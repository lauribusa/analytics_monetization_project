using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Monetization : MonoBehaviour, IUnityAdsListener
{

	public Image rewardVideoIndicator;
	public Image interstitialAdIndicator;
	public UnityAdsScriptableObject UnityAdsSettings; 

	void Start()
	{
		
		Advertisement.AddListener(this);
		Advertisement.Initialize(UnityAdsSettings.gameId, true);
	}

	// Implement a function for showing a rewarded video ad:
	void ShowVideo(string placementId)
	{
		Advertisement.Show(placementId);
	}

	public void ShowRewardedVideo()
	{
		ShowVideo(UnityAdsSettings.rewardedVideoId);
	}

	public void ShowInterstitialVideo()
	{
		ShowVideo(UnityAdsSettings.interstitialId);
	}
	// Implement IUnityAdsListener interface methods:
	public void OnUnityAdsReady(string placementId)
	{
		// If the ready Placement is rewarded, activate the button: 
		
		if(placementId == UnityAdsSettings.interstitialId)
		{
			interstitialAdIndicator.color = new Color(0, 255, 0);
		}
		if(placementId == UnityAdsSettings.rewardedVideoId)
		{
			rewardVideoIndicator.color = new Color(0, 255, 0);
		}
	}

	public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
	{
		// Define conditional logic for each ad completion status:
		if (showResult == ShowResult.Finished)
		{
			// Reward the user for watching the ad to completion.
		}
		else if (showResult == ShowResult.Skipped)
		{
			// Do not reward the user for skipping the ad.
		}
		else if (showResult == ShowResult.Failed)
		{
			Debug.LogWarning("The ad did not finish due to an error.");
		}
	}

	public void OnUnityAdsDidError(string message)
	{
		Debug.LogError(message);
	}

	public void OnUnityAdsDidStart(string placementId)
	{
		// Optional actions to take when the end-users triggers an ad.
	}


}
