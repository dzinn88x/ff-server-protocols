using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000542 RID: 1346
	[Token(Token = "0x2000542")]
	[ProtoContract]
	public class TrainingTokenInfo
	{
		// Token: 0x060021C1 RID: 8641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x24A72FC", Offset = "0x24A72FC", VA = "0x7BBCCA72FC")]
		public TrainingTokenInfo()
		{
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x0000EA78 File Offset: 0x0000CC78
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159008", Offset = "0x1159008")]
		public uint token_id
		{
			[Token(Token = "0x60021C2")]
			[Address(RVA = "0x24A7304", Offset = "0x24A7304", VA = "0x7BBCCA7304")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C44", Offset = "0x1139C44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021C3")]
			[Address(RVA = "0x24A730C", Offset = "0x24A730C", VA = "0x7BBCCA730C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C54", Offset = "0x1139C54")]
			set
			{
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x0000EA90 File Offset: 0x0000CC90
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115901C", Offset = "0x115901C")]
		public uint daily_gained_cnt
		{
			[Token(Token = "0x60021C4")]
			[Address(RVA = "0x24A7314", Offset = "0x24A7314", VA = "0x7BBCCA7314")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C64", Offset = "0x1139C64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021C5")]
			[Address(RVA = "0x24A731C", Offset = "0x24A731C", VA = "0x7BBCCA731C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C74", Offset = "0x1139C74")]
			set
			{
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		// (set) Token: 0x060021C7 RID: 8647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159030", Offset = "0x1159030")]
		public uint token_cnt
		{
			[Token(Token = "0x60021C6")]
			[Address(RVA = "0x24A7324", Offset = "0x24A7324", VA = "0x7BBCCA7324")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C84", Offset = "0x1139C84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021C7")]
			[Address(RVA = "0x24A732C", Offset = "0x24A732C", VA = "0x7BBCCA732C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C94", Offset = "0x1139C94")]
			set
			{
			}
		}

		// Token: 0x04001948 RID: 6472
		[Token(Token = "0x4001948")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11043E4", Offset = "0x11043E4")]
		private uint <token_id>k__BackingField;

		// Token: 0x04001949 RID: 6473
		[Token(Token = "0x4001949")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11043F4", Offset = "0x11043F4")]
		private uint <daily_gained_cnt>k__BackingField;

		// Token: 0x0400194A RID: 6474
		[Token(Token = "0x400194A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104404", Offset = "0x1104404")]
		private uint <token_cnt>k__BackingField;
	}
}
