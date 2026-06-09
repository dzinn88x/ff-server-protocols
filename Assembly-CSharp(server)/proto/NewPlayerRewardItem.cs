using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007BC RID: 1980
	[Token(Token = "0x20007BC")]
	[ProtoContract]
	public class NewPlayerRewardItem
	{
		// Token: 0x060024CB RID: 9419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x249EAA4", Offset = "0x249EAA4", VA = "0x7BBCC9EAA4")]
		public NewPlayerRewardItem()
		{
		}

		// Token: 0x040025FA RID: 9722
		[Token(Token = "0x40025FA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ED80", Offset = "0x110ED80")]
		public uint id;

		// Token: 0x040025FB RID: 9723
		[Token(Token = "0x40025FB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ED94", Offset = "0x110ED94")]
		public uint signed;

		// Token: 0x040025FC RID: 9724
		[Token(Token = "0x40025FC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EDA8", Offset = "0x110EDA8")]
		public List<AwardDesc> awards;
	}
}
