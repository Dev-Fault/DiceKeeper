using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceKeeper
{
    sealed class DiceHistory
    {
        public class Log
        {        
            public string Label { get; private set; }
            public string CustomName { get; private set; }
            public string Total { get; private set; }
            public string IndividualTotals { get; private set; }

            public Log(string label, string total, string individualTotals = null, string customName = null)
            {
                Label = label;
                Total = total;
                IndividualTotals = individualTotals;
                CustomName = customName;
            }

            public static string ToString(List<string> values)
            {
                string output = "";
                for (int i = 0; i != values.Count; i++)
                {
                    output += values[i];
                    if (i != values.Count - 1) output += ", ";
                }
                return output;
            }

            public static string ToString(List<uint> values)
            {
                string output = "";
                for (int i = 0; i != values.Count; i++)
                {
                    output += values[i];
                    if (i != values.Count - 1) output += ", ";
                }
                return output;
            }

            public static string ToString(List<Tuple<Die, uint>> dice)
            {
                string output = "";
                int i = 0;
                foreach (Tuple<Die, uint> tuple in dice)
                {
                    Die die = tuple.Item1;
                    uint roll = tuple.Item2;
                    string name = die.CustomName == "" ? die.Label : die.CustomName;
                    output += die.Label + ": " + roll;
                    if (i != dice.Count - 1) output += ", ";
                    i++;
                }
                return output;
            }
        }

        private const uint maxLogs = 20;
        private int selectedLogIndex;

        private static DiceHistory instance = null;
        public static DiceHistory Instance
        {
            get
            {
                if (instance == null) instance = new DiceHistory();
                return instance;
            }
        }
        public List<Log> Logs { get; private set; }
        public Log SelectedLog
        {
            get
            {
                if (Logs.Count >= 1) return Logs[selectedLogIndex];
                else return null;
            }
        }
        public event Action OnLogAdded;

        private DiceHistory()
        {
            Logs = new List<Log>();
            selectedLogIndex = 0;
        }

        public void AddLog(string label, uint total, List<uint> individualTotals = null, string customName = null)
        {
            if (Logs.Count >= maxLogs) Logs.RemoveAt(0);
            Logs.Add(new Log(label, Convert.ToString(total), Log.ToString(individualTotals), customName));
            selectedLogIndex = Logs.Count - 1;
            OnLogAdded?.Invoke();
        }

        public void AddGroupLog(List<string> groupLabel, uint total, List<Tuple<Die, uint>> dice)
        {
            if (Logs.Count >= maxLogs) Logs.RemoveAt(0);
            Logs.Add(new Log(Log.ToString(groupLabel), Convert.ToString(total), Log.ToString(dice)));
            selectedLogIndex = Logs.Count - 1;
            OnLogAdded?.Invoke();
        }

        public void SelectPreviousLog()
        {
            if (Logs.Count >= 1)
            {
                selectedLogIndex = ((selectedLogIndex - 1) + Logs.Count) % Logs.Count;
            }
            else return;
        }

        public void SelectNextLog()
        {
            if (Logs.Count >= 1)
            {
                selectedLogIndex = (selectedLogIndex + 1) % Logs.Count;
            }
            else return;
        }
    }
}
