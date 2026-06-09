using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000058 RID: 88
[Token(Token = "0x2000058")]
public class EffectHealingDance : MonoBehaviour
{
	// Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x23F479C", Offset = "0x23F479C", VA = "0x7BBCBF479C")]
	public void Init(Transform parent)
	{
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x23F48FC", Offset = "0x23F48FC", VA = "0x7BBCBF48FC")]
	public void SetData(Vector3 worldPos, float range)
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x23F4A2C", Offset = "0x23F4A2C", VA = "0x7BBCBF4A2C")]
	public void Clear()
	{
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x23F4B4C", Offset = "0x23F4B4C", VA = "0x7BBCBF4B4C")]
	public EffectHealingDance()
	{
	}

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_Mesh;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_Others;
}
