using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000625 RID: 1573
	[Token(Token = "0x2000625")]
	[ProtoContract]
	public class ClanIDReq
	{
		// Token: 0x06002396 RID: 9110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002396")]
		[Address(RVA = "0x21B8638", Offset = "0x21B8638", VA = "0x7BBC9B8638")]
		public ClanIDReq()
		{
		}

		// Token: 0x04001F57 RID: 8023
		[Token(Token = "0x4001F57")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107CB0", Offset = "0x1107CB0")]
		public ulong clan_id;

		// Token: 0x04001F58 RID: 8024
		[Token(Token = "0x4001F58")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107CC4", Offset = "0x1107CC4")]
		public ulong account_id;

		// Token: 0x04001F59 RID: 8025
		[Token(Token = "0x4001F59")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107CD8", Offset = "0x1107CD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107CD8", Offset = "0x1107CD8")]
		public string lock_region;

		// Token: 0x04001F5A RID: 8026
		[Token(Token = "0x4001F5A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107D28", Offset = "0x1107D28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107D28", Offset = "0x1107D28")]
		public string noti_region;
	}
}
