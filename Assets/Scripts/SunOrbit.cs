using UnityEngine;

public class SunOrbit : MonoBehaviour
{
    public float orbitSpeed = 10f;
    public Vector3 orbitAxis = Vector3.up;

    void Update()
    {
        if (SolarSystemManager.isPaused) return;

        transform.Rotate(orbitAxis.normalized * orbitSpeed * Time.deltaTime);
    }
}

