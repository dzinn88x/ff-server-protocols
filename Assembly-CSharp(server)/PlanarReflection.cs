using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E4 RID: 484
[Token(Token = "0x20001E4")]
public class PlanarReflection : MonoBehaviour
{
	// Token: 0x060009E4 RID: 2532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x23C159C", Offset = "0x23C159C", VA = "0x7BBCBC159C")]
	private void Start()
	{
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x23C1ADC", Offset = "0x23C1ADC", VA = "0x7BBCBC1ADC")]
	private void Update()
	{
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x23C1810", Offset = "0x23C1810", VA = "0x7BBCBC1810")]
	private void UpdateRefCamera()
	{
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x23C1C10", Offset = "0x23C1C10", VA = "0x7BBCBC1C10")]
	private void OnDestroy()
	{
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x23C1D2C", Offset = "0x23C1D2C", VA = "0x7BBCBC1D2C")]
	public PlanarReflection()
	{
	}

	// Token: 0x04000952 RID: 2386
	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0x18")]
	public PlanarReflection.SizeEnum m_sizeType;

	// Token: 0x04000953 RID: 2387
	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x20")]
	public Camera m_mainCamera;

	// Token: 0x04000954 RID: 2388
	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x28")]
	public Camera m_reflectionCamera;

	// Token: 0x04000955 RID: 2389
	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x30")]
	private Material m_reflectionMaterial;

	// Token: 0x04000956 RID: 2390
	[Token(Token = "0x4000956")]
	[FieldOffset(Offset = "0x38")]
	private RenderTexture m_reflectionRT;

	// Token: 0x04000957 RID: 2391
	[Token(Token = "0x4000957")]
	[FieldOffset(Offset = "0x40")]
	private int m_reflectionRTsize;

	// Token: 0x04000958 RID: 2392
	[Token(Token = "0x4000958")]
	[FieldOffset(Offset = "0x44")]
	private int m_reflectionTexID;

	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	public enum SizeEnum
	{
		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		Sixteenth = 64,
		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		Eighth = 128,
		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		Quarter = 256,
		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		Half = 512,
		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		One = 1024
	}
}
