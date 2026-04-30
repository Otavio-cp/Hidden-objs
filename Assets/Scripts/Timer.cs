using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public float tempo = 10f;
    public TextMeshProUGUI textTimer;

    public UnityEvent OnLost;

    private bool acabou = false;

    void Start()
    {







    }

    void Update()
    {
        if (acabou) return;

        tempo -= Time.deltaTime;

        if (tempo <= 0)
        {
            tempo = 0;
            acabou = true;
            Destroy(gameObject);
            OnLost.Invoke();
            // Aqui tu pode chamar algo tipo:
            // gameController.GameOver();
        }

        textTimer.text = Mathf.Ceil(tempo).ToString();

        
      
    }
}