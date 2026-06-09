using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000814 RID: 2068
	[Token(Token = "0x2000814")]
	[ProtoContract]
	public class CSUpgradeProfileRes
	{
		// Token: 0x06002523 RID: 9507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002523")]
		[Address(RVA = "0x21B7CA0", Offset = "0x21B7CA0", VA = "0x7BBC9B7CA0")]
		public CSUpgradeProfileRes()
		{
		}

		// Token: 0x04002712 RID: 10002
		[Token(Token = "0x4002712")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110D10", Offset = "0x1110D10")]
		public List<AvatarProfile> affected_profiles;

		// Token: 0x04002713 RID: 10003
		[Token(Token = "0x4002713")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110D24", Offset = "0x1110D24")]
		public List<Item> award_items;
	}
}
