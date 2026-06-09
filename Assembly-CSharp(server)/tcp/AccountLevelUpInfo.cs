using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	[ProtoContract]
	public class AccountLevelUpInfo
	{
		// Token: 0x06001BF4 RID: 7156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x24A1DA0", Offset = "0x24A1DA0", VA = "0x7BBCCA1DA0")]
		public AccountLevelUpInfo()
		{
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000337")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11544E0", Offset = "0x11544E0")]
		public ulong account_id
		{
			[Token(Token = "0x6001BF5")]
			[Address(RVA = "0x24A1DA8", Offset = "0x24A1DA8", VA = "0x7BBCCA1DA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134AC4", Offset = "0x1134AC4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001BF6")]
			[Address(RVA = "0x24A1DB0", Offset = "0x24A1DB0", VA = "0x7BBCCA1DB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134AD4", Offset = "0x1134AD4")]
			set
			{
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000338")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11544F4", Offset = "0x11544F4")]
		public uint level_before
		{
			[Token(Token = "0x6001BF7")]
			[Address(RVA = "0x24A1DB8", Offset = "0x24A1DB8", VA = "0x7BBCCA1DB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134AE4", Offset = "0x1134AE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001BF8")]
			[Address(RVA = "0x24A1DC0", Offset = "0x24A1DC0", VA = "0x7BBCCA1DC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134AF4", Offset = "0x1134AF4")]
			set
			{
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x0000BE08 File Offset: 0x0000A008
		// (set) Token: 0x06001BFA RID: 7162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000339")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154508", Offset = "0x1154508")]
		public uint level_after
		{
			[Token(Token = "0x6001BF9")]
			[Address(RVA = "0x24A1DC8", Offset = "0x24A1DC8", VA = "0x7BBCCA1DC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B04", Offset = "0x1134B04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001BFA")]
			[Address(RVA = "0x24A1DD0", Offset = "0x24A1DD0", VA = "0x7BBCCA1DD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B14", Offset = "0x1134B14")]
			set
			{
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x0000BE20 File Offset: 0x0000A020
		// (set) Token: 0x06001BFC RID: 7164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115451C", Offset = "0x115451C")]
		public uint new_exp
		{
			[Token(Token = "0x6001BFB")]
			[Address(RVA = "0x24A1DD8", Offset = "0x24A1DD8", VA = "0x7BBCCA1DD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B24", Offset = "0x1134B24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001BFC")]
			[Address(RVA = "0x24A1DE0", Offset = "0x24A1DE0", VA = "0x7BBCCA1DE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B34", Offset = "0x1134B34")]
			set
			{
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154530", Offset = "0x1154530")]
		public AwardDataTCP awards
		{
			[Token(Token = "0x6001BFD")]
			[Address(RVA = "0x24A1DE8", Offset = "0x24A1DE8", VA = "0x7BBCCA1DE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B44", Offset = "0x1134B44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BFE")]
			[Address(RVA = "0x24A1DF0", Offset = "0x24A1DF0", VA = "0x7BBCCA1DF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134B54", Offset = "0x1134B54")]
			set
			{
			}
		}

		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x4001456")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B24", Offset = "0x1101B24")]
		private ulong <account_id>k__BackingField;

		// Token: 0x04001457 RID: 5207
		[Token(Token = "0x4001457")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B34", Offset = "0x1101B34")]
		private uint <level_before>k__BackingField;

		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x4001458")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B44", Offset = "0x1101B44")]
		private uint <level_after>k__BackingField;

		// Token: 0x04001459 RID: 5209
		[Token(Token = "0x4001459")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B54", Offset = "0x1101B54")]
		private uint <new_exp>k__BackingField;

		// Token: 0x0400145A RID: 5210
		[Token(Token = "0x400145A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B64", Offset = "0x1101B64")]
		private AwardDataTCP <awards>k__BackingField;
	}
}
