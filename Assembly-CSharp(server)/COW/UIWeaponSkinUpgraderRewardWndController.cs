using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BED RID: 7149
	[Token(Token = "0x2001BED")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB294", Offset = "0x10FB294")]
	public class UIWeaponSkinUpgraderRewardWndController : UIPopupWindowController
	{
		// Token: 0x06009B39 RID: 39737 RVA: 0x00028C98 File Offset: 0x00026E98
		[Token(Token = "0x6009B39")]
		[Address(RVA = "0x22321A4", Offset = "0x22321A4", VA = "0x7BBCA321A4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B3A")]
		[Address(RVA = "0x22321F4", Offset = "0x22321F4", VA = "0x7BBCA321F4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B3B RID: 39739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B3B")]
		[Address(RVA = "0x22322D8", Offset = "0x22322D8", VA = "0x7BBCA322D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B3C")]
		[Address(RVA = "0x22323D0", Offset = "0x22323D0", VA = "0x7BBCA323D0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B3D")]
		[Address(RVA = "0x22284C4", Offset = "0x22284C4", VA = "0x7BBCA284C4")]
		public void SetRewardsData(WeaponSkinData data, List<WeaponSkinFeature> features, List<uint> itemIds)
		{
		}

		// Token: 0x06009B3E RID: 39742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B3E")]
		[Address(RVA = "0x223244C", Offset = "0x223244C", VA = "0x7BBCA3244C")]
		private void ShowRewardsView()
		{
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B3F")]
		[Address(RVA = "0x2232978", Offset = "0x2232978", VA = "0x7BBCA32978")]
		private void ShowRewardFeatureView(WeaponSkinFeature feature)
		{
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B40")]
		[Address(RVA = "0x2232564", Offset = "0x2232564", VA = "0x7BBCA32564")]
		private void SetUIVisible(bool flag)
		{
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B41")]
		[Address(RVA = "0x2232A98", Offset = "0x2232A98", VA = "0x7BBCA32A98")]
		private void OnCommonEquipResult(params object[] data)
		{
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B42")]
		[Address(RVA = "0x2232C4C", Offset = "0x2232C4C", VA = "0x7BBCA32C4C")]
		private void OnEquipSuccess()
		{
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B43")]
		[Address(RVA = "0x2232DF8", Offset = "0x2232DF8", VA = "0x7BBCA32DF8")]
		private void OnEquipFail()
		{
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B44")]
		[Address(RVA = "0x2232F10", Offset = "0x2232F10", VA = "0x7BBCA32F10")]
		private void AutoClose()
		{
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B45")]
		[Address(RVA = "0x2232568", Offset = "0x2232568", VA = "0x7BBCA32568")]
		private void CheckFastEquip()
		{
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x00028CB0 File Offset: 0x00026EB0
		[Token(Token = "0x6009B46")]
		[Address(RVA = "0x2233428", Offset = "0x2233428", VA = "0x7BBCA33428")]
		private bool CheckItemABReady(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B47")]
		[Address(RVA = "0x2233570", Offset = "0x2233570", VA = "0x7BBCA33570")]
		public UIWeaponSkinUpgraderRewardWndController()
		{
		}

		// Token: 0x06009B48 RID: 39752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B48")]
		[Address(RVA = "0x2233608", Offset = "0x2233608", VA = "0x7BBCA33608")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145224", Offset = "0x1145224")]
		private void <ShowRewardFeatureView>b__13_0()
		{
		}

		// Token: 0x0400A1AA RID: 41386
		[Token(Token = "0x400A1AA")]
		[FieldOffset(Offset = "0x98")]
		private UIWeaponSkinUpgraderRewardWndView m_View;

		// Token: 0x0400A1AB RID: 41387
		[Token(Token = "0x400A1AB")]
		[FieldOffset(Offset = "0xA0")]
		private WeaponSkinData m_WeaponSkinData;

		// Token: 0x0400A1AC RID: 41388
		[Token(Token = "0x400A1AC")]
		[FieldOffset(Offset = "0xA8")]
		private List<WeaponSkinFeature> m_Features;

		// Token: 0x0400A1AD RID: 41389
		[Token(Token = "0x400A1AD")]
		[FieldOffset(Offset = "0xB0")]
		private List<uint> m_RewardItemIds;

		// Token: 0x0400A1AE RID: 41390
		[Token(Token = "0x400A1AE")]
		[FieldOffset(Offset = "0xB8")]
		private int m_CurRewardIdx;

		// Token: 0x0400A1AF RID: 41391
		[Token(Token = "0x400A1AF")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_AutoCloseDC;

		// Token: 0x0400A1B0 RID: 41392
		[Token(Token = "0x400A1B0")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_HasABNotReadyItem;

		// Token: 0x02001BEE RID: 7150
		[Token(Token = "0x2001BEE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB2CC", Offset = "0x10FB2CC")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06009B49 RID: 39753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009B49")]
			[Address(RVA = "0x2233420", Offset = "0x2233420", VA = "0x7BBCA33420")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x06009B4A RID: 39754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009B4A")]
			[Address(RVA = "0x2233618", Offset = "0x2233618", VA = "0x7BBCA33618")]
			internal void <AutoClose>b__0()
			{
			}

			// Token: 0x0400A1B1 RID: 41393
			[Token(Token = "0x400A1B1")]
			[FieldOffset(Offset = "0x10")]
			public uint skinId;
		}
	}
}
