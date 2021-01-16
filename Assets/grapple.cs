using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class grapple : MonoBehaviour
{
  public LineRenderer lr;
public SpringJoint2D dj;
public Camera m;
public LayerMask ground;
public LayerMask lava;
public Rigidbody2D rb;
public int score;
public Text scoretext;


    // Update is called once per frame
    void Start(){
      dj.enabled=false;

    }
    void Update()
    {
      score=(int) transform.position.x;
      scoretext.text="Score: "+score;
      if(Physics2D.OverlapCircle(transform.position,1f,lava)){
        SceneManager.LoadScene(0);
      }
      if (Input.GetMouseButtonDown(0))
       {
         Vector2 mp=(Vector2) m.ScreenToWorldPoint(Input.mousePosition);
         //float angle= Mathf.Atan2(mp.x,mp.y)*Mathf.Rad2Deg;
         //Quaternion rotate=Quaternion.AngleAxis(angle-90, Vector3.forward);

         //transform.rotation=rotate;
         if(Physics2D.OverlapCircle(mp,0.1f,ground)){
           lr.SetPosition(0,mp);
           lr.SetPosition(1,transform.position);
           dj.connectedAnchor=mp;


           dj.enabled=true;
           lr.enabled=true;

         }


       }
       else if(Input.GetMouseButtonUp(0)){
         dj.enabled=false;
         lr.enabled=false;

       }
       if(dj.enabled){
         lr.SetPosition(1,transform.position);

       }

       }
}
