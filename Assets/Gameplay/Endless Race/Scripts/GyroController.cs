using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GyroController : MonoBehaviour {
    public TextMeshProUGUI velocity;

    public float dirX = 0f;
    public float moveSpeed = 20f;

    void OnGyroData(string data) {
        // Split the data into separate values
        string[] values = data.Split(',');
        float alpha = float.Parse(values[0]);
        float beta = float.Parse(values[1]);
        float gamma = float.Parse(values[2]);

        // Do something with the gyroscope data

        dirX = Mathf.Clamp(gamma * moveSpeed, -45, 45);
        velocity.text = $"gamma: {gamma} \n dirX: {dirX} ";
    }

    void Message(string message) {
        velocity.text = $"message: {message}"; 
    }

    Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        // Apply forces to an object to match the side-to-side acceleration
        // the user is giving to the device.

        rb.velocity = new Vector3(dirX, rb.velocity.y, rb.velocity.z);
    }
}