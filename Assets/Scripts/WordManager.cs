using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    List<Word> words = new List<Word>();

    private bool hasActiveWord = false;
    private Word activeWord;

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

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            // Check if letter was next
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}

[System.Serializable]
public class Word
{
    public string word;
    private int typeIndex;
    
    public Word(string _word)
    {
        word = _word;
        typeIndex = 0;
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        // Remove the letter on screen
    }

    public bool WordTyped()
    {
        bool wordTyped = typeIndex >= word.Length;
        if (wordTyped)
        {
            // Remove the word on screen
        }
        return wordTyped;
    }
}
