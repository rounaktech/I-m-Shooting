using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Banner : MonoBehaviour
{
    public string gameId = "4122497";
    public string surfacingId = "banner";
    bool test = false;
   

    void Start()
    {
        Advertisement.Initialize(gameId, test);
        StartCoroutine(ShowBannerWhenInitialized());
    }

    IEnumerator ShowBannerWhenInitialized()
    {
        while (!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        Advertisement.Banner.Show(surfacingId);
    }
}