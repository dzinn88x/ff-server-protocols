using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BE6 RID: 7142
	[Token(Token = "0x2001BE6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB1A4", Offset = "0x10FB1A4")]
	public class UIWeaponSkinUpgraderGunPickController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x06009B0D RID: 39693 RVA: 0x00028BD8 File Offset: 0x00026DD8
		[Token(Token = "0x6009B0D")]
		[Address(RVA = "0x222E294", Offset = "0x222E294", VA = "0x7BBCA2E294")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B0E")]
		[Address(RVA = "0x222E2E4", Offset = "0x222E2E4", VA = "0x7BBCA2E2E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B0F")]
		[Address(RVA = "0x222E4A4", Offset = "0x222E4A4", VA = "0x7BBCA2E4A4")]
		private void OnCloseBtn()
		{
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x00028BF0 File Offset: 0x00026DF0
		[Token(Token = "0x6009B10")]
		[Address(RVA = "0x222E540", Offset = "0x222E540", VA = "0x7BBCA2E540", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B11")]
		[Address(RVA = "0x222E548", Offset = "0x222E548", VA = "0x7BBCA2E548", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B12")]
		[Address(RVA = "0x222E5B8", Offset = "0x222E5B8", VA = "0x7BBCA2E5B8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B13")]
		[Address(RVA = "0x222E5F8", Offset = "0x222E5F8", VA = "0x7BBCA2E5F8", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x00028C08 File Offset: 0x00026E08
		[Token(Token = "0x6009B14")]
		[Address(RVA = "0x222EE14", Offset = "0x222EE14", VA = "0x7BBCA2EE14", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B15")]
		[Address(RVA = "0x222E5B4", Offset = "0x222E5B4", VA = "0x7BBCA2E5B4")]
		private void RefreshView()
		{
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B16")]
		[Address(RVA = "0x222E670", Offset = "0x222E670", VA = "0x7BBCA2E670")]
		private void RefreshGunPickList()
		{
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B17")]
		[Address(RVA = "0x222FB28", Offset = "0x222FB28", VA = "0x7BBCA2FB28")]
		public UIWeaponSkinUpgraderGunPickController()
		{
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x00028C20 File Offset: 0x00026E20
		[Token(Token = "0x6009B18")]
		[Address(RVA = "0x222FB30", Offset = "0x222FB30", VA = "0x7BBCA2FB30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145160", Offset = "0x1145160")]
		private int <RefreshGunPickList>b__12_0(SkinOwnAndOpenInfo x, SkinOwnAndOpenInfo y)
		{
			return 0;
		}

		// Token: 0x0400A190 RID: 41360
		[Token(Token = "0x400A190")]
		[FieldOffset(Offset = "0xB0")]
		private UIWeaponSkinUpgraderGunPickView m_View;

		// Token: 0x0400A191 RID: 41361
		[Token(Token = "0x400A191")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

		// Token: 0x0400A192 RID: 41362
		[Token(Token = "0x400A192")]
		private const int m_MinShowGunItem = 6;
	}
}
