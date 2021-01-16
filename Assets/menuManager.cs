using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
  public Button playbutton;
  void Start(){
    playbutton.onClick.AddListener(TaskOnClick);
  }
   void TaskOnClick(){
    SceneManager.LoadScene(1);
  }
}
