using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class renkOyunu : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.UI.Text yazi;
    //public UnityEngine.UI.Button btn1, btn2;
    public GameObject btn1, btn2;
    int r , g , b , r2, g2, b2,tempNum;
    public Color turuncu;
    public Color pembe;
    void Start()
    {
        renkSec();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void renkSec()
    {
        tempNum = Random.Range(1, 10);
        switch (tempNum)
        {
            case 1:
                yazi.text = "Mavi";
                r = 0;
                g = 0;
                b = 255;
                renkDondur();
                break;
            case 2:
                yazi.text = "Siyah";
                r = 0;
                g = 0;
                b = 0;
                renkDondur();
                break;
            case 3:
                yazi.text = "Yeþil";
                r = 0;
                g = 255;
                b = 0;
                renkDondur();
                break;
            case 4:
                yazi.text = "Beyaz";
                r = 255;
                g = 255;
                b = 255;
                renkDondur();
                break;
            case 5:
                yazi.text = "Sarý";
                r = 255;
                g = 255;
                b = 0;
                renkDondur();
                break;
            case 6:
                yazi.text = "Kýrmýzý";
                r = 255;
                g = 0;
                b = 0;
                renkDondur();
                break;
            case 7:
                yazi.text = "Mor";
                r = 100;
                g = 0;
                b = 100;
                renkDondur();
                break;
            case 8:
                yazi.text = "Pembe";
                r = 255;
                g = 174;
                b = 201;
                renkDondur();
                break;
            case 9:
                yazi.text = "Turuncu";
                 r = 255;
                 g = 125;
                 b = 0;
                 renkDondur();
                 break;
        }
        
    }
    void renkDondur()
    {
        tempNum = Random.Range(1, 10);
        switch (tempNum)
        {
            case 1:
                yazi.color = Color.blue;
                r2 = 0;
                g2 = 0;
                b2 = 255;
                butonRenk();
                break;
            case 2:
                yazi.color = Color.black;
                r2 = 0;
                g2 = 0;
                b2 = 0;
                butonRenk();
                break;
            case 3:
                yazi.color = Color.green;
                r2 = 0;
                g2 = 255;
                b2 = 0;
                butonRenk();
                break;
            case 4:
                yazi.color = Color.white;
                r2 = 255;
                g2 = 255;
                b2 = 255;
                butonRenk();
                break;
            case 5:
                yazi.color = Color.yellow;
                r2 = 255;
                g2 = 255;
                b2 = 0;
                butonRenk();
                break;

            case 6:
                yazi.color = Color.red;
                r2 = 255;
                g2 = 0;
                b2 = 0;
                butonRenk();
                break;

            case 7:
                yazi.color = new Color(100, 0, 100);
                r2 = 100;
                g2 = 0;
                b2 = 100;
                butonRenk();
                break;

            case 8:              
                yazi.color = new Color(255, 174, 201);
                r2 = 255;
                g2 = 174;
                b2 = 201;              
                butonRenk();
                break;

             case 9:
                yazi.color = turuncu;
                r2 = 255;
                g2 = 125;
                b2 = 0;
                butonRenk();
                break;
        }
    }

    void butonRenk() 
    {
        tempNum = Random.Range(1, 3);

        if (tempNum == 1)
        {
            btn1.GetComponent<Image>().color = new Color(r, g, b);
            btn2.GetComponent<Image>().color = new Color(r2, g2, b2);
            
         /*   if (r == 255 && g == 105 && b ==180)
            {
                btn1.GetComponent<Image>().color = pembe;
            }

            if (r2 == 255 && g2 == 105 && b2 == 180)
            {
                btn2.GetComponent<Image>().color = pembe;
            }*/

            if (r == 255 &&g == 125 && b == 0)
            {
                btn1.GetComponent<Image>().color = turuncu;
            }

            if (r2 == 255 &&g2 == 125 && b2 == 0)
            {
                btn2.GetComponent<Image>().color = turuncu;
            }
        }
        if (tempNum == 2)
        {
            btn1.GetComponent<Image>().color = new Color(r2, g2, b2);
            btn2.GetComponent<Image>().color = new Color(r, g, b);

          /*  if (r == 255 && g == 105 && b == 180)
            {
                btn2.GetComponent<Image>().color = pembe;
            }

            if (r2 == 255 && g2 == 105 && b2 == 180)
            {
                btn1.GetComponent<Image>().color = pembe;
            }
          */
            if (r == 255 && g == 125 && b == 0)
            {
                btn2.GetComponent<Image>().color = turuncu;
            }

            if (r2 == 255 && g2 == 125 && b2 == 0)
            {
                btn1.GetComponent<Image>().color = turuncu;
            }
           
        }
     
    }
}
