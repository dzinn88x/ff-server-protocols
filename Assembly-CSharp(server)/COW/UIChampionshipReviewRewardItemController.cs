using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200148C RID: 5260
	[Token(Token = "0x200148C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED0D4", Offset = "0x10ED0D4")]
	public class UIChampionshipReviewRewardItemController : UIEasyListItemController
	{
		// Token: 0x060058D0 RID: 22736 RVA: 0x0001A298 File Offset: 0x00018498
		[Token(Token = "0x60058D0")]
		[Address(RVA = "0x1EC9128", Offset = "0x1EC9128", VA = "0x7BBC6C9128")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D1")]
		[Address(RVA = "0x1EC9178", Offset = "0x1EC9178", VA = "0x7BBC6C9178", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D2")]
		[Address(RVA = "0x1EC9384", Offset = "0x1EC9384", VA = "0x7BBC6C9384", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D3")]
		[Address(RVA = "0x1EC9490", Offset = "0x1EC9490", VA = "0x7BBC6C9490")]
		public void NeedHighLight(bool needHighLight)
		{
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D4")]
		[Address(RVA = "0x1EC945C", Offset = "0x1EC945C", VA = "0x7BBC6C945C")]
		private void RefreshView()
		{
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D5")]
		[Address(RVA = "0x1EC9634", Offset = "0x1EC9634", VA = "0x7BBC6C9634")]
		private void RefreshRewardList()
		{
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D6")]
		[Address(RVA = "0x1EC9A14", Offset = "0x1EC9A14", VA = "0x7BBC6C9A14")]
		private void RefreshLevel()
		{
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D7")]
		[Address(RVA = "0x1ECA014", Offset = "0x1ECA014", VA = "0x7BBC6CA014")]
		private void HighLightBg()
		{
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D8")]
		[Address(RVA = "0x1EC949C", Offset = "0x1EC949C", VA = "0x7BBC6C949C")]
		private void HideUI()
		{
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D9")]
		[Address(RVA = "0x1ECA138", Offset = "0x1ECA138", VA = "0x7BBC6CA138")]
		public UIChampionshipReviewRewardItemController()
		{
		}

		// Token: 0x04007C93 RID: 31891
		[Token(Token = "0x4007C93")]
		[FieldOffset(Offset = "0x70")]
		private UIChampionshipReviewRewardItemView m_View;

		// Token: 0x04007C94 RID: 31892
		[Token(Token = "0x4007C94")]
		[FieldOffset(Offset = "0x78")]
		private ChampionshipScoreRewardDesc m_AwardData;

		// Token: 0x04007C95 RID: 31893
		[Token(Token = "0x4007C95")]
		[FieldOffset(Offset = "0x80")]
		private List<UIStandardItemMiniController> m_RewardCtrlCache;

		// Token: 0x04007C96 RID: 31894
		[Token(Token = "0x4007C96")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<uint, string> m_CupIconDict;

		// Token: 0x04007C97 RID: 31895
		[Token(Token = "0x4007C97")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<uint, GameObject> m_BGDict;

		// Token: 0x04007C98 RID: 31896
		[Token(Token = "0x4007C98")]
		[FieldOffset(Offset = "0x98")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007C99 RID: 31897
		[Token(Token = "0x4007C99")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_NeedHighLight;

		// Token: 0x04007C9A RID: 31898
		[Token(Token = "0x4007C9A")]
		[FieldOffset(Offset = "0xA4")]
		private uint m_ChampionshipType;

		// Token: 0x04007C9B RID: 31899
		[Token(Token = "0x4007C9B")]
		[FieldOffset(Offset = "0xA8")]
		private ChampionshipSettingDesc m_ChampionshipSetting;

		// Token: 0x04007C9C RID: 31900
		[Token(Token = "0x4007C9C")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_LocalSize;
	}
}
