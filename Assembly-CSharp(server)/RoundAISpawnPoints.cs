using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
[Attribute(Name = "RequireComponent", RVA = "0x10E1A68", Offset = "0x10E1A68")]
[Attribute(Name = "RequireComponent", RVA = "0x10E1A68", Offset = "0x10E1A68")]
public class RoundAISpawnPoints : MonoBehaviour
{
	// Token: 0x060000BE RID: 190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x23DDBEC", Offset = "0x23DDBEC", VA = "0x7BBCBDDBEC")]
	private void Start()
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x23DDC24", Offset = "0x23DDC24", VA = "0x7BBCBDDC24")]
	public RoundAISpawnPoints()
	{
	}

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x18")]
	public List<RoundAISpawnPoints.RoundAIInfo> m_SpawnInfoList;

	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Serializable]
	public struct RoundAIInfo
	{
		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x0")]
		public int RoundID;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x4")]
		public int SubRoundID;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x8")]
		public LKBHVE} AIType;
	}
}
