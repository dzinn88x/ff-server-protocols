using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200083E RID: 2110
	[Token(Token = "0x200083E")]
	[ProtoContract]
	public class SepcialFriendsAppsRes
	{
		// Token: 0x06002553 RID: 9555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x24A0584", Offset = "0x24A0584", VA = "0x7BBCCA0584")]
		public SepcialFriendsAppsRes()
		{
		}

		// Token: 0x0400276E RID: 10094
		[Token(Token = "0x400276E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11115A8", Offset = "0x11115A8")]
		public ulong applicant_id;

		// Token: 0x0400276F RID: 10095
		[Token(Token = "0x400276F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11115BC", Offset = "0x11115BC")]
		public long request_time;

		// Token: 0x04002770 RID: 10096
		[Token(Token = "0x4002770")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11115D0", Offset = "0x11115D0")]
		public uint relation_type;

		// Token: 0x04002771 RID: 10097
		[Token(Token = "0x4002771")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11115E4", Offset = "0x11115E4")]
		public bool is_create;
	}
}
