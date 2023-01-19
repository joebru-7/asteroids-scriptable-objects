#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEditor.TerrainTools;

namespace Asteroids
{

	[CustomEditor(typeof(AsteroidSpawner))]
	public class AsteroidSpawnerEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			SerializedProperty AsteroidPrefabProperty = serializedObject.FindProperty("_asteroidPrefab");

			if ((Asteroid)AsteroidPrefabProperty.objectReferenceValue != null)
			{
				EditorGUI.indentLevel++;
				EditorGUILayout.LabelField("Asteroid:",EditorStyles.boldLabel);
				Asteroid ac = ((Asteroid)AsteroidPrefabProperty.objectReferenceValue);
				if (ac != null)
				{
					CreateEditor(ac).DrawDefaultInspector();

					if(ac._configSO!= null)
					{
						EditorGUI.indentLevel++;
						EditorGUILayout.LabelField("Asteroid Config:",EditorStyles.boldLabel);
						CreateEditor(ac._configSO).DrawDefaultInspector();

					}
				}
			}
		}


			/*
			 * public override VisualElement CreateInspectorGUI()
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
					Asteroid ac = ((Asteroid)AsteroidPrefabProperty.objectReferenceValue);
					if (ac != null)
					{

						Debug.Log(ac);
						var x = CreateEditor(ac);
						x.DrawDefaultInspector();
						Debug.Log(x);
						var y = x.CreateInspectorGUI();
						Debug.Log(y);
						myInspector.Add(y);
						Debug.Log("done");


						VisualElement def = new Foldout();
						InspectorElement.FillDefaultInspector(def, new SerializedObject(x),this);
						myInspector.Add(def);

					}
				}


				serializedObject.FindProperty("_asteroidPrefab");

				myInspector.Add(new Label("end of code"));

				VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/_Game/Scripts/Asteroids/AsteroidSpawner.uxml");
				visualTree.CloneTree(myInspector);


				// Return the finished inspector UI
				return myInspector;
			}
			*/
		}

}
#endif