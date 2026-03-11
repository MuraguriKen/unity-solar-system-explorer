using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class OrbitPath : MonoBehaviour
{
    public float radius = 10f;
    public int segments = 100;
    public Color orbitColor = Color.white;

    void Start()
    {
        LineRenderer line = GetComponent<LineRenderer>();
        line.useWorldSpace = false;
        line.loop = true;
        line.positionCount = segments;

        for (int i = 0; i < segments; i++)
        {
            float angle = 2 * Mathf.PI * i / segments;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            line.SetPosition(i, new Vector3(x, 0, z));
        }

        line.widthMultiplier = 0.05f;
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.startColor = line.endColor = orbitColor;
    }
}
