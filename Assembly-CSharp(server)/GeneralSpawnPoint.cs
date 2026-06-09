using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
public class GeneralSpawnPoint : MonoBehaviour
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000085 RID: 133 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x17000006")]
	public bool ExportDirection
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2748A14", Offset = "0x2748A14", VA = "0x7BBCF48A14")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2748A1C", Offset = "0x2748A1C", VA = "0x7BBCF48A1C")]
	public GeneralSpawnPoint()
	{
	}

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x18")]
	public int ID;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x1C")]
	public EGeneralSpawnPointType Type;
}
