using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200085E RID: 2142
	[Token(Token = "0x200085E")]
	[ProtoContract]
	public class CSLotteryExtraRewardReq
	{
		// Token: 0x0600256C RID: 9580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256C")]
		[Address(RVA = "0x21B680C", Offset = "0x21B680C", VA = "0x7BBC9B680C")]
		public CSLotteryExtraRewardReq()
		{
		}

		// Token: 0x04002815 RID: 10261
		[Token(Token = "0x4002815")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112674", Offset = "0x1112674")]
		public uint chest_id;

		// Token: 0x04002816 RID: 10262
		[Token(Token = "0x4002816")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112688", Offset = "0x1112688")]
		public uint condition_num;

		// Token: 0x04002817 RID: 10263
		[Token(Token = "0x4002817")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111269C", Offset = "0x111269C")]
		public uint chest_sub_id;
	}
}
