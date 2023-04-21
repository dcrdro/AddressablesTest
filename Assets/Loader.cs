using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;

public class Loader : MonoBehaviour
{
    public AssetReference reff;

    public string key;
    public string key2;
    public string path;
    
    // Start is called before the first frame update
    async void Start()
    {
        var locs = await Addressables.InitializeAsync().Task;

        var l = await Addressables.GetDownloadSizeAsync(key).Task;
        Debug.Log("l = " + l);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
