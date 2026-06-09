using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200010F RID: 271
[Token(Token = "0x200010F")]
public class MultiPopMenuData
{
	// Token: 0x060004FC RID: 1276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x22909A0", Offset = "0x22909A0", VA = "0x7BBCA909A0")]
	public MultiPopMenuData()
	{
	}

	// Token: 0x0400043D RID: 1085
	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x10")]
	public string m_Key;

	// Token: 0x0400043E RID: 1086
	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x18")]
	public string m_Label;

	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x20")]
	public bool m_CanSelect;

	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x28")]
	public string m_SelectTip;

	// Token: 0x04000441 RID: 1089
	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x30")]
	public List<MultiPopMenuData> m_Values;
}
