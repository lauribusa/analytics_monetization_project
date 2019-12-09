using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Monetization : MonoBehaviour, IUnityAdsListener
{

	public Image rewardVideoIndicator;
	public Image interstitialAdIndicator;
	public string gameId = "3390432";
	public string interstitialId = "interstitialVideo";
	public string rewardedVideo = "testVideo";
	void Start()
	{
		// Set interactivity to be dependent on the Placement’s status:

		// Map the ShowRewardedVideo function to the button’s click listener
		// Initialize the Ads listener and service:
		Advertisement.AddListener(this);
		Advertisement.Initialize(gameId, true);
	}

	// Implement a function for showing a rewarded video ad:
	void ShowVideo(string placementId)
	{
		Advertisement.Show(placementId);
	}

	public void ShowRewardedVideo()
	{
		ShowVideo(rewardedVideo);
	}

	public void ShowInterstitialVideo()
	{
		ShowVideo(interstitialId);
	}
	// Implement IUnityAdsListener interface methods:
	public void OnUnityAdsReady(string placementId)
	{
		// If the ready Placement is rewarded, activate the button: 
		
		if(placementId == interstitialId)
		{
			interstitialAdIndicator.color = new Color(0, 255, 0);
		}
		if(placementId == rewardedVideo)
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
		// Log the error.
	}

	public void OnUnityAdsDidStart(string placementId)
	{
		// Optional actions to take when the end-users triggers an ad.
	}

	private void Update()
	{
		
	}
}
