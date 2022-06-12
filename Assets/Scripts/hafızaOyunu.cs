using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hafızaOyunu : MonoBehaviour
{

    [SerializeField]
    private Sprite bgImage;

    public Sprite[] puzzles;
    public List<Sprite> gamePuzzles = new List<Sprite>();

    public List<Button> butonlar = new List<Button>();

    private bool firstGuess, secondGuess;
    private int countGuesses;
    private int countCorrectGuesses;
    private int gameGuesses;
    private int firstGuessIndex, secondGuessIndex;
    private string firstGuessPuzzle, secondGuessPuzzle;

    private void Awake()
    {
        puzzles = Resources.LoadAll<Sprite>("Sprites/Candy");
    }
    void Start()
    {
        butonKaydet();
        addListeners();
        addGamePuzzle();
        shuffle(gamePuzzles);
        gameGuesses = gamePuzzles.Count / 2 ;
    }

    void butonKaydet()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("puzzle");
        for (int i = 0; i < objects.Length; i++)
        {
            butonlar.Add(objects[i].GetComponent<Button>());
            butonlar[i].image.sprite = bgImage;
            
        }
    }
    void addListeners()
    {
        foreach(Button btn in butonlar)
        {
            btn.onClick.AddListener(() => PickAPuzzle());
        }

    }
    void addGamePuzzle()
    {
        int looper = butonlar.Count;
        int index = 0;
        for(int i=0; i < looper; i++)
        {
            if (index == looper / 2)
            {
                index = 0;
            }
            gamePuzzles.Add(puzzles[index]);
            index++;
        }
    }

    public void PickAPuzzle()
    {
        if (!firstGuess)
        {
            firstGuess = true;
            Debug.Log(gamePuzzles[firstGuessIndex].name + " adlı puzzle'a tıkladın1.");
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
            butonlar[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];

        }
        else if(!secondGuess){
            secondGuess = true;
            Debug.Log(gamePuzzles[secondGuessIndex].name + " adlı puzzle'a tıkladın2.");
            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
            butonlar[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];

            /* 
             if (firstGuessPuzzle == secondGuessPuzzle)
             {
                 Debug.Log("Puzzlelar eşleşti.");
             }
             else
             {
                 Debug.Log("Puzzlelar eşleşmedi.");
             }
            */
            countGuesses++;
            StartCoroutine(checkIfThePuzzleMatch());
        }
        else
        {

        }
    }
    IEnumerator checkIfThePuzzleMatch()
    {
        yield return new WaitForSeconds(1f);

        if (firstGuessPuzzle == secondGuessPuzzle)
        {
            yield return new WaitForSeconds(0.5f);
            butonlar[firstGuessIndex].interactable = false;
            butonlar[secondGuessIndex].interactable = false;

            butonlar[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
            butonlar[secondGuessIndex].image.color = new Color(0, 0, 0, 0);

            checkIfTheGameFinished();
        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            butonlar[firstGuessIndex].image.sprite = bgImage;
            butonlar[secondGuessIndex].image.sprite = bgImage;
        }
        yield return new WaitForSeconds(0.5f);
        firstGuess = false;
        secondGuess = false;
    }
    void checkIfTheGameFinished()
    {
        countCorrectGuesses++;

        if (countCorrectGuesses == gameGuesses)
        {
            Debug.Log("Oyun bitti.");
            Debug.Log(countGuesses + " tane tahminde bildin.");
        }
    }
    void shuffle(List<Sprite> list)
    {
        for(int i=0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp; 

        }
    }
    
}
