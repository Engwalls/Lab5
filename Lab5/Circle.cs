using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
	class Circle                                           // Setting up a new class
	{
		private float _pi = 3.141f;                        // Setting PI		
		private int _Radius;                               // Setting Radius
		public Circle(int _Radius)                         // Constructor
		{
			this._Radius = _Radius;
		}
		public double GetArea()                            // Method
		{
			double numArea = _Radius * _Radius * _pi;      // Setting up the calculation for the area on the circle
			return numArea;                                // The calculation of the area on the circle
		}
		public float GetVolume()                           // Method
		{
			float sphereVolume = 4 / 3 * _pi * _pi * _pi;  // Setting up the calculation for the volume on the sphere
			return sphereVolume;                           // The Calculation of the volume on the sphere
		}
		public float GetOmkrets()                          // Method
		{
			float sphereOmkrets = 2 * _pi * _Radius;       // Setting up the calculation of the omkrets on the sphere
			return sphereOmkrets;                          // The calculation of the omkrets on the sphere
		}
	}
}
