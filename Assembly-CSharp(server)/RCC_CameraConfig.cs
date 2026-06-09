using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016D RID: 365
[Token(Token = "0x200016D")]
[Attribute(Name = "AddComponentMenu", RVA = "0x10E2410", Offset = "0x10E2410")]
public class RCC_CameraConfig : MonoBehaviour
{
	// Token: 0x0600071D RID: 1821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071D")]
	[Address(RVA = "0x23CE750", Offset = "0x23CE750", VA = "0x7BBCBCE750")]
	private void Awake()
	{
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071E")]
	[Address(RVA = "0x23CCF44", Offset = "0x23CCF44", VA = "0x7BBCBCCF44")]
	public void SetCameraSettings()
	{
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00003408 File Offset: 0x00001608
	[Token(Token = "0x600071F")]
	[Address(RVA = "0x23CE8E4", Offset = "0x23CE8E4", VA = "0x7BBCBCE8E4")]
	public static float MaxBoundsExtent(Transform obj)
	{
		return 0f;
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000720")]
	[Address(RVA = "0x23CEB38", Offset = "0x23CEB38", VA = "0x7BBCBCEB38")]
	public RCC_CameraConfig()
	{
	}

	// Token: 0x040006A4 RID: 1700
	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x18")]
	public bool automatic;

	// Token: 0x040006A5 RID: 1701
	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x1C")]
	private Bounds combinedBounds;

	// Token: 0x040006A6 RID: 1702
	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x34")]
	public float distance;

	// Token: 0x040006A7 RID: 1703
	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x38")]
	public float height;
}
