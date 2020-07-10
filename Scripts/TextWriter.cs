using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{
    private List<TextWriterSingle> textWriterSingleList;
    private void Awake()
    {
        textWriterSingleList = new List<TextWriterSingle>();
    }
    public void AddWriter(Text uiText, string TextToWrite, float TimePerChar)
    {
        textWriterSingleList.Add (new TextWriterSingle(uiText, TextToWrite, TimePerChar));
    }
    private void Update()
    {
        for(int i=0; i < textWriterSingleList.Count; i++)
        {
            textWriterSingleList[i].Update();
            bool destroyInstance = textWriterSingleList[i].Update();
            if(destroyInstance)
            {
                textWriterSingleList.RemoveAt(i);
                i--;
            }
        }
    }

    public class TextWriterSingle
    {
        private Text uiText;
        private string TextToWrite;
        private int CharIndex;
        private float TimePerChar;
        private float timer;

        public TextWriterSingle(Text uiText, string TextToWrite, float TimePerChar)
        {
            this.uiText = uiText;
            this.TextToWrite = TextToWrite;
            this.TimePerChar = TimePerChar;
            CharIndex = 0;
        }

        public bool Update()
        {
            
            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                timer += TimePerChar;
                CharIndex++;
                string text = TextToWrite.Substring(0, CharIndex);
                uiText.text = text;
                if (CharIndex >= TextToWrite.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }    
}
