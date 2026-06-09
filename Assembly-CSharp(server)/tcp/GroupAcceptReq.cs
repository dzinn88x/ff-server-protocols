using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200049E RID: 1182
	[Token(Token = "0x200049E")]
	[ProtoContract]
	public class GroupAcceptReq
	{
		// Token: 0x06001DAC RID: 7596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0x24A31D4", Offset = "0x24A31D4", VA = "0x7BBCCA31D4")]
		public GroupAcceptReq()
		{
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0000CA98 File Offset: 0x0000AC98
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155C50", Offset = "0x1155C50")]
		public ulong group_id
		{
			[Token(Token = "0x6001DAD")]
			[Address(RVA = "0x24A3274", Offset = "0x24A3274", VA = "0x7BBCCA3274")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136284", Offset = "0x1136284")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DAE")]
			[Address(RVA = "0x24A327C", Offset = "0x24A327C", VA = "0x7BBCCA327C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136294", Offset = "0x1136294")]
			set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155C64", Offset = "0x1155C64")]
		public ulong inviter_account_id
		{
			[Token(Token = "0x6001DAF")]
			[Address(RVA = "0x24A3284", Offset = "0x24A3284", VA = "0x7BBCCA3284")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11362A4", Offset = "0x11362A4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DB0")]
			[Address(RVA = "0x24A328C", Offset = "0x24A328C", VA = "0x7BBCCA328C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11362B4", Offset = "0x11362B4")]
			set
			{
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155C78", Offset = "0x1155C78")]
		public uint[] available_maps
		{
			[Token(Token = "0x6001DB1")]
			[Address(RVA = "0x24A3294", Offset = "0x24A3294", VA = "0x7BBCCA3294")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11362C4", Offset = "0x11362C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB2")]
			[Address(RVA = "0x24A329C", Offset = "0x24A329C", VA = "0x7BBCCA329C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11362D4", Offset = "0x11362D4")]
			set
			{
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155CB4", Offset = "0x1155CB4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155CB4", Offset = "0x1155CB4")]
		public string group_code
		{
			[Token(Token = "0x6001DB3")]
			[Address(RVA = "0x24A32A4", Offset = "0x24A32A4", VA = "0x7BBCCA32A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11362E4", Offset = "0x11362E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB4")]
			[Address(RVA = "0x24A325C", Offset = "0x24A325C", VA = "0x7BBCCA325C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11362F4", Offset = "0x11362F4")]
			set
			{
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155D04", Offset = "0x1155D04")]
		public EGroup.InviteChannelType invite_channel_type
		{
			[Token(Token = "0x6001DB5")]
			[Address(RVA = "0x24A32AC", Offset = "0x24A32AC", VA = "0x7BBCCA32AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136304", Offset = "0x1136304")]
			get
			{
				return EGroup.InviteChannelType.InviteChannelType_PLAYER;
			}
			[Token(Token = "0x6001DB6")]
			[Address(RVA = "0x24A32B4", Offset = "0x24A32B4", VA = "0x7BBCCA32B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136314", Offset = "0x1136314")]
			set
			{
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155D18", Offset = "0x1155D18")]
		public uint system_platform
		{
			[Token(Token = "0x6001DB7")]
			[Address(RVA = "0x24A32BC", Offset = "0x24A32BC", VA = "0x7BBCCA32BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136324", Offset = "0x1136324")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001DB8")]
			[Address(RVA = "0x24A32C4", Offset = "0x24A32C4", VA = "0x7BBCCA32C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136334", Offset = "0x1136334")]
			set
			{
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155D2C", Offset = "0x1155D2C")]
		public MatchClientInfo client_info
		{
			[Token(Token = "0x6001DB9")]
			[Address(RVA = "0x24A32CC", Offset = "0x24A32CC", VA = "0x7BBCCA32CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136344", Offset = "0x1136344")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBA")]
			[Address(RVA = "0x24A32D4", Offset = "0x24A32D4", VA = "0x7BBCCA32D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136354", Offset = "0x1136354")]
			set
			{
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155D40", Offset = "0x1155D40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155D40", Offset = "0x1155D40")]
		public string secret_code
		{
			[Token(Token = "0x6001DBB")]
			[Address(RVA = "0x24A32DC", Offset = "0x24A32DC", VA = "0x7BBCCA32DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136364", Offset = "0x1136364")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBC")]
			[Address(RVA = "0x24A3264", Offset = "0x24A3264", VA = "0x7BBCCA3264")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136374", Offset = "0x1136374")]
			set
			{
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155D90", Offset = "0x1155D90")]
		public List<AccountIDCPingInfo> ping_list
		{
			[Token(Token = "0x6001DBD")]
			[Address(RVA = "0x24A32E4", Offset = "0x24A32E4", VA = "0x7BBCCA32E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136384", Offset = "0x1136384")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBE")]
			[Address(RVA = "0x24A326C", Offset = "0x24A326C", VA = "0x7BBCCA326C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136394", Offset = "0x1136394")]
			private set
			{
			}
		}

		// Token: 0x0400161A RID: 5658
		[Token(Token = "0x400161A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102704", Offset = "0x1102704")]
		private ulong <group_id>k__BackingField;

		// Token: 0x0400161B RID: 5659
		[Token(Token = "0x400161B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102714", Offset = "0x1102714")]
		private ulong <inviter_account_id>k__BackingField;

		// Token: 0x0400161C RID: 5660
		[Token(Token = "0x400161C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102724", Offset = "0x1102724")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102734", Offset = "0x1102734")]
		private string <group_code>k__BackingField;

		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102744", Offset = "0x1102744")]
		private EGroup.InviteChannelType <invite_channel_type>k__BackingField;

		// Token: 0x0400161F RID: 5663
		[Token(Token = "0x400161F")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102754", Offset = "0x1102754")]
		private uint <system_platform>k__BackingField;

		// Token: 0x04001620 RID: 5664
		[Token(Token = "0x4001620")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102764", Offset = "0x1102764")]
		private MatchClientInfo <client_info>k__BackingField;

		// Token: 0x04001621 RID: 5665
		[Token(Token = "0x4001621")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102774", Offset = "0x1102774")]
		private string <secret_code>k__BackingField;

		// Token: 0x04001622 RID: 5666
		[Token(Token = "0x4001622")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102784", Offset = "0x1102784")]
		private List<AccountIDCPingInfo> <ping_list>k__BackingField;
	}
}
