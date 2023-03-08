using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UDP;
using UnityEngine.XR;
using Unity.XR.PXR;

public class AndroidEventHandler : MonoBehaviour
{
    void myAction(string msg) {
        UDPSocket send = new UDPSocket();
        send.Client("192.168.1.101", 27000);

        Vector3 v;
        bool result = PXR_EyeTracking.GetCombineEyeGazeVector(out v);
        if (!result) send.Send("N/A");
        else send.Send(v.ToString());
    }
}
