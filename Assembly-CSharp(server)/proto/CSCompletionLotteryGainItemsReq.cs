using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000875 RID: 2165
	[Token(Token = "0x2000875")]
	[ProtoContract]
	public class CSCompletionLotteryGainItemsReq
	{
		// Token: 0x06002583 RID: 9603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x21B0C0C", Offset = "0x21B0C0C", VA = "0x7BBC9B0C0C")]
		public CSCompletionLotteryGainItemsReq()
		{
		}

		// Token: 0x04002892 RID: 10386
		[Token(Token = "0x4002892")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11133D0", Offset = "0x11133D0")]
		public uint lottery_id;

		// Token: 0x04002893 RID: 10387
		[Token(Token = "0x4002893")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11133E4", Offset = "0x11133E4")]
		public uint lottery_sub_id;

		// Token: 0x04002894 RID: 10388
		[Token(Token = "0x4002894")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11133F8", Offset = "0x11133F8")]
		public uint[] id_list;
	}
}
