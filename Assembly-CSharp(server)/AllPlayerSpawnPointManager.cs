using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000045 RID: 69
[Token(Token = "0x2000045")]
public class AllPlayerSpawnPointManager : MonoBehaviour
{
	// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1F8355C", Offset = "0x1F8355C", VA = "0x7BBC78355C")]
	[Attribute(Name = "ContextMenu", RVA = "0x1131EE8", Offset = "0x1131EE8")]
	public void RefreshPoint()
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1F836A8", Offset = "0x1F836A8", VA = "0x7BBC7836A8")]
	public AllPlayerSpawnPointManager()
	{
	}

	// Token: 0x040000FA RID: 250
	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> pointList;
}
