using UnityEngine;
public class DayNightCycle : MonoBehaviour
{
    public float dayLength = 120f;
    public Gradient skyColor;
    private Light sun;

    void Start()
    {
        sun = GetComponent<Light>();
    }
    void Update()
    {
        transform.Rotate(Vector3.right, (360f / dayLength) * Time.deltaTime);

        float intensity = Mathf.Clamp01(Vector3.Dot(transform.forward, Vector3.down));
        sun.intensity = intensity * 1.5f;

        float t = (transform.eulerAngles.x / 360f);
        sun.color = skyColor.Evaluate(t);
        RenderSettings.ambientLight = skyColor.Evaluate(t) * intensity;
    }
}