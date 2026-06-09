using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200097A RID: 2426
	[Token(Token = "0x200097A")]
	[ProtoContract]
	public class BermudaRewardInfo
	{
		// Token: 0x06002688 RID: 9864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x21AF7AC", Offset = "0x21AF7AC", VA = "0x7BBC9AF7AC")]
		public BermudaRewardInfo()
		{
		}

		// Token: 0x04002C1B RID: 11291
		[Token(Token = "0x4002C1B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119A00", Offset = "0x1119A00")]
		public uint group_id;

		// Token: 0x04002C1C RID: 11292
		[Token(Token = "0x4002C1C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119A14", Offset = "0x1119A14")]
		public uint id;
	}
}
