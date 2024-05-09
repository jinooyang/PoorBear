using System;
using Fusion;
using UnityEngine;

public struct NetworkInputData : INetworkInput
{
    public const byte MOUSEBUTTON0 = 1;
    public const byte MOUSEBUTTON1 = 2;
    public const byte RESPAWNBUTTON = 3;
    public const byte SLEEPBUTTON = 4;
    
    
    public NetworkButtons buttons;
    public Vector3 direction;
    public float clientMainCameraEulerAngle;
    public float jumpTimeout;
    public bool isSprint;
    public bool isJump;
}