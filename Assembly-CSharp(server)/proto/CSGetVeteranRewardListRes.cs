using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B4 RID: 1972
	[Token(Token = "0x20007B4")]
	[ProtoContract]
	public class CSGetVeteranRewardListRes
	{
		// Token: 0x060024C3 RID: 9411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C3")]
		[Address(RVA = "0x21B6114", Offset = "0x21B6114", VA = "0x7BBC9B6114")]
		public CSGetVeteranRewardListRes()
		{
		}

		// Token: 0x040025E4 RID: 9700
		[Token(Token = "0x40025E4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EA24", Offset = "0x110EA24")]
		public bool is_veteran;

		// Token: 0x040025E5 RID: 9701
		[Token(Token = "0x40025E5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EA38", Offset = "0x110EA38")]
		public List<VeteranRewardItem> rewards;
	}
}
