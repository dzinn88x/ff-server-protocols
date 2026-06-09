using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C8 RID: 2248
	[Token(Token = "0x20008C8")]
	[ProtoContract]
	public class CSGetInstallmentItemsRes
	{
		// Token: 0x060025D6 RID: 9686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D6")]
		[Address(RVA = "0x21B4254", Offset = "0x21B4254", VA = "0x7BBC9B4254")]
		public CSGetInstallmentItemsRes()
		{
		}

		// Token: 0x04002A33 RID: 10803
		[Token(Token = "0x4002A33")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111692C", Offset = "0x111692C")]
		public List<Item> items;
	}
}
