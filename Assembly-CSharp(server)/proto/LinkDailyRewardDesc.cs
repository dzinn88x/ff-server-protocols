using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B01 RID: 2817
	[Token(Token = "0x2000B01")]
	[ProtoContract]
	public class LinkDailyRewardDesc
	{
		// Token: 0x06002809 RID: 10249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x21BBB70", Offset = "0x21BBB70", VA = "0x7BBC9BBB70")]
		public LinkDailyRewardDesc()
		{
		}

		// Token: 0x0400351F RID: 13599
		[Token(Token = "0x400351F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129F04", Offset = "0x1129F04")]
		public uint id;

		// Token: 0x04003520 RID: 13600
		[Token(Token = "0x4003520")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129F18", Offset = "0x1129F18")]
		public uint activity_id;

		// Token: 0x04003521 RID: 13601
		[Token(Token = "0x4003521")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129F2C", Offset = "0x1129F2C")]
		public uint activity_type;

		// Token: 0x04003522 RID: 13602
		[Token(Token = "0x4003522")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129F40", Offset = "0x1129F40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129F40", Offset = "0x1129F40")]
		public string start_time;

		// Token: 0x04003523 RID: 13603
		[Token(Token = "0x4003523")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129F90", Offset = "0x1129F90")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129F90", Offset = "0x1129F90")]
		public string end_time;

		// Token: 0x04003524 RID: 13604
		[Token(Token = "0x4003524")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129FE0", Offset = "0x1129FE0")]
		public uint[] award_ids;
	}
}
