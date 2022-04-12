using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;

    private void Start()
    {
        
    } 

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter (char letter)
    {
        if (hasActiveWord)
        {
            //Check if letter was next
            //Remove it from the word
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
                    //determines the word you are typing as the active word
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                    //doesn't search for another word and set it to active
                }

            }
        }
        //if we've typed the entire word, set the word to false and remove it from the list
        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
