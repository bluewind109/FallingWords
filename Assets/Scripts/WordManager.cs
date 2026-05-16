using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    List<Word> words = new List<Word>();

    void Start()
    {
        WordGenerator.LoadWords();
        var word = WordGenerator.GetRandomWord();
        Debug.Log(word);
        AddWord(word);
    }

    public void AddWord(string _word)
    {
        Word word = new Word(_word);
        words.Add(word);
    }
}

[System.Serializable]
public class Word
{
    public string word;
    
    public Word(string _word)
    {
        word = _word;
    }
}
