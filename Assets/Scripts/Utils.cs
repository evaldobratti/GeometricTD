using UnityEngine;
using System.Collections;

public static class Utils {

	public static Quaternion LookFromTo(Transform from, Vector3 to) {
		Vector3 lookTo = to - from.position;
		Quaternion rotation = Quaternion.LookRotation (lookTo);
		
		return Quaternion.Slerp(from.rotation, rotation, 1);
	}
}
