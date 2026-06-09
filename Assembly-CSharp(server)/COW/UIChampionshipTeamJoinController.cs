using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001498 RID: 5272
	[Token(Token = "0x2001498")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED2B4", Offset = "0x10ED2B4")]
	public class UIChampionshipTeamJoinController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x0600593D RID: 22845 RVA: 0x0001A430 File Offset: 0x00018630
		[Token(Token = "0x600593D")]
		[Address(RVA = "0x1ED2BFC", Offset = "0x1ED2BFC", VA = "0x7BBC6D2BFC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593E")]
		[Address(RVA = "0x1ED2C4C", Offset = "0x1ED2C4C", VA = "0x7BBC6D2C4C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593F")]
		[Address(RVA = "0x1ED2E5C", Offset = "0x1ED2E5C", VA = "0x7BBC6D2E5C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005940")]
		[Address(RVA = "0x1ED2E9C", Offset = "0x1ED2E9C", VA = "0x7BBC6D2E9C", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005941")]
		[Address(RVA = "0x1ED2ECC", Offset = "0x1ED2ECC", VA = "0x7BBC6D2ECC", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005942")]
		[Address(RVA = "0x1ED2F84", Offset = "0x1ED2F84", VA = "0x7BBC6D2F84")]
		public void SetChampionshipType(uint championshipType)
		{
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x0001A448 File Offset: 0x00018648
		[Token(Token = "0x6005943")]
		[Address(RVA = "0x1ED2F8C", Offset = "0x1ED2F8C", VA = "0x7BBC6D2F8C")]
		public UIChampionshipTeamJoinController.ApplyState GetApplyState(ulong id)
		{
			return UIChampionshipTeamJoinController.ApplyState.Normal;
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005944")]
		[Address(RVA = "0x1ED3014", Offset = "0x1ED3014", VA = "0x7BBC6D3014")]
		public void SetApplyState(ulong id, UIChampionshipTeamJoinController.ApplyState state)
		{
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005945")]
		[Address(RVA = "0x1ED308C", Offset = "0x1ED308C", VA = "0x7BBC6D308C")]
		private void Search()
		{
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005946")]
		[Address(RVA = "0x1ED32BC", Offset = "0x1ED32BC", VA = "0x7BBC6D32BC")]
		public void ShowSearchResultView()
		{
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x0001A460 File Offset: 0x00018660
		[Token(Token = "0x6005947")]
		[Address(RVA = "0x1ED35E0", Offset = "0x1ED35E0", VA = "0x7BBC6D35E0")]
		private int FriendSort(FriendAccountInfo a, FriendAccountInfo b)
		{
			return 0;
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005948")]
		[Address(RVA = "0x1ED36DC", Offset = "0x1ED36DC", VA = "0x7BBC6D36DC", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005949")]
		[Address(RVA = "0x1ED34A4", Offset = "0x1ED34A4", VA = "0x7BBC6D34A4")]
		public void RefreshEasyListView(List<FriendAccountInfo> data)
		{
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x0001A478 File Offset: 0x00018678
		[Token(Token = "0x600594A")]
		[Address(RVA = "0x1ED3814", Offset = "0x1ED3814", VA = "0x7BBC6D3814", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594B")]
		[Address(RVA = "0x1ED3858", Offset = "0x1ED3858", VA = "0x7BBC6D3858")]
		public UIChampionshipTeamJoinController()
		{
		}

		// Token: 0x04007CD4 RID: 31956
		[Token(Token = "0x4007CD4")]
		[FieldOffset(Offset = "0x98")]
		private UIChampionshipTeamJoinView m_View;

		// Token: 0x04007CD5 RID: 31957
		[Token(Token = "0x4007CD5")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CD6 RID: 31958
		[Token(Token = "0x4007CD6")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelFriends m_ModelFriends;

		// Token: 0x04007CD7 RID: 31959
		[Token(Token = "0x4007CD7")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<ulong, UIChampionshipTeamJoinController.ApplyState> m_ApplyStates;

		// Token: 0x04007CD8 RID: 31960
		[Token(Token = "0x4007CD8")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_ChampionshipType;

		// Token: 0x02001499 RID: 5273
		[Token(Token = "0x2001499")]
		public enum ApplyState
		{
			// Token: 0x04007CDA RID: 31962
			[Token(Token = "0x4007CDA")]
			Normal,
			// Token: 0x04007CDB RID: 31963
			[Token(Token = "0x4007CDB")]
			Applying,
			// Token: 0x04007CDC RID: 31964
			[Token(Token = "0x4007CDC")]
			ApplySuccess,
			// Token: 0x04007CDD RID: 31965
			[Token(Token = "0x4007CDD")]
			CantApplyTeamFull
		}

		// Token: 0x0200149A RID: 5274
		[Token(Token = "0x200149A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED2EC", Offset = "0x10ED2EC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600594D RID: 22861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600594D")]
			[Address(RVA = "0x1ED392C", Offset = "0x1ED392C", VA = "0x7BBC6D392C")]
			public <>c()
			{
			}

			// Token: 0x0600594E RID: 22862 RVA: 0x0001A490 File Offset: 0x00018690
			[Token(Token = "0x600594E")]
			[Address(RVA = "0x1ED3934", Offset = "0x1ED3934", VA = "0x7BBC6D3934")]
			internal bool <ShowSearchResultView>b__15_0(FriendAccountInfo e)
			{
				return default(bool);
			}

			// Token: 0x04007CDE RID: 31966
			[Token(Token = "0x4007CDE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIChampionshipTeamJoinController.<>c <>9;

			// Token: 0x04007CDF RID: 31967
			[Token(Token = "0x4007CDF")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<FriendAccountInfo> <>9__15_0;
		}
	}
}
