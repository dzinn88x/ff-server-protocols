using System;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x20001A8")]
[Serializable]
public class SharedColorTable : ScriptableObject, ISerializationCallbackReceiver
{
	// Token: 0x060008EE RID: 2286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x2258548", Offset = "0x2258548", VA = "0x7BBCA58548", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x225854C", Offset = "0x225854C", VA = "0x7BBCA5854C", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x225860C", Offset = "0x225860C", VA = "0x7BBCA5860C")]
	public SharedColorTable()
	{
	}

	// Token: 0x040008A8 RID: 2216
	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x18")]
	public int channelCount;

	// Token: 0x040008A9 RID: 2217
	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x20")]
	public string sharedColorName;

	// Token: 0x040008AA RID: 2218
	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x28")]
	public float colorNormalized;

	// Token: 0x040008AB RID: 2219
	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x30")]
	public OverlayColorData[] colors;
}
