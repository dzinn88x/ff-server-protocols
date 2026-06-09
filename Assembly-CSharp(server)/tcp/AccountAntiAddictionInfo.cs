using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000549 RID: 1353
	[Token(Token = "0x2000549")]
	[ProtoContract]
	public class AccountAntiAddictionInfo
	{
		// Token: 0x060021F2 RID: 8690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F2")]
		[Address(RVA = "0x24A1C8C", Offset = "0x24A1C8C", VA = "0x7BBCCA1C8C")]
		public AccountAntiAddictionInfo()
		{
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0000EC28 File Offset: 0x0000CE28
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159210", Offset = "0x1159210")]
		public uint ban_mode
		{
			[Token(Token = "0x60021F3")]
			[Address(RVA = "0x24A1C94", Offset = "0x24A1C94", VA = "0x7BBCCA1C94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139EE4", Offset = "0x1139EE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021F4")]
			[Address(RVA = "0x24A1C9C", Offset = "0x24A1C9C", VA = "0x7BBCCA1C9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139EF4", Offset = "0x1139EF4")]
			set
			{
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0000EC40 File Offset: 0x0000CE40
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159224", Offset = "0x1159224")]
		public uint unban_time
		{
			[Token(Token = "0x60021F5")]
			[Address(RVA = "0x24A1CA4", Offset = "0x24A1CA4", VA = "0x7BBCCA1CA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F04", Offset = "0x1139F04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021F6")]
			[Address(RVA = "0x24A1CAC", Offset = "0x24A1CAC", VA = "0x7BBCCA1CAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F14", Offset = "0x1139F14")]
			set
			{
			}
		}

		// Token: 0x0400195D RID: 6493
		[Token(Token = "0x400195D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104534", Offset = "0x1104534")]
		private uint <ban_mode>k__BackingField;

		// Token: 0x0400195E RID: 6494
		[Token(Token = "0x400195E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104544", Offset = "0x1104544")]
		private uint <unban_time>k__BackingField;
	}
}
