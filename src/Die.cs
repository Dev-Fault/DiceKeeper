using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceKeeper
{
    public class Die
    {
        public enum ModifierType { NONE, ADD, SUBTRACT, MULTIPLY, DIVIDE }
        private readonly Dictionary<ModifierType, string> modifierSymbols = new Dictionary<ModifierType, string>
        {
            { ModifierType.NONE,        "" },
            { ModifierType.ADD,         "+" },
            { ModifierType.SUBTRACT,    "-" },
            { ModifierType.MULTIPLY,    "*" },
            { ModifierType.DIVIDE,      "/" },
        };

        private string label;
        private string customName;
        private uint sides;
        private uint rollCount = 1;
        private ModifierType modifierType = ModifierType.NONE;
        private uint modifier;
        private Random random = new Random();

        public uint Sides
        {
            get
            { return sides; }
        }
        public string Label
        {
            get
            {
                return label;
            }
        }
        public string CustomName
        {
            get
            {
                return customName;
            }
        }

        public Die(uint sides, uint rollCount = 1, uint modifier = 0, ModifierType modifierType = ModifierType.NONE, string customName = "")
        {
            this.sides = sides;
            this.modifierType = modifierType;
            this.modifier = modifier;
            this.rollCount = rollCount;
            this.customName = customName;
            CreateLabel();
        }

        // sides, rollCount, modifierType, modifier, customName

        public Die(string csvLine)
        {
            string[] dieData = csvLine.Split(',');
            try
            {
                sides = Convert.ToUInt32(dieData[0]);
                rollCount = Convert.ToUInt32(dieData[1]);
                modifierType = StringToModifierType(dieData[2]);
                modifier = Convert.ToUInt32(dieData[3]);
                customName = dieData[4];
            }
            catch
            {
                throw new Exception();
            }        
            CreateLabel();
        }

        private void CreateLabel()
        {
            if (modifier == 0 && rollCount == 1) label = $"D{sides}";
            else if (modifier == 0 && rollCount > 1) label = $"{rollCount}D{sides}";
            else if (modifier > 0 && rollCount == 1) label = $"D{sides} {modifierSymbols[modifierType]} {modifier}";
            else label = $"{rollCount}D{sides} {modifierSymbols[modifierType]} {modifier}";
        }

        public uint ApplyModifier(uint value)
        {
            int mod = Convert.ToInt32(modifier);
            int input = Convert.ToInt32(value);
            switch (modifierType)
            {
                case ModifierType.NONE:
                    return value;
                case ModifierType.ADD:
                    return value + modifier;
                case ModifierType.SUBTRACT:
                    if (input - mod <= 0) return 0;
                    else return value - modifier;
                case ModifierType.MULTIPLY:
                    return value * modifier;
                case ModifierType.DIVIDE:
                    return value / modifier;
                default:
                    return value;
            }
        }

        public uint Roll(bool log = true)
        {
            uint total = 0;
            List<uint> rolls = new List<uint>();
            for (int i = 0; i != rollCount; i++)
            {
                random = new Random(DateTime.UtcNow.Millisecond * (i + 1));
                uint roll = (uint)random.Next(1, Convert.ToInt32(sides) + 1);
                rolls.Add(roll);
                total += ApplyModifier(roll);
            }
            if (log) DiceHistory.Instance.AddLog(label, total, rolls, customName);
            return total;
        }

        public static uint RollGroup(List<Die> dice, bool log = true)
        {
            List<string> groupLabel = new List<string>();
            uint total = 0;
            List<Tuple<Die, uint>> rolls = new List<Tuple<Die, uint>>();
            foreach (Die die in dice)
            {
                groupLabel.Add(die.label);
                uint roll = die.Roll(false);
                total += roll;
                rolls.Add(new Tuple<Die, uint>(die, roll));
            }
            if (log) DiceHistory.Instance.AddGroupLog(groupLabel, total, rolls);
            return total;
        }

        public string ToCSVLine()
        {
            return $"{sides},{rollCount},{modifierType},{modifier},{customName}";
        }

        public static ModifierType StringToModifierType(string input)
        {
            if (input == "+" || input == "ADD")
            {
                return ModifierType.ADD;
            }
            else if (input == "-" || input == "SUBTRACT")
            {
                return ModifierType.SUBTRACT;
            }
            else if (input == "*" || input == "MULTIPLY")
            {
                return ModifierType.MULTIPLY;
            }
            else if (input == "/" || input == "DIVIDE")
            {
                return ModifierType.DIVIDE;
            }
            else
            {
                return ModifierType.NONE;
            }
        }
    }
}
