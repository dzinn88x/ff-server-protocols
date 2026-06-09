using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EC RID: 492
[Token(Token = "0x20001EC")]
public class CameraFogSetting : MonoBehaviour
{
	// Token: 0x060009F7 RID: 2551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x23DFE70", Offset = "0x23DFE70", VA = "0x7BBCBDFE70")]
	private void OnPreRender()
	{
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x23DFEA8", Offset = "0x23DFEA8", VA = "0x7BBCBDFEA8")]
	private void OnPostRender()
	{
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x23DFEB4", Offset = "0x23DFEB4", VA = "0x7BBCBDFEB4")]
	public CameraFogSetting()
	{
	}

	// Token: 0x04000966 RID: 2406
	[Token(Token = "0x4000966")]
	[FieldOffset(Offset = "0x18")]
	public bool needFog;

	// Token: 0x04000967 RID: 2407
	[Token(Token = "0x4000967")]
	[FieldOffset(Offset = "0x19")]
	private bool doWeHaveFogInScene;
}
