using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000054")]
internal interface TransformRotaterAngleCalculator
{
	// Token: 0x060000F5 RID: 245
	[Token(Token = "0x60000F5")]
	Vector3 CalculateAnglesInLocalSpace(Vector3 current, Vector3 target, float maxRad);
}
