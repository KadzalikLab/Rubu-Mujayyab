using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingMouse : MonoBehaviour
{
    public Transform Rubuk;
    private float besarRubukX;
    private float besarRubukY;
    private float besarRubukZ;


private void Start() {
     if (Application.platform == RuntimePlatform.WindowsPlayer) {Screen.fullScreen = false; }
}

     private void OnGUI() {

         if (Application.platform == RuntimePlatform.WindowsPlayer){
          besarRubukX= Rubuk.transform.localScale.x;
          besarRubukY= Rubuk.transform.localScale.y;
          besarRubukZ= Rubuk.transform.localScale.z;
          
          besarRubukX += Input.GetAxis("Mouse ScrollWheel")*10f ;
          besarRubukY += Input.GetAxis("Mouse ScrollWheel")*10f ;
          besarRubukZ += Input.GetAxis("Mouse ScrollWheel")*10f ;
          Rubuk.transform.localScale=new Vector3(besarRubukX,besarRubukY,besarRubukZ);
          }

         
        
    }
}
