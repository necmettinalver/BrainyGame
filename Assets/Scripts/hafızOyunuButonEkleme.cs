using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hafızOyunuButonEkleme : MonoBehaviour
{
    [SerializeField]
    private Transform puzzleToplayıcı;
    [SerializeField]
    private GameObject puzzle;
    int puzzleSayisi = 8;

    void Awake()
    {
        for(int i = 0; i < puzzleSayisi; i++)
        {
            GameObject buton = Instantiate(puzzle);
            buton.name = "" + i;
            buton.transform.SetParent(puzzleToplayıcı,false);
            //false yaptım çünkü objelere doğru tıklayınca ekrandan silinecek
        }
    }

}
