using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManeger : MonoBehaviour
{
    [Header("----------- Audio Source -----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("----------- Audio Clip -------------")]
    public AudioClip background;
}
