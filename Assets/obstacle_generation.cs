using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_generation : MonoBehaviour
{

  public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
      for(int i=0; i<5000; i++){

        Instantiate(obstacle,new Vector2(Random.Range(0,30000),Random.Range(0, 10)),Quaternion.identity);
      }


    }
}
