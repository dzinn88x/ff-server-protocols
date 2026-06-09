using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x2000499")]
	[ProtoContract]
	public class GroupAcceptJoinReq
	{
		// Token: 0x06001D6D RID: 7533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x24A30A0", Offset = "0x24A30A0", VA = "0x7BBCCA30A0")]
		public GroupAcceptJoinReq()
		{
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155890", Offset = "0x1155890")]
		public ulong group_id
		{
			[Token(Token = "0x6001D6E")]
			[Address(RVA = "0x24A313C", Offset = "0x24A313C", VA = "0x7BBCCA313C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135EE4", Offset = "0x1135EE4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D6F")]
			[Address(RVA = "0x24A3144", Offset = "0x24A3144", VA = "0x7BBCCA3144")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135EF4", Offset = "0x1135EF4")]
			set
			{
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x0000C900 File Offset: 0x0000AB00
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11558A4", Offset = "0x11558A4")]
		public ulong joiner_account_id
		{
			[Token(Token = "0x6001D70")]
			[Address(RVA = "0x24A314C", Offset = "0x24A314C", VA = "0x7BBCCA314C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F04", Offset = "0x1135F04")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D71")]
			[Address(RVA = "0x24A3154", Offset = "0x24A3154", VA = "0x7BBCCA3154")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F14", Offset = "0x1135F14")]
			set
			{
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11558B8", Offset = "0x11558B8")]
		public uint[] joiner_available_maps
		{
			[Token(Token = "0x6001D72")]
			[Address(RVA = "0x24A315C", Offset = "0x24A315C", VA = "0x7BBCCA315C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F24", Offset = "0x1135F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D73")]
			[Address(RVA = "0x24A3164", Offset = "0x24A3164", VA = "0x7BBCCA3164")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F34", Offset = "0x1135F34")]
			set
			{
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0000C918 File Offset: 0x0000AB18
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11558F4", Offset = "0x11558F4")]
		public uint joiner_emulator_score
		{
			[Token(Token = "0x6001D74")]
			[Address(RVA = "0x24A316C", Offset = "0x24A316C", VA = "0x7BBCCA316C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F44", Offset = "0x1135F44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D75")]
			[Address(RVA = "0x24A3174", Offset = "0x24A3174", VA = "0x7BBCCA3174")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F54", Offset = "0x1135F54")]
			set
			{
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155908", Offset = "0x1155908")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155908", Offset = "0x1155908")]
		public string joiner_country_code
		{
			[Token(Token = "0x6001D76")]
			[Address(RVA = "0x24A317C", Offset = "0x24A317C", VA = "0x7BBCCA317C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F64", Offset = "0x1135F64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D77")]
			[Address(RVA = "0x24A3124", Offset = "0x24A3124", VA = "0x7BBCCA3124")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F74", Offset = "0x1135F74")]
			set
			{
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DD")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155958", Offset = "0x1155958")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155958", Offset = "0x1155958")]
		public string joiner_signature_md5
		{
			[Token(Token = "0x6001D78")]
			[Address(RVA = "0x24A3184", Offset = "0x24A3184", VA = "0x7BBCCA3184")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F84", Offset = "0x1135F84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D79")]
			[Address(RVA = "0x24A312C", Offset = "0x24A312C", VA = "0x7BBCCA312C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135F94", Offset = "0x1135F94")]
			set
			{
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0000C930 File Offset: 0x0000AB30
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11559A8", Offset = "0x11559A8")]
		public uint joiner_using_version
		{
			[Token(Token = "0x6001D7A")]
			[Address(RVA = "0x24A318C", Offset = "0x24A318C", VA = "0x7BBCCA318C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135FA4", Offset = "0x1135FA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D7B")]
			[Address(RVA = "0x24A3194", Offset = "0x24A3194", VA = "0x7BBCCA3194")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135FB4", Offset = "0x1135FB4")]
			set
			{
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x0000C948 File Offset: 0x0000AB48
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11559BC", Offset = "0x11559BC")]
		public EGroup.InviteeType invitee_type
		{
			[Token(Token = "0x6001D7C")]
			[Address(RVA = "0x24A319C", Offset = "0x24A319C", VA = "0x7BBCCA319C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135FC4", Offset = "0x1135FC4")]
			get
			{
				return EGroup.InviteeType.InviteeType_NONE;
			}
			[Token(Token = "0x6001D7D")]
			[Address(RVA = "0x24A31A4", Offset = "0x24A31A4", VA = "0x7BBCCA31A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135FD4", Offset = "0x1135FD4")]
			set
			{
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x0000C960 File Offset: 0x0000AB60
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11559D0", Offset = "0x11559D0")]
		public uint joiner_system_platform
		{
			[Token(Token = "0x6001D7E")]
			[Address(RVA = "0x24A31AC", Offset = "0x24A31AC", VA = "0x7BBCCA31AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135FE4", Offset = "0x1135FE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D7F")]
			[Address(RVA = "0x24A31B4", Offset = "0x24A31B4", VA = "0x7BBCCA31B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135FF4", Offset = "0x1135FF4")]
			set
			{
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11559E4", Offset = "0x11559E4")]
		public MatchClientInfo joiner_client_info
		{
			[Token(Token = "0x6001D80")]
			[Address(RVA = "0x24A31BC", Offset = "0x24A31BC", VA = "0x7BBCCA31BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136004", Offset = "0x1136004")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D81")]
			[Address(RVA = "0x24A31C4", Offset = "0x24A31C4", VA = "0x7BBCCA31C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136014", Offset = "0x1136014")]
			set
			{
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11559F8", Offset = "0x11559F8")]
		public List<AccountIDCPingInfo> joiner_ping_list
		{
			[Token(Token = "0x6001D82")]
			[Address(RVA = "0x24A31CC", Offset = "0x24A31CC", VA = "0x7BBCCA31CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136024", Offset = "0x1136024")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D83")]
			[Address(RVA = "0x24A3134", Offset = "0x24A3134", VA = "0x7BBCCA3134")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136034", Offset = "0x1136034")]
			private set
			{
			}
		}

		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102534", Offset = "0x1102534")]
		private ulong <group_id>k__BackingField;

		// Token: 0x040015FE RID: 5630
		[Token(Token = "0x40015FE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102544", Offset = "0x1102544")]
		private ulong <joiner_account_id>k__BackingField;

		// Token: 0x040015FF RID: 5631
		[Token(Token = "0x40015FF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102554", Offset = "0x1102554")]
		private uint[] <joiner_available_maps>k__BackingField;

		// Token: 0x04001600 RID: 5632
		[Token(Token = "0x4001600")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102564", Offset = "0x1102564")]
		private uint <joiner_emulator_score>k__BackingField;

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102574", Offset = "0x1102574")]
		private string <joiner_country_code>k__BackingField;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102584", Offset = "0x1102584")]
		private string <joiner_signature_md5>k__BackingField;

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102594", Offset = "0x1102594")]
		private uint <joiner_using_version>k__BackingField;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11025A4", Offset = "0x11025A4")]
		private EGroup.InviteeType <invitee_type>k__BackingField;

		// Token: 0x04001605 RID: 5637
		[Token(Token = "0x4001605")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11025B4", Offset = "0x11025B4")]
		private uint <joiner_system_platform>k__BackingField;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11025C4", Offset = "0x11025C4")]
		private MatchClientInfo <joiner_client_info>k__BackingField;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11025D4", Offset = "0x11025D4")]
		private List<AccountIDCPingInfo> <joiner_ping_list>k__BackingField;
	}
}
