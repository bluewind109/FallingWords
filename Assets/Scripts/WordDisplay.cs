using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    [SerializeField] private Text text;

    public void SetWord(string word)
    {
        text.text = word;
    }
}
