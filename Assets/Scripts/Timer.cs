using TMPro;
using UnityEngine;
using UnityEngine.Events;


public class Timer : MonoBehaviour
{
    public float tempo = 10f;
    public TMP_Text _textinc;

    public UnityEvent OnLost;

    
    void Start()
    {

        _textinc = GetComponent<TMP_Text>();





    }

    void Update()
    {
        
        _textinc.text = tempo.ToString("N0");
        tempo -= Time.deltaTime;

        if (tempo <= 0)
        {
            tempo = 0;

            Destroy(gameObject);
            OnLost.Invoke();

        }

    }
}