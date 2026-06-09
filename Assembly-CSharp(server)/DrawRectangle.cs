using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000067 RID: 103
[Token(Token = "0x2000067")]
public class DrawRectangle : MonoBehaviour
{
	// Token: 0x0600013D RID: 317 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x23E7C4C", Offset = "0x23E7C4C", VA = "0x7BBCBE7C4C")]
	public Bounds GetBounds(float extend)
	{
		return default(Bounds);
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x23E8090", Offset = "0x23E8090", VA = "0x7BBCBE8090")]
	public void GetDirection(out Vector3 forward, out Vector3 right)
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013F")]
	[Address(RVA = "0x23E81F8", Offset = "0x23E81F8", VA = "0x7BBCBE81F8")]
	private void UpdateExtent(ref Vector3 ext, Vector3 point)
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x23E8290", Offset = "0x23E8290", VA = "0x7BBCBE8290")]
	private void Reset()
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x23E82B8", Offset = "0x23E82B8", VA = "0x7BBCBE82B8")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x23E8670", Offset = "0x23E8670", VA = "0x7BBCBE8670")]
	public DrawRectangle()
	{
	}

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_Transform;

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x20")]
	public float m_Width;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x24")]
	public float m_Length;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x28")]
	public float m_Angles;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public Color m_Color;
}
