using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
     void Update()
             { 
                 if(Input.GetMouseButtonDown(0)){
                     Application.LoadLevel("Main");
       // Whatever you want it to do.
                }
             
           }
}
