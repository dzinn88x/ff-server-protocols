using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000038")]
public class RoundColliderManager : MonoBehaviour
{
	// Token: 0x060000AF RID: 175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x23DDC2C", Offset = "0x23DDC2C", VA = "0x7BBCBDDC2C")]
	public void Start()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x23DDD78", Offset = "0x23DDD78", VA = "0x7BBCBDDD78")]
	public void AwakeRoundColliders(int roundID)
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x23DE000", Offset = "0x23DE000", VA = "0x7BBCBDE000")]
	public RoundColliderManager()
	{
	}

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x18")]
	public List<RoundDynamicCollider> colliders;
}
