#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Asteroids
{

	[CustomEditor(typeof(AsteroidSpawner))]
	public class AsteroidSpawnerEditor : Editor
	{
		public override VisualElement CreateInspectorGUI()
		{
			// Create a new VisualElement to be the root of our inspector UI
			VisualElement myInspector = new();

			// Add a simple label
			var l = new Label("This is a custom inspector");

			myInspector.Add(l);

			SerializedProperty AsteroidPrefabProperty = serializedObject.FindProperty("_asteroidPrefab");

			myInspector.Add(new PropertyField(AsteroidPrefabProperty, "Asteroid Prefab"));

			if((Asteroid)AsteroidPrefabProperty.objectReferenceValue != null)
			{
				AsteroidConfigSO ac = ((Asteroid)AsteroidPrefabProperty.objectReferenceValue)._configSO;
				if (ac != null)
				{
					Debug.Log(ac);
					var x = CreateEditor(ac);
					Debug.Log(x);
					var y = x.CreateInspectorGUI();
					Debug.Log(y);
					myInspector.Add(y);
					Debug.Log("done");

				}
			}

			serializedObject.FindProperty("_asteroidPrefab");

			myInspector.Add(new Label("end of code"));

			VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/_Game/Scripts/Asteroids/AsteroidSpawner.uxml");
			visualTree.CloneTree(myInspector);


			// Return the finished inspector UI
			return myInspector;
		}
	}

}
#endif