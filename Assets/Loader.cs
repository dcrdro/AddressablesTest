using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.ResourceLocations;

public class Loader : MonoBehaviour
{
    public string key;

    public string url =
        "https://dcrdro.github.io/AddressablesTest/ServerData/StandaloneOSX/catalog_2023.04.21.09.33.27.hash";
    
    // Start is called before the first frame update
    async void Start()
    {
        StartCoroutine(TestDownload());
        
        var locs = await Addressables.InitializeAsync().Task;

        
        // Addressables.ClearDependencyCacheAsync(locs);
        // await Task.Delay(2000);
        
        foreach (var k in locs.Keys)
        {
            Debug.Log("k = " + k);
        }
        
        // var l = await Addressables.GetDownloadSizeAsync(locs.Keys).Task;
        // Debug.Log("l = " + l);
        
        await Addressables.DownloadDependenciesAsync(key).Task;

        // await Addressables.InstantiateAsync(key).Task;
        
        //
        // var l2 = await Addressables.GetDownloadSizeAsync(key2).Task;
        // Debug.Log("l2 = " + l2);

        // reff.InstantiateAsync(Vector3.zero, Quaternion.identity);

        // Addressables.LoadResourceLocationsAsync()
        // foreach (var k in locs.Keys)
        // {
        //     Debug.Log("k = " + k);
        // }

        // await Addressables.InstantiateAsync("cube").Task;
    }

    IEnumerator TestDownload()
    {
        using UnityWebRequest r = UnityWebRequest.Get(url);
        var rr = r.SendWebRequest();
        yield return rr;

        Debug.Log("download = " + r.downloadHandler.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
