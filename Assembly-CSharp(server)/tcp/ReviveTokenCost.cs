using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000544 RID: 1348
	[Token(Token = "0x2000544")]
	[ProtoContract]
	public class ReviveTokenCost
	{
		// Token: 0x060021CD RID: 8653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x24A5C4C", Offset = "0x24A5C4C", VA = "0x7BBCCA5C4C")]
		public ReviveTokenCost()
		{
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115906C", Offset = "0x115906C")]
		public uint gem_cost_self
		{
			[Token(Token = "0x60021CE")]
			[Address(RVA = "0x24A5C54", Offset = "0x24A5C54", VA = "0x7BBCCA5C54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139CE4", Offset = "0x1139CE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021CF")]
			[Address(RVA = "0x24A5C5C", Offset = "0x24A5C5C", VA = "0x7BBCCA5C5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139CF4", Offset = "0x1139CF4")]
			set
			{
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0000EB08 File Offset: 0x0000CD08
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159080", Offset = "0x1159080")]
		public uint gem_cost_teammate
		{
			[Token(Token = "0x60021D0")]
			[Address(RVA = "0x24A5C64", Offset = "0x24A5C64", VA = "0x7BBCCA5C64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139D04", Offset = "0x1139D04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021D1")]
			[Address(RVA = "0x24A5C6C", Offset = "0x24A5C6C", VA = "0x7BBCCA5C6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139D14", Offset = "0x1139D14")]
			set
			{
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x0000EB20 File Offset: 0x0000CD20
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159094", Offset = "0x1159094")]
		public uint gem_cost_wiped
		{
			[Token(Token = "0x60021D2")]
			[Address(RVA = "0x24A5C74", Offset = "0x24A5C74", VA = "0x7BBCCA5C74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139D24", Offset = "0x1139D24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021D3")]
			[Address(RVA = "0x24A5C7C", Offset = "0x24A5C7C", VA = "0x7BBCCA5C7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139D34", Offset = "0x1139D34")]
			set
			{
			}
		}

		// Token: 0x0400194D RID: 6477
		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104434", Offset = "0x1104434")]
		private uint <gem_cost_self>k__BackingField;

		// Token: 0x0400194E RID: 6478
		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104444", Offset = "0x1104444")]
		private uint <gem_cost_teammate>k__BackingField;

		// Token: 0x0400194F RID: 6479
		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104454", Offset = "0x1104454")]
		private uint <gem_cost_wiped>k__BackingField;
	}
}
