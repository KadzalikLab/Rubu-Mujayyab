using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMuri : MonoBehaviour
{
    public GameObject GameObject1;
     public GameObject GameObject2;
    public GameObject GameObject3;
 public GameObject GameObject4;
     public GameObject GameObject5;
 public GameObject GameObject6;
//   public GameObject GameObject7;
 public void OnToggleValueChanged( bool value )
 {
     GameObject1.SetActive( value ) ;
     GameObject2.SetActive( value ) ;
    GameObject3.SetActive( value ) ;
    GameObject4.SetActive( value ) ;
        GameObject5.SetActive( value ) ;
    GameObject6.SetActive( value ) ;
        // GameObject7.SetActive( value ) ;
    
 }
}
