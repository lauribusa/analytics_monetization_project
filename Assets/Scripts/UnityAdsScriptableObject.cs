using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/UnityAds", order = 1)]
public class UnityAdsScriptableObject : ScriptableObject
{
	/*gameId : "3390432"
	interstitialId : "interstitialVideo"
	rewardedVideoId : "testVideo"*/
	public string gameId;
	public string interstitialId;
	public string rewardedVideoId;
}
