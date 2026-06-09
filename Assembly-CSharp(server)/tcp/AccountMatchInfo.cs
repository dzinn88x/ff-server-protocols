using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200054B RID: 1355
	[Token(Token = "0x200054B")]
	[ProtoContract]
	public class AccountMatchInfo
	{
		// Token: 0x060021FC RID: 8700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021FC")]
		[Address(RVA = "0x24A1DF8", Offset = "0x24A1DF8", VA = "0x7BBCCA1DF8")]
		public AccountMatchInfo()
		{
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x0000EC88 File Offset: 0x0000CE88
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159260", Offset = "0x1159260")]
		public ulong account_id
		{
			[Token(Token = "0x60021FD")]
			[Address(RVA = "0x24A1FD8", Offset = "0x24A1FD8", VA = "0x7BBCCA1FD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F64", Offset = "0x1139F64")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60021FE")]
			[Address(RVA = "0x24A1FE0", Offset = "0x24A1FE0", VA = "0x7BBCCA1FE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F74", Offset = "0x1139F74")]
			set
			{
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DD")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1159274", Offset = "0x1159274")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159274", Offset = "0x1159274")]
		public string nickname
		{
			[Token(Token = "0x60021FF")]
			[Address(RVA = "0x24A1FE8", Offset = "0x24A1FE8", VA = "0x7BBCCA1FE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F84", Offset = "0x1139F84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002200")]
			[Address(RVA = "0x24A1F80", Offset = "0x24A1F80", VA = "0x7BBCCA1F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139F94", Offset = "0x1139F94")]
			set
			{
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11592C4", Offset = "0x11592C4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11592C4", Offset = "0x11592C4")]
		public string lock_region
		{
			[Token(Token = "0x6002201")]
			[Address(RVA = "0x24A1FF0", Offset = "0x24A1FF0", VA = "0x7BBCCA1FF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139FA4", Offset = "0x1139FA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002202")]
			[Address(RVA = "0x24A1F88", Offset = "0x24A1F88", VA = "0x7BBCCA1F88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139FB4", Offset = "0x1139FB4")]
			set
			{
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159314", Offset = "0x1159314")]
		public uint level
		{
			[Token(Token = "0x6002203")]
			[Address(RVA = "0x24A1FF8", Offset = "0x24A1FF8", VA = "0x7BBCCA1FF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139FC4", Offset = "0x1139FC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002204")]
			[Address(RVA = "0x24A2000", Offset = "0x24A2000", VA = "0x7BBCCA2000")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139FD4", Offset = "0x1139FD4")]
			set
			{
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159328", Offset = "0x1159328")]
		public uint avatar_id
		{
			[Token(Token = "0x6002205")]
			[Address(RVA = "0x24A2008", Offset = "0x24A2008", VA = "0x7BBCCA2008")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139FE4", Offset = "0x1139FE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002206")]
			[Address(RVA = "0x24A2010", Offset = "0x24A2010", VA = "0x7BBCCA2010")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139FF4", Offset = "0x1139FF4")]
			set
			{
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115933C", Offset = "0x115933C")]
		public uint skin_color
		{
			[Token(Token = "0x6002207")]
			[Address(RVA = "0x24A2018", Offset = "0x24A2018", VA = "0x7BBCCA2018")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A004", Offset = "0x113A004")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002208")]
			[Address(RVA = "0x24A2020", Offset = "0x24A2020", VA = "0x7BBCCA2020")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A014", Offset = "0x113A014")]
			set
			{
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159350", Offset = "0x1159350")]
		public uint[] clothes
		{
			[Token(Token = "0x6002209")]
			[Address(RVA = "0x24A2028", Offset = "0x24A2028", VA = "0x7BBCCA2028")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A024", Offset = "0x113A024")]
			get
			{
				return null;
			}
			[Token(Token = "0x600220A")]
			[Address(RVA = "0x24A2030", Offset = "0x24A2030", VA = "0x7BBCCA2030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A034", Offset = "0x113A034")]
			set
			{
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115938C", Offset = "0x115938C")]
		public List<LoadoutInfo> loadouts
		{
			[Token(Token = "0x600220B")]
			[Address(RVA = "0x24A2038", Offset = "0x24A2038", VA = "0x7BBCCA2038")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A044", Offset = "0x113A044")]
			get
			{
				return null;
			}
			[Token(Token = "0x600220C")]
			[Address(RVA = "0x24A1F90", Offset = "0x24A1F90", VA = "0x7BBCCA1F90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A054", Offset = "0x113A054")]
			private set
			{
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11593A0", Offset = "0x11593A0")]
		public uint banner_id
		{
			[Token(Token = "0x600220D")]
			[Address(RVA = "0x24A2040", Offset = "0x24A2040", VA = "0x7BBCCA2040")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A064", Offset = "0x113A064")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600220E")]
			[Address(RVA = "0x24A2048", Offset = "0x24A2048", VA = "0x7BBCCA2048")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A074", Offset = "0x113A074")]
			set
			{
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x0000ED00 File Offset: 0x0000CF00
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11593B4", Offset = "0x11593B4")]
		public uint head_pic
		{
			[Token(Token = "0x600220F")]
			[Address(RVA = "0x24A2050", Offset = "0x24A2050", VA = "0x7BBCCA2050")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A084", Offset = "0x113A084")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002210")]
			[Address(RVA = "0x24A2058", Offset = "0x24A2058", VA = "0x7BBCCA2058")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A094", Offset = "0x113A094")]
			set
			{
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11593C8", Offset = "0x11593C8")]
		public uint[] slots
		{
			[Token(Token = "0x6002211")]
			[Address(RVA = "0x24A2060", Offset = "0x24A2060", VA = "0x7BBCCA2060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A0A4", Offset = "0x113A0A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002212")]
			[Address(RVA = "0x24A2068", Offset = "0x24A2068", VA = "0x7BBCCA2068")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A0B4", Offset = "0x113A0B4")]
			set
			{
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002214 RID: 8724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159404", Offset = "0x1159404")]
		public uint[] skills
		{
			[Token(Token = "0x6002213")]
			[Address(RVA = "0x24A2070", Offset = "0x24A2070", VA = "0x7BBCCA2070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A0C4", Offset = "0x113A0C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002214")]
			[Address(RVA = "0x24A2078", Offset = "0x24A2078", VA = "0x7BBCCA2078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A0D4", Offset = "0x113A0D4")]
			set
			{
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002216 RID: 8726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159440", Offset = "0x1159440")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1159440", Offset = "0x1159440")]
		public string clan_name
		{
			[Token(Token = "0x6002215")]
			[Address(RVA = "0x24A2080", Offset = "0x24A2080", VA = "0x7BBCCA2080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A0E4", Offset = "0x113A0E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002216")]
			[Address(RVA = "0x24A1F98", Offset = "0x24A1F98", VA = "0x7BBCCA1F98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A0F4", Offset = "0x113A0F4")]
			set
			{
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159490", Offset = "0x1159490")]
		public List<MMRInfo> mmr_info
		{
			[Token(Token = "0x6002217")]
			[Address(RVA = "0x24A2088", Offset = "0x24A2088", VA = "0x7BBCCA2088")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A104", Offset = "0x113A104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002218")]
			[Address(RVA = "0x24A1FA0", Offset = "0x24A1FA0", VA = "0x7BBCCA1FA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A114", Offset = "0x113A114")]
			private set
			{
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x0000ED18 File Offset: 0x0000CF18
		// (set) Token: 0x0600221A RID: 8730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11594A4", Offset = "0x11594A4")]
		public uint rank
		{
			[Token(Token = "0x6002219")]
			[Address(RVA = "0x24A2090", Offset = "0x24A2090", VA = "0x7BBCCA2090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A124", Offset = "0x113A124")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600221A")]
			[Address(RVA = "0x24A2098", Offset = "0x24A2098", VA = "0x7BBCCA2098")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A134", Offset = "0x113A134")]
			set
			{
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x0000ED30 File Offset: 0x0000CF30
		// (set) Token: 0x0600221C RID: 8732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11594B8", Offset = "0x11594B8")]
		public uint ranking_points
		{
			[Token(Token = "0x600221B")]
			[Address(RVA = "0x24A20A0", Offset = "0x24A20A0", VA = "0x7BBCCA20A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A144", Offset = "0x113A144")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600221C")]
			[Address(RVA = "0x24A20A8", Offset = "0x24A20A8", VA = "0x7BBCCA20A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A154", Offset = "0x113A154")]
			set
			{
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x0000ED48 File Offset: 0x0000CF48
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11594CC", Offset = "0x11594CC")]
		public uint role
		{
			[Token(Token = "0x600221D")]
			[Address(RVA = "0x24A20B0", Offset = "0x24A20B0", VA = "0x7BBCCA20B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A164", Offset = "0x113A164")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600221E")]
			[Address(RVA = "0x24A20B8", Offset = "0x24A20B8", VA = "0x7BBCCA20B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A174", Offset = "0x113A174")]
			set
			{
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x0000ED60 File Offset: 0x0000CF60
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005ED")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11594E0", Offset = "0x11594E0")]
		public bool has_elite_pass
		{
			[Token(Token = "0x600221F")]
			[Address(RVA = "0x24A20C0", Offset = "0x24A20C0", VA = "0x7BBCCA20C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A184", Offset = "0x113A184")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002220")]
			[Address(RVA = "0x24A20C8", Offset = "0x24A20C8", VA = "0x7BBCCA20C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A194", Offset = "0x113A194")]
			set
			{
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x0000ED78 File Offset: 0x0000CF78
		// (set) Token: 0x06002222 RID: 8738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11594F4", Offset = "0x11594F4")]
		public uint badge_cnt
		{
			[Token(Token = "0x6002221")]
			[Address(RVA = "0x24A20D4", Offset = "0x24A20D4", VA = "0x7BBCCA20D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A1A4", Offset = "0x113A1A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002222")]
			[Address(RVA = "0x24A20DC", Offset = "0x24A20DC", VA = "0x7BBCCA20DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A1B4", Offset = "0x113A1B4")]
			set
			{
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x0000ED90 File Offset: 0x0000CF90
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159508", Offset = "0x1159508")]
		public uint badge_id
		{
			[Token(Token = "0x6002223")]
			[Address(RVA = "0x24A20E4", Offset = "0x24A20E4", VA = "0x7BBCCA20E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A1C4", Offset = "0x113A1C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002224")]
			[Address(RVA = "0x24A20EC", Offset = "0x24A20EC", VA = "0x7BBCCA20EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A1D4", Offset = "0x113A1D4")]
			set
			{
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115951C", Offset = "0x115951C")]
		public uint ep_goldlimit_bonus
		{
			[Token(Token = "0x6002225")]
			[Address(RVA = "0x24A20F4", Offset = "0x24A20F4", VA = "0x7BBCCA20F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A1E4", Offset = "0x113A1E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002226")]
			[Address(RVA = "0x24A20FC", Offset = "0x24A20FC", VA = "0x7BBCCA20FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A1F4", Offset = "0x113A1F4")]
			set
			{
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159530", Offset = "0x1159530")]
		public List<RoomCardInfo> room_cards
		{
			[Token(Token = "0x6002227")]
			[Address(RVA = "0x24A2104", Offset = "0x24A2104", VA = "0x7BBCCA2104")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A204", Offset = "0x113A204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002228")]
			[Address(RVA = "0x24A1FA8", Offset = "0x24A1FA8", VA = "0x7BBCCA1FA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A214", Offset = "0x113A214")]
			private set
			{
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159544", Offset = "0x1159544")]
		public bool show_rank
		{
			[Token(Token = "0x6002229")]
			[Address(RVA = "0x24A210C", Offset = "0x24A210C", VA = "0x7BBCCA210C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A224", Offset = "0x113A224")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600222A")]
			[Address(RVA = "0x24A2114", Offset = "0x24A2114", VA = "0x7BBCCA2114")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A234", Offset = "0x113A234")]
			set
			{
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159558", Offset = "0x1159558")]
		public List<EmoteInfo> emotes
		{
			[Token(Token = "0x600222B")]
			[Address(RVA = "0x24A2120", Offset = "0x24A2120", VA = "0x7BBCCA2120")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A244", Offset = "0x113A244")]
			get
			{
				return null;
			}
			[Token(Token = "0x600222C")]
			[Address(RVA = "0x24A1FB0", Offset = "0x24A1FB0", VA = "0x7BBCCA1FB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A254", Offset = "0x113A254")]
			private set
			{
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115956C", Offset = "0x115956C")]
		public List<RedEnvelopeInfo> red_envelopes
		{
			[Token(Token = "0x600222D")]
			[Address(RVA = "0x24A2128", Offset = "0x24A2128", VA = "0x7BBCCA2128")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A264", Offset = "0x113A264")]
			get
			{
				return null;
			}
			[Token(Token = "0x600222E")]
			[Address(RVA = "0x24A1FB8", Offset = "0x24A1FB8", VA = "0x7BBCCA1FB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A274", Offset = "0x113A274")]
			private set
			{
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002230 RID: 8752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159580", Offset = "0x1159580")]
		public uint[] shows
		{
			[Token(Token = "0x600222F")]
			[Address(RVA = "0x24A2130", Offset = "0x24A2130", VA = "0x7BBCCA2130")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A284", Offset = "0x113A284")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002230")]
			[Address(RVA = "0x24A2138", Offset = "0x24A2138", VA = "0x7BBCCA2138")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A294", Offset = "0x113A294")]
			set
			{
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002232 RID: 8754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11595BC", Offset = "0x11595BC")]
		public PetInfo pet_info
		{
			[Token(Token = "0x6002231")]
			[Address(RVA = "0x24A2140", Offset = "0x24A2140", VA = "0x7BBCCA2140")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A2A4", Offset = "0x113A2A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002232")]
			[Address(RVA = "0x24A2148", Offset = "0x24A2148", VA = "0x7BBCCA2148")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A2B4", Offset = "0x113A2B4")]
			set
			{
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		// (set) Token: 0x06002234 RID: 8756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11595D0", Offset = "0x11595D0")]
		public uint pve_primary_weapon_skin
		{
			[Token(Token = "0x6002233")]
			[Address(RVA = "0x24A2150", Offset = "0x24A2150", VA = "0x7BBCCA2150")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A2C4", Offset = "0x113A2C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002234")]
			[Address(RVA = "0x24A2158", Offset = "0x24A2158", VA = "0x7BBCCA2158")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A2D4", Offset = "0x113A2D4")]
			set
			{
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11595E4", Offset = "0x11595E4")]
		public List<ReviveTokenInfo> revive_tokens
		{
			[Token(Token = "0x6002235")]
			[Address(RVA = "0x24A2160", Offset = "0x24A2160", VA = "0x7BBCCA2160")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A2E4", Offset = "0x113A2E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002236")]
			[Address(RVA = "0x24A1FC0", Offset = "0x24A1FC0", VA = "0x7BBCCA1FC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A2F4", Offset = "0x113A2F4")]
			private set
			{
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11595F8", Offset = "0x11595F8")]
		public WalletInfo wallet
		{
			[Token(Token = "0x6002237")]
			[Address(RVA = "0x24A2168", Offset = "0x24A2168", VA = "0x7BBCCA2168")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A304", Offset = "0x113A304")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002238")]
			[Address(RVA = "0x24A2170", Offset = "0x24A2170", VA = "0x7BBCCA2170")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A314", Offset = "0x113A314")]
			set
			{
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115960C", Offset = "0x115960C")]
		public uint platform_type
		{
			[Token(Token = "0x6002239")]
			[Address(RVA = "0x24A2178", Offset = "0x24A2178", VA = "0x7BBCCA2178")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A324", Offset = "0x113A324")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600223A")]
			[Address(RVA = "0x24A2180", Offset = "0x24A2180", VA = "0x7BBCCA2180")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A334", Offset = "0x113A334")]
			set
			{
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x0000EE08 File Offset: 0x0000D008
		// (set) Token: 0x0600223C RID: 8764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159620", Offset = "0x1159620")]
		public uint wta_free_match_num_today
		{
			[Token(Token = "0x600223B")]
			[Address(RVA = "0x24A2188", Offset = "0x24A2188", VA = "0x7BBCCA2188")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A344", Offset = "0x113A344")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600223C")]
			[Address(RVA = "0x24A2190", Offset = "0x24A2190", VA = "0x7BBCCA2190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A354", Offset = "0x113A354")]
			set
			{
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600223E RID: 8766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159634", Offset = "0x1159634")]
		public ChipInfo chips
		{
			[Token(Token = "0x600223D")]
			[Address(RVA = "0x24A2198", Offset = "0x24A2198", VA = "0x7BBCCA2198")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A364", Offset = "0x113A364")]
			get
			{
				return null;
			}
			[Token(Token = "0x600223E")]
			[Address(RVA = "0x24A21A0", Offset = "0x24A21A0", VA = "0x7BBCCA21A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A374", Offset = "0x113A374")]
			set
			{
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002240 RID: 8768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159648", Offset = "0x1159648")]
		public WinnerTakesAllDesc wtaDesc
		{
			[Token(Token = "0x600223F")]
			[Address(RVA = "0x24A21A8", Offset = "0x24A21A8", VA = "0x7BBCCA21A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A384", Offset = "0x113A384")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002240")]
			[Address(RVA = "0x24A21B0", Offset = "0x24A21B0", VA = "0x7BBCCA21B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A394", Offset = "0x113A394")]
			set
			{
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002242 RID: 8770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115965C", Offset = "0x115965C")]
		public WarmGameInfo warm_game
		{
			[Token(Token = "0x6002241")]
			[Address(RVA = "0x24A21B8", Offset = "0x24A21B8", VA = "0x7BBCCA21B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A3A4", Offset = "0x113A3A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002242")]
			[Address(RVA = "0x24A21C0", Offset = "0x24A21C0", VA = "0x7BBCCA21C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A3B4", Offset = "0x113A3B4")]
			set
			{
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002244 RID: 8772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159670", Offset = "0x1159670")]
		public AccountAntiAddictionInfo anti_addiction_info
		{
			[Token(Token = "0x6002243")]
			[Address(RVA = "0x24A21C8", Offset = "0x24A21C8", VA = "0x7BBCCA21C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A3C4", Offset = "0x113A3C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002244")]
			[Address(RVA = "0x24A21D0", Offset = "0x24A21D0", VA = "0x7BBCCA21D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A3D4", Offset = "0x113A3D4")]
			set
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002246 RID: 8774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000600")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159684", Offset = "0x1159684")]
		public ChampionshipInfo championship_info
		{
			[Token(Token = "0x6002245")]
			[Address(RVA = "0x24A21D8", Offset = "0x24A21D8", VA = "0x7BBCCA21D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A3E4", Offset = "0x113A3E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002246")]
			[Address(RVA = "0x24A21E0", Offset = "0x24A21E0", VA = "0x7BBCCA21E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A3F4", Offset = "0x113A3F4")]
			set
			{
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000601")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159698", Offset = "0x1159698")]
		public LinkageInfo linkage_info
		{
			[Token(Token = "0x6002247")]
			[Address(RVA = "0x24A21E8", Offset = "0x24A21E8", VA = "0x7BBCCA21E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A404", Offset = "0x113A404")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002248")]
			[Address(RVA = "0x24A21F0", Offset = "0x24A21F0", VA = "0x7BBCCA21F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A414", Offset = "0x113A414")]
			set
			{
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x0000EE20 File Offset: 0x0000D020
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000602")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11596AC", Offset = "0x11596AC")]
		public uint cs_rank
		{
			[Token(Token = "0x6002249")]
			[Address(RVA = "0x24A21F8", Offset = "0x24A21F8", VA = "0x7BBCCA21F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A424", Offset = "0x113A424")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600224A")]
			[Address(RVA = "0x24A2200", Offset = "0x24A2200", VA = "0x7BBCCA2200")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A434", Offset = "0x113A434")]
			set
			{
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x0000EE38 File Offset: 0x0000D038
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000603")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11596C0", Offset = "0x11596C0")]
		public uint cs_ranking_points
		{
			[Token(Token = "0x600224B")]
			[Address(RVA = "0x24A2208", Offset = "0x24A2208", VA = "0x7BBCCA2208")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A444", Offset = "0x113A444")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600224C")]
			[Address(RVA = "0x24A2210", Offset = "0x24A2210", VA = "0x7BBCCA2210")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A454", Offset = "0x113A454")]
			set
			{
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x0000EE50 File Offset: 0x0000D050
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000604")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11596D4", Offset = "0x11596D4")]
		public uint pin_id
		{
			[Token(Token = "0x600224D")]
			[Address(RVA = "0x24A2218", Offset = "0x24A2218", VA = "0x7BBCCA2218")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A464", Offset = "0x113A464")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600224E")]
			[Address(RVA = "0x24A2220", Offset = "0x24A2220", VA = "0x7BBCCA2220")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A474", Offset = "0x113A474")]
			set
			{
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x0000EE68 File Offset: 0x0000D068
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000605")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11596E8", Offset = "0x11596E8")]
		public bool is_cs_ranking_ban
		{
			[Token(Token = "0x600224F")]
			[Address(RVA = "0x24A2228", Offset = "0x24A2228", VA = "0x7BBCCA2228")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A484", Offset = "0x113A484")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002250")]
			[Address(RVA = "0x24A2230", Offset = "0x24A2230", VA = "0x7BBCCA2230")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A494", Offset = "0x113A494")]
			set
			{
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x0000EE80 File Offset: 0x0000D080
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000606")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11596FC", Offset = "0x11596FC")]
		public bool is_trial_avatar
		{
			[Token(Token = "0x6002251")]
			[Address(RVA = "0x24A223C", Offset = "0x24A223C", VA = "0x7BBCCA223C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A4A4", Offset = "0x113A4A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002252")]
			[Address(RVA = "0x24A2244", Offset = "0x24A2244", VA = "0x7BBCCA2244")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A4B4", Offset = "0x113A4B4")]
			set
			{
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002254 RID: 8788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000607")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159710", Offset = "0x1159710")]
		public AccountHackerTagInfo hacker_tag
		{
			[Token(Token = "0x6002253")]
			[Address(RVA = "0x24A2250", Offset = "0x24A2250", VA = "0x7BBCCA2250")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A4C4", Offset = "0x113A4C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002254")]
			[Address(RVA = "0x24A2258", Offset = "0x24A2258", VA = "0x7BBCCA2258")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A4D4", Offset = "0x113A4D4")]
			set
			{
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x0000EE98 File Offset: 0x0000D098
		// (set) Token: 0x06002256 RID: 8790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000608")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159724", Offset = "0x1159724")]
		public long create_at
		{
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x24A2260", Offset = "0x24A2260", VA = "0x7BBCCA2260")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A4E4", Offset = "0x113A4E4")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002256")]
			[Address(RVA = "0x24A2268", Offset = "0x24A2268", VA = "0x7BBCCA2268")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A4F4", Offset = "0x113A4F4")]
			set
			{
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000609")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159738", Offset = "0x1159738")]
		public TrainingTokenInfo training_token_info
		{
			[Token(Token = "0x6002257")]
			[Address(RVA = "0x24A2270", Offset = "0x24A2270", VA = "0x7BBCCA2270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A504", Offset = "0x113A504")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002258")]
			[Address(RVA = "0x24A2278", Offset = "0x24A2278", VA = "0x7BBCCA2278")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A514", Offset = "0x113A514")]
			set
			{
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		// (set) Token: 0x0600225A RID: 8794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115974C", Offset = "0x115974C")]
		public uint ranking_bot_points
		{
			[Token(Token = "0x6002259")]
			[Address(RVA = "0x24A2280", Offset = "0x24A2280", VA = "0x7BBCCA2280")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A524", Offset = "0x113A524")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600225A")]
			[Address(RVA = "0x24A2288", Offset = "0x24A2288", VA = "0x7BBCCA2288")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A534", Offset = "0x113A534")]
			set
			{
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159760", Offset = "0x1159760")]
		public List<IntimacyRelation> intimacy_relation_info
		{
			[Token(Token = "0x600225B")]
			[Address(RVA = "0x24A2290", Offset = "0x24A2290", VA = "0x7BBCCA2290")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A544", Offset = "0x113A544")]
			get
			{
				return null;
			}
			[Token(Token = "0x600225C")]
			[Address(RVA = "0x24A1FC8", Offset = "0x24A1FC8", VA = "0x7BBCCA1FC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A554", Offset = "0x113A554")]
			private set
			{
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600225E RID: 8798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159774", Offset = "0x1159774")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1159774", Offset = "0x1159774")]
		public string mem_value
		{
			[Token(Token = "0x600225D")]
			[Address(RVA = "0x24A2298", Offset = "0x24A2298", VA = "0x7BBCCA2298")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A564", Offset = "0x113A564")]
			get
			{
				return null;
			}
			[Token(Token = "0x600225E")]
			[Address(RVA = "0x24A1FD0", Offset = "0x24A1FD0", VA = "0x7BBCCA1FD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113A574", Offset = "0x113A574")]
			set
			{
			}
		}

		// Token: 0x04001961 RID: 6497
		[Token(Token = "0x4001961")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104574", Offset = "0x1104574")]
		private ulong <account_id>k__BackingField;

		// Token: 0x04001962 RID: 6498
		[Token(Token = "0x4001962")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104584", Offset = "0x1104584")]
		private string <nickname>k__BackingField;

		// Token: 0x04001963 RID: 6499
		[Token(Token = "0x4001963")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104594", Offset = "0x1104594")]
		private string <lock_region>k__BackingField;

		// Token: 0x04001964 RID: 6500
		[Token(Token = "0x4001964")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11045A4", Offset = "0x11045A4")]
		private uint <level>k__BackingField;

		// Token: 0x04001965 RID: 6501
		[Token(Token = "0x4001965")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11045B4", Offset = "0x11045B4")]
		private uint <avatar_id>k__BackingField;

		// Token: 0x04001966 RID: 6502
		[Token(Token = "0x4001966")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11045C4", Offset = "0x11045C4")]
		private uint <skin_color>k__BackingField;

		// Token: 0x04001967 RID: 6503
		[Token(Token = "0x4001967")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11045D4", Offset = "0x11045D4")]
		private uint[] <clothes>k__BackingField;

		// Token: 0x04001968 RID: 6504
		[Token(Token = "0x4001968")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11045E4", Offset = "0x11045E4")]
		private List<LoadoutInfo> <loadouts>k__BackingField;

		// Token: 0x04001969 RID: 6505
		[Token(Token = "0x4001969")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11045F4", Offset = "0x11045F4")]
		private uint <banner_id>k__BackingField;

		// Token: 0x0400196A RID: 6506
		[Token(Token = "0x400196A")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104604", Offset = "0x1104604")]
		private uint <head_pic>k__BackingField;

		// Token: 0x0400196B RID: 6507
		[Token(Token = "0x400196B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104614", Offset = "0x1104614")]
		private uint[] <slots>k__BackingField;

		// Token: 0x0400196C RID: 6508
		[Token(Token = "0x400196C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104624", Offset = "0x1104624")]
		private uint[] <skills>k__BackingField;

		// Token: 0x0400196D RID: 6509
		[Token(Token = "0x400196D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104634", Offset = "0x1104634")]
		private string <clan_name>k__BackingField;

		// Token: 0x0400196E RID: 6510
		[Token(Token = "0x400196E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104644", Offset = "0x1104644")]
		private List<MMRInfo> <mmr_info>k__BackingField;

		// Token: 0x0400196F RID: 6511
		[Token(Token = "0x400196F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104654", Offset = "0x1104654")]
		private uint <rank>k__BackingField;

		// Token: 0x04001970 RID: 6512
		[Token(Token = "0x4001970")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104664", Offset = "0x1104664")]
		private uint <ranking_points>k__BackingField;

		// Token: 0x04001971 RID: 6513
		[Token(Token = "0x4001971")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104674", Offset = "0x1104674")]
		private uint <role>k__BackingField;

		// Token: 0x04001972 RID: 6514
		[Token(Token = "0x4001972")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104684", Offset = "0x1104684")]
		private bool <has_elite_pass>k__BackingField;

		// Token: 0x04001973 RID: 6515
		[Token(Token = "0x4001973")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104694", Offset = "0x1104694")]
		private uint <badge_cnt>k__BackingField;

		// Token: 0x04001974 RID: 6516
		[Token(Token = "0x4001974")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11046A4", Offset = "0x11046A4")]
		private uint <badge_id>k__BackingField;

		// Token: 0x04001975 RID: 6517
		[Token(Token = "0x4001975")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11046B4", Offset = "0x11046B4")]
		private uint <ep_goldlimit_bonus>k__BackingField;

		// Token: 0x04001976 RID: 6518
		[Token(Token = "0x4001976")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11046C4", Offset = "0x11046C4")]
		private List<RoomCardInfo> <room_cards>k__BackingField;

		// Token: 0x04001977 RID: 6519
		[Token(Token = "0x4001977")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11046D4", Offset = "0x11046D4")]
		private bool <show_rank>k__BackingField;

		// Token: 0x04001978 RID: 6520
		[Token(Token = "0x4001978")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11046E4", Offset = "0x11046E4")]
		private List<EmoteInfo> <emotes>k__BackingField;

		// Token: 0x04001979 RID: 6521
		[Token(Token = "0x4001979")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11046F4", Offset = "0x11046F4")]
		private List<RedEnvelopeInfo> <red_envelopes>k__BackingField;

		// Token: 0x0400197A RID: 6522
		[Token(Token = "0x400197A")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104704", Offset = "0x1104704")]
		private uint[] <shows>k__BackingField;

		// Token: 0x0400197B RID: 6523
		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104714", Offset = "0x1104714")]
		private PetInfo <pet_info>k__BackingField;

		// Token: 0x0400197C RID: 6524
		[Token(Token = "0x400197C")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104724", Offset = "0x1104724")]
		private uint <pve_primary_weapon_skin>k__BackingField;

		// Token: 0x0400197D RID: 6525
		[Token(Token = "0x400197D")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104734", Offset = "0x1104734")]
		private List<ReviveTokenInfo> <revive_tokens>k__BackingField;

		// Token: 0x0400197E RID: 6526
		[Token(Token = "0x400197E")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104744", Offset = "0x1104744")]
		private WalletInfo <wallet>k__BackingField;

		// Token: 0x0400197F RID: 6527
		[Token(Token = "0x400197F")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104754", Offset = "0x1104754")]
		private uint <platform_type>k__BackingField;

		// Token: 0x04001980 RID: 6528
		[Token(Token = "0x4001980")]
		[FieldOffset(Offset = "0xDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104764", Offset = "0x1104764")]
		private uint <wta_free_match_num_today>k__BackingField;

		// Token: 0x04001981 RID: 6529
		[Token(Token = "0x4001981")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104774", Offset = "0x1104774")]
		private ChipInfo <chips>k__BackingField;

		// Token: 0x04001982 RID: 6530
		[Token(Token = "0x4001982")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104784", Offset = "0x1104784")]
		private WinnerTakesAllDesc <wtaDesc>k__BackingField;

		// Token: 0x04001983 RID: 6531
		[Token(Token = "0x4001983")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104794", Offset = "0x1104794")]
		private WarmGameInfo <warm_game>k__BackingField;

		// Token: 0x04001984 RID: 6532
		[Token(Token = "0x4001984")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11047A4", Offset = "0x11047A4")]
		private AccountAntiAddictionInfo <anti_addiction_info>k__BackingField;

		// Token: 0x04001985 RID: 6533
		[Token(Token = "0x4001985")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11047B4", Offset = "0x11047B4")]
		private ChampionshipInfo <championship_info>k__BackingField;

		// Token: 0x04001986 RID: 6534
		[Token(Token = "0x4001986")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11047C4", Offset = "0x11047C4")]
		private LinkageInfo <linkage_info>k__BackingField;

		// Token: 0x04001987 RID: 6535
		[Token(Token = "0x4001987")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11047D4", Offset = "0x11047D4")]
		private uint <cs_rank>k__BackingField;

		// Token: 0x04001988 RID: 6536
		[Token(Token = "0x4001988")]
		[FieldOffset(Offset = "0x114")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11047E4", Offset = "0x11047E4")]
		private uint <cs_ranking_points>k__BackingField;

		// Token: 0x04001989 RID: 6537
		[Token(Token = "0x4001989")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11047F4", Offset = "0x11047F4")]
		private uint <pin_id>k__BackingField;

		// Token: 0x0400198A RID: 6538
		[Token(Token = "0x400198A")]
		[FieldOffset(Offset = "0x11C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104804", Offset = "0x1104804")]
		private bool <is_cs_ranking_ban>k__BackingField;

		// Token: 0x0400198B RID: 6539
		[Token(Token = "0x400198B")]
		[FieldOffset(Offset = "0x11D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104814", Offset = "0x1104814")]
		private bool <is_trial_avatar>k__BackingField;

		// Token: 0x0400198C RID: 6540
		[Token(Token = "0x400198C")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104824", Offset = "0x1104824")]
		private AccountHackerTagInfo <hacker_tag>k__BackingField;

		// Token: 0x0400198D RID: 6541
		[Token(Token = "0x400198D")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104834", Offset = "0x1104834")]
		private long <create_at>k__BackingField;

		// Token: 0x0400198E RID: 6542
		[Token(Token = "0x400198E")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104844", Offset = "0x1104844")]
		private TrainingTokenInfo <training_token_info>k__BackingField;

		// Token: 0x0400198F RID: 6543
		[Token(Token = "0x400198F")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104854", Offset = "0x1104854")]
		private uint <ranking_bot_points>k__BackingField;

		// Token: 0x04001990 RID: 6544
		[Token(Token = "0x4001990")]
		[FieldOffset(Offset = "0x140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104864", Offset = "0x1104864")]
		private List<IntimacyRelation> <intimacy_relation_info>k__BackingField;

		// Token: 0x04001991 RID: 6545
		[Token(Token = "0x4001991")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104874", Offset = "0x1104874")]
		private string <mem_value>k__BackingField;
	}
}
