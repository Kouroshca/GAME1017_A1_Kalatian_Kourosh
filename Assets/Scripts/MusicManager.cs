using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  public GameObject musicManagerPrefab;
  public void Awake()
  {
    if (StartMusic.Instance == null)
    {
        Instantiate(musicManagerPrefab);
    }
  }
}
