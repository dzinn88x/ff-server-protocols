using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000769 RID: 1897
	[Token(Token = "0x2000769")]
	[ProtoContract]
	public class CSGetSelectedItemsRes
	{
		// Token: 0x06002476 RID: 9334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002476")]
		[Address(RVA = "0x21B5AA8", Offset = "0x21B5AA8", VA = "0x7BBC9B5AA8")]
		public CSGetSelectedItemsRes()
		{
		}

		// Token: 0x04002524 RID: 9508
		[Token(Token = "0x4002524")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D7B4", Offset = "0x110D7B4")]
		public SelectedItems items;
	}
}
