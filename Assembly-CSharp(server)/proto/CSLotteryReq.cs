using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200085C RID: 2140
	[Token(Token = "0x200085C")]
	[ProtoContract]
	public class CSLotteryReq
	{
		// Token: 0x0600256A RID: 9578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256A")]
		[Address(RVA = "0x21B6814", Offset = "0x21B6814", VA = "0x7BBC9B6814")]
		public CSLotteryReq()
		{
		}

		// Token: 0x040027FF RID: 10239
		[Token(Token = "0x40027FF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112494", Offset = "0x1112494")]
		public uint chest_id;

		// Token: 0x04002800 RID: 10240
		[Token(Token = "0x4002800")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11124A8", Offset = "0x11124A8")]
		public uint gacha_type;

		// Token: 0x04002801 RID: 10241
		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11124BC", Offset = "0x11124BC")]
		public uint chest_sub_id;

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11124D0", Offset = "0x11124D0")]
		public ELottery.ConsumeType consume_type;

		// Token: 0x04002803 RID: 10243
		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11124E4", Offset = "0x11124E4")]
		public uint finite_jackpot;

		// Token: 0x04002804 RID: 10244
		[Token(Token = "0x4002804")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11124F8", Offset = "0x11124F8")]
		public uint finite_lottery_count;

		// Token: 0x04002805 RID: 10245
		[Token(Token = "0x4002805")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111250C", Offset = "0x111250C")]
		public uint show_type;
	}
}
