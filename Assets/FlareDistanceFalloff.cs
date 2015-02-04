using UnityEngine;
using System.Collections;

public class FlareDistanceFalloff : MonoBehaviour
{
    public float size = 3.0f;

    void Update()
    {
        float ratio = Mathf.Pow(Vector3.Distance(transform.position, Camera.main.transform.position), 1f);

        ratio = Mathf.Clamp(ratio, size, 100);

        GetComponent<LensFlare>().brightness = size / ratio;

        if (GetComponent<LensFlare>().brightness <= 0.2)
        {
            GetComponent<LensFlare>().brightness = 0;
        }
    }
}
