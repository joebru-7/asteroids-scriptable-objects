using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{

	[CreateAssetMenu(fileName = "Asteroid Config", menuName = "ScriptableObjects/AsteroidConfig", order = 0)]
	public class AsteroidConfigSO : ScriptableObject
	{
		public float _minForce;
		public float _maxForce;
		public float _minSize;
		public float _maxSize;
		public float _minTorque;
		public float _maxTorque;

	}
}
