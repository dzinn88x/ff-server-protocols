using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020014A8 RID: 5288
	[Token(Token = "0x20014A8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED4CC", Offset = "0x10ED4CC")]
	public class UIChampionshipWarmUpController : UINavigationController
	{
		// Token: 0x060059B0 RID: 22960 RVA: 0x0001A610 File Offset: 0x00018810
		[Token(Token = "0x60059B0")]
		[Address(RVA = "0x1EDD518", Offset = "0x1EDD518", VA = "0x7BBC6DD518")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x0001A628 File Offset: 0x00018828
		[Token(Token = "0x60059B1")]
		[Address(RVA = "0x1EDD568", Offset = "0x1EDD568", VA = "0x7BBC6DD568", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B2")]
		[Address(RVA = "0x1EDD570", Offset = "0x1EDD570", VA = "0x7BBC6DD570", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0x1EDD794", Offset = "0x1EDD794", VA = "0x7BBC6DD794")]
		private void SetView()
		{
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x1EDDC58", Offset = "0x1EDDC58", VA = "0x7BBC6DDC58")]
		protected void RefreshCupIcon()
		{
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B5")]
		[Address(RVA = "0x1EDDDFC", Offset = "0x1EDDDFC", VA = "0x7BBC6DDDFC")]
		protected void OnBtnRuleClick()
		{
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B6")]
		[Address(RVA = "0x1EDDEB0", Offset = "0x1EDDEB0", VA = "0x7BBC6DDEB0")]
		public UIChampionshipWarmUpController()
		{
		}

		// Token: 0x04007D15 RID: 32021
		[Token(Token = "0x4007D15")]
		[FieldOffset(Offset = "0xB0")]
		private UIChampionshipWarmUpView m_View;

		// Token: 0x04007D16 RID: 32022
		[Token(Token = "0x4007D16")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007D17 RID: 32023
		[Token(Token = "0x4007D17")]
		[FieldOffset(Offset = "0xC0")]
		private ChampionshipSettingDesc m_ChampionshipSettingInfo;

		// Token: 0x04007D18 RID: 32024
		[Token(Token = "0x4007D18")]
		[FieldOffset(Offset = "0xC8")]
		private MapOpeningInfo m_MapInfo;

		// Token: 0x04007D19 RID: 32025
		[Token(Token = "0x4007D19")]
		[FieldOffset(Offset = "0xD0")]
		private ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;
	}
}
