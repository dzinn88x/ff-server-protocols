using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D1 RID: 465
[Token(Token = "0x20001D1")]
public class ABSceneInfo
{
	// Token: 0x060009A4 RID: 2468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x1F82C94", Offset = "0x1F82C94", VA = "0x7BBC782C94")]
	public ABSceneInfo()
	{
	}

	// Token: 0x0400092E RID: 2350
	[Token(Token = "0x400092E")]
	[FieldOffset(Offset = "0x10")]
	public bool m_hasLMOrCollider;

	// Token: 0x0400092F RID: 2351
	[Token(Token = "0x400092F")]
	[FieldOffset(Offset = "0x18")]
	public List<ABSceneGOInfo> m_sceneGOInfoList;

	// Token: 0x04000930 RID: 2352
	[Token(Token = "0x4000930")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_rootGO;
}
