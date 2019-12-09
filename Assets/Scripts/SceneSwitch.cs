﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToMonetization()
    {
        SceneManager.LoadScene("MonetizationScene");        
    }
    
    public void GoToAnalytics()
    {
        SceneManager.LoadScene("AnalyticsScene");
    }
}
