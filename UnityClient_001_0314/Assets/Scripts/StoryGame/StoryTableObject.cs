using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORTGAME
{
    [CreateAssetMenu(fileName = "NewStory", menuName = "ScriptableObject/StoryTableObject")]
    public class StoryTableObject : ScriptableObject
    {
        public int storyNumber;
        public Enums.StoryType storyType;
        public bool storyDone;

        [TextArea(10, 10)]
        public string storyText;
        public List<Option> options = new List<Option>();

        [System.Serializable]
        public class Option
        {
            public string optionText;
            public string buttonText;
            public EventCheck eventCheck;
        }

        [System.Serializable]

        public class EventCheck
        {
            public int checkValue;
            public Enums.EventType eventType;
            public List<Result> successResult = new List<Result>();
            public List<Result> FailResult = new List<Result>();

        }
        public class Result
        {
            public Enums.ResultType resultType;
            public int value;
            public Stats stats;
        }
    }
}