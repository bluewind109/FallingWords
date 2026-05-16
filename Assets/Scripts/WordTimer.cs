using UnityEngine;

public class WordTimer : MonoBehaviour
{
    [SerializeField] private float wordDelay = 1.5f;

    private float nextWordTime = 0f;

    void Update()
    {
        if (Time.time >= nextWordTime)
        {
            WordManager.Instance.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= 0.99f; // Decrease delay for next word
        }
    }
}
