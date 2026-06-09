using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000550 RID: 1360
	[Token(Token = "0x2000550")]
	[ProtoContract]
	public class ChampionshipInfo
	{
		// Token: 0x06002305 RID: 8965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002305")]
		[Address(RVA = "0x24A28D4", Offset = "0x24A28D4", VA = "0x7BBCCA28D4")]
		public ChampionshipInfo()
		{
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x0000F408 File Offset: 0x0000D608
		// (set) Token: 0x06002307 RID: 8967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A098", Offset = "0x115A098")]
		public ulong team_id
		{
			[Token(Token = "0x6002306")]
			[Address(RVA = "0x24A2938", Offset = "0x24A2938", VA = "0x7BBCCA2938")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AFA4", Offset = "0x113AFA4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002307")]
			[Address(RVA = "0x24A2940", Offset = "0x24A2940", VA = "0x7BBCCA2940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AFB4", Offset = "0x113AFB4")]
			set
			{
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002309 RID: 8969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065F")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x115A0AC", Offset = "0x115A0AC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A0AC", Offset = "0x115A0AC")]
		public string country_or_area
		{
			[Token(Token = "0x6002308")]
			[Address(RVA = "0x24A2948", Offset = "0x24A2948", VA = "0x7BBCCA2948")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AFC4", Offset = "0x113AFC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002309")]
			[Address(RVA = "0x24A2930", Offset = "0x24A2930", VA = "0x7BBCCA2930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AFD4", Offset = "0x113AFD4")]
			set
			{
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600230B RID: 8971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000660")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A0FC", Offset = "0x115A0FC")]
		public ulong[] member_ids
		{
			[Token(Token = "0x600230A")]
			[Address(RVA = "0x24A2950", Offset = "0x24A2950", VA = "0x7BBCCA2950")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AFE4", Offset = "0x113AFE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600230B")]
			[Address(RVA = "0x24A2958", Offset = "0x24A2958", VA = "0x7BBCCA2958")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113AFF4", Offset = "0x113AFF4")]
			set
			{
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x0000F420 File Offset: 0x0000D620
		// (set) Token: 0x0600230D RID: 8973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000661")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A138", Offset = "0x115A138")]
		public uint limited_level
		{
			[Token(Token = "0x600230C")]
			[Address(RVA = "0x24A2960", Offset = "0x24A2960", VA = "0x7BBCCA2960")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B004", Offset = "0x113B004")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600230D")]
			[Address(RVA = "0x24A2968", Offset = "0x24A2968", VA = "0x7BBCCA2968")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B014", Offset = "0x113B014")]
			set
			{
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x0000F438 File Offset: 0x0000D638
		// (set) Token: 0x0600230F RID: 8975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000662")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A14C", Offset = "0x115A14C")]
		public uint limited_ranking_point
		{
			[Token(Token = "0x600230E")]
			[Address(RVA = "0x24A2970", Offset = "0x24A2970", VA = "0x7BBCCA2970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B024", Offset = "0x113B024")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600230F")]
			[Address(RVA = "0x24A2978", Offset = "0x24A2978", VA = "0x7BBCCA2978")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B034", Offset = "0x113B034")]
			set
			{
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x0000F450 File Offset: 0x0000D650
		// (set) Token: 0x06002311 RID: 8977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000663")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A160", Offset = "0x115A160")]
		public bool is_qualified
		{
			[Token(Token = "0x6002310")]
			[Address(RVA = "0x24A2980", Offset = "0x24A2980", VA = "0x7BBCCA2980")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B044", Offset = "0x113B044")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002311")]
			[Address(RVA = "0x24A2988", Offset = "0x24A2988", VA = "0x7BBCCA2988")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B054", Offset = "0x113B054")]
			set
			{
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x0000F468 File Offset: 0x0000D668
		// (set) Token: 0x06002313 RID: 8979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000664")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A174", Offset = "0x115A174")]
		public uint upper_limited_level
		{
			[Token(Token = "0x6002312")]
			[Address(RVA = "0x24A2994", Offset = "0x24A2994", VA = "0x7BBCCA2994")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B064", Offset = "0x113B064")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002313")]
			[Address(RVA = "0x24A299C", Offset = "0x24A299C", VA = "0x7BBCCA299C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B074", Offset = "0x113B074")]
			set
			{
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x0000F480 File Offset: 0x0000D680
		// (set) Token: 0x06002315 RID: 8981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000665")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115A188", Offset = "0x115A188")]
		public uint upper_limited_ranking_point
		{
			[Token(Token = "0x6002314")]
			[Address(RVA = "0x24A29A4", Offset = "0x24A29A4", VA = "0x7BBCCA29A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B084", Offset = "0x113B084")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002315")]
			[Address(RVA = "0x24A29AC", Offset = "0x24A29AC", VA = "0x7BBCCA29AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B094", Offset = "0x113B094")]
			set
			{
			}
		}

		// Token: 0x040019E3 RID: 6627
		[Token(Token = "0x40019E3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104D94", Offset = "0x1104D94")]
		private ulong <team_id>k__BackingField;

		// Token: 0x040019E4 RID: 6628
		[Token(Token = "0x40019E4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104DA4", Offset = "0x1104DA4")]
		private string <country_or_area>k__BackingField;

		// Token: 0x040019E5 RID: 6629
		[Token(Token = "0x40019E5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104DB4", Offset = "0x1104DB4")]
		private ulong[] <member_ids>k__BackingField;

		// Token: 0x040019E6 RID: 6630
		[Token(Token = "0x40019E6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104DC4", Offset = "0x1104DC4")]
		private uint <limited_level>k__BackingField;

		// Token: 0x040019E7 RID: 6631
		[Token(Token = "0x40019E7")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104DD4", Offset = "0x1104DD4")]
		private uint <limited_ranking_point>k__BackingField;

		// Token: 0x040019E8 RID: 6632
		[Token(Token = "0x40019E8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104DE4", Offset = "0x1104DE4")]
		private bool <is_qualified>k__BackingField;

		// Token: 0x040019E9 RID: 6633
		[Token(Token = "0x40019E9")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104DF4", Offset = "0x1104DF4")]
		private uint <upper_limited_level>k__BackingField;

		// Token: 0x040019EA RID: 6634
		[Token(Token = "0x40019EA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104E04", Offset = "0x1104E04")]
		private uint <upper_limited_ranking_point>k__BackingField;
	}
}
