using UnityEngine;

public class WordInput : MonoBehaviour
{
    void Update()
    {
        if (WordManager.Instance == null) return;

        foreach (char letter in Input.inputString)
        {
            WordManager.Instance.TypeLetter(letter);
            Debug.Log("Typed letter: " + letter);
        }
    }
}
