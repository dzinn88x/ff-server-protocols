using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200077D RID: 1917
	[Token(Token = "0x200077D")]
	[ProtoContract]
	public class CSGetBackpackRes
	{
		// Token: 0x0600248C RID: 9356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248C")]
		[Address(RVA = "0x21B23C8", Offset = "0x21B23C8", VA = "0x7BBC9B23C8")]
		public CSGetBackpackRes()
		{
		}

		// Token: 0x0400254E RID: 9550
		[Token(Token = "0x400254E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DBB0", Offset = "0x110DBB0")]
		public AccountWallet wallet;

		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DBC4", Offset = "0x110DBC4")]
		public SelectedItems selected_items;

		// Token: 0x04002550 RID: 9552
		[Token(Token = "0x4002550")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DBD8", Offset = "0x110DBD8")]
		public List<Item> items;
	}
}
