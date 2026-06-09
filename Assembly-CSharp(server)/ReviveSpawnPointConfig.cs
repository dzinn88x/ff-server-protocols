using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000037 RID: 55
[Token(Token = "0x2000037")]
[Attribute(Name = "RequireComponent", RVA = "0x10E19A0", Offset = "0x10E19A0")]
public class ReviveSpawnPointConfig : MonoBehaviour
{
	// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x23DD730", Offset = "0x23DD730", VA = "0x7BBCBDD730")]
	public List<Transform> GetEventTriggerPoints()
	{
		return null;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x23DD888", Offset = "0x23DD888", VA = "0x7BBCBDD888")]
	public List<Transform> GetZeppelinTriggerPoint()
	{
		return null;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x23DDA4C", Offset = "0x23DDA4C", VA = "0x7BBCBDDA4C")]
	public ReviveSpawnPointConfig()
	{
	}

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ColliderTemplate;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EventTriggerSpawnPointsObj;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ZeppelinTriggerSpawnPointsObj;
}
