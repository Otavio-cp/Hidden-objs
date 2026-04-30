using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public int foundedCats;
    public int catsNumber;
    public UnityEvent OnVictory;
    public UnityEvent OnCatSpawn;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        catsNumber = transform.childCount;



        Screen.SetResolution(1920, 1080, true);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FoundCat()
    {
        //Esta linha é apenas para programadores
        //foundedCats = foundedCats + 1;
        foundedCats += 1;
        if (foundedCats >= catsNumber)
        {
            
            OnVictory.Invoke();
        }
        //foundedCats++;


        if (foundedCats >= 3)
        {
            OnCatSpawn.Invoke();
        }

    }
}
