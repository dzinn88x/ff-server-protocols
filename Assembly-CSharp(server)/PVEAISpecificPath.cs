using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000031 RID: 49
[Token(Token = "0x2000031")]
public class PVEAISpecificPath : MonoBehaviour
{
	// Token: 0x060000A4 RID: 164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x22AB9C0", Offset = "0x22AB9C0", VA = "0x7BBCAAB9C0")]
	private void Awake()
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x22ABA74", Offset = "0x22ABA74", VA = "0x7BBCAABA74")]
	public PVEAISpecificPath()
	{
	}

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x18")]
	public int PathGroupId;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> PathNaviSpots;
}
