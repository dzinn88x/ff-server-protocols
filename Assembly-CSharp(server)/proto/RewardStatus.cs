using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200088A RID: 2186
	[Token(Token = "0x200088A")]
	[ProtoContract]
	public class RewardStatus
	{
		// Token: 0x06002598 RID: 9624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x24A0268", Offset = "0x24A0268", VA = "0x7BBCCA0268")]
		public RewardStatus()
		{
		}

		// Token: 0x040028C4 RID: 10436
		[Token(Token = "0x40028C4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113998", Offset = "0x1113998")]
		public uint unlock_id;

		// Token: 0x040028C5 RID: 10437
		[Token(Token = "0x40028C5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11139AC", Offset = "0x11139AC")]
		public EPTarget_Status status;

		// Token: 0x040028C6 RID: 10438
		[Token(Token = "0x40028C6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11139C0", Offset = "0x11139C0")]
		public uint is_ep;
	}
}
