using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventry :MonoBehaviour {
	List<int> itemList = new List<int>();
	public void AddItem(Item.itemType type) {
		itemList.Add ((int)type);
	}

	public bool HasItem() {
		print (itemList.Count);
		if (itemList.Count >= 1) {
			return true;
		} else {
			return false;
		}
	}

}
