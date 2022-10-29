using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsaber : MonoBehaviour
{
    public Animator LightSaberAnimator;
    
    public void TurnOnLightSaber()
    {
        LightSaberAnimator.SetTrigger("Turn Lightsaber On");
        LightSaberAnimator.ResetTrigger("Turn Lightsaber Off");
    }

    public void TurnOffLightSaber()
    {
        LightSaberAnimator.SetTrigger("Turn Lightsaber Off");
        LightSaberAnimator.ResetTrigger("Turn Lightsaber On");
    }
}
