using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NilaiQous : MonoBehaviour
{
   private float angle;
    public GameObject Markaz;
    public GameObject Syakul;
    public RectTransform Anchor;//pasak untuk memutar titik qous
    public Text text;//text Qous
    public Text textSittini;
    public Text textJaibT;

    public GameObject TitikSittini;
    public GameObject TitikJaibT;


    // Update is called once per frame
    public void Update()
    {

        Vector2 syakul=Syakul.transform.position;
        Vector2 awalQous=Markaz.transform.position;
        Vector2 dir= awalQous-syakul;
        angle=(Mathf.Atan2(dir.y,-dir.x)*Mathf.Rad2Deg);
        string nilai;//Qous

        //mencari nilai sinus dari angle
        float nilaiSittini=Mathf.Abs(Mathf.Cos(angle*Mathf.Deg2Rad));
        string sittini;

        float nilaiJaibT=Mathf.Abs(Mathf.Sin(angle*Mathf.Deg2Rad));
        string JaibT;

        
        float posisiSitini=-200.872f*nilaiSittini;//200.294 adalah nilai batas wilayah rubuk dalam app ini
        float posisiJaibT=-200.872f*nilaiJaibT;


        if (angle<0){//apabila melebihi wilayah rubuk maka disetel maks (90)

        nilai=90+"\u00B0 "+ "00" +"\u2032  ";
        sittini=60+"\u00B0 "+ "00" +"\u2032  ";
        JaibT="00"+"\u00B0 "+ "00" +"\u2032  ";


        Anchor.localEulerAngles=new Vector3(0,0,-90);
        TitikSittini.transform.localPosition=new Vector3(-200.294f,10f,0);//menentukan posisi titik sittini
         TitikJaibT.transform.localPosition=new Vector3(10f,0,0);
  

        }else {

    if (angle>=90.0f){//apabila nggak melebihi wilayah rubuk
        //Qous
        int derajat = Konversi.DesimalKeDerajat(angle%90)[1];
        int menit = Konversi.DesimalKeDerajat(angle%90)[2];
        nilai=derajat.ToString("D2")+"\u00B0 "+ menit.ToString("D2") +"\u2032  ";
        
        //Sittini
        int derajatSt = Konversi.DesimalKeDerajat(nilaiSittini*60)[1];
        int menitSt = Konversi.DesimalKeDerajat(nilaiSittini*60)[2];
        sittini=derajatSt.ToString("D2")+"\u00B0"+ menitSt.ToString("D2") +"\u2032";

        //Jaib T
       int derajatJt = Konversi.DesimalKeDerajat(nilaiJaibT*60)[1];
        int menitJt = Konversi.DesimalKeDerajat(nilaiJaibT*60)[2];
        JaibT=derajatJt.ToString("D2")+"\u00B0"+ menitJt.ToString("D2") +"\u2032";

        Anchor.localEulerAngles=new Vector3(0,0,-(angle-90));//memutar pasak 

        TitikSittini.transform.localPosition=new Vector3(posisiSitini,10f,-0.2f);//menentukan posisi titik sittini
        TitikJaibT.transform.localPosition=new Vector3(10f,posisiJaibT,-0.2f);
   


    }else
    {//apabila kurang dar wilayah rubuk maka disetel minimalnilai (0)
        nilai="00"+"\u00B0"+ "00" +"\u2032 ";
        sittini="00"+"\u00B0 "+ "00" +"\u2032  ";
        JaibT="60"+"\u00B0 "+ "00" +"\u2032  ";
        Anchor.localEulerAngles=new Vector3(0,0,0);
        TitikSittini.transform.localPosition=new Vector3(0,10f,0);//menentukan posisi titik sittini
        TitikJaibT.transform.localPosition=new Vector3(10f,-200.294f,0);
       
    }
}
        text.text ="Qous : " +nilai;
        textSittini.text="Sittini: "+sittini;
        textJaibT.text="Jaib T: "+JaibT;




       
    }

}
