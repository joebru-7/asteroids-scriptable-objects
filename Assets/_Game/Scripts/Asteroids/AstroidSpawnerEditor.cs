#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Asteroids
{

	//[CustomEditor(typeof(AsteroidSpawner))]
	public class AsteroidSpawnerEditor : Editor
	{
		public override VisualElement CreateInspectorGUI()
		{
			// Create a new VisualElement to be the root of our inspector UI
			VisualElement myInspector = new();

			// Add a simple label
			myInspector.Add(new Label("This is a custom inspector"));

			myInspector.Add(new RadioButton("radio"));
			
			VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/_Game/Scripts/Asteroids/AsteroidSpawner.uxml");
			visualTree.CloneTree(myInspector);


			// Return the finished inspector UI
			return myInspector;
		}
	}

}
#endif