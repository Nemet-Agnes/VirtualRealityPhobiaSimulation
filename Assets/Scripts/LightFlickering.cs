using System.Collections;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    public float flickerInterval = 5f; 
    public float flickerDuration = 0.5f;
    public float turnOffDuration = 2f;

    private Light[] lights;

    void Start()
    {
        lights = GetComponentsInChildren<Light>();
        StartCoroutine(FlickerLights());
    }

    IEnumerator FlickerLights()
    {
        while (true)
        {
            yield return new WaitForSeconds(flickerInterval);

            foreach (var light in lights)
            {
                StartCoroutine(FlickerLight(light));
            }
            yield return new WaitForSeconds(flickerDuration);
            StartCoroutine(TurnOffLights());
        }
    }

    IEnumerator FlickerLight(Light light)
    {
        float originalIntensity = light.intensity;
        for (float t = 0; t < flickerDuration; t += Time.deltaTime)
        {
            light.intensity = Random.Range(originalIntensity * 0.8f, originalIntensity * 1.2f);
            yield return null;
        }
        light.intensity = originalIntensity;
    }

    IEnumerator TurnOffLights()
    {
        float elapsedTime = 0f;
        float initialIntensity = lights[0].intensity;

        while (elapsedTime < turnOffDuration)
        {
            foreach (var light in lights)
            {
                light.intensity = Mathf.Lerp(initialIntensity, 0f, elapsedTime / turnOffDuration);
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
