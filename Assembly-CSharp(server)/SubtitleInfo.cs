using System;
using Il2CppDummyDll;

// Token: 0x020000C7 RID: 199
[Token(Token = "0x20000C7")]
[Serializable]
public class SubtitleInfo
{
	// Token: 0x06000320 RID: 800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000320")]
	[Address(RVA = "0x2264430", Offset = "0x2264430", VA = "0x7BBCA64430")]
	public SubtitleInfo()
	{
	}

	// Token: 0x04000334 RID: 820
	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x10")]
	public string content;

	// Token: 0x04000335 RID: 821
	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x18")]
	public string voiceResIDName;

	// Token: 0x04000336 RID: 822
	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x20")]
	public float duration;
}
