using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameController gameController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        gameController = GetComponentInParent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        gameController.FoundCat();
        Destroy(gameObject);
    }
}
