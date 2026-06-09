using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000495")]
	[ProtoContract]
	public class GroupCreateReq
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x24A342C", Offset = "0x24A342C", VA = "0x7BBCCA342C")]
		public GroupCreateReq()
		{
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11552C8", Offset = "0x11552C8")]
		public uint[] map_ids
		{
			[Token(Token = "0x6001D16")]
			[Address(RVA = "0x24A34D8", Offset = "0x24A34D8", VA = "0x7BBCCA34D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11359A4", Offset = "0x11359A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D17")]
			[Address(RVA = "0x24A34E0", Offset = "0x24A34E0", VA = "0x7BBCCA34E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11359B4", Offset = "0x11359B4")]
			set
			{
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x0000C690 File Offset: 0x0000A890
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155304", Offset = "0x1155304")]
		public uint game_mode
		{
			[Token(Token = "0x6001D18")]
			[Address(RVA = "0x24A34E8", Offset = "0x24A34E8", VA = "0x7BBCCA34E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11359C4", Offset = "0x11359C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D19")]
			[Address(RVA = "0x24A34F0", Offset = "0x24A34F0", VA = "0x7BBCCA34F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11359D4", Offset = "0x11359D4")]
			set
			{
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155318", Offset = "0x1155318")]
		public uint group_mode
		{
			[Token(Token = "0x6001D1A")]
			[Address(RVA = "0x24A34F8", Offset = "0x24A34F8", VA = "0x7BBCCA34F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11359E4", Offset = "0x11359E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D1B")]
			[Address(RVA = "0x24A3500", Offset = "0x24A3500", VA = "0x7BBCCA3500")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11359F4", Offset = "0x11359F4")]
			set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115532C", Offset = "0x115532C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x115532C", Offset = "0x115532C")]
		public string language
		{
			[Token(Token = "0x6001D1C")]
			[Address(RVA = "0x24A3508", Offset = "0x24A3508", VA = "0x7BBCCA3508")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A04", Offset = "0x1135A04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D1D")]
			[Address(RVA = "0x24A34C0", Offset = "0x24A34C0", VA = "0x7BBCCA34C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A14", Offset = "0x1135A14")]
			set
			{
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115537C", Offset = "0x115537C")]
		public uint difficulty
		{
			[Token(Token = "0x6001D1E")]
			[Address(RVA = "0x24A3510", Offset = "0x24A3510", VA = "0x7BBCCA3510")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A24", Offset = "0x1135A24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D1F")]
			[Address(RVA = "0x24A3518", Offset = "0x24A3518", VA = "0x7BBCCA3518")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A34", Offset = "0x1135A34")]
			set
			{
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155390", Offset = "0x1155390")]
		public List<AccountIDCPingInfo> ping_list
		{
			[Token(Token = "0x6001D20")]
			[Address(RVA = "0x24A3520", Offset = "0x24A3520", VA = "0x7BBCCA3520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A44", Offset = "0x1135A44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D21")]
			[Address(RVA = "0x24A34C8", Offset = "0x24A34C8", VA = "0x7BBCCA34C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A54", Offset = "0x1135A54")]
			private set
			{
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11553A4", Offset = "0x11553A4")]
		public uint match_mode
		{
			[Token(Token = "0x6001D22")]
			[Address(RVA = "0x24A3528", Offset = "0x24A3528", VA = "0x7BBCCA3528")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A64", Offset = "0x1135A64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D23")]
			[Address(RVA = "0x24A3530", Offset = "0x24A3530", VA = "0x7BBCCA3530")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A74", Offset = "0x1135A74")]
			set
			{
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11553B8", Offset = "0x11553B8")]
		public uint[] available_maps
		{
			[Token(Token = "0x6001D24")]
			[Address(RVA = "0x24A3538", Offset = "0x24A3538", VA = "0x7BBCCA3538")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A84", Offset = "0x1135A84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D25")]
			[Address(RVA = "0x24A3540", Offset = "0x24A3540", VA = "0x7BBCCA3540")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135A94", Offset = "0x1135A94")]
			set
			{
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11553F4", Offset = "0x11553F4")]
		public EGroup.CreateFromType from_type
		{
			[Token(Token = "0x6001D26")]
			[Address(RVA = "0x24A3548", Offset = "0x24A3548", VA = "0x7BBCCA3548")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135AA4", Offset = "0x1135AA4")]
			get
			{
				return EGroup.CreateFromType.CreateFromType_NONE;
			}
			[Token(Token = "0x6001D27")]
			[Address(RVA = "0x24A3550", Offset = "0x24A3550", VA = "0x7BBCCA3550")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135AB4", Offset = "0x1135AB4")]
			set
			{
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0000C708 File Offset: 0x0000A908
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155408", Offset = "0x1155408")]
		public uint system_platform
		{
			[Token(Token = "0x6001D28")]
			[Address(RVA = "0x24A3558", Offset = "0x24A3558", VA = "0x7BBCCA3558")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135AC4", Offset = "0x1135AC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D29")]
			[Address(RVA = "0x24A3560", Offset = "0x24A3560", VA = "0x7BBCCA3560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135AD4", Offset = "0x1135AD4")]
			set
			{
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115541C", Offset = "0x115541C")]
		public MatchClientInfo client_info
		{
			[Token(Token = "0x6001D2A")]
			[Address(RVA = "0x24A3568", Offset = "0x24A3568", VA = "0x7BBCCA3568")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135AE4", Offset = "0x1135AE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D2B")]
			[Address(RVA = "0x24A3570", Offset = "0x24A3570", VA = "0x7BBCCA3570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135AF4", Offset = "0x1135AF4")]
			set
			{
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0000C720 File Offset: 0x0000A920
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155430", Offset = "0x1155430")]
		public uint required_rank
		{
			[Token(Token = "0x6001D2C")]
			[Address(RVA = "0x24A3578", Offset = "0x24A3578", VA = "0x7BBCCA3578")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B04", Offset = "0x1135B04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D2D")]
			[Address(RVA = "0x24A3580", Offset = "0x24A3580", VA = "0x7BBCCA3580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B14", Offset = "0x1135B14")]
			set
			{
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155444", Offset = "0x1155444")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155444", Offset = "0x1155444")]
		public string group_tag
		{
			[Token(Token = "0x6001D2E")]
			[Address(RVA = "0x24A3588", Offset = "0x24A3588", VA = "0x7BBCCA3588")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B24", Offset = "0x1135B24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D2F")]
			[Address(RVA = "0x24A34D0", Offset = "0x24A34D0", VA = "0x7BBCCA34D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B34", Offset = "0x1135B34")]
			set
			{
			}
		}

		// Token: 0x040015D3 RID: 5587
		[Token(Token = "0x40015D3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102294", Offset = "0x1102294")]
		private uint[] <map_ids>k__BackingField;

		// Token: 0x040015D4 RID: 5588
		[Token(Token = "0x40015D4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11022A4", Offset = "0x11022A4")]
		private uint <game_mode>k__BackingField;

		// Token: 0x040015D5 RID: 5589
		[Token(Token = "0x40015D5")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11022B4", Offset = "0x11022B4")]
		private uint <group_mode>k__BackingField;

		// Token: 0x040015D6 RID: 5590
		[Token(Token = "0x40015D6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11022C4", Offset = "0x11022C4")]
		private string <language>k__BackingField;

		// Token: 0x040015D7 RID: 5591
		[Token(Token = "0x40015D7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11022D4", Offset = "0x11022D4")]
		private uint <difficulty>k__BackingField;

		// Token: 0x040015D8 RID: 5592
		[Token(Token = "0x40015D8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11022E4", Offset = "0x11022E4")]
		private List<AccountIDCPingInfo> <ping_list>k__BackingField;

		// Token: 0x040015D9 RID: 5593
		[Token(Token = "0x40015D9")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11022F4", Offset = "0x11022F4")]
		private uint <match_mode>k__BackingField;

		// Token: 0x040015DA RID: 5594
		[Token(Token = "0x40015DA")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102304", Offset = "0x1102304")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x040015DB RID: 5595
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102314", Offset = "0x1102314")]
		private EGroup.CreateFromType <from_type>k__BackingField;

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102324", Offset = "0x1102324")]
		private uint <system_platform>k__BackingField;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102334", Offset = "0x1102334")]
		private MatchClientInfo <client_info>k__BackingField;

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102344", Offset = "0x1102344")]
		private uint <required_rank>k__BackingField;

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102354", Offset = "0x1102354")]
		private string <group_tag>k__BackingField;
	}
}
