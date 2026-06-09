using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000488 RID: 1160
	[Token(Token = "0x2000488")]
	[ProtoContract]
	public class IntimacyChangeNtf
	{
		// Token: 0x06001D0D RID: 7437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x24A414C", Offset = "0x24A414C", VA = "0x7BBCCA414C")]
		public IntimacyChangeNtf()
		{
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x0000C648 File Offset: 0x0000A848
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115528C", Offset = "0x115528C")]
		public ulong related_friend_id
		{
			[Token(Token = "0x6001D0E")]
			[Address(RVA = "0x24A4154", Offset = "0x24A4154", VA = "0x7BBCCA4154")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135944", Offset = "0x1135944")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D0F")]
			[Address(RVA = "0x24A415C", Offset = "0x24A415C", VA = "0x7BBCCA415C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135954", Offset = "0x1135954")]
			set
			{
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x0000C660 File Offset: 0x0000A860
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11552A0", Offset = "0x11552A0")]
		public uint relation_type
		{
			[Token(Token = "0x6001D10")]
			[Address(RVA = "0x24A4164", Offset = "0x24A4164", VA = "0x7BBCCA4164")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135964", Offset = "0x1135964")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D11")]
			[Address(RVA = "0x24A416C", Offset = "0x24A416C", VA = "0x7BBCCA416C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135974", Offset = "0x1135974")]
			set
			{
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x0000C678 File Offset: 0x0000A878
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11552B4", Offset = "0x11552B4")]
		public uint add_value
		{
			[Token(Token = "0x6001D12")]
			[Address(RVA = "0x24A4174", Offset = "0x24A4174", VA = "0x7BBCCA4174")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135984", Offset = "0x1135984")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D13")]
			[Address(RVA = "0x24A417C", Offset = "0x24A417C", VA = "0x7BBCCA417C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135994", Offset = "0x1135994")]
			set
			{
			}
		}

		// Token: 0x0400153F RID: 5439
		[Token(Token = "0x400153F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102264", Offset = "0x1102264")]
		private ulong <related_friend_id>k__BackingField;

		// Token: 0x04001540 RID: 5440
		[Token(Token = "0x4001540")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102274", Offset = "0x1102274")]
		private uint <relation_type>k__BackingField;

		// Token: 0x04001541 RID: 5441
		[Token(Token = "0x4001541")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102284", Offset = "0x1102284")]
		private uint <add_value>k__BackingField;
	}
}
