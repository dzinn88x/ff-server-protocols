using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	[ProtoContract]
	public class IntimacyRelation
	{
		// Token: 0x06002335 RID: 9013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x24A4184", Offset = "0x24A4184", VA = "0x7BBCCA4184")]
		public IntimacyRelation()
		{
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x0000F570 File Offset: 0x0000D770
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000674")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A32C", Offset = "0x115A32C")]
		public ulong related_friend_id
		{
			[Token(Token = "0x6002336")]
			[Address(RVA = "0x24A418C", Offset = "0x24A418C", VA = "0x7BBCCA418C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B264", Offset = "0x113B264")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002337")]
			[Address(RVA = "0x24A4194", Offset = "0x24A4194", VA = "0x7BBCCA4194")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B274", Offset = "0x113B274")]
			set
			{
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x0000F588 File Offset: 0x0000D788
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000675")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A340", Offset = "0x115A340")]
		public uint relation_type
		{
			[Token(Token = "0x6002338")]
			[Address(RVA = "0x24A419C", Offset = "0x24A419C", VA = "0x7BBCCA419C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B284", Offset = "0x113B284")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002339")]
			[Address(RVA = "0x24A41A4", Offset = "0x24A41A4", VA = "0x7BBCCA41A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B294", Offset = "0x113B294")]
			set
			{
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000676")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A354", Offset = "0x115A354")]
		public uint intimacy
		{
			[Token(Token = "0x600233A")]
			[Address(RVA = "0x24A41AC", Offset = "0x24A41AC", VA = "0x7BBCCA41AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B2A4", Offset = "0x113B2A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600233B")]
			[Address(RVA = "0x24A41B4", Offset = "0x24A41B4", VA = "0x7BBCCA41B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B2B4", Offset = "0x113B2B4")]
			set
			{
			}
		}

		// Token: 0x040019FD RID: 6653
		[Token(Token = "0x40019FD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104EF4", Offset = "0x1104EF4")]
		private ulong <related_friend_id>k__BackingField;

		// Token: 0x040019FE RID: 6654
		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104F04", Offset = "0x1104F04")]
		private uint <relation_type>k__BackingField;

		// Token: 0x040019FF RID: 6655
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104F14", Offset = "0x1104F14")]
		private uint <intimacy>k__BackingField;
	}
}
