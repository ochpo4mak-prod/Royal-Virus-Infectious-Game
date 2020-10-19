using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdvertismentG : MonoBehaviour {

    public string gameId = "3509681";
    public string placementId = "banner";
    public bool testMode = false;

    void Start () {
        Advertisement.Initialize (gameId, testMode);
        StartCoroutine (ShowBannerWhenReady ());
    }

    IEnumerator ShowBannerWhenReady () {
        while (!Advertisement.IsReady (placementId)) {
            yield return new WaitForSeconds (0.5f);
        }
        Advertisement.Banner.Show (placementId);
        Advertisement.Banner.SetPosition (BannerPosition.BOTTOM_CENTER);
    }
}