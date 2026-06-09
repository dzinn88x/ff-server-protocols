using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015A1 RID: 5537
	[Token(Token = "0x20015A1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEE8C", Offset = "0x10EEE8C")]
	public class UIMallItemBaseController : UIEasyListItemController
	{
		// Token: 0x06006138 RID: 24888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006138")]
		[Address(RVA = "0x1DEA380", Offset = "0x1DEA380", VA = "0x7BBC5EA380", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006139")]
		[Address(RVA = "0x1DEA500", Offset = "0x1DEA500", VA = "0x7BBC5EA500", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600613A RID: 24890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613A")]
		[Address(RVA = "0x1DEA5CC", Offset = "0x1DEA5CC", VA = "0x7BBC5EA5CC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613B")]
		[Address(RVA = "0x1DEA5D4", Offset = "0x1DEA5D4", VA = "0x7BBC5EA5D4", Slot = "30")]
		public override void OnItemBtnClick2()
		{
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613C")]
		[Address(RVA = "0x1DEA72C", Offset = "0x1DEA72C", VA = "0x7BBC5EA72C", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613D")]
		[Address(RVA = "0x1DEAEF8", Offset = "0x1DEAEF8", VA = "0x7BBC5EAEF8", Slot = "34")]
		protected virtual void SendItemClickEvent()
		{
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613E")]
		[Address(RVA = "0x1DEAEFC", Offset = "0x1DEAEFC", VA = "0x7BBC5EAEFC", Slot = "35")]
		protected virtual void SendClothClickEvent()
		{
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613F")]
		[Address(RVA = "0x1DEAF00", Offset = "0x1DEAF00", VA = "0x7BBC5EAF00", Slot = "36")]
		protected virtual void OnClothItemClick()
		{
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006140")]
		[Address(RVA = "0x1DEB1A0", Offset = "0x1DEB1A0", VA = "0x7BBC5EB1A0", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006141")]
		[Address(RVA = "0x1DEB1D8", Offset = "0x1DEB1D8", VA = "0x7BBC5EB1D8", Slot = "37")]
		public virtual void SetHighLightBGState(bool show)
		{
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006142")]
		[Address(RVA = "0x1DEB210", Offset = "0x1DEB210", VA = "0x7BBC5EB210")]
		public void RefreshTag(EInventory.StoreTag tag_type, uint tag_value, ulong expireTime)
		{
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006143")]
		[Address(RVA = "0x1DEB474", Offset = "0x1DEB474", VA = "0x7BBC5EB474")]
		public void HideAllTag()
		{
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x0001C068 File Offset: 0x0001A268
		[Token(Token = "0x6006144")]
		[Address(RVA = "0x1DEB614", Offset = "0x1DEB614", VA = "0x7BBC5EB614", Slot = "38")]
		protected virtual bool CanShowDiscountTag()
		{
			return default(bool);
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006145")]
		[Address(RVA = "0x1DEB61C", Offset = "0x1DEB61C", VA = "0x7BBC5EB61C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006146")]
		[Address(RVA = "0x1DEB73C", Offset = "0x1DEB73C", VA = "0x7BBC5EB73C", Slot = "39")]
		protected virtual void RefreshItemView()
		{
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006147")]
		[Address(RVA = "0x1DEBB14", Offset = "0x1DEBB14", VA = "0x7BBC5EBB14", Slot = "40")]
		protected virtual void ResetState()
		{
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006148")]
		[Address(RVA = "0x1DEB8BC", Offset = "0x1DEB8BC", VA = "0x7BBC5EB8BC")]
		private void SetIPTag()
		{
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006149")]
		[Address(RVA = "0x1DEBB18", Offset = "0x1DEBB18", VA = "0x7BBC5EBB18")]
		protected void InitItemData(uint itemID)
		{
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614A")]
		[Address(RVA = "0x1DEB774", Offset = "0x1DEB774", VA = "0x7BBC5EB774")]
		protected void CheckItemABReady()
		{
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614B")]
		[Address(RVA = "0x1DEBDDC", Offset = "0x1DEBDDC", VA = "0x7BBC5EBDDC", Slot = "41")]
		protected virtual void SetLimitedTitleState()
		{
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614C")]
		[Address(RVA = "0x1DEBE84", Offset = "0x1DEBE84", VA = "0x7BBC5EBE84", Slot = "42")]
		protected virtual void SetUniquedTitleState()
		{
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614D")]
		[Address(RVA = "0x1DEBF44", Offset = "0x1DEBF44", VA = "0x7BBC5EBF44", Slot = "43")]
		protected virtual void SetPreviewTitle()
		{
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614E")]
		[Address(RVA = "0x1DEC108", Offset = "0x1DEC108", VA = "0x7BBC5EC108", Slot = "44")]
		protected virtual void RefreshItemBGState()
		{
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614F")]
		[Address(RVA = "0x1DEC1D4", Offset = "0x1DEC1D4", VA = "0x7BBC5EC1D4")]
		protected void SetWebTitleState()
		{
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006150")]
		[Address(RVA = "0x1DEC288", Offset = "0x1DEC288", VA = "0x7BBC5EC288", Slot = "45")]
		protected virtual void InitShowBoostAvatarParams()
		{
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x0001C080 File Offset: 0x0001A280
		[Token(Token = "0x6006151")]
		[Address(RVA = "0x1DEC338", Offset = "0x1DEC338", VA = "0x7BBC5EC338", Slot = "46")]
		protected virtual BoostState CheckBoostStateDelegate(uint itemID)
		{
			return BoostState.DontChange;
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006152")]
		[Address(RVA = "0x1DEC344", Offset = "0x1DEC344", VA = "0x7BBC5EC344")]
		private void AnimationEventHandler(params object[] data)
		{
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006153")]
		[Address(RVA = "0x1DEC58C", Offset = "0x1DEC58C", VA = "0x7BBC5EC58C", Slot = "47")]
		protected virtual void OnStartToggleMove()
		{
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006154")]
		[Address(RVA = "0x1DEC590", Offset = "0x1DEC590", VA = "0x7BBC5EC590", Slot = "48")]
		protected virtual void OnFinishToggleMove()
		{
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006155")]
		[Address(RVA = "0x1DEC594", Offset = "0x1DEC594", VA = "0x7BBC5EC594")]
		public UIMallItemBaseController()
		{
		}

		// Token: 0x0400810E RID: 33038
		[Token(Token = "0x400810E")]
		[FieldOffset(Offset = "0x70")]
		protected CSSharedItemData m_ItemData;

		// Token: 0x0400810F RID: 33039
		[Token(Token = "0x400810F")]
		[FieldOffset(Offset = "0x78")]
		protected UIModelMall m_ModelMall;

		// Token: 0x04008110 RID: 33040
		[Token(Token = "0x4008110")]
		[FieldOffset(Offset = "0x80")]
		protected UIModelGift m_ModelGift;

		// Token: 0x04008111 RID: 33041
		[Token(Token = "0x4008111")]
		[FieldOffset(Offset = "0x88")]
		protected UIModelRankingItem m_ModelRankingItem;

		// Token: 0x04008112 RID: 33042
		[Token(Token = "0x4008112")]
		[FieldOffset(Offset = "0x90")]
		protected UIModelLadderMatch m_LadderModel;

		// Token: 0x04008113 RID: 33043
		[Token(Token = "0x4008113")]
		[FieldOffset(Offset = "0x98")]
		protected CSSharedItemData m_EffectedItemData;

		// Token: 0x04008114 RID: 33044
		[Token(Token = "0x4008114")]
		[FieldOffset(Offset = "0xA0")]
		protected UIMallDetailBaseController m_ParentController;

		// Token: 0x04008115 RID: 33045
		[Token(Token = "0x4008115")]
		[FieldOffset(Offset = "0xA8")]
		protected FullScreenAnimParams m_AnimParams;

		// Token: 0x04008116 RID: 33046
		[Token(Token = "0x4008116")]
		[FieldOffset(Offset = "0xB0")]
		protected bool m_IsUniqueAndOwned;

		// Token: 0x04008117 RID: 33047
		[Token(Token = "0x4008117")]
		[FieldOffset(Offset = "0xB1")]
		protected bool m_HavePurchaseTimes;

		// Token: 0x04008118 RID: 33048
		[Token(Token = "0x4008118")]
		[FieldOffset(Offset = "0xB4")]
		protected uint m_ItemIconGrey;

		// Token: 0x04008119 RID: 33049
		[Token(Token = "0x4008119")]
		[FieldOffset(Offset = "0xB8")]
		protected uint m_ItemIconWhite;

		// Token: 0x0400811A RID: 33050
		[Token(Token = "0x400811A")]
		[FieldOffset(Offset = "0xBC")]
		protected bool m_NeedClearCache;

		// Token: 0x0400811B RID: 33051
		[Token(Token = "0x400811B")]
		[FieldOffset(Offset = "0xBD")]
		protected bool m_IsItemABReady;

		// Token: 0x0400811C RID: 33052
		[Token(Token = "0x400811C")]
		[FieldOffset(Offset = "0xBE")]
		protected bool m_ShowInstallmentInfo;

		// Token: 0x0400811D RID: 33053
		[Token(Token = "0x400811D")]
		[FieldOffset(Offset = "0xC0")]
		protected ShowBoostAvatarParams m_ShowBoostAvatarParams;

		// Token: 0x0400811E RID: 33054
		[Token(Token = "0x400811E")]
		[FieldOffset(Offset = "0xC8")]
		protected UIButton ItemBtn;

		// Token: 0x0400811F RID: 33055
		[Token(Token = "0x400811F")]
		[FieldOffset(Offset = "0xD0")]
		protected UIWidget ItemWidget;

		// Token: 0x04008120 RID: 33056
		[Token(Token = "0x4008120")]
		[FieldOffset(Offset = "0xD8")]
		protected GameObject NormalContainer;

		// Token: 0x04008121 RID: 33057
		[Token(Token = "0x4008121")]
		[FieldOffset(Offset = "0xE0")]
		protected BaseItemView BaseInfoView;

		// Token: 0x04008122 RID: 33058
		[Token(Token = "0x4008122")]
		[FieldOffset(Offset = "0xE8")]
		protected GameObject HighLightBG;

		// Token: 0x04008123 RID: 33059
		[Token(Token = "0x4008123")]
		[FieldOffset(Offset = "0xF0")]
		protected UISprite BG;

		// Token: 0x04008124 RID: 33060
		[Token(Token = "0x4008124")]
		[FieldOffset(Offset = "0xF8")]
		protected UISprite BGQualityLine;

		// Token: 0x04008125 RID: 33061
		[Token(Token = "0x4008125")]
		[FieldOffset(Offset = "0x100")]
		protected GameObject BG_grey;

		// Token: 0x04008126 RID: 33062
		[Token(Token = "0x4008126")]
		[FieldOffset(Offset = "0x108")]
		protected GameObject LimitedTitle;

		// Token: 0x04008127 RID: 33063
		[Token(Token = "0x4008127")]
		[FieldOffset(Offset = "0x110")]
		protected GameObject PreviewFemale;

		// Token: 0x04008128 RID: 33064
		[Token(Token = "0x4008128")]
		[FieldOffset(Offset = "0x118")]
		protected GameObject PreviewMale;

		// Token: 0x04008129 RID: 33065
		[Token(Token = "0x4008129")]
		[FieldOffset(Offset = "0x120")]
		protected UISprite Descargar;

		// Token: 0x0400812A RID: 33066
		[Token(Token = "0x400812A")]
		[FieldOffset(Offset = "0x128")]
		protected Transform GoldContainer;

		// Token: 0x0400812B RID: 33067
		[Token(Token = "0x400812B")]
		[FieldOffset(Offset = "0x130")]
		protected UILabel GoldPriceLabel;

		// Token: 0x0400812C RID: 33068
		[Token(Token = "0x400812C")]
		[FieldOffset(Offset = "0x138")]
		protected Transform DiamondContainer;

		// Token: 0x0400812D RID: 33069
		[Token(Token = "0x400812D")]
		[FieldOffset(Offset = "0x140")]
		protected UILabel DiamondPriceLabel;

		// Token: 0x0400812E RID: 33070
		[Token(Token = "0x400812E")]
		[FieldOffset(Offset = "0x148")]
		protected Transform ExchangeContainer;

		// Token: 0x0400812F RID: 33071
		[Token(Token = "0x400812F")]
		[FieldOffset(Offset = "0x150")]
		protected UILabel ExchangePriceLabel;

		// Token: 0x04008130 RID: 33072
		[Token(Token = "0x4008130")]
		[FieldOffset(Offset = "0x158")]
		protected UISprite ExchangeIcon;

		// Token: 0x04008131 RID: 33073
		[Token(Token = "0x4008131")]
		[FieldOffset(Offset = "0x160")]
		protected GameObject UniquedTitle;

		// Token: 0x04008132 RID: 33074
		[Token(Token = "0x4008132")]
		[FieldOffset(Offset = "0x168")]
		protected GameObject WebTitleContainer;

		// Token: 0x04008133 RID: 33075
		[Token(Token = "0x4008133")]
		[FieldOffset(Offset = "0x170")]
		protected UILabel DiscountTag;

		// Token: 0x04008134 RID: 33076
		[Token(Token = "0x4008134")]
		[FieldOffset(Offset = "0x178")]
		protected GameObject NewTag;

		// Token: 0x04008135 RID: 33077
		[Token(Token = "0x4008135")]
		[FieldOffset(Offset = "0x180")]
		protected GameObject HotTag;

		// Token: 0x04008136 RID: 33078
		[Token(Token = "0x4008136")]
		[FieldOffset(Offset = "0x188")]
		protected GameObject LimitTag;

		// Token: 0x04008137 RID: 33079
		[Token(Token = "0x4008137")]
		[FieldOffset(Offset = "0x190")]
		protected GameObject LimitCountTag;

		// Token: 0x04008138 RID: 33080
		[Token(Token = "0x4008138")]
		[FieldOffset(Offset = "0x198")]
		protected GameObject EarlyAccess;

		// Token: 0x04008139 RID: 33081
		[Token(Token = "0x4008139")]
		[FieldOffset(Offset = "0x1A0")]
		protected UISprite RankIcon;

		// Token: 0x0400813A RID: 33082
		[Token(Token = "0x400813A")]
		[FieldOffset(Offset = "0x1A8")]
		protected GameObject DefaultContainer;

		// Token: 0x0400813B RID: 33083
		[Token(Token = "0x400813B")]
		[FieldOffset(Offset = "0x1B0")]
		protected UILabel ClanLevelTitle;

		// Token: 0x0400813C RID: 33084
		[Token(Token = "0x400813C")]
		[FieldOffset(Offset = "0x1B8")]
		protected Transform ClanDiamondContainer;

		// Token: 0x0400813D RID: 33085
		[Token(Token = "0x400813D")]
		[FieldOffset(Offset = "0x1C0")]
		protected UILabel ClanDiamondPriceLabel;

		// Token: 0x0400813E RID: 33086
		[Token(Token = "0x400813E")]
		[FieldOffset(Offset = "0x1C8")]
		protected GameObject OverDueTitle;

		// Token: 0x0400813F RID: 33087
		[Token(Token = "0x400813F")]
		[FieldOffset(Offset = "0x1D0")]
		protected GameObject Default;

		// Token: 0x04008140 RID: 33088
		[Token(Token = "0x4008140")]
		[FieldOffset(Offset = "0x1D8")]
		protected UINetworkTexture NetworkTexture;

		// Token: 0x04008141 RID: 33089
		[Token(Token = "0x4008141")]
		[FieldOffset(Offset = "0x1E0")]
		protected UIGrid PriceContainer;

		// Token: 0x04008142 RID: 33090
		[Token(Token = "0x4008142")]
		[FieldOffset(Offset = "0x1E8")]
		protected UISprite IPTag;

		// Token: 0x04008143 RID: 33091
		[Token(Token = "0x4008143")]
		[FieldOffset(Offset = "0x1F0")]
		protected GameObject PreviewCommon;

		// Token: 0x04008144 RID: 33092
		[Token(Token = "0x4008144")]
		[FieldOffset(Offset = "0x1F8")]
		protected GameObject GemsAndGoldContainer;

		// Token: 0x04008145 RID: 33093
		[Token(Token = "0x4008145")]
		[FieldOffset(Offset = "0x200")]
		protected UILabel DualCurrencyGemsPrice;

		// Token: 0x04008146 RID: 33094
		[Token(Token = "0x4008146")]
		[FieldOffset(Offset = "0x208")]
		protected UILabel DualCurrencyGoldPrice;

		// Token: 0x04008147 RID: 33095
		[Token(Token = "0x4008147")]
		[FieldOffset(Offset = "0x210")]
		protected UILabel OriginalGemsPriceLabel;

		// Token: 0x04008148 RID: 33096
		[Token(Token = "0x4008148")]
		[FieldOffset(Offset = "0x218")]
		protected UILabel ExpireTime;
	}
}
