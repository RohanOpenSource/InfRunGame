using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class postprocessdisable : MonoBehaviour
{
  public PostProcessVolume v;
    void Update()
    {
      if(Input.GetKeyDown("p")&& v.enabled){
        v.enabled=false;
      }
      else if(Input.GetKeyDown("p")&& !v.enabled){
        v.enabled=true;
      }

    }
}
