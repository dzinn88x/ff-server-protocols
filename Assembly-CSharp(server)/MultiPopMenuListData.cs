using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000110 RID: 272
[Token(Token = "0x2000110")]
public class MultiPopMenuListData
{
	// Token: 0x060004FD RID: 1277 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x22909B0", Offset = "0x22909B0", VA = "0x7BBCA909B0")]
	public int GetParentMenuIndexCount()
	{
		return 0;
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x2290A10", Offset = "0x2290A10", VA = "0x7BBCA90A10")]
	public MultiPopMenuListData()
	{
	}

	// Token: 0x04000442 RID: 1090
	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x10")]
	public string m_Key;

	// Token: 0x04000443 RID: 1091
	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x18")]
	public string m_Label;

	// Token: 0x04000444 RID: 1092
	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x20")]
	public List<int> m_ParentMenuIndex;
}
