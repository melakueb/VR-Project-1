using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.Networking;

public class WeatherScript : MonoBehaviour
{
    public TMP_Text weatherText;

    // Napa Valley coordinates with Fahrenheit output
    private const string api =
        "https://api.open-meteo.com/v1/forecast?latitude=38.5025&longitude=-122.2654&hourly=temperature_2m&temperature_unit=fahrenheit";

    void Start()
    {
        StartCoroutine(UpdateWeatherLoop());
    }

    IEnumerator UpdateWeatherLoop()
    {
        while (true)
        {
            yield return StartCoroutine(GetWeather());
            yield return new WaitForSeconds(600f); // update every 10 minutes
        }
    }

    IEnumerator GetWeather()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(api))
        {
            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Weather request failed: " + request.error);
                weatherText.text = "Weather\nUnavailable";
            }
            else
            {
                string json = request.downloadHandler.text;
                WeatherResponse data = JsonUtility.FromJson<WeatherResponse>(json);

                if (data != null && data.hourly.temperature_2m.Length > 0)
                {
                    float temp = data.hourly.temperature_2m[0];
                    weatherText.text = $"Weather\n{temp:0.#}°F";
                }
                else
                {
                    weatherText.text = "Weather\nUnavailable";
                }
            }
        }
    }

    [System.Serializable]
    public class WeatherResponse
    {
        public HourlyData hourly;
    }

    [System.Serializable]
    public class HourlyData
    {
        public float[] temperature_2m;
    }
}