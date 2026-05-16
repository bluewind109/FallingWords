using UnityEngine;

public class WordDisplay : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI text;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red; // Current active word
    }

    public void RemoveWord()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
