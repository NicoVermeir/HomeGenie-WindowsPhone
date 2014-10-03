using System;

namespace HomeGenie.SDK.Objects
{
	public class ModuleParameter : Data
	{
		private string _value;
		//
		public string Name { get; set; }
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
		public string Description { get; set; }
		public DateTime UpdateTime { get; /* protected */ set; }
		public bool NeedsUpdate { get; set; }
		//
		public double ValueIncrement 
		{
			get
			{
				return (DecimalValue - LastDecimalValue);
			}
		}
		//
		public string LastValue { get; /* protected */ set; }
		public DateTime LastUpdateTime { get; /* protected */ set; }
		//
		public ModuleParameter()
		{
			Name = "";
			Value = "";
			Description = "";
			UpdateTime = DateTime.Now;
			//
			LastValue = "";
			LastUpdateTime = DateTime.Now;
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

		public bool Is(string name)
		{
			return (Name.ToLower() == name.ToLower());
		}
	}

}
