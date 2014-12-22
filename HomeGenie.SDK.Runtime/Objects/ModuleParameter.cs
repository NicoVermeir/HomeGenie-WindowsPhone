using System;
using System.Text.RegularExpressions;

namespace HomeGenie.SDK.Objects
{
    public class ModuleParameter : Data
    {
        public string Description { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool NeedsUpdate { get; set; }
        public string Name { get; set; }
        public string LastValue { get; set; }
        public DateTime LastUpdateTime { get; set; }

        public string DisplayName
        {
            get
            {
                string name = Name.Substring(Name.IndexOf('.'));
                return Regex.Replace(name, @"\.", @" ");
            }
        }

        public string DisplayValue
        {
            get
            {
                return string.IsNullOrWhiteSpace(Value) ? LastValue : Value;
            }
        }

        public double ValueIncrement
        {
            get
            {
                return (DecimalValue - LastDecimalValue);
            }
        }

        public double DecimalValue
        {
            get
            {
                double v;
                if (!double.TryParse(Value, out v)) v = 0;
                return v;
            }
        }

        public double LastDecimalValue
        {
            get
            {
                double v;
                if (!double.TryParse(LastValue, out v)) v = 0;
                return v;
            }
        }

        private string _value;
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                SetField(ref _value, value, "Value");
            }
        }

        public ModuleParameter()
        {
            Name = "";
            Value = "";
            Description = "";
            UpdateTime = DateTime.Now;
            LastValue = "";
            LastUpdateTime = DateTime.Now;
        }

        public bool Is(string name)
        {
            return (Name.ToLower() == name.ToLower());
        }
    }

}
