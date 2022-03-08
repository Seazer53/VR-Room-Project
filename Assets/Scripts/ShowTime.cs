using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTime : MonoBehaviour
{
    [SerializeField] private GameObject pointerHours;
    [SerializeField] private GameObject pointerMinutes;
    [SerializeField] private GameObject pointerSeconds;

    private float rotationHours;
    private float rotationMinutes;
    private float rotationSeconds;

    private int hours, minutes, seconds;

    private void Update()
    {
        hours = DateTime.Now.Hour;
        minutes = DateTime.Now.Minute;
        seconds = DateTime.Now.Second;

        // Calculate pointer angles
        rotationSeconds = (360.0f / 60.0f) * seconds;
        rotationMinutes = (360.0f / 60.0f) * minutes;
        rotationHours = ((360.0f / 12.0f) * hours) + ((360.0f / (60.0f * 12.0f)) * minutes);

        pointerSeconds.transform.localEulerAngles = new Vector3(rotationSeconds, 0, -90);
        pointerMinutes.transform.localEulerAngles = new Vector3(rotationMinutes, 0, -90);
        pointerHours.transform.localEulerAngles = new Vector3(rotationHours, 0, -90);
    }

}
