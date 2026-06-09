using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000066 RID: 102
[Token(Token = "0x2000066")]
public class DrawCircle : MonoBehaviour
{
	// Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x23E78A0", Offset = "0x23E78A0", VA = "0x7BBCBE78A0")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x23E7A74", Offset = "0x23E7A74", VA = "0x7BBCBE7A74")]
	private void drawCircle(float radius)
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x23E7BF4", Offset = "0x23E7BF4", VA = "0x7BBCBE7BF4")]
	public DrawCircle()
	{
	}

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_Transform;

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x24")]
	public int m_Index;

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x28")]
	public bool m_MiniZone;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x2C")]
	public float m_InnerRadius;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float m_Theta;

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public Color m_Color;

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public Color m_InnerColor;
}
