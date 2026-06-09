using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000201 RID: 513
[Token(Token = "0x2000201")]
[ExecuteInEditMode]
public class NoCastShadow : MonoBehaviour
{
	// Token: 0x06000A38 RID: 2616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x2290EEC", Offset = "0x2290EEC", VA = "0x7BBCA90EEC")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x22910C4", Offset = "0x22910C4", VA = "0x7BBCA910C4")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x22912D0", Offset = "0x22912D0", VA = "0x7BBCA912D0")]
	public NoCastShadow()
	{
	}

	// Token: 0x04000997 RID: 2455
	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x18")]
	public Renderer[] renderers;

	// Token: 0x04000998 RID: 2456
	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x20")]
	public ShadowCastingMode[] shadowCastingMode;
}
