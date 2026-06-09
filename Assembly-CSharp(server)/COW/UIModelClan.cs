using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001DE7 RID: 7655
	[Token(Token = "0x2001DE7")]
	public class UIModelClan : UIBaseModel
	{
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600A741 RID: 42817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF5")]
		public List<ClanNews> MyClanNews
		{
			[Token(Token = "0x600A741")]
			[Address(RVA = "0x2100498", Offset = "0x2100498", VA = "0x7BBC900498")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600A743 RID: 42819 RVA: 0x0002D108 File Offset: 0x0002B308
		// (set) Token: 0x0600A742 RID: 42818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF6")]
		public bool HasReadApplyDeputyCaptainRedDot
		{
			[Token(Token = "0x600A743")]
			[Address(RVA = "0x2100554", Offset = "0x2100554", VA = "0x7BBC900554")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A742")]
			[Address(RVA = "0x21004A0", Offset = "0x21004A0", VA = "0x7BBC9004A0")]
			set
			{
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600A744 RID: 42820 RVA: 0x0002D120 File Offset: 0x0002B320
		// (set) Token: 0x0600A745 RID: 42821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF7")]
		public bool CanApplyDeputyCaptain
		{
			[Token(Token = "0x600A744")]
			[Address(RVA = "0x210055C", Offset = "0x210055C", VA = "0x7BBC90055C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A745")]
			[Address(RVA = "0x2100564", Offset = "0x2100564", VA = "0x7BBC900564")]
			set
			{
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600A747 RID: 42823 RVA: 0x0002D138 File Offset: 0x0002B338
		// (set) Token: 0x0600A746 RID: 42822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF8")]
		public bool HasGetMembersSinceLogin
		{
			[Token(Token = "0x600A747")]
			[Address(RVA = "0x2100644", Offset = "0x2100644", VA = "0x7BBC900644")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D2C", Offset = "0x1145D2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A746")]
			[Address(RVA = "0x2100638", Offset = "0x2100638", VA = "0x7BBC900638")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D1C", Offset = "0x1145D1C")]
			private set
			{
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x0600A748 RID: 42824 RVA: 0x0002D150 File Offset: 0x0002B350
		// (set) Token: 0x0600A749 RID: 42825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF9")]
		public int NewLuckyBagCnt
		{
			[Token(Token = "0x600A748")]
			[Address(RVA = "0x210064C", Offset = "0x210064C", VA = "0x7BBC90064C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A749")]
			[Address(RVA = "0x2100654", Offset = "0x2100654", VA = "0x7BBC900654")]
			set
			{
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x0600A74A RID: 42826 RVA: 0x0002D168 File Offset: 0x0002B368
		[Token(Token = "0x17000AFA")]
		public ulong MyClanID
		{
			[Token(Token = "0x600A74A")]
			[Address(RVA = "0x21006EC", Offset = "0x21006EC", VA = "0x7BBC9006EC")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x0600A74B RID: 42827 RVA: 0x0002D180 File Offset: 0x0002B380
		[Token(Token = "0x17000AFB")]
		public bool HasInvitationToShow
		{
			[Token(Token = "0x600A74B")]
			[Address(RVA = "0x2100718", Offset = "0x2100718", VA = "0x7BBC900718")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x0600A74C RID: 42828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFC")]
		public InviteToClanReq Invitation
		{
			[Token(Token = "0x600A74C")]
			[Address(RVA = "0x2100720", Offset = "0x2100720", VA = "0x7BBC900720")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x0600A74D RID: 42829 RVA: 0x0002D198 File Offset: 0x0002B398
		[Token(Token = "0x17000AFD")]
		public EClanRole MyClanRole
		{
			[Token(Token = "0x600A74D")]
			[Address(RVA = "0x2100728", Offset = "0x2100728", VA = "0x7BBC900728")]
			get
			{
				return EClanRole.None;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x0600A74E RID: 42830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFE")]
		public string ClanName
		{
			[Token(Token = "0x600A74E")]
			[Address(RVA = "0x21009D4", Offset = "0x21009D4", VA = "0x7BBC9009D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600A74F RID: 42831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFF")]
		public ClanInfo MyClanInfo
		{
			[Token(Token = "0x600A74F")]
			[Address(RVA = "0x2100A00", Offset = "0x2100A00", VA = "0x7BBC900A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x0600A750 RID: 42832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B00")]
		public List<ClanMember> ClanMemberList
		{
			[Token(Token = "0x600A750")]
			[Address(RVA = "0x2100A08", Offset = "0x2100A08", VA = "0x7BBC900A08")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600A751 RID: 42833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B01")]
		public List<ClanMember> SelfTopClanMemberList
		{
			[Token(Token = "0x600A751")]
			[Address(RVA = "0x2100A10", Offset = "0x2100A10", VA = "0x7BBC900A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x0600A752 RID: 42834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B02")]
		public List<ClanMember> OnlineClanMemberList
		{
			[Token(Token = "0x600A752")]
			[Address(RVA = "0x2100BD0", Offset = "0x2100BD0", VA = "0x7BBC900BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x0600A753 RID: 42835 RVA: 0x0002D1B0 File Offset: 0x0002B3B0
		[Token(Token = "0x17000B03")]
		public int ClanMemberNum
		{
			[Token(Token = "0x600A753")]
			[Address(RVA = "0x2100BD8", Offset = "0x2100BD8", VA = "0x7BBC900BD8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x0600A754 RID: 42836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B04")]
		public List<ClanInfo> ClanList
		{
			[Token(Token = "0x600A754")]
			[Address(RVA = "0x2100C38", Offset = "0x2100C38", VA = "0x7BBC900C38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0600A755 RID: 42837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B05")]
		public List<BaseProfileInfo> ClanApplicationList
		{
			[Token(Token = "0x600A755")]
			[Address(RVA = "0x2100C40", Offset = "0x2100C40", VA = "0x7BBC900C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600A756 RID: 42838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B06")]
		public Dictionary<ulong, bool> ClanApplyStatus
		{
			[Token(Token = "0x600A756")]
			[Address(RVA = "0x2100C48", Offset = "0x2100C48", VA = "0x7BBC900C48")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A757 RID: 42839 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		[Token(Token = "0x600A757")]
		[Address(RVA = "0x2100C50", Offset = "0x2100C50", VA = "0x7BBC900C50")]
		public bool IsManager()
		{
			return default(bool);
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x0002D1E0 File Offset: 0x0002B3E0
		[Token(Token = "0x600A758")]
		[Address(RVA = "0x2100CA0", Offset = "0x2100CA0", VA = "0x7BBC900CA0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x0600A759 RID: 42841 RVA: 0x0002D1F8 File Offset: 0x0002B3F8
		[Token(Token = "0x17000B07")]
		public uint GoldCost
		{
			[Token(Token = "0x600A759")]
			[Address(RVA = "0x2100CA8", Offset = "0x2100CA8", VA = "0x7BBC900CA8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600A75A RID: 42842 RVA: 0x0002D210 File Offset: 0x0002B410
		[Token(Token = "0x17000B08")]
		public uint DiamondCost
		{
			[Token(Token = "0x600A75A")]
			[Address(RVA = "0x2100D88", Offset = "0x2100D88", VA = "0x7BBC900D88")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A75B")]
		[Address(RVA = "0x2100E68", Offset = "0x2100E68", VA = "0x7BBC900E68", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A75C")]
		[Address(RVA = "0x2100F50", Offset = "0x2100F50", VA = "0x7BBC900F50")]
		public void ClearSigninData()
		{
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A75D")]
		[Address(RVA = "0x2101160", Offset = "0x2101160", VA = "0x7BBC901160")]
		public void ClearLuckyBagData()
		{
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A75E")]
		[Address(RVA = "0x210121C", Offset = "0x210121C", VA = "0x7BBC90121C")]
		public string GetKeyByDayOfWeek(DayOfWeek day)
		{
			return null;
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A75F")]
		[Address(RVA = "0x2101280", Offset = "0x2101280", VA = "0x7BBC901280")]
		public void RequestApplyDeputyCaptain()
		{
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A760")]
		[Address(RVA = "0x21017A8", Offset = "0x21017A8", VA = "0x7BBC9017A8")]
		public void RequestClanList(proto.EClan.ClanMainType mainType = proto.EClan.ClanMainType.ClanMainType_REGION, uint areaId = 0U, uint playStyle = 0U)
		{
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A761")]
		[Address(RVA = "0x21019A8", Offset = "0x21019A8", VA = "0x7BBC9019A8")]
		public void SetClaimClanRaceAwardTime()
		{
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A762")]
		[Address(RVA = "0x2101A1C", Offset = "0x2101A1C", VA = "0x7BBC901A1C")]
		public void SearchClanList(ulong clanid)
		{
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A763")]
		[Address(RVA = "0x2101C00", Offset = "0x2101C00", VA = "0x7BBC901C00")]
		public void SearchClanList(string keyword)
		{
		}

		// Token: 0x0600A764 RID: 42852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A764")]
		[Address(RVA = "0x2101DCC", Offset = "0x2101DCC", VA = "0x7BBC901DCC")]
		public void RequestMyClanInfo(uint httpOp = 0U)
		{
		}

		// Token: 0x0600A765 RID: 42853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A765")]
		[Address(RVA = "0x2101ED8", Offset = "0x2101ED8", VA = "0x7BBC901ED8")]
		public void RequestClanInfo(ulong clanid, uint httpOp = 0U)
		{
		}

		// Token: 0x0600A766 RID: 42854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A766")]
		[Address(RVA = "0x21020D0", Offset = "0x21020D0", VA = "0x7BBC9020D0")]
		public void RequestApplyForJoinClan(ClanInfo clanInfo)
		{
		}

		// Token: 0x0600A767 RID: 42855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A767")]
		[Address(RVA = "0x20FDF38", Offset = "0x20FDF38", VA = "0x7BBC8FDF38")]
		public void RequestApplyForJoinClan(ulong clanid)
		{
		}

		// Token: 0x0600A768 RID: 42856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A768")]
		[Address(RVA = "0x2102170", Offset = "0x2102170", VA = "0x7BBC902170")]
		public void RequestCreateClan(string name, string slogan, proto.EInventory.CurrencyType currency_type, uint entry_type, uint areaId, uint playStyle, bool sendRecruitToWorld = false, uint entry_level = 0U, uint entry_rank = 0U)
		{
		}

		// Token: 0x0600A769 RID: 42857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A769")]
		[Address(RVA = "0x21024C4", Offset = "0x21024C4", VA = "0x7BBC9024C4")]
		public void OperateClan(EClanOperation operate, ulong playerid)
		{
		}

		// Token: 0x0600A76A RID: 42858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A76A")]
		[Address(RVA = "0x2102BD0", Offset = "0x2102BD0", VA = "0x7BBC902BD0")]
		public void DismissClan()
		{
		}

		// Token: 0x0600A76B RID: 42859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A76B")]
		[Address(RVA = "0x2102E00", Offset = "0x2102E00", VA = "0x7BBC902E00")]
		public void InviteToClan(ulong playerid)
		{
		}

		// Token: 0x0600A76C RID: 42860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A76C")]
		[Address(RVA = "0x2103210", Offset = "0x2103210", VA = "0x7BBC903210")]
		public void RequestDetails()
		{
		}

		// Token: 0x0600A76D RID: 42861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A76D")]
		[Address(RVA = "0x210349C", Offset = "0x210349C", VA = "0x7BBC90349C")]
		public void RequestMemberList(bool forceUpdate = true, [Optional] object[] inviteData, bool refreshPresent = true)
		{
		}

		// Token: 0x0600A76E RID: 42862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A76E")]
		[Address(RVA = "0x2103B24", Offset = "0x2103B24", VA = "0x7BBC903B24")]
		public void RequestActivityTrigger()
		{
		}

		// Token: 0x0600A76F RID: 42863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A76F")]
		[Address(RVA = "0x2103924", Offset = "0x2103924", VA = "0x7BBC903924")]
		public void RequesetClanmemberPresence()
		{
		}

		// Token: 0x0600A770 RID: 42864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A770")]
		[Address(RVA = "0x2103CB4", Offset = "0x2103CB4", VA = "0x7BBC903CB4")]
		internal void RefreshMemberPresences(PresenceListRes resData)
		{
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A771")]
		[Address(RVA = "0x210433C", Offset = "0x210433C", VA = "0x7BBC90433C")]
		public void ModifyClanInfo(string announcement, string slogan, uint entryType, uint areaId, uint playStyle, uint entry_level = 0U, uint entry_rank = 0U)
		{
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A772")]
		[Address(RVA = "0x21046A0", Offset = "0x21046A0", VA = "0x7BBC9046A0")]
		public void ModifyClanName(string name)
		{
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A773")]
		[Address(RVA = "0x21048A8", Offset = "0x21048A8", VA = "0x7BBC9048A8")]
		public void ExtendClanScale()
		{
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A774")]
		[Address(RVA = "0x2104AE0", Offset = "0x2104AE0", VA = "0x7BBC904AE0")]
		public void RequestClanApplication()
		{
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A775")]
		[Address(RVA = "0x2104D0C", Offset = "0x2104D0C", VA = "0x7BBC904D0C")]
		public void ProcessClanApplication(bool isAccept, ulong playerid)
		{
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A776")]
		[Address(RVA = "0x2104FA8", Offset = "0x2104FA8", VA = "0x7BBC904FA8")]
		private void SetApplyRedDotCount()
		{
		}

		// Token: 0x0600A777 RID: 42871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A777")]
		[Address(RVA = "0x2105078", Offset = "0x2105078", VA = "0x7BBC905078")]
		public void ProcessClanInvitation(bool isAccept, ulong inviterid, ulong clanid)
		{
		}

		// Token: 0x0600A778 RID: 42872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A778")]
		[Address(RVA = "0x2105280", Offset = "0x2105280", VA = "0x7BBC905280")]
		public void ExitClan()
		{
		}

		// Token: 0x0600A779 RID: 42873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A779")]
		[Address(RVA = "0x2105504", Offset = "0x2105504", VA = "0x7BBC905504")]
		public void RequestSigninData()
		{
		}

		// Token: 0x0600A77A RID: 42874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A77A")]
		[Address(RVA = "0x2105678", Offset = "0x2105678", VA = "0x7BBC905678")]
		public void OnResponseGetSinginData(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x0002D228 File Offset: 0x0002B428
		[Token(Token = "0x600A77B")]
		[Address(RVA = "0x2105928", Offset = "0x2105928", VA = "0x7BBC905928")]
		private int GetCanClaimCount()
		{
			return 0;
		}

		// Token: 0x0600A77C RID: 42876 RVA: 0x0002D240 File Offset: 0x0002B440
		[Token(Token = "0x600A77C")]
		[Address(RVA = "0x2105A9C", Offset = "0x2105A9C", VA = "0x7BBC905A9C")]
		public bool PermitClaim()
		{
			return default(bool);
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x0002D258 File Offset: 0x0002B458
		[Token(Token = "0x600A77D")]
		[Address(RVA = "0x21058DC", Offset = "0x21058DC", VA = "0x7BBC9058DC")]
		public int GetGuildSigninRedDotCount()
		{
			return 0;
		}

		// Token: 0x0600A77E RID: 42878 RVA: 0x0002D270 File Offset: 0x0002B470
		[Token(Token = "0x600A77E")]
		[Address(RVA = "0x2105CAC", Offset = "0x2105CAC", VA = "0x7BBC905CAC")]
		public bool HasItemToClaim(proto.EClan.ClanSignInRewardStatus signinStatus, DayOfWeek day)
		{
			return default(bool);
		}

		// Token: 0x0600A77F RID: 42879 RVA: 0x0002D288 File Offset: 0x0002B488
		[Token(Token = "0x600A77F")]
		[Address(RVA = "0x2105B58", Offset = "0x2105B58", VA = "0x7BBC905B58")]
		public bool HasSignInToday()
		{
			return default(bool);
		}

		// Token: 0x0600A780 RID: 42880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A780")]
		[Address(RVA = "0x2105D70", Offset = "0x2105D70", VA = "0x7BBC905D70")]
		public List<ClanSignInRewardItem> GetClanSignInData()
		{
			return null;
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A781")]
		[Address(RVA = "0x2105D78", Offset = "0x2105D78", VA = "0x7BBC905D78")]
		public void RequestNextLevelSigninData()
		{
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A782")]
		[Address(RVA = "0x2105F2C", Offset = "0x2105F2C", VA = "0x7BBC905F2C")]
		public List<ClanSignInRewardItem> GetNextLevelClanSignInData()
		{
			return null;
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A783")]
		[Address(RVA = "0x2105F34", Offset = "0x2105F34", VA = "0x7BBC905F34")]
		public void SinginClaim(DayOfWeek day)
		{
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A784")]
		[Address(RVA = "0x21060F8", Offset = "0x21060F8", VA = "0x7BBC9060F8")]
		public void RequestClanLuckyBagsInfo(ulong clan_id, bool isRefreshRequest = false)
		{
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x0002D2A0 File Offset: 0x0002B4A0
		[Token(Token = "0x600A785")]
		[Address(RVA = "0x21063B4", Offset = "0x21063B4", VA = "0x7BBC9063B4")]
		public bool CanRequestClanLuckyBagInfo(bool isRefreshRequest = false)
		{
			return default(bool);
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A786")]
		[Address(RVA = "0x2106480", Offset = "0x2106480", VA = "0x7BBC906480")]
		public void RequestDrawClanLuckyBag(ulong clan_id, ulong bag_id)
		{
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x0002D2B8 File Offset: 0x0002B4B8
		[Token(Token = "0x600A787")]
		[Address(RVA = "0x21067B4", Offset = "0x21067B4", VA = "0x7BBC9067B4")]
		public bool IsDrawedLuckyBag(ulong bag_id)
		{
			return default(bool);
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A788")]
		[Address(RVA = "0x2106898", Offset = "0x2106898", VA = "0x7BBC906898")]
		public void SortLuckyBagList()
		{
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
		[Token(Token = "0x600A789")]
		[Address(RVA = "0x2106938", Offset = "0x2106938", VA = "0x7BBC906938")]
		private int SortLuckyBagList(ClanLuckyBag x, ClanLuckyBag y)
		{
			return 0;
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A78A")]
		[Address(RVA = "0x2106980", Offset = "0x2106980", VA = "0x7BBC906980")]
		public void FilterLuckyBagList()
		{
		}

		// Token: 0x0600A78B RID: 42891 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
		[Token(Token = "0x600A78B")]
		[Address(RVA = "0x2106AC8", Offset = "0x2106AC8", VA = "0x7BBC906AC8")]
		public bool HasUnClamiedLucykBag()
		{
			return default(bool);
		}

		// Token: 0x0600A78C RID: 42892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A78C")]
		[Address(RVA = "0x2106B5C", Offset = "0x2106B5C", VA = "0x7BBC906B5C")]
		public void AddNewLuckyBag(ClanLuckyBag luckyBag)
		{
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A78D")]
		[Address(RVA = "0x2106D78", Offset = "0x2106D78", VA = "0x7BBC906D78")]
		public void RequestMyClanNews()
		{
		}

		// Token: 0x0600A78E RID: 42894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A78E")]
		[Address(RVA = "0x2106F10", Offset = "0x2106F10", VA = "0x7BBC906F10")]
		public string GetNewsStringFromNewsType(proto.EClan.NewsType type, ulong accountId, EClanRole memberType, uint level)
		{
			return null;
		}

		// Token: 0x0600A78F RID: 42895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A78F")]
		[Address(RVA = "0x21072E8", Offset = "0x21072E8", VA = "0x7BBC9072E8")]
		public void UpdateClanMallTipsNum()
		{
		}

		// Token: 0x0600A790 RID: 42896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A790")]
		[Address(RVA = "0x210065C", Offset = "0x210065C", VA = "0x7BBC90065C")]
		public void UpdateLuckyBagTipsNum()
		{
		}

		// Token: 0x0600A791 RID: 42897 RVA: 0x0002D300 File Offset: 0x0002B500
		[Token(Token = "0x600A791")]
		[Address(RVA = "0x2106AAC", Offset = "0x2106AAC", VA = "0x7BBC906AAC")]
		private bool IsShowLuckyBag(ClanLuckyBag luckyBag)
		{
			return default(bool);
		}

		// Token: 0x0600A792 RID: 42898 RVA: 0x0002D318 File Offset: 0x0002B518
		[Token(Token = "0x600A792")]
		[Address(RVA = "0x21073B4", Offset = "0x21073B4", VA = "0x7BBC9073B4")]
		private bool IsExpiredLuckyBag(ClanLuckyBag luckyBag)
		{
			return default(bool);
		}

		// Token: 0x0600A793 RID: 42899 RVA: 0x0002D330 File Offset: 0x0002B530
		[Token(Token = "0x600A793")]
		[Address(RVA = "0x21074BC", Offset = "0x21074BC", VA = "0x7BBC9074BC")]
		public ulong CalculateLucykBagExpirationTime(ClanLuckyBag lucykBag)
		{
			return 0UL;
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x0002D348 File Offset: 0x0002B548
		[Token(Token = "0x600A794")]
		[Address(RVA = "0x2105A90", Offset = "0x2105A90", VA = "0x7BBC905A90")]
		public DayOfWeek IntegerToDayOfWeek(uint weekday)
		{
			return DayOfWeek.Sunday;
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x0002D360 File Offset: 0x0002B560
		[Token(Token = "0x600A795")]
		[Address(RVA = "0x2105D60", Offset = "0x2105D60", VA = "0x7BBC905D60")]
		public uint DayOfWeekToInteger(DayOfWeek weekday)
		{
			return 0U;
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x0002D378 File Offset: 0x0002B578
		[Token(Token = "0x600A796")]
		[Address(RVA = "0x21075A0", Offset = "0x21075A0", VA = "0x7BBC9075A0")]
		public bool IsClanApplied(ulong clanID)
		{
			return default(bool);
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A797")]
		[Address(RVA = "0x2107620", Offset = "0x2107620", VA = "0x7BBC907620")]
		public void SetHasInvitationToShow(bool hasInvitation, [Optional] InviteToClanReq ntf)
		{
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x0002D390 File Offset: 0x0002B590
		[Token(Token = "0x600A798")]
		[Address(RVA = "0x2107634", Offset = "0x2107634", VA = "0x7BBC907634")]
		public int GetOnlineNum()
		{
			return 0;
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A799")]
		[Address(RVA = "0x2107714", Offset = "0x2107714", VA = "0x7BBC907714")]
		public void TriggerVisitNewSetting()
		{
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x0002D3A8 File Offset: 0x0002B5A8
		[Token(Token = "0x600A79A")]
		[Address(RVA = "0x21077D8", Offset = "0x21077D8", VA = "0x7BBC9077D8")]
		public bool CheckHasShowNewSetting()
		{
			return default(bool);
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A79B")]
		[Address(RVA = "0x21078B8", Offset = "0x21078B8", VA = "0x7BBC9078B8")]
		public ClanMember FindClanMemberByID(ulong accountID)
		{
			return null;
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A79C")]
		[Address(RVA = "0x2101028", Offset = "0x2101028", VA = "0x7BBC901028")]
		public void ClearClanData()
		{
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A79D")]
		[Address(RVA = "0x2107990", Offset = "0x2107990", VA = "0x7BBC907990")]
		public void ClearAll()
		{
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A79E")]
		[Address(RVA = "0x21079FC", Offset = "0x21079FC", VA = "0x7BBC9079FC")]
		public void RefreshClanInfo(uint httpOp = 0U)
		{
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A79F")]
		[Address(RVA = "0x2107B04", Offset = "0x2107B04", VA = "0x7BBC907B04")]
		private void NotifyErrorMessage(params object[] param)
		{
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A7A0")]
		[Address(RVA = "0x2107D34", Offset = "0x2107D34", VA = "0x7BBC907D34")]
		private string GetErrorMsgKey(string errormsgS)
		{
			return null;
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A7A1")]
		[Address(RVA = "0x210164C", Offset = "0x210164C", VA = "0x7BBC90164C")]
		public ClanMember GetMyClanMemeberInfo()
		{
			return null;
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A7A2")]
		[Address(RVA = "0x2107EB8", Offset = "0x2107EB8", VA = "0x7BBC907EB8")]
		public ClanMember FindDeputyCaptain()
		{
			return null;
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A3")]
		[Address(RVA = "0x2107FBC", Offset = "0x2107FBC", VA = "0x7BBC907FBC")]
		public void SetDeputyCaptain(ulong deputyCaptainId)
		{
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A4")]
		[Address(RVA = "0x2108148", Offset = "0x2108148", VA = "0x7BBC908148")]
		public UIModelClan()
		{
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A6")]
		[Address(RVA = "0x2108980", Offset = "0x2108980", VA = "0x7BBC908980")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D3C", Offset = "0x1145D3C")]
		private void <RequestApplyDeputyCaptain>b__111_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A7")]
		[Address(RVA = "0x2108BF0", Offset = "0x2108BF0", VA = "0x7BBC908BF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D4C", Offset = "0x1145D4C")]
		private void <RequestClanList>b__112_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A8")]
		[Address(RVA = "0x2108D88", Offset = "0x2108D88", VA = "0x7BBC908D88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D5C", Offset = "0x1145D5C")]
		private void <SearchClanList>b__114_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A9")]
		[Address(RVA = "0x2108EB8", Offset = "0x2108EB8", VA = "0x7BBC908EB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D6C", Offset = "0x1145D6C")]
		private void <SearchClanList>b__115_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AA")]
		[Address(RVA = "0x2109050", Offset = "0x2109050", VA = "0x7BBC909050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D7C", Offset = "0x1145D7C")]
		private void <RequestClanInfo>b__117_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AB")]
		[Address(RVA = "0x2109140", Offset = "0x2109140", VA = "0x7BBC909140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D8C", Offset = "0x1145D8C")]
		private void <DismissClan>b__122_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AC")]
		[Address(RVA = "0x2109238", Offset = "0x2109238", VA = "0x7BBC909238")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D9C", Offset = "0x1145D9C")]
		private void <RequestDetails>b__124_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7AD RID: 42925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AD")]
		[Address(RVA = "0x2109310", Offset = "0x2109310", VA = "0x7BBC909310")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145DAC", Offset = "0x1145DAC")]
		private void <RequestActivityTrigger>b__126_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7AE RID: 42926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AE")]
		[Address(RVA = "0x2109324", Offset = "0x2109324", VA = "0x7BBC909324")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145DBC", Offset = "0x1145DBC")]
		private void <ExtendClanScale>b__131_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AF")]
		[Address(RVA = "0x2109698", Offset = "0x2109698", VA = "0x7BBC909698")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145DCC", Offset = "0x1145DCC")]
		private void <RequestClanApplication>b__132_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7B0")]
		[Address(RVA = "0x2109904", Offset = "0x2109904", VA = "0x7BBC909904")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145DDC", Offset = "0x1145DDC")]
		private void <ExitClan>b__136_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7B1")]
		[Address(RVA = "0x2109A6C", Offset = "0x2109A6C", VA = "0x7BBC909A6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145DEC", Offset = "0x1145DEC")]
		private void <RequestSigninData>b__137_0(HttpErrorCode code, object obj)
		{
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7B2")]
		[Address(RVA = "0x2109A80", Offset = "0x2109A80", VA = "0x7BBC909A80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145DFC", Offset = "0x1145DFC")]
		private void <RequestNextLevelSigninData>b__145_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600A7B3 RID: 42931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7B3")]
		[Address(RVA = "0x2109BE8", Offset = "0x2109BE8", VA = "0x7BBC909BE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E0C", Offset = "0x1145E0C")]
		private void <RequestMyClanNews>b__157_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0400ACEE RID: 44270
		[Token(Token = "0x400ACEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ClanInfo m_MyClanInfo;

		// Token: 0x0400ACEF RID: 44271
		[Token(Token = "0x400ACEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ClanMember> m_ClanMemberList;

		// Token: 0x0400ACF0 RID: 44272
		[Token(Token = "0x400ACF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ClanMember> m_OnlineClanMemberList;

		// Token: 0x0400ACF1 RID: 44273
		[Token(Token = "0x400ACF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<ClanInfo> m_ClanList;

		// Token: 0x0400ACF2 RID: 44274
		[Token(Token = "0x400ACF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<BaseProfileInfo> m_ClanApplicationList;

		// Token: 0x0400ACF3 RID: 44275
		[Token(Token = "0x400ACF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private EClanRole m_MyClanRole;

		// Token: 0x0400ACF4 RID: 44276
		[Token(Token = "0x400ACF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<ulong, bool> m_ClanApplyStatus;

		// Token: 0x0400ACF5 RID: 44277
		[Token(Token = "0x400ACF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<ulong> m_PlayerIdsInvitedToClan;

		// Token: 0x0400ACF6 RID: 44278
		[Token(Token = "0x400ACF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<ClanSignInRewardItem> m_SignInRewardItems;

		// Token: 0x0400ACF7 RID: 44279
		[Token(Token = "0x400ACF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<ClanSignInRewardItem> m_NextLevelSignInRewardItems;

		// Token: 0x0400ACF8 RID: 44280
		[Token(Token = "0x400ACF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<ClanLuckyBag> m_ClanLuckyBagsList;

		// Token: 0x0400ACF9 RID: 44281
		[Token(Token = "0x400ACF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<LuckyBagDraw> m_LuckyBagDrawList;

		// Token: 0x0400ACFA RID: 44282
		[Token(Token = "0x400ACFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private uint create_gold_cost;

		// Token: 0x0400ACFB RID: 44283
		[Token(Token = "0x400ACFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private uint create_diamond_cost;

		// Token: 0x0400ACFC RID: 44284
		[Token(Token = "0x400ACFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public EClanJoinState ClanJoinState;

		// Token: 0x0400ACFD RID: 44285
		[Token(Token = "0x400ACFD")]
		public const int MinClanLevel = 1;

		// Token: 0x0400ACFE RID: 44286
		[Token(Token = "0x400ACFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool m_HasInvitationToShow;

		// Token: 0x0400ACFF RID: 44287
		[Token(Token = "0x400ACFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private InviteToClanReq m_Inivtation;

		// Token: 0x0400AD00 RID: 44288
		[Token(Token = "0x400AD00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_HasRequestClanLuckyBagInfo;

		// Token: 0x0400AD01 RID: 44289
		[Token(Token = "0x400AD01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_LastRequestRefreshLuckyBagInfoTime;

		// Token: 0x0400AD02 RID: 44290
		[Token(Token = "0x400AD02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float m_RefreshLuckyBagInfoCoolDownTime;

		// Token: 0x0400AD03 RID: 44291
		[Token(Token = "0x400AD03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<ClanNews> m_MyClanNews;

		// Token: 0x0400AD04 RID: 44292
		[Token(Token = "0x400AD04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool m_HasReadApplyDeputyCaptainRedDot;

		// Token: 0x0400AD05 RID: 44293
		[Token(Token = "0x400AD05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool m_CanApplyDeputyCaptain;

		// Token: 0x0400AD06 RID: 44294
		[Token(Token = "0x400AD06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<proto.EClan.NewsType, string> newsTypeDict;

		// Token: 0x0400AD07 RID: 44295
		[Token(Token = "0x400AD07")]
		public const uint PropID_ClanListUpdate = 2U;

		// Token: 0x0400AD08 RID: 44296
		[Token(Token = "0x400AD08")]
		public const uint PropID_GetClanInfo = 4U;

		// Token: 0x0400AD09 RID: 44297
		[Token(Token = "0x400AD09")]
		public const uint PropID_MemberListUpdate = 8U;

		// Token: 0x0400AD0A RID: 44298
		[Token(Token = "0x400AD0A")]
		public const uint PropID_ClanApplicationUpdate = 16U;

		// Token: 0x0400AD0B RID: 44299
		[Token(Token = "0x400AD0B")]
		public const uint PropID_CreateClanSuccess = 32U;

		// Token: 0x0400AD0C RID: 44300
		[Token(Token = "0x400AD0C")]
		public const uint PropID_ClanJoinError = 64U;

		// Token: 0x0400AD0D RID: 44301
		[Token(Token = "0x400AD0D")]
		public const uint PropID_QuitClan = 128U;

		// Token: 0x0400AD0E RID: 44302
		[Token(Token = "0x400AD0E")]
		public const uint PropID_DismissClan = 256U;

		// Token: 0x0400AD0F RID: 44303
		[Token(Token = "0x400AD0F")]
		public const uint PropID_AcceptJoinClanSuccess = 512U;

		// Token: 0x0400AD10 RID: 44304
		[Token(Token = "0x400AD10")]
		public const uint PropID_ClanInfoUpdate = 1024U;

		// Token: 0x0400AD11 RID: 44305
		[Token(Token = "0x400AD11")]
		public const uint PropID_ApplyDeputyCaptainSuccess = 2048U;

		// Token: 0x0400AD12 RID: 44306
		[Token(Token = "0x400AD12")]
		public const uint PropID_CanApplyDeputyCaptain = 4096U;

		// Token: 0x0400AD13 RID: 44307
		[Token(Token = "0x400AD13")]
		public const uint PropID_DeputyCaptainFailed = 8192U;

		// Token: 0x0400AD14 RID: 44308
		[Token(Token = "0x400AD14")]
		public const uint PropID_NotifyErrorMessage = 1048576U;

		// Token: 0x0400AD15 RID: 44309
		[Token(Token = "0x400AD15")]
		public const uint PropID_NotifyNormalMessage = 2097152U;

		// Token: 0x0400AD16 RID: 44310
		[Token(Token = "0x400AD16")]
		public const uint PropID_Details = 4194304U;

		// Token: 0x0400AD17 RID: 44311
		[Token(Token = "0x400AD17")]
		public const uint PropID_ExtendScale = 8388608U;

		// Token: 0x0400AD18 RID: 44312
		[Token(Token = "0x400AD18")]
		public const uint PropID_GetSigninData = 16777216U;

		// Token: 0x0400AD19 RID: 44313
		[Token(Token = "0x400AD19")]
		public const uint PropID_SigninClaim = 33554432U;

		// Token: 0x0400AD1A RID: 44314
		[Token(Token = "0x400AD1A")]
		public const uint PropID_GetLuckyBagsInfo = 67108864U;

		// Token: 0x0400AD1B RID: 44315
		[Token(Token = "0x400AD1B")]
		public const uint PropID_DrawClanLuckyBag = 134217728U;

		// Token: 0x0400AD1C RID: 44316
		[Token(Token = "0x400AD1C")]
		public const uint PropID_GetClanNews = 268435456U;

		// Token: 0x0400AD1D RID: 44317
		[Token(Token = "0x400AD1D")]
		public const uint PropID_NotifyLuckyBag = 536870912U;

		// Token: 0x0400AD1E RID: 44318
		[Token(Token = "0x400AD1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly uint INVALUED_CLANID;

		// Token: 0x0400AD1F RID: 44319
		[Token(Token = "0x400AD1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private DayOfWeek m_CurrentDayWhenReceivedData;

		// Token: 0x0400AD20 RID: 44320
		[Token(Token = "0x400AD20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool m_HasGetCurrentSigninDataSinceLogin;

		// Token: 0x0400AD21 RID: 44321
		[Token(Token = "0x400AD21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool m_HasGetNextSigninDataSinceLogin;

		// Token: 0x0400AD22 RID: 44322
		[Token(Token = "0x400AD22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FEBC", Offset = "0x112FEBC")]
		private bool <HasGetMembersSinceLogin>k__BackingField;

		// Token: 0x0400AD23 RID: 44323
		[Token(Token = "0x400AD23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBF")]
		private bool m_HasActivityTriggerSinceLogin;

		// Token: 0x0400AD24 RID: 44324
		[Token(Token = "0x400AD24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<ulong> m_InRequestListBagID;

		// Token: 0x0400AD25 RID: 44325
		[Token(Token = "0x400AD25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public ulong m_FilterEndTimeStamp;

		// Token: 0x0400AD26 RID: 44326
		[Token(Token = "0x400AD26")]
		public const string DEFAULT_LABELSTRING = "TXT_BANNER_NAME_DEFAULT";

		// Token: 0x0400AD27 RID: 44327
		[Token(Token = "0x400AD27")]
		public const string CLAN_SETTING_NEW = "CLAN_SETTING_NEW";

		// Token: 0x0400AD28 RID: 44328
		[Token(Token = "0x400AD28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool AutoShowedLuckyBag;

		// Token: 0x0400AD29 RID: 44329
		[Token(Token = "0x400AD29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int m_NewLuckyBagCnt;

		// Token: 0x0400AD2A RID: 44330
		[Token(Token = "0x400AD2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<ClanMember> m_SelfTopClanMemberList;

		// Token: 0x0400AD2B RID: 44331
		[Token(Token = "0x400AD2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Dictionary<string, string> m_ErrorMsgDic;

		// Token: 0x02001DE8 RID: 7656
		[Token(Token = "0x2001DE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC1C4", Offset = "0x10FC1C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A7B5 RID: 42933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7B5")]
			[Address(RVA = "0x2109DA0", Offset = "0x2109DA0", VA = "0x7BBC909DA0")]
			public <>c()
			{
			}

			// Token: 0x0600A7B6 RID: 42934 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
			[Token(Token = "0x600A7B6")]
			[Address(RVA = "0x2109DA8", Offset = "0x2109DA8", VA = "0x7BBC909DA8")]
			internal bool <get_SelfTopClanMemberList>b__90_0(ClanMember temp)
			{
				return default(bool);
			}

			// Token: 0x0600A7B7 RID: 42935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7B7")]
			[Address(RVA = "0x2109E78", Offset = "0x2109E78", VA = "0x7BBC909E78")]
			internal void <InviteToClan>b__123_0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0600A7B8 RID: 42936 RVA: 0x0002D3D8 File Offset: 0x0002B5D8
			[Token(Token = "0x600A7B8")]
			[Address(RVA = "0x210A004", Offset = "0x210A004", VA = "0x7BBC90A004")]
			internal bool <RefreshMemberPresences>b__128_0(ClanMember a)
			{
				return default(bool);
			}

			// Token: 0x0600A7B9 RID: 42937 RVA: 0x0002D3F0 File Offset: 0x0002B5F0
			[Token(Token = "0x600A7B9")]
			[Address(RVA = "0x210A0E8", Offset = "0x210A0E8", VA = "0x7BBC90A0E8")]
			internal bool <GetMyClanMemeberInfo>b__177_0(ClanMember m)
			{
				return default(bool);
			}

			// Token: 0x0600A7BA RID: 42938 RVA: 0x0002D408 File Offset: 0x0002B608
			[Token(Token = "0x600A7BA")]
			[Address(RVA = "0x210A1B8", Offset = "0x210A1B8", VA = "0x7BBC90A1B8")]
			internal bool <FindDeputyCaptain>b__178_0(ClanMember m)
			{
				return default(bool);
			}

			// Token: 0x0400AD2C RID: 44332
			[Token(Token = "0x400AD2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelClan.<>c <>9;

			// Token: 0x0400AD2D RID: 44333
			[Token(Token = "0x400AD2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<ClanMember> <>9__90_0;

			// Token: 0x0400AD2E RID: 44334
			[Token(Token = "0x400AD2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<HttpErrorCode, object> <>9__123_0;

			// Token: 0x0400AD2F RID: 44335
			[Token(Token = "0x400AD2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<ClanMember, bool> <>9__128_0;

			// Token: 0x0400AD30 RID: 44336
			[Token(Token = "0x400AD30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<ClanMember> <>9__177_0;

			// Token: 0x0400AD31 RID: 44337
			[Token(Token = "0x400AD31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<ClanMember> <>9__178_0;
		}

		// Token: 0x02001DE9 RID: 7657
		[Token(Token = "0x2001DE9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC1D4", Offset = "0x10FC1D4")]
		private sealed class <>c__DisplayClass119_0
		{
			// Token: 0x0600A7BB RID: 42939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7BB")]
			[Address(RVA = "0x2102168", Offset = "0x2102168", VA = "0x7BBC902168")]
			public <>c__DisplayClass119_0()
			{
			}

			// Token: 0x0600A7BC RID: 42940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7BC")]
			[Address(RVA = "0x210A1EC", Offset = "0x210A1EC", VA = "0x7BBC90A1EC")]
			internal void <RequestApplyForJoinClan>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD32 RID: 44338
			[Token(Token = "0x400AD32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelClan <>4__this;

			// Token: 0x0400AD33 RID: 44339
			[Token(Token = "0x400AD33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong clanid;
		}

		// Token: 0x02001DEA RID: 7658
		[Token(Token = "0x2001DEA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC1E4", Offset = "0x10FC1E4")]
		private sealed class <>c__DisplayClass120_0
		{
			// Token: 0x0600A7BD RID: 42941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7BD")]
			[Address(RVA = "0x21024BC", Offset = "0x21024BC", VA = "0x7BBC9024BC")]
			public <>c__DisplayClass120_0()
			{
			}

			// Token: 0x0600A7BE RID: 42942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7BE")]
			[Address(RVA = "0x210A288", Offset = "0x210A288", VA = "0x7BBC90A288")]
			internal void <RequestCreateClan>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD34 RID: 44340
			[Token(Token = "0x400AD34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool sendRecruitToWorld;

			// Token: 0x0400AD35 RID: 44341
			[Token(Token = "0x400AD35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x0400AD36 RID: 44342
			[Token(Token = "0x400AD36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string slogan;

			// Token: 0x0400AD37 RID: 44343
			[Token(Token = "0x400AD37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public uint entry_type;

			// Token: 0x0400AD38 RID: 44344
			[Token(Token = "0x400AD38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public uint entry_level;

			// Token: 0x0400AD39 RID: 44345
			[Token(Token = "0x400AD39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public uint entry_rank;

			// Token: 0x0400AD3A RID: 44346
			[Token(Token = "0x400AD3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public UIModelClan <>4__this;
		}

		// Token: 0x02001DEB RID: 7659
		[Token(Token = "0x2001DEB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC1F4", Offset = "0x10FC1F4")]
		private sealed class <>c__DisplayClass121_0
		{
			// Token: 0x0600A7BF RID: 42943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7BF")]
			[Address(RVA = "0x2102BC0", Offset = "0x2102BC0", VA = "0x7BBC902BC0")]
			public <>c__DisplayClass121_0()
			{
			}

			// Token: 0x0600A7C0 RID: 42944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7C0")]
			[Address(RVA = "0x210A714", Offset = "0x210A714", VA = "0x7BBC90A714")]
			internal void <OperateClan>b__1(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0600A7C1 RID: 42945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7C1")]
			[Address(RVA = "0x210AC18", Offset = "0x210AC18", VA = "0x7BBC90AC18")]
			internal void <OperateClan>b__2(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD3B RID: 44347
			[Token(Token = "0x400AD3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelClan <>4__this;

			// Token: 0x0400AD3C RID: 44348
			[Token(Token = "0x400AD3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong playerid;

			// Token: 0x0400AD3D RID: 44349
			[Token(Token = "0x400AD3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EClanOperation operate;
		}

		// Token: 0x02001DEC RID: 7660
		[Token(Token = "0x2001DEC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC204", Offset = "0x10FC204")]
		private sealed class <>c__DisplayClass121_1
		{
			// Token: 0x0600A7C2 RID: 42946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7C2")]
			[Address(RVA = "0x2102BC8", Offset = "0x2102BC8", VA = "0x7BBC902BC8")]
			public <>c__DisplayClass121_1()
			{
			}

			// Token: 0x0600A7C3 RID: 42947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7C3")]
			[Address(RVA = "0x210AF8C", Offset = "0x210AF8C", VA = "0x7BBC90AF8C")]
			internal void <OperateClan>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD3E RID: 44350
			[Token(Token = "0x400AD3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CSChangeMemberTypeReq req;

			// Token: 0x0400AD3F RID: 44351
			[Token(Token = "0x400AD3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelClan.<>c__DisplayClass121_0 CS$<>8__locals1;
		}

		// Token: 0x02001DED RID: 7661
		[Token(Token = "0x2001DED")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC214", Offset = "0x10FC214")]
		private sealed class <>c__DisplayClass125_0
		{
			// Token: 0x0600A7C4 RID: 42948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7C4")]
			[Address(RVA = "0x210391C", Offset = "0x210391C", VA = "0x7BBC90391C")]
			public <>c__DisplayClass125_0()
			{
			}

			// Token: 0x0600A7C5 RID: 42949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7C5")]
			[Address(RVA = "0x210B448", Offset = "0x210B448", VA = "0x7BBC90B448")]
			internal void <RequestMemberList>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD40 RID: 44352
			[Token(Token = "0x400AD40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelClan <>4__this;

			// Token: 0x0400AD41 RID: 44353
			[Token(Token = "0x400AD41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool refreshPresent;

			// Token: 0x0400AD42 RID: 44354
			[Token(Token = "0x400AD42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] inviteData;
		}

		// Token: 0x02001DEE RID: 7662
		[Token(Token = "0x2001DEE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC224", Offset = "0x10FC224")]
		private sealed class <>c__DisplayClass128_0
		{
			// Token: 0x0600A7C6 RID: 42950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7C6")]
			[Address(RVA = "0x210432C", Offset = "0x210432C", VA = "0x7BBC90432C")]
			public <>c__DisplayClass128_0()
			{
			}

			// Token: 0x0400AD43 RID: 44355
			[Token(Token = "0x400AD43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PresenceListRes resData;
		}

		// Token: 0x02001DEF RID: 7663
		[Token(Token = "0x2001DEF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC234", Offset = "0x10FC234")]
		private sealed class <>c__DisplayClass128_1
		{
			// Token: 0x0600A7C7 RID: 42951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7C7")]
			[Address(RVA = "0x2104334", Offset = "0x2104334", VA = "0x7BBC904334")]
			public <>c__DisplayClass128_1()
			{
			}

			// Token: 0x0600A7C8 RID: 42952 RVA: 0x0002D420 File Offset: 0x0002B620
			[Token(Token = "0x600A7C8")]
			[Address(RVA = "0x210B81C", Offset = "0x210B81C", VA = "0x7BBC90B81C")]
			internal bool <RefreshMemberPresences>b__1(ClanMember x)
			{
				return default(bool);
			}

			// Token: 0x0400AD44 RID: 44356
			[Token(Token = "0x400AD44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400AD45 RID: 44357
			[Token(Token = "0x400AD45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelClan.<>c__DisplayClass128_0 CS$<>8__locals1;
		}

		// Token: 0x02001DF0 RID: 7664
		[Token(Token = "0x2001DF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC244", Offset = "0x10FC244")]
		private sealed class <>c__DisplayClass129_0
		{
			// Token: 0x0600A7C9 RID: 42953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7C9")]
			[Address(RVA = "0x2104698", Offset = "0x2104698", VA = "0x7BBC904698")]
			public <>c__DisplayClass129_0()
			{
			}

			// Token: 0x0600A7CA RID: 42954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7CA")]
			[Address(RVA = "0x210B8FC", Offset = "0x210B8FC", VA = "0x7BBC90B8FC")]
			internal void <ModifyClanInfo>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD46 RID: 44358
			[Token(Token = "0x400AD46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelClan <>4__this;

			// Token: 0x0400AD47 RID: 44359
			[Token(Token = "0x400AD47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string announcement;

			// Token: 0x0400AD48 RID: 44360
			[Token(Token = "0x400AD48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string slogan;

			// Token: 0x0400AD49 RID: 44361
			[Token(Token = "0x400AD49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public uint entryType;

			// Token: 0x0400AD4A RID: 44362
			[Token(Token = "0x400AD4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public uint areaId;

			// Token: 0x0400AD4B RID: 44363
			[Token(Token = "0x400AD4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public uint playStyle;

			// Token: 0x0400AD4C RID: 44364
			[Token(Token = "0x400AD4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public uint entry_level;

			// Token: 0x0400AD4D RID: 44365
			[Token(Token = "0x400AD4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public uint entry_rank;
		}

		// Token: 0x02001DF1 RID: 7665
		[Token(Token = "0x2001DF1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC254", Offset = "0x10FC254")]
		private sealed class <>c__DisplayClass130_0
		{
			// Token: 0x0600A7CB RID: 42955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7CB")]
			[Address(RVA = "0x21048A0", Offset = "0x21048A0", VA = "0x7BBC9048A0")]
			public <>c__DisplayClass130_0()
			{
			}

			// Token: 0x0600A7CC RID: 42956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7CC")]
			[Address(RVA = "0x210BAAC", Offset = "0x210BAAC", VA = "0x7BBC90BAAC")]
			internal void <ModifyClanName>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD4E RID: 44366
			[Token(Token = "0x400AD4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelClan <>4__this;

			// Token: 0x0400AD4F RID: 44367
			[Token(Token = "0x400AD4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;
		}

		// Token: 0x02001DF2 RID: 7666
		[Token(Token = "0x2001DF2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC264", Offset = "0x10FC264")]
		private sealed class <>c__DisplayClass133_0
		{
			// Token: 0x0600A7CD RID: 42957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7CD")]
			[Address(RVA = "0x2104FA0", Offset = "0x2104FA0", VA = "0x7BBC904FA0")]
			public <>c__DisplayClass133_0()
			{
			}

			// Token: 0x0600A7CE RID: 42958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7CE")]
			[Address(RVA = "0x210BD28", Offset = "0x210BD28", VA = "0x7BBC90BD28")]
			internal void <ProcessClanApplication>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD50 RID: 44368
			[Token(Token = "0x400AD50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelClan <>4__this;

			// Token: 0x0400AD51 RID: 44369
			[Token(Token = "0x400AD51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong playerid;
		}

		// Token: 0x02001DF3 RID: 7667
		[Token(Token = "0x2001DF3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC274", Offset = "0x10FC274")]
		private sealed class <>c__DisplayClass135_0
		{
			// Token: 0x0600A7CF RID: 42959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7CF")]
			[Address(RVA = "0x2105278", Offset = "0x2105278", VA = "0x7BBC905278")]
			public <>c__DisplayClass135_0()
			{
			}

			// Token: 0x0600A7D0 RID: 42960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7D0")]
			[Address(RVA = "0x210BFD4", Offset = "0x210BFD4", VA = "0x7BBC90BFD4")]
			internal void <ProcessClanInvitation>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD52 RID: 44370
			[Token(Token = "0x400AD52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong clanid;

			// Token: 0x0400AD53 RID: 44371
			[Token(Token = "0x400AD53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelClan <>4__this;
		}

		// Token: 0x02001DF4 RID: 7668
		[Token(Token = "0x2001DF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC284", Offset = "0x10FC284")]
		private sealed class <>c__DisplayClass143_0
		{
			// Token: 0x0600A7D1 RID: 42961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7D1")]
			[Address(RVA = "0x2105D58", Offset = "0x2105D58", VA = "0x7BBC905D58")]
			public <>c__DisplayClass143_0()
			{
			}

			// Token: 0x0600A7D2 RID: 42962 RVA: 0x0002D438 File Offset: 0x0002B638
			[Token(Token = "0x600A7D2")]
			[Address(RVA = "0x210C0DC", Offset = "0x210C0DC", VA = "0x7BBC90C0DC")]
			internal bool <HasSignInToday>b__0(ClanSignInRewardItem temp)
			{
				return default(bool);
			}

			// Token: 0x0400AD54 RID: 44372
			[Token(Token = "0x400AD54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint originDay;
		}

		// Token: 0x02001DF5 RID: 7669
		[Token(Token = "0x2001DF5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC294", Offset = "0x10FC294")]
		private sealed class <>c__DisplayClass147_0
		{
			// Token: 0x0600A7D3 RID: 42963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7D3")]
			[Address(RVA = "0x21060F0", Offset = "0x21060F0", VA = "0x7BBC9060F0")]
			public <>c__DisplayClass147_0()
			{
			}

			// Token: 0x0600A7D4 RID: 42964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7D4")]
			[Address(RVA = "0x210C128", Offset = "0x210C128", VA = "0x7BBC90C128")]
			internal void <SinginClaim>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD55 RID: 44373
			[Token(Token = "0x400AD55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelClan <>4__this;

			// Token: 0x0400AD56 RID: 44374
			[Token(Token = "0x400AD56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DayOfWeek day;
		}

		// Token: 0x02001DF6 RID: 7670
		[Token(Token = "0x2001DF6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC2A4", Offset = "0x10FC2A4")]
		private sealed class <>c__DisplayClass147_1
		{
			// Token: 0x0600A7D5 RID: 42965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7D5")]
			[Address(RVA = "0x210C364", Offset = "0x210C364", VA = "0x7BBC90C364")]
			public <>c__DisplayClass147_1()
			{
			}

			// Token: 0x0600A7D6 RID: 42966 RVA: 0x0002D450 File Offset: 0x0002B650
			[Token(Token = "0x600A7D6")]
			[Address(RVA = "0x210C36C", Offset = "0x210C36C", VA = "0x7BBC90C36C")]
			internal bool <SinginClaim>b__1(ClanSignInRewardItem temp)
			{
				return default(bool);
			}

			// Token: 0x0400AD57 RID: 44375
			[Token(Token = "0x400AD57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint originDay;
		}

		// Token: 0x02001DF7 RID: 7671
		[Token(Token = "0x2001DF7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC2B4", Offset = "0x10FC2B4")]
		private sealed class <>c__DisplayClass148_0
		{
			// Token: 0x0600A7D7 RID: 42967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7D7")]
			[Address(RVA = "0x21063AC", Offset = "0x21063AC", VA = "0x7BBC9063AC")]
			public <>c__DisplayClass148_0()
			{
			}

			// Token: 0x0600A7D8 RID: 42968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7D8")]
			[Address(RVA = "0x210C3B8", Offset = "0x210C3B8", VA = "0x7BBC90C3B8")]
			internal void <RequestClanLuckyBagsInfo>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD58 RID: 44376
			[Token(Token = "0x400AD58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelClan <>4__this;

			// Token: 0x0400AD59 RID: 44377
			[Token(Token = "0x400AD59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isRefreshRequest;
		}

		// Token: 0x02001DF8 RID: 7672
		[Token(Token = "0x2001DF8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC2C4", Offset = "0x10FC2C4")]
		private sealed class <>c__DisplayClass150_0
		{
			// Token: 0x0600A7D9 RID: 42969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7D9")]
			[Address(RVA = "0x21067AC", Offset = "0x21067AC", VA = "0x7BBC9067AC")]
			public <>c__DisplayClass150_0()
			{
			}

			// Token: 0x0600A7DA RID: 42970 RVA: 0x0002D468 File Offset: 0x0002B668
			[Token(Token = "0x600A7DA")]
			[Address(RVA = "0x210C680", Offset = "0x210C680", VA = "0x7BBC90C680")]
			internal bool <RequestDrawClanLuckyBag>b__0(ClanLuckyBag item)
			{
				return default(bool);
			}

			// Token: 0x0600A7DB RID: 42971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7DB")]
			[Address(RVA = "0x210C6BC", Offset = "0x210C6BC", VA = "0x7BBC90C6BC")]
			internal void <RequestDrawClanLuckyBag>b__1(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AD5A RID: 44378
			[Token(Token = "0x400AD5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong bag_id;

			// Token: 0x0400AD5B RID: 44379
			[Token(Token = "0x400AD5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelClan <>4__this;

			// Token: 0x0400AD5C RID: 44380
			[Token(Token = "0x400AD5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ClanLuckyBag luckyBag;
		}

		// Token: 0x02001DF9 RID: 7673
		[Token(Token = "0x2001DF9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC2D4", Offset = "0x10FC2D4")]
		private sealed class <>c__DisplayClass151_0
		{
			// Token: 0x0600A7DC RID: 42972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7DC")]
			[Address(RVA = "0x2106890", Offset = "0x2106890", VA = "0x7BBC906890")]
			public <>c__DisplayClass151_0()
			{
			}

			// Token: 0x0600A7DD RID: 42973 RVA: 0x0002D480 File Offset: 0x0002B680
			[Token(Token = "0x600A7DD")]
			[Address(RVA = "0x210D004", Offset = "0x210D004", VA = "0x7BBC90D004")]
			internal bool <IsDrawedLuckyBag>b__0(LuckyBagDraw item)
			{
				return default(bool);
			}

			// Token: 0x0400AD5D RID: 44381
			[Token(Token = "0x400AD5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong bag_id;
		}

		// Token: 0x02001DFA RID: 7674
		[Token(Token = "0x2001DFA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC2E4", Offset = "0x10FC2E4")]
		private sealed class <>c__DisplayClass158_0
		{
			// Token: 0x0600A7DE RID: 42974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7DE")]
			[Address(RVA = "0x21072E0", Offset = "0x21072E0", VA = "0x7BBC9072E0")]
			public <>c__DisplayClass158_0()
			{
			}

			// Token: 0x0600A7DF RID: 42975 RVA: 0x0002D498 File Offset: 0x0002B698
			[Token(Token = "0x600A7DF")]
			[Address(RVA = "0x210D040", Offset = "0x210D040", VA = "0x7BBC90D040")]
			internal bool <GetNewsStringFromNewsType>b__0(ClanMember m)
			{
				return default(bool);
			}

			// Token: 0x0400AD5E RID: 44382
			[Token(Token = "0x400AD5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong accountId;
		}

		// Token: 0x02001DFB RID: 7675
		[Token(Token = "0x2001DFB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC2F4", Offset = "0x10FC2F4")]
		private sealed class <>c__DisplayClass171_0
		{
			// Token: 0x0600A7E0 RID: 42976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7E0")]
			[Address(RVA = "0x2107988", Offset = "0x2107988", VA = "0x7BBC907988")]
			public <>c__DisplayClass171_0()
			{
			}

			// Token: 0x0600A7E1 RID: 42977 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
			[Token(Token = "0x600A7E1")]
			[Address(RVA = "0x210D08C", Offset = "0x210D08C", VA = "0x7BBC90D08C")]
			internal bool <FindClanMemberByID>b__0(ClanMember member)
			{
				return default(bool);
			}

			// Token: 0x0400AD5F RID: 44383
			[Token(Token = "0x400AD5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong accountID;
		}
	}
}
