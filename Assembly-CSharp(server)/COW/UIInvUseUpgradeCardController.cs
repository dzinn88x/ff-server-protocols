using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019C4 RID: 6596
	[Token(Token = "0x20019C4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7004", Offset = "0x10F7004")]
	public class UIInvUseUpgradeCardController : UIPopupWindowController, IEasyList
	{
		// Token: 0x0600878B RID: 34699 RVA: 0x000249D8 File Offset: 0x00022BD8
		[Token(Token = "0x600878B")]
		[Address(RVA = "0x191115C", Offset = "0x191115C", VA = "0x7BBC11115C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600878C RID: 34700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600878C")]
		[Address(RVA = "0x19111AC", Offset = "0x19111AC", VA = "0x7BBC1111AC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600878D RID: 34701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600878D")]
		[Address(RVA = "0x191168C", Offset = "0x191168C", VA = "0x7BBC11168C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600878E RID: 34702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600878E")]
		[Address(RVA = "0x19118AC", Offset = "0x19118AC", VA = "0x7BBC1118AC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600878F RID: 34703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600878F")]
		[Address(RVA = "0x1911914", Offset = "0x1911914", VA = "0x7BBC111914")]
		public void InitInventoryView(List<AvatarProfile> avatarList, int _cardId)
		{
		}

		// Token: 0x06008790 RID: 34704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008790")]
		[Address(RVA = "0x19126C0", Offset = "0x19126C0", VA = "0x7BBC1126C0")]
		private void OnSelectAvatarheadItem(params object[] data)
		{
		}

		// Token: 0x06008791 RID: 34705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008791")]
		[Address(RVA = "0x19128BC", Offset = "0x19128BC", VA = "0x7BBC1128BC")]
		private void OnSelectAvatarLevelCardItem(params object[] data)
		{
		}

		// Token: 0x06008792 RID: 34706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008792")]
		[Address(RVA = "0x1911B28", Offset = "0x1911B28", VA = "0x7BBC111B28")]
		private void RefreshDesc()
		{
		}

		// Token: 0x06008793 RID: 34707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008793")]
		[Address(RVA = "0x1912294", Offset = "0x1912294", VA = "0x7BBC112294")]
		private void RefreshAward()
		{
		}

		// Token: 0x06008794 RID: 34708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008794")]
		[Address(RVA = "0x1912A64", Offset = "0x1912A64", VA = "0x7BBC112A64")]
		private void RefreshUseState(bool _useable, bool _hasCard)
		{
		}

		// Token: 0x06008795 RID: 34709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008795")]
		[Address(RVA = "0x1912C44", Offset = "0x1912C44", VA = "0x7BBC112C44")]
		private void OnUseCardClick()
		{
		}

		// Token: 0x06008796 RID: 34710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008796")]
		[Address(RVA = "0x1912EF8", Offset = "0x1912EF8", VA = "0x7BBC112EF8")]
		private void OnAvatarListNextBtnClick()
		{
		}

		// Token: 0x06008797 RID: 34711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008797")]
		[Address(RVA = "0x1913070", Offset = "0x1913070", VA = "0x7BBC113070")]
		private void OnAvatarListPreBtnClick()
		{
		}

		// Token: 0x06008798 RID: 34712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008798")]
		[Address(RVA = "0x1913190", Offset = "0x1913190", VA = "0x7BBC113190", Slot = "40")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008799 RID: 34713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008799")]
		[Address(RVA = "0x1913224", Offset = "0x1913224", VA = "0x7BBC113224", Slot = "41")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600879A RID: 34714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600879A")]
		[Address(RVA = "0x1913254", Offset = "0x1913254", VA = "0x7BBC113254")]
		public UIInvUseUpgradeCardController()
		{
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600879B")]
		[Address(RVA = "0x19133A4", Offset = "0x19133A4", VA = "0x7BBC1133A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11435FC", Offset = "0x11435FC")]
		private void <OnUseCardClick>b__23_0()
		{
		}

		// Token: 0x04009614 RID: 38420
		[Token(Token = "0x4009614")]
		[FieldOffset(Offset = "0x98")]
		private UIInvUseUpgradeCardWindowView m_View;

		// Token: 0x04009615 RID: 38421
		[Token(Token = "0x4009615")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelAvatarProfile m_ProfileModel;

		// Token: 0x04009616 RID: 38422
		[Token(Token = "0x4009616")]
		[FieldOffset(Offset = "0xA8")]
		private int careAvatarId;

		// Token: 0x04009617 RID: 38423
		[Token(Token = "0x4009617")]
		[FieldOffset(Offset = "0xAC")]
		private int levelCardId;

		// Token: 0x04009618 RID: 38424
		[Token(Token = "0x4009618")]
		private const float ITEM_WIDTH = 140f;

		// Token: 0x04009619 RID: 38425
		[Token(Token = "0x4009619")]
		private const float ITEM_HEIGHT = 140f;

		// Token: 0x0400961A RID: 38426
		[Token(Token = "0x400961A")]
		[FieldOffset(Offset = "0xB0")]
		private BaseItemView[] levelUpRewardList;

		// Token: 0x0400961B RID: 38427
		[Token(Token = "0x400961B")]
		[FieldOffset(Offset = "0xB8")]
		private List<UIAvatarLevelCardItemController> m_LevelCards;

		// Token: 0x0400961C RID: 38428
		[Token(Token = "0x400961C")]
		[FieldOffset(Offset = "0xC0")]
		private Color NORMAL_COLOR;

		// Token: 0x0400961D RID: 38429
		[Token(Token = "0x400961D")]
		[FieldOffset(Offset = "0xD0")]
		private Color DISABLE_COLOR;

		// Token: 0x0400961E RID: 38430
		[Token(Token = "0x400961E")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 NO_REWARD_DESC_OFFSET_POS;

		// Token: 0x0400961F RID: 38431
		[Token(Token = "0x400961F")]
		[FieldOffset(Offset = "0xEC")]
		private Vector3 REWARD_DESC_OFFSET_POS;

		// Token: 0x04009620 RID: 38432
		[Token(Token = "0x4009620")]
		[FieldOffset(Offset = "0xF8")]
		private List<AvatarProfile> m_ShowAvatarList;

		// Token: 0x020019C5 RID: 6597
		[Token(Token = "0x20019C5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F703C", Offset = "0x10F703C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600879D RID: 34717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600879D")]
			[Address(RVA = "0x191347C", Offset = "0x191347C", VA = "0x7BBC11347C")]
			public <>c()
			{
			}

			// Token: 0x0600879E RID: 34718 RVA: 0x000249F0 File Offset: 0x00022BF0
			[Token(Token = "0x600879E")]
			[Address(RVA = "0x1913484", Offset = "0x1913484", VA = "0x7BBC113484")]
			internal int <InitInventoryView>b__17_0(AvatarProfile ap1, AvatarProfile ap2)
			{
				return 0;
			}

			// Token: 0x04009621 RID: 38433
			[Token(Token = "0x4009621")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIInvUseUpgradeCardController.<>c <>9;

			// Token: 0x04009622 RID: 38434
			[Token(Token = "0x4009622")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AvatarProfile> <>9__17_0;
		}
	}
}
