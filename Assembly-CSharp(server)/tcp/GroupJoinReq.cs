using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x2000498")]
	[ProtoContract]
	public class GroupJoinReq
	{
		// Token: 0x06001D48 RID: 7496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x24A38DC", Offset = "0x24A38DC", VA = "0x7BBCCA38DC")]
		public GroupJoinReq()
		{
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		// (set) Token: 0x06001D4A RID: 7498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155610", Offset = "0x1155610")]
		public ulong participant_id
		{
			[Token(Token = "0x6001D49")]
			[Address(RVA = "0x24A3990", Offset = "0x24A3990", VA = "0x7BBCCA3990")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135CA4", Offset = "0x1135CA4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D4A")]
			[Address(RVA = "0x24A3998", Offset = "0x24A3998", VA = "0x7BBCCA3998")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135CB4", Offset = "0x1135CB4")]
			set
			{
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C7")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155624", Offset = "0x1155624")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155624", Offset = "0x1155624")]
		public string self_region
		{
			[Token(Token = "0x6001D4B")]
			[Address(RVA = "0x24A39A0", Offset = "0x24A39A0", VA = "0x7BBCCA39A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135CC4", Offset = "0x1135CC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D4C")]
			[Address(RVA = "0x24A3968", Offset = "0x24A3968", VA = "0x7BBCCA3968")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135CD4", Offset = "0x1135CD4")]
			set
			{
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155674", Offset = "0x1155674")]
		public EGroup.JoinFromType from_type
		{
			[Token(Token = "0x6001D4D")]
			[Address(RVA = "0x24A39A8", Offset = "0x24A39A8", VA = "0x7BBCCA39A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135CE4", Offset = "0x1135CE4")]
			get
			{
				return EGroup.JoinFromType.JoinFromType_NONE;
			}
			[Token(Token = "0x6001D4E")]
			[Address(RVA = "0x24A39B0", Offset = "0x24A39B0", VA = "0x7BBCCA39B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135CF4", Offset = "0x1135CF4")]
			set
			{
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x0000C810 File Offset: 0x0000AA10
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155688", Offset = "0x1155688")]
		public EGroup.InviteeType target_type
		{
			[Token(Token = "0x6001D4F")]
			[Address(RVA = "0x24A39B8", Offset = "0x24A39B8", VA = "0x7BBCCA39B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D04", Offset = "0x1135D04")]
			get
			{
				return EGroup.InviteeType.InviteeType_NONE;
			}
			[Token(Token = "0x6001D50")]
			[Address(RVA = "0x24A39C0", Offset = "0x24A39C0", VA = "0x7BBCCA39C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D14", Offset = "0x1135D14")]
			set
			{
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115569C", Offset = "0x115569C")]
		public uint[] available_maps
		{
			[Token(Token = "0x6001D51")]
			[Address(RVA = "0x24A39C8", Offset = "0x24A39C8", VA = "0x7BBCCA39C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D24", Offset = "0x1135D24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D52")]
			[Address(RVA = "0x24A39D0", Offset = "0x24A39D0", VA = "0x7BBCCA39D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D34", Offset = "0x1135D34")]
			set
			{
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CB")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11556D8", Offset = "0x11556D8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11556D8", Offset = "0x11556D8")]
		public string nickname
		{
			[Token(Token = "0x6001D53")]
			[Address(RVA = "0x24A39D8", Offset = "0x24A39D8", VA = "0x7BBCCA39D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D44", Offset = "0x1135D44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D54")]
			[Address(RVA = "0x24A3970", Offset = "0x24A3970", VA = "0x7BBCCA3970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D54", Offset = "0x1135D54")]
			set
			{
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0000C828 File Offset: 0x0000AA28
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155728", Offset = "0x1155728")]
		public uint rank
		{
			[Token(Token = "0x6001D55")]
			[Address(RVA = "0x24A39E0", Offset = "0x24A39E0", VA = "0x7BBCCA39E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D64", Offset = "0x1135D64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D56")]
			[Address(RVA = "0x24A39E8", Offset = "0x24A39E8", VA = "0x7BBCCA39E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D74", Offset = "0x1135D74")]
			set
			{
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x0000C840 File Offset: 0x0000AA40
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115573C", Offset = "0x115573C")]
		public uint ranking_points
		{
			[Token(Token = "0x6001D57")]
			[Address(RVA = "0x24A39F0", Offset = "0x24A39F0", VA = "0x7BBCCA39F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D84", Offset = "0x1135D84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D58")]
			[Address(RVA = "0x24A39F8", Offset = "0x24A39F8", VA = "0x7BBCCA39F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135D94", Offset = "0x1135D94")]
			set
			{
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0000C858 File Offset: 0x0000AA58
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155750", Offset = "0x1155750")]
		public uint emulator_score
		{
			[Token(Token = "0x6001D59")]
			[Address(RVA = "0x24A3A00", Offset = "0x24A3A00", VA = "0x7BBCCA3A00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135DA4", Offset = "0x1135DA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D5A")]
			[Address(RVA = "0x24A3A08", Offset = "0x24A3A08", VA = "0x7BBCCA3A08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135DB4", Offset = "0x1135DB4")]
			set
			{
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CF")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155764", Offset = "0x1155764")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155764", Offset = "0x1155764")]
		public string country_code
		{
			[Token(Token = "0x6001D5B")]
			[Address(RVA = "0x24A3A10", Offset = "0x24A3A10", VA = "0x7BBCCA3A10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135DC4", Offset = "0x1135DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D5C")]
			[Address(RVA = "0x24A3978", Offset = "0x24A3978", VA = "0x7BBCCA3978")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135DD4", Offset = "0x1135DD4")]
			set
			{
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11557B4", Offset = "0x11557B4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11557B4", Offset = "0x11557B4")]
		public string signature_md5
		{
			[Token(Token = "0x6001D5D")]
			[Address(RVA = "0x24A3A18", Offset = "0x24A3A18", VA = "0x7BBCCA3A18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135DE4", Offset = "0x1135DE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D5E")]
			[Address(RVA = "0x24A3980", Offset = "0x24A3980", VA = "0x7BBCCA3980")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135DF4", Offset = "0x1135DF4")]
			set
			{
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x0000C870 File Offset: 0x0000AA70
		// (set) Token: 0x06001D60 RID: 7520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155804", Offset = "0x1155804")]
		public uint using_version
		{
			[Token(Token = "0x6001D5F")]
			[Address(RVA = "0x24A3A20", Offset = "0x24A3A20", VA = "0x7BBCCA3A20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E04", Offset = "0x1135E04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D60")]
			[Address(RVA = "0x24A3A28", Offset = "0x24A3A28", VA = "0x7BBCCA3A28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E14", Offset = "0x1135E14")]
			set
			{
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x0000C888 File Offset: 0x0000AA88
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155818", Offset = "0x1155818")]
		public ulong partic_group_id
		{
			[Token(Token = "0x6001D61")]
			[Address(RVA = "0x24A3A30", Offset = "0x24A3A30", VA = "0x7BBCCA3A30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E24", Offset = "0x1135E24")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D62")]
			[Address(RVA = "0x24A3A38", Offset = "0x24A3A38", VA = "0x7BBCCA3A38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E34", Offset = "0x1135E34")]
			set
			{
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115582C", Offset = "0x115582C")]
		public uint system_platform
		{
			[Token(Token = "0x6001D63")]
			[Address(RVA = "0x24A3A40", Offset = "0x24A3A40", VA = "0x7BBCCA3A40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E44", Offset = "0x1135E44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D64")]
			[Address(RVA = "0x24A3A48", Offset = "0x24A3A48", VA = "0x7BBCCA3A48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E54", Offset = "0x1135E54")]
			set
			{
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155840", Offset = "0x1155840")]
		public MatchClientInfo client_info
		{
			[Token(Token = "0x6001D65")]
			[Address(RVA = "0x24A3A50", Offset = "0x24A3A50", VA = "0x7BBCCA3A50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E64", Offset = "0x1135E64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D66")]
			[Address(RVA = "0x24A3A58", Offset = "0x24A3A58", VA = "0x7BBCCA3A58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E74", Offset = "0x1135E74")]
			set
			{
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155854", Offset = "0x1155854")]
		public uint cs_rank
		{
			[Token(Token = "0x6001D67")]
			[Address(RVA = "0x24A3A60", Offset = "0x24A3A60", VA = "0x7BBCCA3A60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E84", Offset = "0x1135E84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D68")]
			[Address(RVA = "0x24A3A68", Offset = "0x24A3A68", VA = "0x7BBCCA3A68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135E94", Offset = "0x1135E94")]
			set
			{
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155868", Offset = "0x1155868")]
		public uint cs_ranking_points
		{
			[Token(Token = "0x6001D69")]
			[Address(RVA = "0x24A3A70", Offset = "0x24A3A70", VA = "0x7BBCCA3A70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135EA4", Offset = "0x1135EA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D6A")]
			[Address(RVA = "0x24A3A78", Offset = "0x24A3A78", VA = "0x7BBCCA3A78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135EB4", Offset = "0x1135EB4")]
			set
			{
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115587C", Offset = "0x115587C")]
		public List<AccountIDCPingInfo> ping_list
		{
			[Token(Token = "0x6001D6B")]
			[Address(RVA = "0x24A3A80", Offset = "0x24A3A80", VA = "0x7BBCCA3A80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135EC4", Offset = "0x1135EC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D6C")]
			[Address(RVA = "0x24A3988", Offset = "0x24A3988", VA = "0x7BBCCA3988")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135ED4", Offset = "0x1135ED4")]
			private set
			{
			}
		}

		// Token: 0x040015EB RID: 5611
		[Token(Token = "0x40015EB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102414", Offset = "0x1102414")]
		private ulong <participant_id>k__BackingField;

		// Token: 0x040015EC RID: 5612
		[Token(Token = "0x40015EC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102424", Offset = "0x1102424")]
		private string <self_region>k__BackingField;

		// Token: 0x040015ED RID: 5613
		[Token(Token = "0x40015ED")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102434", Offset = "0x1102434")]
		private EGroup.JoinFromType <from_type>k__BackingField;

		// Token: 0x040015EE RID: 5614
		[Token(Token = "0x40015EE")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102444", Offset = "0x1102444")]
		private EGroup.InviteeType <target_type>k__BackingField;

		// Token: 0x040015EF RID: 5615
		[Token(Token = "0x40015EF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102454", Offset = "0x1102454")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x040015F0 RID: 5616
		[Token(Token = "0x40015F0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102464", Offset = "0x1102464")]
		private string <nickname>k__BackingField;

		// Token: 0x040015F1 RID: 5617
		[Token(Token = "0x40015F1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102474", Offset = "0x1102474")]
		private uint <rank>k__BackingField;

		// Token: 0x040015F2 RID: 5618
		[Token(Token = "0x40015F2")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102484", Offset = "0x1102484")]
		private uint <ranking_points>k__BackingField;

		// Token: 0x040015F3 RID: 5619
		[Token(Token = "0x40015F3")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102494", Offset = "0x1102494")]
		private uint <emulator_score>k__BackingField;

		// Token: 0x040015F4 RID: 5620
		[Token(Token = "0x40015F4")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11024A4", Offset = "0x11024A4")]
		private string <country_code>k__BackingField;

		// Token: 0x040015F5 RID: 5621
		[Token(Token = "0x40015F5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11024B4", Offset = "0x11024B4")]
		private string <signature_md5>k__BackingField;

		// Token: 0x040015F6 RID: 5622
		[Token(Token = "0x40015F6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11024C4", Offset = "0x11024C4")]
		private uint <using_version>k__BackingField;

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11024D4", Offset = "0x11024D4")]
		private ulong <partic_group_id>k__BackingField;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11024E4", Offset = "0x11024E4")]
		private uint <system_platform>k__BackingField;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11024F4", Offset = "0x11024F4")]
		private MatchClientInfo <client_info>k__BackingField;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102504", Offset = "0x1102504")]
		private uint <cs_rank>k__BackingField;

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102514", Offset = "0x1102514")]
		private uint <cs_ranking_points>k__BackingField;

		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102524", Offset = "0x1102524")]
		private List<AccountIDCPingInfo> <ping_list>k__BackingField;
	}
}
