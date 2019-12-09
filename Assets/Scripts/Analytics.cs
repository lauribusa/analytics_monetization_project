using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;

public class Analytics : MonoBehaviour
{
	// Start is called before the first frame update
	void Awake()
	{
		
	}

	private void Start()
	{
		if (FB.IsInitialized)
		{
			FB.ActivateApp();
		}
		else
		{
			//Handle FB.Init
			FB.Init(() => {
				FB.ActivateApp();
				ButtonEventParameterless();
			});
		}
	}

	public void ButtonEventParameterless()
	{
		LogEvent_parameterlessEvent("Event_parameterless");
	}

	public void ButtonEventParameters()
	{


		//LogEvent_paramsEvent("Event_params", string["key"]);
	}

	public void LogEvent_parameterlessEvent(string eventName)
	{
		FB.LogAppEvent(
			eventName
		);
	}

	public void LogEvent_paramsEvent(string eventName, string[] key, object[] values)
	{
		if(key.Length != values.Length)
		{
			Debug.LogError("Values array isn't the same length as key array.");
			return;
		}

		Dictionary<string, object> parameters = new Dictionary<string, object>();

		for (int i = 0; i < key.Length; i++)
		{
			parameters[key[i]] = values[i];

		}
		
			FB.LogAppEvent(
				eventName,
				parameters : parameters
			);
		
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}
