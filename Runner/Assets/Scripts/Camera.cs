using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera : MonoBehaviour
{
    public CinemachineVirtualCamera VirtualCamera;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftCommand))
        {
            VirtualCamera.m_Priority = 11;
        }
        else
        {
            VirtualCamera.m_Priority = 0;
        }
        
       
    }
}
