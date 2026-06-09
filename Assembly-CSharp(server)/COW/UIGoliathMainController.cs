using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001381 RID: 4993
	[Token(Token = "0x2001381")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB6F8", Offset = "0x10EB6F8")]
	internal class UIGoliathMainController : UINaviPopController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x0600504A RID: 20554 RVA: 0x00018648 File Offset: 0x00016848
		[Token(Token = "0x600504A")]
		[Address(RVA = "0x1A762D4", Offset = "0x1A762D4", VA = "0x7BBC2762D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504B")]
		[Address(RVA = "0x1A76324", Offset = "0x1A76324", VA = "0x7BBC276324", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504C")]
		[Address(RVA = "0x1A77B1C", Offset = "0x1A77B1C", VA = "0x7BBC277B1C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504D")]
		[Address(RVA = "0x1A77D34", Offset = "0x1A77D34", VA = "0x7BBC277D34", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504E")]
		[Address(RVA = "0x1A784F0", Offset = "0x1A784F0", VA = "0x7BBC2784F0", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504F")]
		[Address(RVA = "0x1A785AC", Offset = "0x1A785AC", VA = "0x7BBC2785AC", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005050")]
		[Address(RVA = "0x1A785DC", Offset = "0x1A785DC", VA = "0x7BBC2785DC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005051")]
		[Address(RVA = "0x1A785E4", Offset = "0x1A785E4", VA = "0x7BBC2785E4", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005052")]
		[Address(RVA = "0x1A77FE4", Offset = "0x1A77FE4", VA = "0x7BBC277FE4")]
		private void AutoOpenPeakDayWndIfNeed()
		{
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005053")]
		[Address(RVA = "0x1A77474", Offset = "0x1A77474", VA = "0x7BBC277474")]
		public void SetCameraFov()
		{
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005054")]
		[Address(RVA = "0x1A7866C", Offset = "0x1A7866C", VA = "0x7BBC27866C")]
		private void ShowGuideIfNeed(params object[] data)
		{
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005055")]
		[Address(RVA = "0x1A790DC", Offset = "0x1A790DC", VA = "0x7BBC2790DC")]
		private void CancelGuideIfNeed(UIGoliathMainController.EGuideState state)
		{
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x00018660 File Offset: 0x00016860
		[Token(Token = "0x6005056")]
		[Address(RVA = "0x1A79220", Offset = "0x1A79220", VA = "0x7BBC279220")]
		private static Vector2 GetGuideBgUVCenter(Vector2 pos, UIWidget tar)
		{
			return default(Vector2);
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x00018678 File Offset: 0x00016878
		[Token(Token = "0x6005057")]
		[Address(RVA = "0x1A793AC", Offset = "0x1A793AC", VA = "0x7BBC2793AC")]
		private static Vector2 GetGuideBgUVSize(UIWidget widget, UIWidget tar)
		{
			return default(Vector2);
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005058")]
		[Address(RVA = "0x1A72AA4", Offset = "0x1A72AA4", VA = "0x7BBC272AA4")]
		public static void RefreshGuideBgView(UIWidget widget, UIWidget tar, Material mat)
		{
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005059")]
		[Address(RVA = "0x1A77704", Offset = "0x1A77704", VA = "0x7BBC277704")]
		private void RefreshTimeView()
		{
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505A")]
		[Address(RVA = "0x1A77778", Offset = "0x1A77778", VA = "0x7BBC277778")]
		private void RefreshTokenView()
		{
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505B")]
		[Address(RVA = "0x1A778D4", Offset = "0x1A778D4", VA = "0x7BBC2778D4")]
		private void RefreshPeakDayView()
		{
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505C")]
		[Address(RVA = "0x1A79484", Offset = "0x1A79484", VA = "0x7BBC279484")]
		private void RefreshGroupView(bool rechooseGroup)
		{
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505D")]
		[Address(RVA = "0x1A79EE8", Offset = "0x1A79EE8", VA = "0x7BBC279EE8")]
		private void RefreshGroupMemberView(int itemIndex)
		{
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505E")]
		[Address(RVA = "0x1A7B85C", Offset = "0x1A7B85C", VA = "0x7BBC27B85C")]
		private void AvatarCrossFade(UIStatedAvatar avatar)
		{
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505F")]
		[Address(RVA = "0x1A7ABC0", Offset = "0x1A7ABC0", VA = "0x7BBC27ABC0")]
		private void RefreshMemberAvatar(GoliathAFKGroupInfo groupInfo)
		{
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005060")]
		[Address(RVA = "0x1A7BA98", Offset = "0x1A7BA98", VA = "0x7BBC27BA98")]
		private void RefreshExchangeStoreView()
		{
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005061")]
		[Address(RVA = "0x1A7BF4C", Offset = "0x1A7BF4C", VA = "0x7BBC27BF4C")]
		private void OnBtnTokenClick()
		{
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005062")]
		[Address(RVA = "0x1A7C09C", Offset = "0x1A7C09C", VA = "0x7BBC27C09C")]
		private void OnBtnRuleClick()
		{
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005063")]
		[Address(RVA = "0x1A7C1B8", Offset = "0x1A7C1B8", VA = "0x7BBC27C1B8")]
		private void OnBtnPeakDayClick()
		{
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005064")]
		[Address(RVA = "0x1A7C4C0", Offset = "0x1A7C4C0", VA = "0x7BBC27C4C0")]
		private void OnBtnWebClick()
		{
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005065")]
		[Address(RVA = "0x1A7C5D4", Offset = "0x1A7C5D4", VA = "0x7BBC27C5D4")]
		private void OnBtnInviteGroupClick()
		{
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005066")]
		[Address(RVA = "0x1A7C810", Offset = "0x1A7C810", VA = "0x7BBC27C810")]
		private void OnBtnCreateOrJoinGroupClick()
		{
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005067")]
		[Address(RVA = "0x1A7C8DC", Offset = "0x1A7C8DC", VA = "0x7BBC27C8DC")]
		private void OnBtnAddFriendClick(int accountIndex)
		{
		}

		// Token: 0x06005068 RID: 20584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005068")]
		[Address(RVA = "0x1A78248", Offset = "0x1A78248", VA = "0x7BBC278248")]
		private void OnTopTabSelect(UIGoliathMainController.ETabType tabType)
		{
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005069")]
		[Address(RVA = "0x1A7CAF4", Offset = "0x1A7CAF4", VA = "0x7BBC27CAF4")]
		private void OnEventCallback(params object[] data)
		{
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506A")]
		[Address(RVA = "0x1A79BEC", Offset = "0x1A79BEC", VA = "0x7BBC279BEC")]
		private void OnSelectGroup(params object[] data)
		{
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506B")]
		[Address(RVA = "0x1A7CC9C", Offset = "0x1A7CC9C", VA = "0x7BBC27CC9C")]
		private void OnGuideClick()
		{
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506C")]
		[Address(RVA = "0x1A7CC88", Offset = "0x1A7CC88", VA = "0x7BBC27CC88")]
		private void OnGroupStart(int index)
		{
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506D")]
		[Address(RVA = "0x1A7CDA8", Offset = "0x1A7CDA8", VA = "0x7BBC27CDA8", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x00018690 File Offset: 0x00016890
		[Token(Token = "0x600506E")]
		[Address(RVA = "0x1A7D3C0", Offset = "0x1A7D3C0", VA = "0x7BBC27D3C0", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506F")]
		[Address(RVA = "0x1A7D464", Offset = "0x1A7D464", VA = "0x7BBC27D464")]
		public UIGoliathMainController()
		{
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005070")]
		[Address(RVA = "0x1A7D7B4", Offset = "0x1A7D7B4", VA = "0x7BBC27D7B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DFCC", Offset = "0x113DFCC")]
		private void <OnUIInit>b__39_0()
		{
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005071")]
		[Address(RVA = "0x1A7D7BC", Offset = "0x1A7D7BC", VA = "0x7BBC27D7BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DFDC", Offset = "0x113DFDC")]
		private void <OnUIInit>b__39_1()
		{
		}

		// Token: 0x040076BF RID: 30399
		[Token(Token = "0x40076BF")]
		[FieldOffset(Offset = "0xB8")]
		private UIGoliathMainView m_View;

		// Token: 0x040076C0 RID: 30400
		[Token(Token = "0x40076C0")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x040076C1 RID: 30401
		[Token(Token = "0x40076C1")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelGoliath m_ModelGoliath;

		// Token: 0x040076C2 RID: 30402
		[Token(Token = "0x40076C2")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelFriends m_ModelFriends;

		// Token: 0x040076C3 RID: 30403
		[Token(Token = "0x40076C3")]
		[FieldOffset(Offset = "0xD8")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040076C4 RID: 30404
		[Token(Token = "0x40076C4")]
		[FieldOffset(Offset = "0xE0")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x040076C5 RID: 30405
		[Token(Token = "0x40076C5")]
		[FieldOffset(Offset = "0xE8")]
		private UIModelAvatarProfile m_ModelAvatar;

		// Token: 0x040076C6 RID: 30406
		[Token(Token = "0x40076C6")]
		[FieldOffset(Offset = "0xF0")]
		public Transform m_ModelTransfrom;

		// Token: 0x040076C7 RID: 30407
		[Token(Token = "0x40076C7")]
		[FieldOffset(Offset = "0xF8")]
		private UIGoliathGroupItemController m_MainGroupCtrl;

		// Token: 0x040076C8 RID: 30408
		[Token(Token = "0x40076C8")]
		[FieldOffset(Offset = "0x100")]
		private List<UIGoliathOtherGroupItemController> m_SubGroupCtrlList;

		// Token: 0x040076C9 RID: 30409
		[Token(Token = "0x40076C9")]
		[FieldOffset(Offset = "0x108")]
		private UIRightReigonClickMask m_GuideClickMask;

		// Token: 0x040076CA RID: 30410
		[Token(Token = "0x40076CA")]
		[FieldOffset(Offset = "0x110")]
		private int m_CurItemIndex;

		// Token: 0x040076CB RID: 30411
		[Token(Token = "0x40076CB")]
		[FieldOffset(Offset = "0x118")]
		private ulong m_GroupToSelect;

		// Token: 0x040076CC RID: 30412
		[Token(Token = "0x40076CC")]
		[FieldOffset(Offset = "0x120")]
		private bool m_FirstSelectGroup;

		// Token: 0x040076CD RID: 30413
		[Token(Token = "0x40076CD")]
		[FieldOffset(Offset = "0x124")]
		private uint m_AutoPeakDay;

		// Token: 0x040076CE RID: 30414
		[Token(Token = "0x40076CE")]
		private const int MAX_SUB_GROUP_NUM = 2;

		// Token: 0x040076CF RID: 30415
		[Token(Token = "0x40076CF")]
		private const int MAX_NUM_PER_TEAM = 4;

		// Token: 0x040076D0 RID: 30416
		[Token(Token = "0x40076D0")]
		private const int m_CaptionAccountIndex = 1;

		// Token: 0x040076D1 RID: 30417
		[Token(Token = "0x40076D1")]
		[FieldOffset(Offset = "0x128")]
		private int[] m_NormalAccountIndexArray;

		// Token: 0x040076D2 RID: 30418
		[Token(Token = "0x40076D2")]
		[FieldOffset(Offset = "0x130")]
		private ulong[] m_AccountIdArray;

		// Token: 0x040076D3 RID: 30419
		[Token(Token = "0x40076D3")]
		[FieldOffset(Offset = "0x138")]
		private List<UILabel> m_MemberNameLabelList;

		// Token: 0x040076D4 RID: 30420
		[Token(Token = "0x40076D4")]
		[FieldOffset(Offset = "0x140")]
		private List<UIButton> m_BtnInviteGroupList;

		// Token: 0x040076D5 RID: 30421
		[Token(Token = "0x40076D5")]
		[FieldOffset(Offset = "0x148")]
		private List<UIButton> m_BtnAddFriendList;

		// Token: 0x040076D6 RID: 30422
		[Token(Token = "0x40076D6")]
		[FieldOffset(Offset = "0x150")]
		private List<IGoliathGroupItem> m_GroupItemList;

		// Token: 0x040076D7 RID: 30423
		[Token(Token = "0x40076D7")]
		[FieldOffset(Offset = "0x158")]
		private LimitedEventStore m_ExchangeStoreData;

		// Token: 0x040076D8 RID: 30424
		[Token(Token = "0x40076D8")]
		[FieldOffset(Offset = "0x160")]
		private GameObject m_GoliathCar;

		// Token: 0x040076D9 RID: 30425
		[Token(Token = "0x40076D9")]
		[FieldOffset(Offset = "0x168")]
		private List<UIMaleAvatar> m_MaleAvatarList;

		// Token: 0x040076DA RID: 30426
		[Token(Token = "0x40076DA")]
		[FieldOffset(Offset = "0x170")]
		private List<Animator> m_AvatarAnimatorList;

		// Token: 0x040076DB RID: 30427
		[Token(Token = "0x40076DB")]
		[FieldOffset(Offset = "0x178")]
		private RuntimeAnimatorController m_AnimatorCtrl;

		// Token: 0x040076DC RID: 30428
		[Token(Token = "0x40076DC")]
		[FieldOffset(Offset = "0x180")]
		public float[] m_NotchModelPosOffset;

		// Token: 0x040076DD RID: 30429
		[Token(Token = "0x40076DD")]
		[FieldOffset(Offset = "0x188")]
		public float[] m_ModelPosOffset;

		// Token: 0x040076DE RID: 30430
		[Token(Token = "0x40076DE")]
		[FieldOffset(Offset = "0x190")]
		public float[] m_ScreenShreshold;

		// Token: 0x040076DF RID: 30431
		[Token(Token = "0x40076DF")]
		[FieldOffset(Offset = "0x198")]
		private HashSet<uint> m_GuideNeedToDeal;

		// Token: 0x040076E0 RID: 30432
		[Token(Token = "0x40076E0")]
		[FieldOffset(Offset = "0x1A0")]
		private uint[] m_AvatarWeaponArray;

		// Token: 0x040076E1 RID: 30433
		[Token(Token = "0x40076E1")]
		[FieldOffset(Offset = "0x1A8")]
		private Camera m_CarCamera;

		// Token: 0x040076E2 RID: 30434
		[Token(Token = "0x40076E2")]
		[FieldOffset(Offset = "0x1B0")]
		private UIGoliathMainController.ETabType m_TopTabType;

		// Token: 0x02001382 RID: 4994
		[Token(Token = "0x2001382")]
		public enum ETabType
		{
			// Token: 0x040076E4 RID: 30436
			[Token(Token = "0x40076E4")]
			None,
			// Token: 0x040076E5 RID: 30437
			[Token(Token = "0x40076E5")]
			Group,
			// Token: 0x040076E6 RID: 30438
			[Token(Token = "0x40076E6")]
			Store
		}

		// Token: 0x02001383 RID: 4995
		[Token(Token = "0x2001383")]
		public enum EGuideState
		{
			// Token: 0x040076E8 RID: 30440
			[Token(Token = "0x40076E8")]
			RightRegion,
			// Token: 0x040076E9 RID: 30441
			[Token(Token = "0x40076E9")]
			LeftRegion,
			// Token: 0x040076EA RID: 30442
			[Token(Token = "0x40076EA")]
			StoreTab,
			// Token: 0x040076EB RID: 30443
			[Token(Token = "0x40076EB")]
			BtnCreate,
			// Token: 0x040076EC RID: 30444
			[Token(Token = "0x40076EC")]
			BtnInvite,
			// Token: 0x040076ED RID: 30445
			[Token(Token = "0x40076ED")]
			BtnRecruit,
			// Token: 0x040076EE RID: 30446
			[Token(Token = "0x40076EE")]
			BtnCopy,
			// Token: 0x040076EF RID: 30447
			[Token(Token = "0x40076EF")]
			Finished
		}

		// Token: 0x02001384 RID: 4996
		[Token(Token = "0x2001384")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB730", Offset = "0x10EB730")]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x06005072 RID: 20594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005072")]
			[Address(RVA = "0x1A776FC", Offset = "0x1A776FC", VA = "0x7BBC2776FC")]
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x06005073 RID: 20595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005073")]
			[Address(RVA = "0x1A7D7C4", Offset = "0x1A7D7C4", VA = "0x7BBC27D7C4")]
			internal void <OnUIInit>b__2()
			{
			}

			// Token: 0x040076F0 RID: 30448
			[Token(Token = "0x40076F0")]
			[FieldOffset(Offset = "0x10")]
			public int friendIndex;

			// Token: 0x040076F1 RID: 30449
			[Token(Token = "0x40076F1")]
			[FieldOffset(Offset = "0x18")]
			public UIGoliathMainController <>4__this;
		}

		// Token: 0x02001385 RID: 4997
		[Token(Token = "0x2001385")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB740", Offset = "0x10EB740")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x06005074 RID: 20596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005074")]
			[Address(RVA = "0x1A7947C", Offset = "0x1A7947C", VA = "0x7BBC27947C")]
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x06005075 RID: 20597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005075")]
			[Address(RVA = "0x1A7D7F8", Offset = "0x1A7D7F8", VA = "0x7BBC27D7F8")]
			internal void <RefreshGuideBgView>b__0()
			{
			}

			// Token: 0x040076F2 RID: 30450
			[Token(Token = "0x40076F2")]
			[FieldOffset(Offset = "0x10")]
			public UIWidget widget;

			// Token: 0x040076F3 RID: 30451
			[Token(Token = "0x40076F3")]
			[FieldOffset(Offset = "0x18")]
			public UIWidget tar;

			// Token: 0x040076F4 RID: 30452
			[Token(Token = "0x40076F4")]
			[FieldOffset(Offset = "0x20")]
			public Material mat;
		}
	}
}
