using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WebglGyroInput : MonoBehaviour {
    public TextMeshProUGUI textLog;


    Rigidbody rb;
    float moveSpeed = 20f;
    float dirX;

    //void Start() {
    //    rb = GetComponent<Rigidbody>();

    //    textLog.text = $"SupportsGyroscope: {SystemInfo.supportsGyroscope}";
    //}

    //private void Update() {
    //    dirX = Input.acceleration.x * moveSpeed;
    //    transform.position = new Vector3(Mathf.Clamp(transform.position.x, -17.5f, 17.5f), transform.position.y, transform.position.z);
    //}

    //void FixedUpdate() {
    //    // Apply forces to an object to match the side-to-side acceleration
    //    // the user is giving to the device.

    //    rb.velocity = new Vector3(dirX, rb.velocity.y, rb.velocity.z);
    //}


}
