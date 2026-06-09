using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD5 RID: 2773
	[Token(Token = "0x2000AD5")]
	[ProtoContract]
	public class PaidLevelDesc
	{
		// Token: 0x060027DD RID: 10205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x249EFAC", Offset = "0x249EFAC", VA = "0x7BBCC9EFAC")]
		public PaidLevelDesc()
		{
		}

		// Token: 0x04003413 RID: 13331
		[Token(Token = "0x4003413")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127B00", Offset = "0x1127B00")]
		public uint paid_level;

		// Token: 0x04003414 RID: 13332
		[Token(Token = "0x4003414")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127B14", Offset = "0x1127B14")]
		public uint min_paid;

		// Token: 0x04003415 RID: 13333
		[Token(Token = "0x4003415")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127B28", Offset = "0x1127B28")]
		public uint max_paid;

		// Token: 0x04003416 RID: 13334
		[Token(Token = "0x4003416")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127B3C", Offset = "0x1127B3C")]
		public uint no_topup_days;
	}
}
