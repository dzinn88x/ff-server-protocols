using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001724 RID: 5924
	[Token(Token = "0x2001724")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F18DC", Offset = "0x10F18DC")]
	public class UIClanCreateController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06006EAC RID: 28332 RVA: 0x0001F230 File Offset: 0x0001D430
		[Token(Token = "0x6006EAC")]
		[Address(RVA = "0x1CF7BF0", Offset = "0x1CF7BF0", VA = "0x7BBC4F7BF0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAD")]
		[Address(RVA = "0x1CF7C40", Offset = "0x1CF7C40", VA = "0x7BBC4F7C40", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAE")]
		[Address(RVA = "0x1CF8608", Offset = "0x1CF8608", VA = "0x7BBC4F8608", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAF")]
		[Address(RVA = "0x1CF86BC", Offset = "0x1CF86BC", VA = "0x7BBC4F86BC")]
		private void OnCoinBtnClick()
		{
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB0")]
		[Address(RVA = "0x1CF9114", Offset = "0x1CF9114", VA = "0x7BBC4F9114")]
		private void OnGemBtnClick()
		{
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB1")]
		[Address(RVA = "0x1CF9208", Offset = "0x1CF9208", VA = "0x7BBC4F9208")]
		private void OnChangeAudit()
		{
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB2")]
		[Address(RVA = "0x1CF92B4", Offset = "0x1CF92B4", VA = "0x7BBC4F92B4")]
		private void RefreshDefault()
		{
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB3")]
		[Address(RVA = "0x1CF93E8", Offset = "0x1CF93E8", VA = "0x7BBC4F93E8")]
		private void OnClickApprovalCondLevel()
		{
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB4")]
		[Address(RVA = "0x1CF9648", Offset = "0x1CF9648", VA = "0x7BBC4F9648")]
		private void OnClickApprovalCondRank()
		{
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB5")]
		[Address(RVA = "0x1CF98A8", Offset = "0x1CF98A8", VA = "0x7BBC4F98A8")]
		private void OnClickArea()
		{
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB6")]
		[Address(RVA = "0x1CF9A9C", Offset = "0x1CF9A9C", VA = "0x7BBC4F9A9C")]
		private void OnClickTag()
		{
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB7")]
		[Address(RVA = "0x1CF87B0", Offset = "0x1CF87B0", VA = "0x7BBC4F87B0")]
		private void OnBtnConfirmClick()
		{
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB8")]
		[Address(RVA = "0x1CF9C90", Offset = "0x1CF9C90", VA = "0x7BBC4F9C90", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x0001F248 File Offset: 0x0001D448
		[Token(Token = "0x6006EB9")]
		[Address(RVA = "0x1CF9D0C", Offset = "0x1CF9D0C", VA = "0x7BBC4F9D0C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBA")]
		[Address(RVA = "0x1CF8430", Offset = "0x1CF8430", VA = "0x7BBC4F8430")]
		private void RefreshPriceBtnState(int coinCost, int ownedCoin, int gemCost, int ownedGem)
		{
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBB")]
		[Address(RVA = "0x1CF9D50", Offset = "0x1CF9D50", VA = "0x7BBC4F9D50")]
		public UIClanCreateController()
		{
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBC")]
		[Address(RVA = "0x1CF9D60", Offset = "0x1CF9D60", VA = "0x7BBC4F9D60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114137C", Offset = "0x114137C")]
		private void <OnClickApprovalCondLevel>b__20_0(List<string> ids)
		{
		}

		// Token: 0x06006EBD RID: 28349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBD")]
		[Address(RVA = "0x1CF9EB8", Offset = "0x1CF9EB8", VA = "0x7BBC4F9EB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114138C", Offset = "0x114138C")]
		private void <OnClickApprovalCondRank>b__21_0(List<string> ids)
		{
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBE")]
		[Address(RVA = "0x1CFA010", Offset = "0x1CFA010", VA = "0x7BBC4FA010")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114139C", Offset = "0x114139C")]
		private void <OnClickArea>b__22_0(List<string> ids)
		{
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBF")]
		[Address(RVA = "0x1CFA0DC", Offset = "0x1CFA0DC", VA = "0x7BBC4FA0DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11413AC", Offset = "0x11413AC")]
		private void <OnClickTag>b__23_0(List<string> ids)
		{
		}

		// Token: 0x04008920 RID: 35104
		[Token(Token = "0x4008920")]
		private const int CREATE_CLAN_NAME_LOWER_LIMIT = 3;

		// Token: 0x04008921 RID: 35105
		[Token(Token = "0x4008921")]
		private const int CREATE_CLAN_SLOGAN_LOWER_LIMIT = 3;

		// Token: 0x04008922 RID: 35106
		[Token(Token = "0x4008922")]
		[FieldOffset(Offset = "0x94")]
		private uint goldNeeded;

		// Token: 0x04008923 RID: 35107
		[Token(Token = "0x4008923")]
		[FieldOffset(Offset = "0x98")]
		private uint goldOwned;

		// Token: 0x04008924 RID: 35108
		[Token(Token = "0x4008924")]
		[FieldOffset(Offset = "0x9C")]
		private uint diamonNeeded;

		// Token: 0x04008925 RID: 35109
		[Token(Token = "0x4008925")]
		[FieldOffset(Offset = "0xA0")]
		private int diamondOwned;

		// Token: 0x04008926 RID: 35110
		[Token(Token = "0x4008926")]
		[FieldOffset(Offset = "0xA4")]
		private UIClanCreateController.TokenType m_CurrentTokenType;

		// Token: 0x04008927 RID: 35111
		[Token(Token = "0x4008927")]
		[FieldOffset(Offset = "0xA8")]
		private UIClanCreateView m_View;

		// Token: 0x04008928 RID: 35112
		[Token(Token = "0x4008928")]
		[FieldOffset(Offset = "0xB0")]
		private List<string> m_TagIDs;

		// Token: 0x04008929 RID: 35113
		[Token(Token = "0x4008929")]
		[FieldOffset(Offset = "0xB8")]
		private List<string> m_AreaIDs;

		// Token: 0x0400892A RID: 35114
		[Token(Token = "0x400892A")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_RankCondition;

		// Token: 0x0400892B RID: 35115
		[Token(Token = "0x400892B")]
		[FieldOffset(Offset = "0xC4")]
		private uint m_LevelCondition;

		// Token: 0x02001725 RID: 5925
		[Token(Token = "0x2001725")]
		public enum TokenType
		{
			// Token: 0x0400892D RID: 35117
			[Token(Token = "0x400892D")]
			Gold = 1,
			// Token: 0x0400892E RID: 35118
			[Token(Token = "0x400892E")]
			Diamond,
			// Token: 0x0400892F RID: 35119
			[Token(Token = "0x400892F")]
			Max
		}
	}
}
