using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007ED RID: 2029
	[Token(Token = "0x20007ED")]
	[ProtoContract]
	public class CSClanSignInRes
	{
		// Token: 0x060024FC RID: 9468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FC")]
		[Address(RVA = "0x21B0B98", Offset = "0x21B0B98", VA = "0x7BBC9B0B98")]
		public CSClanSignInRes()
		{
		}

		// Token: 0x04002696 RID: 9878
		[Token(Token = "0x4002696")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110108", Offset = "0x1110108")]
		public List<ClanSignInRewardItem> rewards;

		// Token: 0x04002697 RID: 9879
		[Token(Token = "0x4002697")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111011C", Offset = "0x111011C")]
		public bool is_newcomer;
	}
}
