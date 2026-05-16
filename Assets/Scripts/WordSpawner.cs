using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wordPrefab;
    [SerializeField] private Transform wordCanvas;

    public WordDisplay SpawnWord()
    {
        WordDisplay wordInstance = Instantiate(wordPrefab, wordCanvas).GetComponent<WordDisplay>();
        return wordInstance;
    }
}
