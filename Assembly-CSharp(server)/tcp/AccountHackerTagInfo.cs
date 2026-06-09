using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200054A RID: 1354
	[Token(Token = "0x200054A")]
	[ProtoContract]
	public class AccountHackerTagInfo
	{
		// Token: 0x060021F7 RID: 8695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x24A1CFC", Offset = "0x24A1CFC", VA = "0x7BBCCA1CFC")]
		public AccountHackerTagInfo()
		{
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x0000EC58 File Offset: 0x0000CE58
		// (set) Token: 0x060021F9 RID: 8697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159238", Offset = "0x1159238")]
		public uint hacker_tag
		{
			[Token(Token = "0x60021F8")]
			[Address(RVA = "0x24A1D04", Offset = "0x24A1D04", VA = "0x7BBCCA1D04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F24", Offset = "0x1139F24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021F9")]
			[Address(RVA = "0x24A1D0C", Offset = "0x24A1D0C", VA = "0x7BBCCA1D0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F34", Offset = "0x1139F34")]
			set
			{
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x0000EC70 File Offset: 0x0000CE70
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115924C", Offset = "0x115924C")]
		public long hackerpool_time
		{
			[Token(Token = "0x60021FA")]
			[Address(RVA = "0x24A1D14", Offset = "0x24A1D14", VA = "0x7BBCCA1D14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F44", Offset = "0x1139F44")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60021FB")]
			[Address(RVA = "0x24A1D1C", Offset = "0x24A1D1C", VA = "0x7BBCCA1D1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F54", Offset = "0x1139F54")]
			set
			{
			}
		}

		// Token: 0x0400195F RID: 6495
		[Token(Token = "0x400195F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104554", Offset = "0x1104554")]
		private uint <hacker_tag>k__BackingField;

		// Token: 0x04001960 RID: 6496
		[Token(Token = "0x4001960")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104564", Offset = "0x1104564")]
		private long <hackerpool_time>k__BackingField;
	}
}
