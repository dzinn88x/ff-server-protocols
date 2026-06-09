using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200053F RID: 1343
	[Token(Token = "0x200053F")]
	[ProtoContract]
	public class RedEnvelopeInfo
	{
		// Token: 0x060021AC RID: 8620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x24A5AAC", Offset = "0x24A5AAC", VA = "0x7BBCCA5AAC")]
		public RedEnvelopeInfo()
		{
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158F54", Offset = "0x1158F54")]
		public uint id
		{
			[Token(Token = "0x60021AD")]
			[Address(RVA = "0x24A5AB4", Offset = "0x24A5AB4", VA = "0x7BBCCA5AB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B24", Offset = "0x1139B24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021AE")]
			[Address(RVA = "0x24A5ABC", Offset = "0x24A5ABC", VA = "0x7BBCCA5ABC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B34", Offset = "0x1139B34")]
			set
			{
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158F68", Offset = "0x1158F68")]
		public uint cnt
		{
			[Token(Token = "0x60021AF")]
			[Address(RVA = "0x24A5AC4", Offset = "0x24A5AC4", VA = "0x7BBCCA5AC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B44", Offset = "0x1139B44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021B0")]
			[Address(RVA = "0x24A5ACC", Offset = "0x24A5ACC", VA = "0x7BBCCA5ACC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B54", Offset = "0x1139B54")]
			set
			{
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158F7C", Offset = "0x1158F7C")]
		public uint expire_time
		{
			[Token(Token = "0x60021B1")]
			[Address(RVA = "0x24A5AD4", Offset = "0x24A5AD4", VA = "0x7BBCCA5AD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B64", Offset = "0x1139B64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021B2")]
			[Address(RVA = "0x24A5ADC", Offset = "0x24A5ADC", VA = "0x7BBCCA5ADC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B74", Offset = "0x1139B74")]
			set
			{
			}
		}

		// Token: 0x0400193F RID: 6463
		[Token(Token = "0x400193F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104354", Offset = "0x1104354")]
		private uint <id>k__BackingField;

		// Token: 0x04001940 RID: 6464
		[Token(Token = "0x4001940")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104364", Offset = "0x1104364")]
		private uint <cnt>k__BackingField;

		// Token: 0x04001941 RID: 6465
		[Token(Token = "0x4001941")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104374", Offset = "0x1104374")]
		private uint <expire_time>k__BackingField;
	}
}
