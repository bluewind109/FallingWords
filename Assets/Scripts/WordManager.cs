using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    List<Word> words = new List<Word>();

    void Start()
    {
        WordGenerator.LoadWords();
        AddWord();
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord());
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
