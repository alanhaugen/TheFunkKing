using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyBar : MonoBehaviour
{
    public Slider slider;

    public void SetMinJoy(int joy)
    {
        slider.minValue= joy;
        slider.value= joy;
    }

    public void SetJoy(int joy)
    {
        slider.value = joy;
    }
}