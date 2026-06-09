using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E8 RID: 488
[Token(Token = "0x20001E8")]
[ExecuteInEditMode]
public class VignetteEffect : MonoBehaviour
{
	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B3")]
	private Material material
	{
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x218CD64", Offset = "0x218CD64", VA = "0x7BBC98CD64")]
		get
		{
			return null;
		}
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EC")]
	[Address(RVA = "0x218CE2C", Offset = "0x218CE2C", VA = "0x7BBC98CE2C")]
	private void Start()
	{
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009ED")]
	[Address(RVA = "0x218CE6C", Offset = "0x218CE6C", VA = "0x7BBC98CE6C")]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EE")]
	[Address(RVA = "0x218CFB0", Offset = "0x218CFB0", VA = "0x7BBC98CFB0")]
	private void OnDisable()
	{
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EF")]
	[Address(RVA = "0x218D060", Offset = "0x218D060", VA = "0x7BBC98D060")]
	public VignetteEffect()
	{
	}

	// Token: 0x04000961 RID: 2401
	[Token(Token = "0x4000961")]
	[FieldOffset(Offset = "0x18")]
	public Shader curShader;

	// Token: 0x04000962 RID: 2402
	[Token(Token = "0x4000962")]
	[FieldOffset(Offset = "0x20")]
	public float VignettePower;

	// Token: 0x04000963 RID: 2403
	[Token(Token = "0x4000963")]
	[FieldOffset(Offset = "0x28")]
	private Material curMaterial;
}
