using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
  public Button StartButton;

  public void ButtonPressed(){
    StartButton.gameObject.SetActive(false);
  }

}
