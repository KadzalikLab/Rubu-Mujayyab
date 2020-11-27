using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Script untuk mengatur segala yang berhubungan dengan muri

public class NIlaiMuri : MonoBehaviour
{
    public InputField nilaiDerajat;//input muri
    public InputField nilaiMenit;

    public GameObject Syakul;
    public GameObject Markaz;
    public GameObject Muri;//titik muri
    public GameObject MuriSittini;//titik muri yang ada disittini
    public GameObject MuriJaibT;//titik muri yang ada jaib t
    public RectTransform TitikQousMuri;//titik muri yang ada qous
    public Text TextQousMuri;//unutk menampilkan nilai muri
    private float angle;//sudut antara Syakul dan Markaz
   

    public void Update(){
//ambil nilai dari user
    float nilaiInput=(float)Konversi.DerajatKeDesimal(double.Parse(nilaiDerajat.text),double.Parse(nilaiMenit.text),0);


        Vector2 syakul=Syakul.transform.position;
        Vector2 awalQous=Markaz.transform.position;
        Vector2 dir= awalQous-syakul;//menghitung vectornya dari Markaz dikurangi syakul, supaya Origin sudutnya berada pada Markaz
        angle=(Mathf.Atan2(dir.y,-dir.x)*Mathf.Rad2Deg);
 
         if (nilaiInput>60)nilaiInput%=60;

        float nilaiSittini=Mathf.Sin(angle%90*Mathf.Deg2Rad)*nilaiInput/60;
        float nilaiJaibT=Mathf.Cos(angle%90*Mathf.Deg2Rad)*nilaiInput/60;
        float angleMuri=(Mathf.Asin(nilaiSittini)*Mathf.Rad2Deg);
        float OousInputMuri=(Mathf.Asin(nilaiInput/60)*Mathf.Rad2Deg);
    

      

        nilaiInput/=60;
        float posisiMuri=-49.49f*nilaiInput;//-49.49f adalah nilai vector y batas daerah jaib T rubuk
        
        Muri.transform.localPosition=new Vector3(0,posisiMuri,0f);


        float posisiMuriS=-200.294f*nilaiSittini;
    
        float posisiMuriJ=-200.294f*nilaiJaibT;

        

        string nilai;


        string nilaiMuriS;


        string nilaiMuriT;




    

  

        if (angle<0){
            if(angleMuri==0){
                TitikQousMuri.localEulerAngles=new Vector3(0,0,-OousInputMuri);}
            else
            {
             TitikQousMuri.localEulerAngles=new Vector3(0,0,angleMuri);
            }
            
             MuriSittini.transform.localPosition=new Vector3(-200f*nilaiInput,10f,0);
             MuriJaibT.transform.localPosition=new Vector3(10f,0,0);

        int derajat = Konversi.DesimalKeDerajat(angleMuri%90)[1];
        int menit = Konversi.DesimalKeDerajat(angleMuri%90)[2];
        nilai=derajat.ToString("D2")+"\u00B0 "+ menit.ToString("D2") +"\u2032  ";

        int derajatS = Konversi.DesimalKeDerajat(nilaiInput*60)[1];
        int menitS = Konversi.DesimalKeDerajat(nilaiInput*60)[2];
        nilaiMuriS=derajatS.ToString("D2")+"\u00B0 "+ menitS.ToString("D2") +"\u2032  ";

        nilaiMuriT="00"+"\u00B0 "+"00"+"\u2032";
              

        }else{
            if(angle>=90.0f){
                   TitikQousMuri.localEulerAngles=new Vector3(0,0,-angleMuri);
                   Debug.Log(-angleMuri+"");
                   MuriSittini.transform.localPosition=new Vector3(posisiMuriS,10f,0);
                   MuriJaibT.transform.localPosition=new Vector3(10f,posisiMuriJ,0);
                   
        int derajat = Konversi.DesimalKeDerajat(angleMuri%90)[1];
        int menit = Konversi.DesimalKeDerajat(angleMuri%90)[2];
        nilai=derajat.ToString("D2")+"\u00B0 "+ menit.ToString("D2") +"\u2032  ";

        int derajatS = Konversi.DesimalKeDerajat(nilaiSittini*60)[1];
        int menitS = Konversi.DesimalKeDerajat(nilaiSittini*60)[2];
        nilaiMuriS=derajatS.ToString("D2")+"\u00B0 "+ menitS.ToString("D2") +"\u2032  ";

        int derajatT = Konversi.DesimalKeDerajat(nilaiJaibT*60)[1];
        int menitT = Konversi.DesimalKeDerajat(nilaiJaibT*60)[2];
        nilaiMuriT=derajatT.ToString("D2")+"\u00B0 "+ menitT.ToString("D2") +"\u2032  ";





            }else{
                 TitikQousMuri.localEulerAngles=new Vector3(0,0,0);
                 MuriSittini.transform.localPosition=new Vector3(0,10f,0);
                 MuriJaibT.transform.localPosition=new Vector3(10f,-200f*nilaiInput,0);

                    nilai="00"+"\u00B0 "+"00"+"\u2032";
                     nilaiMuriS="00"+"\u00B0 "+"00"+"\u2032";
        int derajatJ= Konversi.DesimalKeDerajat(nilaiInput*60)[1];
        int menitJ = Konversi.DesimalKeDerajat(nilaiInput*60)[2];
        nilaiMuriT=derajatJ.ToString("D2")+"\u00B0 "+ menitJ.ToString("D2") +"\u2032  ";

            }
    
        }

                TextQousMuri.text ="Qous Muri:"+"\n"+nilai+"\n\n"+"Sittini Muri:"+"\n"+nilaiMuriS+"\n\n"+"Jaib T Muri:"+"\n"+nilaiMuriT;



//Debug.Log("Sitini  "+nilaiSittini+"\n"+"JaibT   :" +nilaiJaibT+" Sudut   :" +(-angleMuri));


    }




}
