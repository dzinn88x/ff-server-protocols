using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BC RID: 444
[Token(Token = "0x20001BC")]
public class TrikeMotorcycleSkinInfo : MotorcyleSkinInfo
{
	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A1")]
	public override List<Transform> WheelModels
	{
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x22690C0", Offset = "0x22690C0", VA = "0x7BBCA690C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000955")]
	[Address(RVA = "0x22691C0", Offset = "0x22691C0", VA = "0x7BBCA691C0")]
	public TrikeMotorcycleSkinInfo()
	{
	}

	// Token: 0x040008DA RID: 2266
	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x58")]
	public Transform SideWheelModel;
}
