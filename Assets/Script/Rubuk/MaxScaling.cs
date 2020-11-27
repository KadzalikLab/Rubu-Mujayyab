using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script ini untuk membatasi batas zoom yang dilakukan oleh user
//bisa ditempelkan di game object manapun

public class MaxScaling : MonoBehaviour
{
    public Transform nilaiScaling;
    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(28.3f, 28.3f, 28.3f);//batas zoom, berbentuk nilai vector
         
    }

    // Update is called once per frame
    void Update()
    {
       
    float x = nilaiScaling.localScale.x;
    if (x>28.3){

        nilaiScaling.transform.localScale =scaleChange;
    }
    if (x<0){
        nilaiScaling.transform.localScale =new Vector3(1f,1f,1f);

    }

        
       
    }
}
