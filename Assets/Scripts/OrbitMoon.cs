using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform orbitCenter;
    public float orbitSpeed = 10f;
    public Vector3 orbitAxis = Vector3.up;

    void Update()
    {
        if (SolarSystemManager.isPaused) return;

        if (orbitCenter != null)
        {
            transform.RotateAround(orbitCenter.position, orbitAxis.normalized, orbitSpeed * Time.deltaTime);
        }
    }
}
