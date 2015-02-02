using UnityEngine;
using System.Collections;

public class FlareDistanceFalloff : MonoBehaviour
{

    private GameObject mainCamera;
    private LensFlare flare;

    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        flare = GetComponent<LensFlare>();
    }

    void LateUpdate()
    {
        flare.brightness = 100 - (transform.position - mainCamera.transform.position).magnitude;
    }
}
