using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F8 RID: 2040
	[Token(Token = "0x20007F8")]
	[ProtoContract]
	public class ClanLuckyBag
	{
		// Token: 0x06002507 RID: 9479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002507")]
		[Address(RVA = "0x21B8858", Offset = "0x21B8858", VA = "0x7BBC9B8858")]
		public ClanLuckyBag()
		{
		}

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110720", Offset = "0x1110720")]
		public ulong clan_id;

		// Token: 0x040026CD RID: 9933
		[Token(Token = "0x40026CD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110734", Offset = "0x1110734")]
		public ulong bag_id;

		// Token: 0x040026CE RID: 9934
		[Token(Token = "0x40026CE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110748", Offset = "0x1110748")]
		public ulong creater_id;

		// Token: 0x040026CF RID: 9935
		[Token(Token = "0x40026CF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111075C", Offset = "0x111075C")]
		public ulong created_at;

		// Token: 0x040026D0 RID: 9936
		[Token(Token = "0x40026D0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110770", Offset = "0x1110770")]
		public uint total_num;

		// Token: 0x040026D1 RID: 9937
		[Token(Token = "0x40026D1")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110784", Offset = "0x1110784")]
		public uint taken_num;

		// Token: 0x040026D2 RID: 9938
		[Token(Token = "0x40026D2")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110798", Offset = "0x1110798")]
		public uint reason;
	}
}
