using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000055 RID: 85
[Token(Token = "0x2000055")]
internal class TransformRotaterYXAngleCalculator : TransformRotaterAngleCalculator
{
	// Token: 0x060000F6 RID: 246 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x2266E68", Offset = "0x2266E68", VA = "0x7BBCA66E68", Slot = "4")]
	public Vector3 CalculateAnglesInLocalSpace(Vector3 current, Vector3 target, float maxAngles)
	{
		return default(Vector3);
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x22671BC", Offset = "0x22671BC", VA = "0x7BBCA671BC")]
	public TransformRotaterYXAngleCalculator()
	{
	}

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 XAngleBounds;
}
