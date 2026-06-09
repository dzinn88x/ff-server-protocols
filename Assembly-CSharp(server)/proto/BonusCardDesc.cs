using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D9 RID: 2521
	[Token(Token = "0x20009D9")]
	[ProtoContract]
	public class BonusCardDesc
	{
		// Token: 0x060026E3 RID: 9955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x21AFB88", Offset = "0x21AFB88", VA = "0x7BBC9AFB88")]
		public BonusCardDesc()
		{
		}

		// Token: 0x04002D8D RID: 11661
		[Token(Token = "0x4002D8D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B760", Offset = "0x111B760")]
		public uint id;

		// Token: 0x04002D8E RID: 11662
		[Token(Token = "0x4002D8E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B774", Offset = "0x111B774")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111B774", Offset = "0x111B774")]
		public string name;

		// Token: 0x04002D8F RID: 11663
		[Token(Token = "0x4002D8F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B7C4", Offset = "0x111B7C4")]
		public EInventory.BonusCardType card_type;

		// Token: 0x04002D90 RID: 11664
		[Token(Token = "0x4002D90")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B7D8", Offset = "0x111B7D8")]
		public uint gold_factor;

		// Token: 0x04002D91 RID: 11665
		[Token(Token = "0x4002D91")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B7EC", Offset = "0x111B7EC")]
		public uint exp_factor;

		// Token: 0x04002D92 RID: 11666
		[Token(Token = "0x4002D92")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B800", Offset = "0x111B800")]
		public uint ep_debris_factor;
	}
}
