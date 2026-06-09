using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
public class BigToyBallConfig : MonoBehaviour
{
	// Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1F8C1F8", Offset = "0x1F8C1F8", VA = "0x7BBC78C1F8")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1F8C438", Offset = "0x1F8C438", VA = "0x7BBC78C438")]
	public BigToyBallConfig()
	{
	}

	// Token: 0x0400014C RID: 332
	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_SpawnPoint;

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x20")]
	public Transform m_MoveRangeCenter;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x28")]
	public float m_MoveRangeRadius;

	// Token: 0x0400014F RID: 335
	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFB00", Offset = "0x10FFB00")]
	public float m_Size;

	// Token: 0x04000150 RID: 336
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x30")]
	public float m_VelocityY;

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x34")]
	public float m_VelocityXZ;

	// Token: 0x04000152 RID: 338
	[Token(Token = "0x4000152")]
	private const float m_Theta = 0.0001f;
}
