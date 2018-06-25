using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using UnityEditor;

public class ECSScript : MonoBehaviour
{

	public float speed;

}

class ECSSystem : ComponentSystem
{
	struct Components
	{
	 	public ECSScript scriptComponent;
		public Transform componentTransform;

	}
	protected override void OnUpdate()
	{
		float time = Time.deltaTime;
		foreach (var e in GetEntities<Components>())
		{
			e.componentTransform.Rotate(time*e.scriptComponent.speed,time*e.scriptComponent.speed,0f);
		}
	}
}