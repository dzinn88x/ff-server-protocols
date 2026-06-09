using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001474 RID: 5236
	[Token(Token = "0x2001474")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECE10", Offset = "0x10ECE10")]
	public class UIChampionshipEntranceItemController : UIBaseController, ITipsDelegate
	{
		// Token: 0x0600583D RID: 22589 RVA: 0x0001A0B8 File Offset: 0x000182B8
		[Token(Token = "0x600583D")]
		[Address(RVA = "0x1C304BC", Offset = "0x1C304BC", VA = "0x7BBC4304BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583E")]
		[Address(RVA = "0x1C3050C", Offset = "0x1C3050C", VA = "0x7BBC43050C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583F")]
		[Address(RVA = "0x1C3076C", Offset = "0x1C3076C", VA = "0x7BBC43076C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005840")]
		[Address(RVA = "0x1C30888", Offset = "0x1C30888", VA = "0x7BBC430888")]
		public void SetViewData(EntranceType type, uint championshipType = 1U)
		{
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005841")]
		[Address(RVA = "0x1C30B88", Offset = "0x1C30B88", VA = "0x7BBC430B88")]
		private void SetLockView()
		{
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005842")]
		[Address(RVA = "0x1C30A4C", Offset = "0x1C30A4C", VA = "0x7BBC430A4C")]
		private void CreateEntranceInfo(EntranceType type)
		{
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005843")]
		[Address(RVA = "0x1C314A4", Offset = "0x1C314A4", VA = "0x7BBC4314A4")]
		private void AnimationEventHandler(params object[] data)
		{
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005844")]
		[Address(RVA = "0x1C318E0", Offset = "0x1C318E0", VA = "0x7BBC4318E0")]
		private void OpenDetailedInfo()
		{
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005845")]
		[Address(RVA = "0x1C31B40", Offset = "0x1C31B40", VA = "0x7BBC431B40")]
		private void CloseDetailedInfo()
		{
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005846")]
		[Address(RVA = "0x1C318E8", Offset = "0x1C318E8", VA = "0x7BBC4318E8")]
		private void SwitchDetailedInfo(bool openDetailedInfo)
		{
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005847")]
		[Address(RVA = "0x1C31B48", Offset = "0x1C31B48", VA = "0x7BBC431B48", Slot = "28")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005848")]
		[Address(RVA = "0x1C31CE0", Offset = "0x1C31CE0", VA = "0x7BBC431CE0")]
		public UIChampionshipEntranceItemController()
		{
		}

		// Token: 0x04007C2F RID: 31791
		[Token(Token = "0x4007C2F")]
		[FieldOffset(Offset = "0x58")]
		private uint m_ChampionshipType;

		// Token: 0x04007C30 RID: 31792
		[Token(Token = "0x4007C30")]
		[FieldOffset(Offset = "0x60")]
		private UIChampionshipEntranceItemView m_View;

		// Token: 0x04007C31 RID: 31793
		[Token(Token = "0x4007C31")]
		[FieldOffset(Offset = "0x68")]
		private UIChampionshipEntranceItemController.EntranceInfo m_EntranceInfo;

		// Token: 0x04007C32 RID: 31794
		[Token(Token = "0x4007C32")]
		[FieldOffset(Offset = "0x70")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x02001475 RID: 5237
		[Token(Token = "0x2001475")]
		private class EntranceInfo
		{
			// Token: 0x06005849 RID: 22601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005849")]
			[Address(RVA = "0x1C31CE8", Offset = "0x1C31CE8", VA = "0x7BBC431CE8")]
			public EntranceInfo(UIChampionshipEntranceItemController ctrl, uint type)
			{
			}

			// Token: 0x0600584A RID: 22602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600584A")]
			[Address(RVA = "0x1C30B24", Offset = "0x1C30B24", VA = "0x7BBC430B24")]
			public void RefreshView()
			{
			}

			// Token: 0x0600584B RID: 22603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600584B")]
			[Address(RVA = "0x1C32B3C", Offset = "0x1C32B3C", VA = "0x7BBC432B3C", Slot = "4")]
			protected virtual void OnRefreshView()
			{
			}

			// Token: 0x0600584C RID: 22604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600584C")]
			[Address(RVA = "0x1C32B40", Offset = "0x1C32B40", VA = "0x7BBC432B40")]
			private void SetDetailedInfo()
			{
			}

			// Token: 0x0600584D RID: 22605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600584D")]
			[Address(RVA = "0x1C333E0", Offset = "0x1C333E0", VA = "0x7BBC4333E0")]
			private void SetSettingInfo()
			{
			}

			// Token: 0x0600584E RID: 22606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600584E")]
			[Address(RVA = "0x1C336DC", Offset = "0x1C336DC", VA = "0x7BBC4336DC", Slot = "5")]
			protected virtual void OnSetSettingInfo()
			{
			}

			// Token: 0x0600584F RID: 22607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600584F")]
			[Address(RVA = "0x1C3386C", Offset = "0x1C3386C", VA = "0x7BBC43386C")]
			protected void SetOpenInfo()
			{
			}

			// Token: 0x06005850 RID: 22608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005850")]
			[Address(RVA = "0x1C33900", Offset = "0x1C33900", VA = "0x7BBC433900")]
			protected void SetMapOpenInfo()
			{
			}

			// Token: 0x06005851 RID: 22609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005851")]
			[Address(RVA = "0x1C3260C", Offset = "0x1C3260C", VA = "0x7BBC43260C")]
			private void RefreshViewByState()
			{
			}

			// Token: 0x06005852 RID: 22610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005852")]
			[Address(RVA = "0x1C33C20", Offset = "0x1C33C20", VA = "0x7BBC433C20")]
			private void OnEntranceBtnClick()
			{
			}

			// Token: 0x06005853 RID: 22611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005853")]
			[Address(RVA = "0x1C315C8", Offset = "0x1C315C8", VA = "0x7BBC4315C8")]
			public void OnEntranceAnimFinish()
			{
			}

			// Token: 0x06005854 RID: 22612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005854")]
			[Address(RVA = "0x1C30988", Offset = "0x1C30988", VA = "0x7BBC430988")]
			public void Clear()
			{
			}

			// Token: 0x04007C33 RID: 31795
			[Token(Token = "0x4007C33")]
			[FieldOffset(Offset = "0x10")]
			protected UIChampionshipEntranceItemView m_View;

			// Token: 0x04007C34 RID: 31796
			[Token(Token = "0x4007C34")]
			[FieldOffset(Offset = "0x18")]
			protected ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

			// Token: 0x04007C35 RID: 31797
			[Token(Token = "0x4007C35")]
			[FieldOffset(Offset = "0x20")]
			protected ChampionshipSettingDesc m_ChampionshipSettingInfo;

			// Token: 0x04007C36 RID: 31798
			[Token(Token = "0x4007C36")]
			[FieldOffset(Offset = "0x28")]
			protected UIModelChampionship m_ModelChampionship;

			// Token: 0x04007C37 RID: 31799
			[Token(Token = "0x4007C37")]
			[FieldOffset(Offset = "0x30")]
			protected uint m_ChampionshipType;

			// Token: 0x04007C38 RID: 31800
			[Token(Token = "0x4007C38")]
			[FieldOffset(Offset = "0x34")]
			protected UIModelChampionship.ChampionshipOpenState m_ChampionshipState;

			// Token: 0x04007C39 RID: 31801
			[Token(Token = "0x4007C39")]
			[FieldOffset(Offset = "0x38")]
			protected MapOpeningInfo m_MapInfo;

			// Token: 0x04007C3A RID: 31802
			[Token(Token = "0x4007C3A")]
			[FieldOffset(Offset = "0x40")]
			private bool m_Clicked;

			// Token: 0x04007C3B RID: 31803
			[Token(Token = "0x4007C3B")]
			[FieldOffset(Offset = "0x48")]
			private Dictionary<UIModelChampionship.ChampionshipOpenState, UIToggleButton> m_StateBtnDict;

			// Token: 0x04007C3C RID: 31804
			[Token(Token = "0x4007C3C")]
			[FieldOffset(Offset = "0x50")]
			private Dictionary<uint, GameObject> m_OpenDayDict;

			// Token: 0x04007C3D RID: 31805
			[Token(Token = "0x4007C3D")]
			[FieldOffset(Offset = "0x58")]
			private Dictionary<uint, GameObject> m_UnOpenDayDict;

			// Token: 0x04007C3E RID: 31806
			[Token(Token = "0x4007C3E")]
			[FieldOffset(Offset = "0x60")]
			private readonly string[] m_DayInWeekKey;

			// Token: 0x04007C3F RID: 31807
			[Token(Token = "0x4007C3F")]
			[FieldOffset(Offset = "0x0")]
			protected static Dictionary<UIModelChampionship.ChampionshipOpenState, UIChampionshipEntranceItemController.EntranceInfo.EntranceStateInfo> m_EntranceStateInfoDict;

			// Token: 0x02001476 RID: 5238
			[Token(Token = "0x2001476")]
			protected class EntranceStateInfo
			{
				// Token: 0x06005856 RID: 22614 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005856")]
				[Address(RVA = "0x1C345E0", Offset = "0x1C345E0", VA = "0x7BBC4345E0")]
				public EntranceStateInfo()
				{
				}

				// Token: 0x04007C40 RID: 31808
				[Token(Token = "0x4007C40")]
				[FieldOffset(Offset = "0x10")]
				public bool SubscriptState;

				// Token: 0x04007C41 RID: 31809
				[Token(Token = "0x4007C41")]
				[FieldOffset(Offset = "0x18")]
				public string SubscriptText;

				// Token: 0x04007C42 RID: 31810
				[Token(Token = "0x4007C42")]
				[FieldOffset(Offset = "0x20")]
				public bool TicketState;

				// Token: 0x04007C43 RID: 31811
				[Token(Token = "0x4007C43")]
				[FieldOffset(Offset = "0x21")]
				public bool ShowTimeEffect;

				// Token: 0x04007C44 RID: 31812
				[Token(Token = "0x4007C44")]
				[FieldOffset(Offset = "0x22")]
				public bool ShowOpenTime;

				// Token: 0x04007C45 RID: 31813
				[Token(Token = "0x4007C45")]
				[FieldOffset(Offset = "0x23")]
				public bool ShowWeekTime;

				// Token: 0x04007C46 RID: 31814
				[Token(Token = "0x4007C46")]
				[FieldOffset(Offset = "0x24")]
				public bool ShowDayTime;

				// Token: 0x04007C47 RID: 31815
				[Token(Token = "0x4007C47")]
				[FieldOffset(Offset = "0x25")]
				public bool ShowStartTime;

				// Token: 0x04007C48 RID: 31816
				[Token(Token = "0x4007C48")]
				[FieldOffset(Offset = "0x26")]
				public bool ShowSettleTime;

				// Token: 0x04007C49 RID: 31817
				[Token(Token = "0x4007C49")]
				[FieldOffset(Offset = "0x27")]
				public bool ShowMatchFinished;

				// Token: 0x04007C4A RID: 31818
				[Token(Token = "0x4007C4A")]
				[FieldOffset(Offset = "0x28")]
				public string OpenTimeDescText;
			}
		}

		// Token: 0x02001477 RID: 5239
		[Token(Token = "0x2001477")]
		private class FFCEntrance : UIChampionshipEntranceItemController.EntranceInfo
		{
			// Token: 0x06005857 RID: 22615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005857")]
			[Address(RVA = "0x1C31108", Offset = "0x1C31108", VA = "0x7BBC431108")]
			public FFCEntrance(UIChampionshipEntranceItemController ctrl, uint type)
			{
			}

			// Token: 0x06005858 RID: 22616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005858")]
			[Address(RVA = "0x1C34654", Offset = "0x1C34654", VA = "0x7BBC434654", Slot = "4")]
			protected override void OnRefreshView()
			{
			}

			// Token: 0x06005859 RID: 22617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005859")]
			[Address(RVA = "0x1C34698", Offset = "0x1C34698", VA = "0x7BBC434698", Slot = "5")]
			protected override void OnSetSettingInfo()
			{
			}
		}

		// Token: 0x02001478 RID: 5240
		[Token(Token = "0x2001478")]
		private class OpenThirdPartyEntrance : UIChampionshipEntranceItemController.EntranceInfo
		{
			// Token: 0x0600585A RID: 22618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600585A")]
			[Address(RVA = "0x1C31338", Offset = "0x1C31338", VA = "0x7BBC431338")]
			public OpenThirdPartyEntrance(UIChampionshipEntranceItemController ctrl, uint type)
			{
			}

			// Token: 0x0600585B RID: 22619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600585B")]
			[Address(RVA = "0x1C347A4", Offset = "0x1C347A4", VA = "0x7BBC4347A4", Slot = "4")]
			protected override void OnRefreshView()
			{
			}

			// Token: 0x0600585C RID: 22620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600585C")]
			[Address(RVA = "0x1C347E8", Offset = "0x1C347E8", VA = "0x7BBC4347E8", Slot = "5")]
			protected override void OnSetSettingInfo()
			{
			}
		}

		// Token: 0x02001479 RID: 5241
		[Token(Token = "0x2001479")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x10ECE48", Offset = "0x10ECE48")]
		private class UnOpenThirdPartyEntrance : UIChampionshipEntranceItemController.EntranceInfo
		{
			// Token: 0x0600585D RID: 22621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600585D")]
			[Address(RVA = "0x1C31420", Offset = "0x1C31420", VA = "0x7BBC431420")]
			public UnOpenThirdPartyEntrance(UIChampionshipEntranceItemController ctrl, uint type)
			{
			}

			// Token: 0x0600585E RID: 22622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600585E")]
			[Address(RVA = "0x1C347EC", Offset = "0x1C347EC", VA = "0x7BBC4347EC", Slot = "4")]
			protected override void OnRefreshView()
			{
			}
		}
	}
}
