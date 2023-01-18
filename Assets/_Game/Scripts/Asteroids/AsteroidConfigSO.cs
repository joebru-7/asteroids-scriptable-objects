using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{

	[CreateAssetMenu(fileName = "Asteroid Config", menuName = "ScriptableObjects/AsteroidConfig", order = 0)]
	public class AsteroidConfigSO : ScriptableObject
	{

		[Header("Config:")]
		[SerializeField] public float _minForce;
		[SerializeField] public float _maxForce;
		[SerializeField] public float _minSize;
		[SerializeField] public float _maxSize;
		[SerializeField] public float _minTorque;
		[SerializeField] public float _maxTorque;

	}
}
