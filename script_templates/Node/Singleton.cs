using _BINDINGS_NAMESPACE_;
using System;

// Author : 

namespace Com.IsartDigital.Pizza_Hell-s {
	
	public partial class _CLASS_ : _BASE_
	{

        static private _CLASS_ instance;
		static private PackedScene factory = GD.Load<PackedScene>("res://Scenes/_CLASS_.tscn");

		private _CLASS_():base() {
			if (instance != null)
			{
				QueueFree();
				GD.Print(nameof(_CLASS_) + " Instance already exist, destroying the last added.");
				return;
			}

			instance = this;	
		}

		static public _CLASS_ GetInstance()
		{
			if (instance == null) instance = (_CLASS_)factory.Instantiate();
			return instance;

		}

		public override void _Ready()
		{
			base._Ready();
        }

        public override void _Process(double pDelta)
		{
			base._Process(pDelta);
			float lDelta = (float)pDelta;
		}

		protected override void Dispose(bool pDisposing)
		{
			instance = null;
			base.Dispose(pDisposing);
		}
	}
}