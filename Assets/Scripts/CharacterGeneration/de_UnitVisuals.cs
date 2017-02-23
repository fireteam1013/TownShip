using UnityEngine;

public class de_UnitVisuals : MonoBehaviour {

	#region Variables
	public Sprite[] heads;
	public Sprite[] bodies;

	int head = 0;
	int body = 0;

	private GameObject headObj;
	private GameObject bodyObj;
	#endregion

	#region UnityMethods
	void Awake () 
	{
		DebugGeneration();
		headObj = gameObject.transform.GetChild(0).gameObject;
		SpriteRenderer headSprite = headObj.GetComponent<SpriteRenderer>();
		headSprite.sprite = heads[head];
		if(head ==0 || head == 2)
		{
			headSprite.transform.localPosition = new Vector3(0, .05f, 0);
		}
		bodyObj = gameObject.transform.GetChild(1).gameObject;
		SpriteRenderer bodySprite = bodyObj.GetComponent<SpriteRenderer>();
		bodySprite.sprite = bodies[body];
	}
	#endregion

	void DebugGeneration()
	{
		int x = Random.Range(0, 4);
		head = x;
		body = x;
	}
}
