using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BC3 RID: 7107
	[Token(Token = "0x2001BC3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FACF4", Offset = "0x10FACF4")]
	public class UIUseUpgradeCardController : UIPopupWindowController, IEasyList
	{
		// Token: 0x060099A1 RID: 39329 RVA: 0x00028710 File Offset: 0x00026910
		[Token(Token = "0x60099A1")]
		[Address(RVA = "0x19FBD28", Offset = "0x19FBD28", VA = "0x7BBC1FBD28")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060099A2 RID: 39330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A2")]
		[Address(RVA = "0x19FBD78", Offset = "0x19FBD78", VA = "0x7BBC1FBD78", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A3")]
		[Address(RVA = "0x19FC1F8", Offset = "0x19FC1F8", VA = "0x7BBC1FC1F8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A4")]
		[Address(RVA = "0x19FC418", Offset = "0x19FC418", VA = "0x7BBC1FC418", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A5")]
		[Address(RVA = "0x19FC440", Offset = "0x19FC440", VA = "0x7BBC1FC440")]
		private void Refresh()
		{
		}

		// Token: 0x060099A6 RID: 39334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A6")]
		[Address(RVA = "0x19FC6AC", Offset = "0x19FC6AC", VA = "0x7BBC1FC6AC")]
		public void InitInventoryView(int _cardId)
		{
		}

		// Token: 0x060099A7 RID: 39335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A7")]
		[Address(RVA = "0x19FD538", Offset = "0x19FD538", VA = "0x7BBC1FD538")]
		public void InitAvatarNavigationView(int _avatarId, int selected)
		{
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A8")]
		[Address(RVA = "0x19FDE30", Offset = "0x19FDE30", VA = "0x7BBC1FDE30")]
		private void OnSelectAvatarheadItem(params object[] data)
		{
		}

		// Token: 0x060099A9 RID: 39337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A9")]
		[Address(RVA = "0x19FE02C", Offset = "0x19FE02C", VA = "0x7BBC1FE02C")]
		private void OnSelectAvatarLevelCardItem(params object[] data)
		{
		}

		// Token: 0x060099AA RID: 39338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099AA")]
		[Address(RVA = "0x19FC988", Offset = "0x19FC988", VA = "0x7BBC1FC988")]
		private void RefreshDesc()
		{
		}

		// Token: 0x060099AB RID: 39339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099AB")]
		[Address(RVA = "0x19FD0F4", Offset = "0x19FD0F4", VA = "0x7BBC1FD0F4")]
		private void RefreshAward()
		{
		}

		// Token: 0x060099AC RID: 39340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099AC")]
		[Address(RVA = "0x19FE224", Offset = "0x19FE224", VA = "0x7BBC1FE224")]
		private void RefreshUseState(bool _useable, bool _hasCard)
		{
		}

		// Token: 0x060099AD RID: 39341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099AD")]
		[Address(RVA = "0x19FE404", Offset = "0x19FE404", VA = "0x7BBC1FE404")]
		private void OnUseCardClick()
		{
		}

		// Token: 0x060099AE RID: 39342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099AE")]
		[Address(RVA = "0x19FE6B0", Offset = "0x19FE6B0", VA = "0x7BBC1FE6B0")]
		private void OnGotoClick()
		{
		}

		// Token: 0x060099AF RID: 39343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099AF")]
		[Address(RVA = "0x19FE8B8", Offset = "0x19FE8B8", VA = "0x7BBC1FE8B8", Slot = "40")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060099B0 RID: 39344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099B0")]
		[Address(RVA = "0x19FE94C", Offset = "0x19FE94C", VA = "0x7BBC1FE94C", Slot = "41")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060099B1 RID: 39345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099B1")]
		[Address(RVA = "0x19FE97C", Offset = "0x19FE97C", VA = "0x7BBC1FE97C")]
		public UIUseUpgradeCardController()
		{
		}

		// Token: 0x060099B2 RID: 39346 RVA: 0x00028728 File Offset: 0x00026928
		[Token(Token = "0x60099B2")]
		[Address(RVA = "0x19FEAA0", Offset = "0x19FEAA0", VA = "0x7BBC1FEAA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144F48", Offset = "0x1144F48")]
		private bool <InitInventoryView>b__18_0(AvatarProfile a)
		{
			return default(bool);
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099B3")]
		[Address(RVA = "0x19FEB34", Offset = "0x19FEB34", VA = "0x7BBC1FEB34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144F58", Offset = "0x1144F58")]
		private void <OnUseCardClick>b__25_0()
		{
		}

		// Token: 0x0400A0D2 RID: 41170
		[Token(Token = "0x400A0D2")]
		[FieldOffset(Offset = "0x98")]
		private UIUseUpgradeCardWindowView m_View;

		// Token: 0x0400A0D3 RID: 41171
		[Token(Token = "0x400A0D3")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelAvatarProfile m_ProfileModel;

		// Token: 0x0400A0D4 RID: 41172
		[Token(Token = "0x400A0D4")]
		[FieldOffset(Offset = "0xA8")]
		private int careAvatarId;

		// Token: 0x0400A0D5 RID: 41173
		[Token(Token = "0x400A0D5")]
		[FieldOffset(Offset = "0xAC")]
		private int levelCardId;

		// Token: 0x0400A0D6 RID: 41174
		[Token(Token = "0x400A0D6")]
		[FieldOffset(Offset = "0xB0")]
		private int selectedIndex;

		// Token: 0x0400A0D7 RID: 41175
		[Token(Token = "0x400A0D7")]
		private const float ITEM_WIDTH = 140f;

		// Token: 0x0400A0D8 RID: 41176
		[Token(Token = "0x400A0D8")]
		private const float ITEM_HEIGHT = 140f;

		// Token: 0x0400A0D9 RID: 41177
		[Token(Token = "0x400A0D9")]
		[FieldOffset(Offset = "0xB8")]
		private BaseItemView[] levelUpRewardList;

		// Token: 0x0400A0DA RID: 41178
		[Token(Token = "0x400A0DA")]
		[FieldOffset(Offset = "0xC0")]
		private List<UIAvatarLevelCardItemController> m_LevelCards;

		// Token: 0x0400A0DB RID: 41179
		[Token(Token = "0x400A0DB")]
		[FieldOffset(Offset = "0xC8")]
		private Color NORMAL_COLOR;

		// Token: 0x0400A0DC RID: 41180
		[Token(Token = "0x400A0DC")]
		[FieldOffset(Offset = "0xD8")]
		private Color DISABLE_COLOR;

		// Token: 0x0400A0DD RID: 41181
		[Token(Token = "0x400A0DD")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 DESC_OFFSET_POS;

		// Token: 0x0400A0DE RID: 41182
		[Token(Token = "0x400A0DE")]
		[FieldOffset(Offset = "0xF8")]
		private List<AvatarProfile> m_ShowAvatarList;

		// Token: 0x02001BC4 RID: 7108
		[Token(Token = "0x2001BC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAD2C", Offset = "0x10FAD2C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060099B5 RID: 39349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60099B5")]
			[Address(RVA = "0x19FEC0C", Offset = "0x19FEC0C", VA = "0x7BBC1FEC0C")]
			public <>c()
			{
			}

			// Token: 0x060099B6 RID: 39350 RVA: 0x00028740 File Offset: 0x00026940
			[Token(Token = "0x60099B6")]
			[Address(RVA = "0x19FEC14", Offset = "0x19FEC14", VA = "0x7BBC1FEC14")]
			internal int <InitInventoryView>b__18_1(AvatarProfile ap1, AvatarProfile ap2)
			{
				return 0;
			}

			// Token: 0x0400A0DF RID: 41183
			[Token(Token = "0x400A0DF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIUseUpgradeCardController.<>c <>9;

			// Token: 0x0400A0E0 RID: 41184
			[Token(Token = "0x400A0E0")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AvatarProfile> <>9__18_1;
		}
	}
}
