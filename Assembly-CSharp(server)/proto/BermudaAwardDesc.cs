using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B23 RID: 2851
	[Token(Token = "0x2000B23")]
	[ProtoContract]
	public class BermudaAwardDesc
	{
		// Token: 0x0600282B RID: 10283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282B")]
		[Address(RVA = "0x21AF744", Offset = "0x21AF744", VA = "0x7BBC9AF744")]
		public BermudaAwardDesc()
		{
		}

		// Token: 0x04003611 RID: 13841
		[Token(Token = "0x4003611")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C09C", Offset = "0x112C09C")]
		public uint group_id;

		// Token: 0x04003612 RID: 13842
		[Token(Token = "0x4003612")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C0B0", Offset = "0x112C0B0")]
		public uint id;

		// Token: 0x04003613 RID: 13843
		[Token(Token = "0x4003613")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C0C4", Offset = "0x112C0C4")]
		public AwardDesc award_items;

		// Token: 0x04003614 RID: 13844
		[Token(Token = "0x4003614")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C0D8", Offset = "0x112C0D8")]
		public uint progress;
	}
}
