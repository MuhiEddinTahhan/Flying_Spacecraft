using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllers : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("General Setup Settings")]
    [Tooltip("How fast the ship moves due to input")] [SerializeField] float controlSpeed = 50f;
    [Tooltip("how far can player go on the x-axis")] [SerializeField] float xRange = 24f;
    [Tooltip("how far can player go on the y-axis")] [SerializeField] float yRange = 21f;
    
    [Header("laser gun array")]
    [Tooltip("Add all player lasers here")]
    [SerializeField] GameObject[] lasers;

    [Header("Screen position based on tuning")]
    [Tooltip("constant for player up-down movment due to position")] [SerializeField] float postionPitchFactor = -2f;
    [Tooltip("constant for player up-down movment due to input")] [SerializeField] float controlPitchFactor = -20f;
    [Tooltip("constant for player right-left movment due to position")] [SerializeField] float postionYawFactor = 2f;
    [Tooltip("constant for player right-left movment due to input")] [SerializeField] float controlYawFactor = 20f;
    [Tooltip("constant for player rotation due to postion")] [SerializeField] float postionRollFactor = -2f;
    [Tooltip("constant for player rotaion due to input")] [SerializeField] float controlRollFactor = -20f;

    float x_Movment, y_Movment;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementControls();
        RotationProcess();
        FiringProcess();
    }

    void RotationProcess()
    {
        float pitchDueController = y_Movment * controlPitchFactor;
        float pitchDueToPostion = transform.localPosition.y * postionPitchFactor;
        float pitch = pitchDueToPostion + pitchDueController;
        
        float yawDueToController = x_Movment * controlYawFactor;
        float yawDueToPosition= transform.localPosition.x * postionYawFactor;
        float yaw = yawDueToPosition + yawDueToController;
        
        float rollDueToControl = x_Movment * controlRollFactor;
        float rollDueToPostion = transform.localRotation.z * postionRollFactor;
        float roll = rollDueToPostion + rollDueToControl;
        
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);

    } 

    void MovementControls()
    {
        x_Movment = Input.GetAxis("Horizontal");      //get input horizntal
        y_Movment = Input.GetAxis("Vertical");        //get input vertical

        float yOffset = y_Movment * Time.deltaTime * controlSpeed;      //move based on input vertical
        float xOffset = x_Movment * Time.deltaTime * controlSpeed;      //move based on input horizantal

        float XPosition = transform.localPosition.x + xOffset;
        float YPosition = transform.localPosition.y + yOffset;

        float restricted_X = Mathf.Clamp(XPosition, -xRange, xRange);
        float restricted_Y = Mathf.Clamp(YPosition, -yRange, yRange);

        transform.localPosition = new Vector3(restricted_X, restricted_Y, transform.localPosition.z);
    }

    void FiringProcess()
    {
        if (Input.GetButton("Jump"))
        {
            SetLaserActivity(true);
        }
        else
        {
            SetLaserActivity(false);
        }
    }

    void SetLaserActivity(bool isActive)
    {
        foreach (GameObject laserGun in lasers)
        {
            var emissionModule = laserGun.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isActive;
        }
    }
}
