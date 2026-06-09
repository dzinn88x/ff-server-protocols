using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000496 RID: 1174
	[Token(Token = "0x2000496")]
	[ProtoContract]
	public class GroupInviteReq
	{
		// Token: 0x06001D30 RID: 7472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x24A3840", Offset = "0x24A3840", VA = "0x7BBCCA3840")]
		public GroupInviteReq()
		{
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0000C738 File Offset: 0x0000A938
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155494", Offset = "0x1155494")]
		public ulong invitee_id
		{
			[Token(Token = "0x6001D31")]
			[Address(RVA = "0x24A38A4", Offset = "0x24A38A4", VA = "0x7BBCCA38A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B44", Offset = "0x1135B44")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D32")]
			[Address(RVA = "0x24A38AC", Offset = "0x24A38AC", VA = "0x7BBCCA38AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B54", Offset = "0x1135B54")]
			set
			{
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11554A8", Offset = "0x11554A8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11554A8", Offset = "0x11554A8")]
		public string invitee_region
		{
			[Token(Token = "0x6001D33")]
			[Address(RVA = "0x24A38B4", Offset = "0x24A38B4", VA = "0x7BBCCA38B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B64", Offset = "0x1135B64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D34")]
			[Address(RVA = "0x24A389C", Offset = "0x24A389C", VA = "0x7BBCCA389C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B74", Offset = "0x1135B74")]
			set
			{
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0000C750 File Offset: 0x0000A950
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11554F8", Offset = "0x11554F8")]
		public EGroup.InviteChannelType channel_type
		{
			[Token(Token = "0x6001D35")]
			[Address(RVA = "0x24A38BC", Offset = "0x24A38BC", VA = "0x7BBCCA38BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B84", Offset = "0x1135B84")]
			get
			{
				return EGroup.InviteChannelType.InviteChannelType_PLAYER;
			}
			[Token(Token = "0x6001D36")]
			[Address(RVA = "0x24A38C4", Offset = "0x24A38C4", VA = "0x7BBCCA38C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135B94", Offset = "0x1135B94")]
			set
			{
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x0000C768 File Offset: 0x0000A968
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115550C", Offset = "0x115550C")]
		public EGroup.InviteeType invitee_type
		{
			[Token(Token = "0x6001D37")]
			[Address(RVA = "0x24A38CC", Offset = "0x24A38CC", VA = "0x7BBCCA38CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135BA4", Offset = "0x1135BA4")]
			get
			{
				return EGroup.InviteeType.InviteeType_NONE;
			}
			[Token(Token = "0x6001D38")]
			[Address(RVA = "0x24A38D4", Offset = "0x24A38D4", VA = "0x7BBCCA38D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135BB4", Offset = "0x1135BB4")]
			set
			{
			}
		}

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102364", Offset = "0x1102364")]
		private ulong <invitee_id>k__BackingField;

		// Token: 0x040015E1 RID: 5601
		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102374", Offset = "0x1102374")]
		private string <invitee_region>k__BackingField;

		// Token: 0x040015E2 RID: 5602
		[Token(Token = "0x40015E2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102384", Offset = "0x1102384")]
		private EGroup.InviteChannelType <channel_type>k__BackingField;

		// Token: 0x040015E3 RID: 5603
		[Token(Token = "0x40015E3")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102394", Offset = "0x1102394")]
		private EGroup.InviteeType <invitee_type>k__BackingField;
	}
}
