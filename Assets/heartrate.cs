using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class heartrate : MonoBehaviour
{
       Text txt;
     private int currentscore=0;
 
     // Use this for initialization
     void Start () {
         txt = gameObject.GetComponent<Text>(); 
         
         txt.text=Random.Range(60,80).ToString();
         Change();
     }
     IEnumerator ExecuteAfterTime(float time)
 {  
     for(int i =0; i < 100; i++)
        {
     yield return new WaitForSeconds(time);
     txt.text=Random.Range(60,80).ToString();
      }
 
     
 }
     void Change()
     {
        
            StartCoroutine(ExecuteAfterTime(2));
            
       


     }
     
     // Update is called once per frame
     void Update () {
         //Random rand = new Random();
         
         
         
     }
}
