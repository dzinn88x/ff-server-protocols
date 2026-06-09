using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000874 RID: 2164
	[Token(Token = "0x2000874")]
	[ProtoContract]
	public class CSReRandomCompletionLotteryReq
	{
		// Token: 0x06002582 RID: 9602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x21B718C", Offset = "0x21B718C", VA = "0x7BBC9B718C")]
		public CSReRandomCompletionLotteryReq()
		{
		}

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111331C", Offset = "0x111331C")]
		public uint lottery_id;

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113330", Offset = "0x1113330")]
		public uint lottery_sub_id;

		// Token: 0x04002890 RID: 10384
		[Token(Token = "0x4002890")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113344", Offset = "0x1113344")]
		public uint[] id_list;

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113380", Offset = "0x1113380")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1113380", Offset = "0x1113380")]
		public string nick_name;
	}
}
