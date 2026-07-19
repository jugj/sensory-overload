using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro ;
public class ButtonScript : MonoBehaviour

{
    public TextMeshProUGUI zählerText;
    int maxZähler = 20;
    int zähler;
    public lebensanzeige lebensanzeige;
    
    //Eine Funktion
    // Start is called before the first frame update
   
   public void ButtonPressed(){
    zähler =zähler -1;
    zählerText.text = zähler + "";
    lebensanzeige.SetzeLeben(zähler);

   }
   void Start()
    {
        zähler = maxZähler;
        lebensanzeige.setzeMaxLeben(maxZähler);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
