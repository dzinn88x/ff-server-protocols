using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
[Attribute(Name = "RequireComponent", RVA = "0x10E193C", Offset = "0x10E193C")]
public class PVEAISpawnPoint : MonoBehaviour
{
	// Token: 0x060000A2 RID: 162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x22AB88C", Offset = "0x22AB88C", VA = "0x7BBCAAB88C")]
	private void Awake()
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x22AB940", Offset = "0x22AB940", VA = "0x7BBCAAB940")]
	public PVEAISpawnPoint()
	{
	}

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x18")]
	public int Id;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x1C")]
	public LKBHVE} SpawnAIType;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x20")]
	public int SpecificPathGroupId;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x24")]
	public int AttackSafeDoorId;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x28")]
	public bool isGroundPoint;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x29")]
	public bool isBossOnly;

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x30")]
	public List<int> RoundsId;
}
