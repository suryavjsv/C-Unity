using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.IO;

public class AssetBundleDownloader : MonoBehaviour
{
    public string[] assetBundleURLs;

    private int currentIndex = 0;

    public void StartDownload()
    {
        currentIndex = 0;
        StartCoroutine(DownloadAssetBundles());
    }

    IEnumerator DownloadAssetBundles()
    {
        while (currentIndex < assetBundleURLs.Length)
        {
            string currentURL = assetBundleURLs[currentIndex];
            Debug.Log("Downloading asset bundle from URL: " + currentURL);

            UnityWebRequest www = UnityWebRequest.Get(currentURL);
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Failed to download asset bundle from URL: " + currentURL + "\nError: " + www.error);
            }
            else
            {
                // Save the downloaded asset bundle to persistent data path
                string fileName = "assetBundleFile" + currentIndex; // Append index to avoid clashes
                string filePath = Path.Combine(Application.persistentDataPath, fileName);
                File.WriteAllBytes(filePath, www.downloadHandler.data);
                Debug.Log("Asset bundle downloaded and saved at: " + filePath);
            }

            currentIndex++;
        }

        Debug.Log("All asset bundles downloaded successfully!");
    }
}
