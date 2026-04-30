using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public int foundedCats;
    public int catsNumber;
    public UnityEvent OnVictory;
    bool gameEnd = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        catsNumber = transform.childCount;
        
    
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

        if (gameEnd) return;
    }
}
