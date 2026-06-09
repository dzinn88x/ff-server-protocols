using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001663 RID: 5731
	[Token(Token = "0x2001663")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F001C", Offset = "0x10F001C")]
	internal class UIHUDTeamBattleScoreBoardItemController : UIBaseController
	{
		// Token: 0x060067A3 RID: 26531 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
		[Token(Token = "0x60067A3")]
		[Address(RVA = "0x1D4D978", Offset = "0x1D4D978", VA = "0x7BBC54D978")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060067A4 RID: 26532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000911")]
		protected List<EMatchResultPlayerInfoType> InfoTypeList
		{
			[Token(Token = "0x60067A4")]
			[Address(RVA = "0x1D4D9C8", Offset = "0x1D4D9C8", VA = "0x7BBC54D9C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067A5")]
		[Address(RVA = "0x1D4DA3C", Offset = "0x1D4DA3C", VA = "0x7BBC54DA3C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067A6")]
		[Address(RVA = "0x1D4DC98", Offset = "0x1D4DC98", VA = "0x7BBC54DC98", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067A7")]
		[Address(RVA = "0x1D4DD64", Offset = "0x1D4DD64", VA = "0x7BBC54DD64")]
		public void InitData(List<EMatchResultPlayerInfoType> list, Player player, bool isLocalSelf)
		{
		}

		// Token: 0x060067A8 RID: 26536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067A8")]
		[Address(RVA = "0x1D4E1C8", Offset = "0x1D4E1C8", VA = "0x7BBC54E1C8", Slot = "28")]
		protected virtual void OnInitData(Player player)
		{
		}

		// Token: 0x060067A9 RID: 26537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067A9")]
		[Address(RVA = "0x1D4E18C", Offset = "0x1D4E18C", VA = "0x7BBC54E18C")]
		public void ShowSelf(bool isShow)
		{
		}

		// Token: 0x060067AA RID: 26538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067AA")]
		[Address(RVA = "0x1D4E0FC", Offset = "0x1D4E0FC", VA = "0x7BBC54E0FC")]
		public void RefreshData(Player player)
		{
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067AB")]
		[Address(RVA = "0x1D4E83C", Offset = "0x1D4E83C", VA = "0x7BBC54E83C")]
		public void RefreshData(int index, string msg)
		{
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067AC")]
		[Address(RVA = "0x1D4DE24", Offset = "0x1D4DE24", VA = "0x7BBC54DE24")]
		public void SetInfoTypeList(List<EMatchResultPlayerInfoType> list)
		{
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067AD")]
		[Address(RVA = "0x1D4DE2C", Offset = "0x1D4DE2C", VA = "0x7BBC54DE2C")]
		public void SetIsSelf(bool isSelf)
		{
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067AE")]
		[Address(RVA = "0x1D4DEFC", Offset = "0x1D4DEFC", VA = "0x7BBC54DEFC")]
		private void SetDeadBG(bool isDead)
		{
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067AF")]
		[Address(RVA = "0x1D4DF44", Offset = "0x1D4DF44", VA = "0x7BBC54DF44")]
		private void InitInfoTxtByType()
		{
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B0")]
		[Address(RVA = "0x1D4E968", Offset = "0x1D4E968", VA = "0x7BBC54E968", Slot = "29")]
		protected virtual void UpdatePlayerData(Player player)
		{
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B1")]
		[Address(RVA = "0x1D4E1CC", Offset = "0x1D4E1CC", VA = "0x7BBC54E1CC")]
		private void UpdateInfoData(UILabel infoTxt, Player player, int index)
		{
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B2")]
		[Address(RVA = "0x1D4EEA8", Offset = "0x1D4EEA8", VA = "0x7BBC54EEA8", Slot = "30")]
		protected virtual void OnKillChange(int kill)
		{
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B3")]
		[Address(RVA = "0x1D4EEAC", Offset = "0x1D4EEAC", VA = "0x7BBC54EEAC", Slot = "31")]
		protected virtual void OnDeadChange(int dead)
		{
		}

		// Token: 0x060067B4 RID: 26548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B4")]
		[Address(RVA = "0x1D4EEB0", Offset = "0x1D4EEB0", VA = "0x7BBC54EEB0", Slot = "32")]
		protected virtual void OnDamageChange(uint damage)
		{
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B5")]
		[Address(RVA = "0x1D4EEB4", Offset = "0x1D4EEB4", VA = "0x7BBC54EEB4")]
		private void OnPlayerAliveStateChanged(params object[] data)
		{
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B6")]
		[Address(RVA = "0x1D4F05C", Offset = "0x1D4F05C", VA = "0x7BBC54F05C")]
		public UIHUDTeamBattleScoreBoardItemController()
		{
		}

		// Token: 0x040084DD RID: 34013
		[Token(Token = "0x40084DD")]
		[FieldOffset(Offset = "0x58")]
		protected TeamScoreBoardItemView m_View;

		// Token: 0x040084DE RID: 34014
		[Token(Token = "0x40084DE")]
		[FieldOffset(Offset = "0x60")]
		protected Player m_Player;

		// Token: 0x040084DF RID: 34015
		[Token(Token = "0x40084DF")]
		[FieldOffset(Offset = "0x68")]
		private List<UILabel> m_InfoLabelList;

		// Token: 0x040084E0 RID: 34016
		[Token(Token = "0x40084E0")]
		[FieldOffset(Offset = "0x70")]
		private List<EMatchResultPlayerInfoType> m_InfoTypeList;
	}
}
