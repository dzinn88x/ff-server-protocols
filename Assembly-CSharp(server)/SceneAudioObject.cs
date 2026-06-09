using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
public class SceneAudioObject : MonoBehaviour
{
	// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2256748", Offset = "0x2256748", VA = "0x7BBCA56748")]
	public SceneAudioObject()
	{
	}

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string m_ResourceID;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SceneAudioObject.EMultiPositionType m_PositionType;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private SceneAudioObject.EAttenuationSphere m_ShowAttenuationSphere;

	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public enum EMultiPositionType
	{
		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		Simple_Mode,
		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		Large_Mode,
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		MultiPosition_Mode
	}

	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public enum EAttenuationSphere
	{
		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		Dont_Show,
		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		Current_Event_Only,
		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		All_Events
	}
}
