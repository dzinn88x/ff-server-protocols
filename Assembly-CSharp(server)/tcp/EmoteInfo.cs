using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x200053E")]
	[ProtoContract]
	public class EmoteInfo
	{
		// Token: 0x060021A7 RID: 8615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x24A2DD0", Offset = "0x24A2DD0", VA = "0x7BBCCA2DD0")]
		public EmoteInfo()
		{
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x0000E970 File Offset: 0x0000CB70
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158F2C", Offset = "0x1158F2C")]
		public uint slot_id
		{
			[Token(Token = "0x60021A8")]
			[Address(RVA = "0x24A2DD8", Offset = "0x24A2DD8", VA = "0x7BBCCA2DD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139AE4", Offset = "0x1139AE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021A9")]
			[Address(RVA = "0x24A2DE0", Offset = "0x24A2DE0", VA = "0x7BBCCA2DE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139AF4", Offset = "0x1139AF4")]
			set
			{
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x0000E988 File Offset: 0x0000CB88
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158F40", Offset = "0x1158F40")]
		public uint emote_id
		{
			[Token(Token = "0x60021AA")]
			[Address(RVA = "0x24A2DE8", Offset = "0x24A2DE8", VA = "0x7BBCCA2DE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B04", Offset = "0x1139B04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021AB")]
			[Address(RVA = "0x24A2DF0", Offset = "0x24A2DF0", VA = "0x7BBCCA2DF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B14", Offset = "0x1139B14")]
			set
			{
			}
		}

		// Token: 0x0400193D RID: 6461
		[Token(Token = "0x400193D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104334", Offset = "0x1104334")]
		private uint <slot_id>k__BackingField;

		// Token: 0x0400193E RID: 6462
		[Token(Token = "0x400193E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104344", Offset = "0x1104344")]
		private uint <emote_id>k__BackingField;
	}
}
