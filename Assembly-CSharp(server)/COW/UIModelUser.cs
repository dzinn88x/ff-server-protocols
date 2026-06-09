using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x0200201C RID: 8220
	[Token(Token = "0x200201C")]
	internal class UIModelUser : UIBaseModel
	{
		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x0600B70E RID: 46862 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B70F RID: 46863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C94")]
		public LoginRes UserLoginData
		{
			[Token(Token = "0x600B70E")]
			[Address(RVA = "0x22F3228", Offset = "0x22F3228", VA = "0x7BBCAF3228")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114767C", Offset = "0x114767C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B70F")]
			[Address(RVA = "0x230D6C8", Offset = "0x230D6C8", VA = "0x7BBCB0D6C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114768C", Offset = "0x114768C")]
			private set
			{
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x0600B710 RID: 46864 RVA: 0x00034398 File Offset: 0x00032598
		// (set) Token: 0x0600B711 RID: 46865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C95")]
		public ulong AccountID
		{
			[Token(Token = "0x600B710")]
			[Address(RVA = "0x230AFE0", Offset = "0x230AFE0", VA = "0x7BBCB0AFE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114769C", Offset = "0x114769C")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600B711")]
			[Address(RVA = "0x230D6D0", Offset = "0x230D6D0", VA = "0x7BBCB0D6D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11476AC", Offset = "0x11476AC")]
			private set
			{
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x0600B712 RID: 46866 RVA: 0x000343B0 File Offset: 0x000325B0
		// (set) Token: 0x0600B713 RID: 46867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C96")]
		public ulong RegisterTime
		{
			[Token(Token = "0x600B712")]
			[Address(RVA = "0x230D6D8", Offset = "0x230D6D8", VA = "0x7BBCB0D6D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11476BC", Offset = "0x11476BC")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600B713")]
			[Address(RVA = "0x230D6E0", Offset = "0x230D6E0", VA = "0x7BBCB0D6E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11476CC", Offset = "0x11476CC")]
			private set
			{
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x0600B714 RID: 46868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B715 RID: 46869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C97")]
		public string Nickname
		{
			[Token(Token = "0x600B714")]
			[Address(RVA = "0x230D6E8", Offset = "0x230D6E8", VA = "0x7BBCB0D6E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11476DC", Offset = "0x11476DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B715")]
			[Address(RVA = "0x230D6F0", Offset = "0x230D6F0", VA = "0x7BBCB0D6F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11476EC", Offset = "0x11476EC")]
			private set
			{
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x0600B716 RID: 46870 RVA: 0x000343C8 File Offset: 0x000325C8
		// (set) Token: 0x0600B717 RID: 46871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C98")]
		public uint Role
		{
			[Token(Token = "0x600B716")]
			[Address(RVA = "0x230D6F8", Offset = "0x230D6F8", VA = "0x7BBCB0D6F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11476FC", Offset = "0x11476FC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600B717")]
			[Address(RVA = "0x230D700", Offset = "0x230D700", VA = "0x7BBCB0D700")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114770C", Offset = "0x114770C")]
			private set
			{
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x0600B718 RID: 46872 RVA: 0x000343E0 File Offset: 0x000325E0
		// (set) Token: 0x0600B719 RID: 46873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C99")]
		public ulong ClanID
		{
			[Token(Token = "0x600B718")]
			[Address(RVA = "0x230D708", Offset = "0x230D708", VA = "0x7BBCB0D708")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114771C", Offset = "0x114771C")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600B719")]
			[Address(RVA = "0x230D710", Offset = "0x230D710", VA = "0x7BBCB0D710")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114772C", Offset = "0x114772C")]
			private set
			{
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x0600B71A RID: 46874 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B71B RID: 46875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9A")]
		public string ClanName
		{
			[Token(Token = "0x600B71A")]
			[Address(RVA = "0x230D718", Offset = "0x230D718", VA = "0x7BBCB0D718")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114773C", Offset = "0x114773C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B71B")]
			[Address(RVA = "0x230D720", Offset = "0x230D720", VA = "0x7BBCB0D720")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114774C", Offset = "0x114774C")]
			private set
			{
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x0600B71C RID: 46876 RVA: 0x000343F8 File Offset: 0x000325F8
		// (set) Token: 0x0600B71D RID: 46877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9B")]
		public uint UserCoins
		{
			[Token(Token = "0x600B71C")]
			[Address(RVA = "0x230D728", Offset = "0x230D728", VA = "0x7BBCB0D728")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114775C", Offset = "0x114775C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600B71D")]
			[Address(RVA = "0x230D730", Offset = "0x230D730", VA = "0x7BBCB0D730")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114776C", Offset = "0x114776C")]
			private set
			{
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600B71E RID: 46878 RVA: 0x00034410 File Offset: 0x00032610
		// (set) Token: 0x0600B71F RID: 46879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9C")]
		public int UserGems
		{
			[Token(Token = "0x600B71E")]
			[Address(RVA = "0x230D738", Offset = "0x230D738", VA = "0x7BBCB0D738")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B71F")]
			[Address(RVA = "0x230D740", Offset = "0x230D740", VA = "0x7BBCB0D740")]
			private set
			{
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600B720 RID: 46880 RVA: 0x00034428 File Offset: 0x00032628
		// (set) Token: 0x0600B721 RID: 46881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9D")]
		public uint UserLevel
		{
			[Token(Token = "0x600B720")]
			[Address(RVA = "0x230D748", Offset = "0x230D748", VA = "0x7BBCB0D748")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600B721")]
			[Address(RVA = "0x230D774", Offset = "0x230D774", VA = "0x7BBCB0D774")]
			private set
			{
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600B722 RID: 46882 RVA: 0x00034440 File Offset: 0x00032640
		// (set) Token: 0x0600B723 RID: 46883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9E")]
		public uint UserExp
		{
			[Token(Token = "0x600B722")]
			[Address(RVA = "0x230D8B4", Offset = "0x230D8B4", VA = "0x7BBCB0D8B4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600B723")]
			[Address(RVA = "0x230D8E0", Offset = "0x230D8E0", VA = "0x7BBCB0D8E0")]
			set
			{
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600B724 RID: 46884 RVA: 0x00034458 File Offset: 0x00032658
		[Token(Token = "0x17000C9F")]
		public proto.EAccount.NewbieChoice NewbieChoice
		{
			[Token(Token = "0x600B724")]
			[Address(RVA = "0x230D910", Offset = "0x230D910", VA = "0x7BBCB0D910")]
			get
			{
				return proto.EAccount.NewbieChoice.NewbieChoice_NONE;
			}
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B725")]
		[Address(RVA = "0x230D918", Offset = "0x230D918", VA = "0x7BBCB0D918")]
		public void SetNewbieChoice(proto.EAccount.NewbieChoice choice)
		{
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600B726 RID: 46886 RVA: 0x00034470 File Offset: 0x00032670
		// (set) Token: 0x0600B727 RID: 46887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA0")]
		public bool NeedShowLevelUpWindow
		{
			[Token(Token = "0x600B726")]
			[Address(RVA = "0x230D920", Offset = "0x230D920", VA = "0x7BBCB0D920")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B727")]
			[Address(RVA = "0x230D928", Offset = "0x230D928", VA = "0x7BBCB0D928")]
			set
			{
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x0600B728 RID: 46888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA1")]
		public List<RegionIDMapping> RegionList
		{
			[Token(Token = "0x600B728")]
			[Address(RVA = "0x230D934", Offset = "0x230D934", VA = "0x7BBCB0D934")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x0600B729 RID: 46889 RVA: 0x00034488 File Offset: 0x00032688
		// (set) Token: 0x0600B72A RID: 46890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA2")]
		public bool HasElitePass
		{
			[Token(Token = "0x600B729")]
			[Address(RVA = "0x230D93C", Offset = "0x230D93C", VA = "0x7BBCB0D93C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114777C", Offset = "0x114777C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B72A")]
			[Address(RVA = "0x230D944", Offset = "0x230D944", VA = "0x7BBCB0D944")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114778C", Offset = "0x114778C")]
			private set
			{
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600B72B RID: 46891 RVA: 0x000344A0 File Offset: 0x000326A0
		// (set) Token: 0x0600B72C RID: 46892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA3")]
		public uint BadgeItemId
		{
			[Token(Token = "0x600B72B")]
			[Address(RVA = "0x230D950", Offset = "0x230D950", VA = "0x7BBCB0D950")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114779C", Offset = "0x114779C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600B72C")]
			[Address(RVA = "0x230D958", Offset = "0x230D958", VA = "0x7BBCB0D958")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11477AC", Offset = "0x11477AC")]
			private set
			{
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600B72D RID: 46893 RVA: 0x000344B8 File Offset: 0x000326B8
		// (set) Token: 0x0600B72E RID: 46894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA4")]
		public uint BadgeItemCount
		{
			[Token(Token = "0x600B72D")]
			[Address(RVA = "0x230D960", Offset = "0x230D960", VA = "0x7BBCB0D960")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11477BC", Offset = "0x11477BC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600B72E")]
			[Address(RVA = "0x230D968", Offset = "0x230D968", VA = "0x7BBCB0D968")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11477CC", Offset = "0x11477CC")]
			private set
			{
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x0600B72F RID: 46895 RVA: 0x000344D0 File Offset: 0x000326D0
		// (set) Token: 0x0600B730 RID: 46896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA5")]
		public uint EmulatorScore
		{
			[Token(Token = "0x600B72F")]
			[Address(RVA = "0x230D970", Offset = "0x230D970", VA = "0x7BBCB0D970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11477DC", Offset = "0x11477DC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600B730")]
			[Address(RVA = "0x230D978", Offset = "0x230D978", VA = "0x7BBCB0D978")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11477EC", Offset = "0x11477EC")]
			set
			{
			}
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x000344E8 File Offset: 0x000326E8
		[Token(Token = "0x600B731")]
		[Address(RVA = "0x230D980", Offset = "0x230D980", VA = "0x7BBCB0D980", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x00034500 File Offset: 0x00032700
		[Token(Token = "0x600B732")]
		[Address(RVA = "0x230D988", Offset = "0x230D988", VA = "0x7BBCB0D988")]
		public bool IsLogin()
		{
			return default(bool);
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x00034518 File Offset: 0x00032718
		[Token(Token = "0x600B733")]
		[Address(RVA = "0x230D9F8", Offset = "0x230D9F8", VA = "0x7BBCB0D9F8")]
		public byte GetRegionIDByName(string regionName)
		{
			return 0;
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B734")]
		[Address(RVA = "0x230DBBC", Offset = "0x230DBBC", VA = "0x7BBCB0DBBC", Slot = "7")]
		public override void LoginOffline()
		{
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B735")]
		[Address(RVA = "0x230DC44", Offset = "0x230DC44", VA = "0x7BBCB0DC44", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B736")]
		[Address(RVA = "0x230E4C8", Offset = "0x230E4C8", VA = "0x7BBCB0E4C8")]
		public void UpdateLevelUpInfo(AccountLevelUpInfo levelUpInfo)
		{
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B737")]
		[Address(RVA = "0x230E7AC", Offset = "0x230E7AC", VA = "0x7BBCB0E7AC")]
		public void AfterMatch(MatchIncome inData)
		{
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B738")]
		[Address(RVA = "0x230E8C0", Offset = "0x230E8C0", VA = "0x7BBCB0E8C0")]
		public void AfterQuestBackpack(AccountWallet wData)
		{
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B739")]
		[Address(RVA = "0x230E944", Offset = "0x230E944", VA = "0x7BBCB0E944")]
		public void RefreshUserResource(uint coins, int gems)
		{
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B73A")]
		[Address(RVA = "0x230EA38", Offset = "0x230EA38", VA = "0x7BBCB0EA38")]
		public void RefreshUserResourceByDeltaValue(int deltaCoins, int deltaGem)
		{
		}

		// Token: 0x0600B73B RID: 46907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B73B")]
		[Address(RVA = "0x230EA48", Offset = "0x230EA48", VA = "0x7BBCB0EA48")]
		public void SetClanID(ulong clanid)
		{
		}

		// Token: 0x0600B73C RID: 46908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B73C")]
		[Address(RVA = "0x230EF64", Offset = "0x230EF64", VA = "0x7BBCB0EF64")]
		public void UserRename(string new_name, bool useCard)
		{
		}

		// Token: 0x0600B73D RID: 46909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B73D")]
		[Address(RVA = "0x230F10C", Offset = "0x230F10C", VA = "0x7BBCB0F10C")]
		public void ReqNewbieChoose(proto.EAccount.NewbieChoice choice)
		{
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B73E")]
		[Address(RVA = "0x230F318", Offset = "0x230F318", VA = "0x7BBCB0F318")]
		public void CheckCdKey(string email, string key)
		{
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B73F")]
		[Address(RVA = "0x230F530", Offset = "0x230F530", VA = "0x7BBCB0F530")]
		public void UpdateUserRole(AccountRoleInfo roleInfo)
		{
		}

		// Token: 0x0600B740 RID: 46912 RVA: 0x00034530 File Offset: 0x00032730
		[Token(Token = "0x600B740")]
		[Address(RVA = "0x230F79C", Offset = "0x230F79C", VA = "0x7BBCB0F79C")]
		public int GetUserGameDays()
		{
			return 0;
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B741")]
		[Address(RVA = "0x230E324", Offset = "0x230E324", VA = "0x7BBCB0E324")]
		private void ResizeResolutionByRegion(string region)
		{
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B742")]
		[Address(RVA = "0x230F888", Offset = "0x230F888", VA = "0x7BBCB0F888")]
		public string GetAccountIdEnc()
		{
			return null;
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B743")]
		[Address(RVA = "0x230F900", Offset = "0x230F900", VA = "0x7BBCB0F900")]
		private string GetAccountIdEnc(int idx)
		{
			return null;
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B744")]
		[Address(RVA = "0x230FDB4", Offset = "0x230FDB4", VA = "0x7BBCB0FDB4")]
		private string GetDynamicKey(int idx)
		{
			return null;
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x00034548 File Offset: 0x00032748
		[Token(Token = "0x600B745")]
		[Address(RVA = "0x230FFD8", Offset = "0x230FFD8", VA = "0x7BBCB0FFD8")]
		public bool IsNeedAutoMatchForNewbie()
		{
			return default(bool);
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B746")]
		[Address(RVA = "0x231004C", Offset = "0x231004C", VA = "0x7BBCB1004C")]
		public UIModelUser()
		{
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B747")]
		[Address(RVA = "0x23100DC", Offset = "0x23100DC", VA = "0x7BBCB100DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11477FC", Offset = "0x11477FC")]
		private void <UserRename>b__90_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B748")]
		[Address(RVA = "0x2310548", Offset = "0x2310548", VA = "0x7BBCB10548")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114780C", Offset = "0x114780C")]
		private void <CheckCdKey>b__92_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0400B955 RID: 47445
		[Token(Token = "0x400B955")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113074C", Offset = "0x113074C")]
		private LoginRes <UserLoginData>k__BackingField;

		// Token: 0x0400B956 RID: 47446
		[Token(Token = "0x400B956")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113075C", Offset = "0x113075C")]
		private ulong <AccountID>k__BackingField;

		// Token: 0x0400B957 RID: 47447
		[Token(Token = "0x400B957")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113076C", Offset = "0x113076C")]
		private ulong <RegisterTime>k__BackingField;

		// Token: 0x0400B958 RID: 47448
		[Token(Token = "0x400B958")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113077C", Offset = "0x113077C")]
		private string <Nickname>k__BackingField;

		// Token: 0x0400B959 RID: 47449
		[Token(Token = "0x400B959")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113078C", Offset = "0x113078C")]
		private uint <Role>k__BackingField;

		// Token: 0x0400B95A RID: 47450
		[Token(Token = "0x400B95A")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113079C", Offset = "0x113079C")]
		private ulong <ClanID>k__BackingField;

		// Token: 0x0400B95B RID: 47451
		[Token(Token = "0x400B95B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11307AC", Offset = "0x11307AC")]
		private string <ClanName>k__BackingField;

		// Token: 0x0400B95C RID: 47452
		[Token(Token = "0x400B95C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11307BC", Offset = "0x11307BC")]
		private uint <UserCoins>k__BackingField;

		// Token: 0x0400B95D RID: 47453
		[Token(Token = "0x400B95D")]
		[FieldOffset(Offset = "0x54")]
		private int m_UserGems;

		// Token: 0x0400B95E RID: 47454
		[Token(Token = "0x400B95E")]
		[FieldOffset(Offset = "0x58")]
		private proto.EAccount.NewbieChoice m_NewbieChoice;

		// Token: 0x0400B95F RID: 47455
		[Token(Token = "0x400B95F")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_NeedShowLevelUpWindow;

		// Token: 0x0400B960 RID: 47456
		[Token(Token = "0x400B960")]
		[FieldOffset(Offset = "0x60")]
		private List<RegionIDMapping> m_RegionList;

		// Token: 0x0400B961 RID: 47457
		[Token(Token = "0x400B961")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11307CC", Offset = "0x11307CC")]
		private bool <HasElitePass>k__BackingField;

		// Token: 0x0400B962 RID: 47458
		[Token(Token = "0x400B962")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11307DC", Offset = "0x11307DC")]
		private uint <BadgeItemId>k__BackingField;

		// Token: 0x0400B963 RID: 47459
		[Token(Token = "0x400B963")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11307EC", Offset = "0x11307EC")]
		private uint <BadgeItemCount>k__BackingField;

		// Token: 0x0400B964 RID: 47460
		[Token(Token = "0x400B964")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11307FC", Offset = "0x11307FC")]
		private uint <EmulatorScore>k__BackingField;

		// Token: 0x0400B965 RID: 47461
		[Token(Token = "0x400B965")]
		public const uint PropID_ResourceUpdate = 2U;

		// Token: 0x0400B966 RID: 47462
		[Token(Token = "0x400B966")]
		public const uint PropID_UserProfileUpdate = 4U;

		// Token: 0x0400B967 RID: 47463
		[Token(Token = "0x400B967")]
		public const uint PropID_UserRenameError = 8U;

		// Token: 0x0400B968 RID: 47464
		[Token(Token = "0x400B968")]
		public const uint PropID_UserRenameSuccess = 16U;

		// Token: 0x0400B969 RID: 47465
		[Token(Token = "0x400B969")]
		public const uint PropID_UserLevelUp = 32U;

		// Token: 0x0400B96A RID: 47466
		[Token(Token = "0x400B96A")]
		public const uint PropID_CheckCdKeyError = 64U;

		// Token: 0x0400B96B RID: 47467
		[Token(Token = "0x400B96B")]
		public const uint PropID_CheckEmailError = 128U;

		// Token: 0x0400B96C RID: 47468
		[Token(Token = "0x400B96C")]
		public const uint PropID_CheckCdKeySuccess = 256U;

		// Token: 0x0400B96D RID: 47469
		[Token(Token = "0x400B96D")]
		private const string CharacterSet = "a0bcdefg1hjkm2npqrs3tuv456789wxy";

		// Token: 0x0400B96E RID: 47470
		[Token(Token = "0x400B96E")]
		private const string EncKey = "QDENCRYPTKEY";

		// Token: 0x0200201D RID: 8221
		[Token(Token = "0x200201D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD7D4", Offset = "0x10FD7D4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B74A RID: 46922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B74A")]
			[Address(RVA = "0x14BBF98", Offset = "0x14BBF98", VA = "0x7BBBCBBF98")]
			public <>c()
			{
			}

			// Token: 0x0600B74B RID: 46923 RVA: 0x00034560 File Offset: 0x00032760
			[Token(Token = "0x600B74B")]
			[Address(RVA = "0x14BBFA0", Offset = "0x14BBFA0", VA = "0x7BBBCBBFA0")]
			internal DisconnectedReason <Login>b__83_0(TCPMsgPacket packet)
			{
				return DisconnectedReason.Unknown;
			}

			// Token: 0x0400B96F RID: 47471
			[Token(Token = "0x400B96F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelUser.<>c <>9;

			// Token: 0x0400B970 RID: 47472
			[Token(Token = "0x400B970")]
			[FieldOffset(Offset = "0x8")]
			public static TCPParameters.KickByServerMsgDeserializer <>9__83_0;
		}

		// Token: 0x0200201E RID: 8222
		[Token(Token = "0x200201E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD7E4", Offset = "0x10FD7E4")]
		private sealed class <>c__DisplayClass91_0
		{
			// Token: 0x0600B74C RID: 46924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B74C")]
			[Address(RVA = "0x14BC3B8", Offset = "0x14BC3B8", VA = "0x7BBBCBC3B8")]
			public <>c__DisplayClass91_0()
			{
			}

			// Token: 0x0600B74D RID: 46925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B74D")]
			[Address(RVA = "0x14BC3C0", Offset = "0x14BC3C0", VA = "0x7BBBCBC3C0")]
			internal void <ReqNewbieChoose>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400B971 RID: 47473
			[Token(Token = "0x400B971")]
			[FieldOffset(Offset = "0x10")]
			public UIModelUser <>4__this;

			// Token: 0x0400B972 RID: 47474
			[Token(Token = "0x400B972")]
			[FieldOffset(Offset = "0x18")]
			public proto.EAccount.NewbieChoice choice;
		}
	}
}
