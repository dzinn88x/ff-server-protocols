using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006D RID: 109
[Token(Token = "0x200006D")]
public class PlayerSpawnRegion : MonoBehaviour
{
	// Token: 0x0600014C RID: 332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x23C2BF0", Offset = "0x23C2BF0", VA = "0x7BBCBC2BF0")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014D")]
	[Address(RVA = "0x23C1DFC", Offset = "0x23C1DFC", VA = "0x7BBCBC1DFC")]
	public PlayerSpawnRegion()
	{
	}

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_Transform;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public float m_Theta;

	// Token: 0x04000169 RID: 361
	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Color m_Color;
}
