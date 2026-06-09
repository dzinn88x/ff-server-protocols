using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000628 RID: 1576
	[Token(Token = "0x2000628")]
	[ProtoContract]
	public class ClanInfoBasic
	{
		// Token: 0x06002399 RID: 9113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002399")]
		[Address(RVA = "0x21B8704", Offset = "0x21B8704", VA = "0x7BBC9B8704")]
		public ClanInfoBasic()
		{
		}

		// Token: 0x04001F5F RID: 8031
		[Token(Token = "0x4001F5F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107E68", Offset = "0x1107E68")]
		public ulong clan_id;

		// Token: 0x04001F60 RID: 8032
		[Token(Token = "0x4001F60")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107E7C", Offset = "0x1107E7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107E7C", Offset = "0x1107E7C")]
		public string clan_name;

		// Token: 0x04001F61 RID: 8033
		[Token(Token = "0x4001F61")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107ECC", Offset = "0x1107ECC")]
		public ulong captain_id;

		// Token: 0x04001F62 RID: 8034
		[Token(Token = "0x4001F62")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107EE0", Offset = "0x1107EE0")]
		public uint clan_level;

		// Token: 0x04001F63 RID: 8035
		[Token(Token = "0x4001F63")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107EF4", Offset = "0x1107EF4")]
		public uint capacity;

		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107F08", Offset = "0x1107F08")]
		public uint member_num;

		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107F1C", Offset = "0x1107F1C")]
		public uint honor_point;
	}
}
