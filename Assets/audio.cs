using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
  public AudioSource audioName;

  public void PlayAudio()
  {
    audioName.Play();
  }
}