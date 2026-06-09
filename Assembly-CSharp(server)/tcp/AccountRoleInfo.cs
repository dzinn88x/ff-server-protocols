using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200043F RID: 1087
	[Token(Token = "0x200043F")]
	[ProtoContract]
	public class AccountRoleInfo
	{
		// Token: 0x06001BFF RID: 7167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x24A22A0", Offset = "0x24A22A0", VA = "0x7BBCCA22A0")]
		public AccountRoleInfo()
		{
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x0000BE38 File Offset: 0x0000A038
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154544", Offset = "0x1154544")]
		public ulong account_id
		{
			[Token(Token = "0x6001C00")]
			[Address(RVA = "0x24A22A8", Offset = "0x24A22A8", VA = "0x7BBCCA22A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B64", Offset = "0x1134B64")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C01")]
			[Address(RVA = "0x24A22B0", Offset = "0x24A22B0", VA = "0x7BBCCA22B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B74", Offset = "0x1134B74")]
			set
			{
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0000BE50 File Offset: 0x0000A050
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154558", Offset = "0x1154558")]
		public uint role
		{
			[Token(Token = "0x6001C02")]
			[Address(RVA = "0x24A22B8", Offset = "0x24A22B8", VA = "0x7BBCCA22B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B84", Offset = "0x1134B84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C03")]
			[Address(RVA = "0x24A22C0", Offset = "0x24A22C0", VA = "0x7BBCCA22C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B94", Offset = "0x1134B94")]
			set
			{
			}
		}

		// Token: 0x0400145B RID: 5211
		[Token(Token = "0x400145B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B74", Offset = "0x1101B74")]
		private ulong <account_id>k__BackingField;

		// Token: 0x0400145C RID: 5212
		[Token(Token = "0x400145C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B84", Offset = "0x1101B84")]
		private uint <role>k__BackingField;
	}
}
