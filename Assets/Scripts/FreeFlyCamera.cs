using UnityEngine;

public class FreeFlyCamera : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float upDown = 0;

        if (Input.GetKey(KeyCode.E)) upDown = 1;
        if (Input.GetKey(KeyCode.Q)) upDown = -1;

        Vector3 move = new Vector3(h, upDown, v);
        transform.Translate(move * moveSpeed * Time.deltaTime, Space.Self);
    }
}
