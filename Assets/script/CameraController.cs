using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float rotationSpeed = 100f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // Gira o offset em volta do jogador (eixo Y)
        float input = 0f;
        if (Input.GetKey(KeyCode.Q)) input = 1f;
        if (Input.GetKey(KeyCode.E)) input = -1f;

        offset = Quaternion.AngleAxis(-input * rotationSpeed * Time.deltaTime, Vector3.up) * offset;

        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
    }
}
