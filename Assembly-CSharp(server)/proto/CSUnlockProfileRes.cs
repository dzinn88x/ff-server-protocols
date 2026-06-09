using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000804 RID: 2052
	[Token(Token = "0x2000804")]
	[ProtoContract]
	public class CSUnlockProfileRes
	{
		// Token: 0x06002513 RID: 9491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002513")]
		[Address(RVA = "0x21B7ABC", Offset = "0x21B7ABC", VA = "0x7BBC9B7ABC")]
		public CSUnlockProfileRes()
		{
		}

		// Token: 0x040026EC RID: 9964
		[Token(Token = "0x40026EC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11109C8", Offset = "0x11109C8")]
		public List<AvatarProfile> affected_profiles;

		// Token: 0x040026ED RID: 9965
		[Token(Token = "0x40026ED")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11109DC", Offset = "0x11109DC")]
		public List<Item> award_items;
	}
}
