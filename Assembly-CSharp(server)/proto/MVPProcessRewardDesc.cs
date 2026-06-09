using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B43 RID: 2883
	[Token(Token = "0x2000B43")]
	[ProtoContract]
	public class MVPProcessRewardDesc
	{
		// Token: 0x0600284B RID: 10315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284B")]
		[Address(RVA = "0x21BC0E8", Offset = "0x21BC0E8", VA = "0x7BBC9BC0E8")]
		public MVPProcessRewardDesc()
		{
		}

		// Token: 0x040036BD RID: 14013
		[Token(Token = "0x40036BD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D4D8", Offset = "0x112D4D8")]
		public uint id;

		// Token: 0x040036BE RID: 14014
		[Token(Token = "0x40036BE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D4EC", Offset = "0x112D4EC")]
		public uint progress;

		// Token: 0x040036BF RID: 14015
		[Token(Token = "0x40036BF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D500", Offset = "0x112D500")]
		public List<AwardDesc> award_items;
	}
}
