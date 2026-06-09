using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E0 RID: 480
[Token(Token = "0x20001E0")]
[Attribute(Name = "RequireComponent", RVA = "0x10E2534", Offset = "0x10E2534")]
public class CameraReflection : MonoBehaviour
{
	// Token: 0x060009DF RID: 2527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x23DFEBC", Offset = "0x23DFEBC", VA = "0x7BBCBDFEBC")]
	public CameraReflection()
	{
	}

	// Token: 0x04000940 RID: 2368
	[Token(Token = "0x4000940")]
	public const int DISTRICT_COUNT = 3;

	// Token: 0x04000941 RID: 2369
	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x18")]
	public CameraClearFlags clearFlag;

	// Token: 0x04000942 RID: 2370
	[Token(Token = "0x4000942")]
	[FieldOffset(Offset = "0x1C")]
	public Color backgroundColor;

	// Token: 0x04000943 RID: 2371
	[Token(Token = "0x4000943")]
	[FieldOffset(Offset = "0x2C")]
	public CameraReflection.SizeEnum sizeType;

	// Token: 0x04000944 RID: 2372
	[Token(Token = "0x4000944")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float horizonY;

	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	public enum SizeEnum
	{
		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		Sixteenth = 64,
		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		Eighth = 128,
		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		Quarter = 256,
		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		Half = 512,
		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		One = 1024
	}

	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	public enum ReflectDistrict
	{
		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		Sea,
		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		Dam,
		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		UnderDam
	}
}
