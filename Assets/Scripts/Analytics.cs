using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;

public class Analytics : MonoBehaviour
{
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
	#region Button Functions
		public void ButtonEventParameterless()
		{
			LogEvent_parameterlessEvent("Event_parameterless");
		}

		public void ButtonEventParameters()
		{
			string[] keys = new string[] { "valeur " };
			object[] values = new object[] { 42 };
			LogEvent_paramsEvent("Event_params", key: keys, paramValue: values);
		}

		public void ButtonEventFull()
		{
			string[] keys = new string[] { "nom" };
			object[] values = new object[] { "toto" };
			float value = 12;
			LogEvent_paramsEvent("Event_full", key: keys, paramValue: values, value);

		}
	#endregion

	#region Event Functions
		public void LogEvent_parameterlessEvent(string eventName)
		{
			FB.LogAppEvent(
				eventName
			);
		}

		public void LogEvent_paramsEvent(string eventName, string[] key = null, object[] paramValue = null, float? value = null)
		{
			Dictionary<string, object> parameters = null;

			if ((key != null && paramValue != null) && (key.Length == paramValue.Length))
			{

				parameters = new Dictionary<string, object>();
				for (int i = 0; i < key.Length; i++)
				{
					parameters[key[i]] = paramValue[i];

				}
			}

			FB.LogAppEvent(
				eventName,
				value,
				parameters
			);
		}
	#endregion


}
