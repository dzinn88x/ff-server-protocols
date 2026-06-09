using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017CE RID: 6094
	[Token(Token = "0x20017CE")]
	public class UIFriendRequestController : UIPopupWindowController, IUIModelDataChangeObserver, ITipsDelegate, IEasyList
	{
		// Token: 0x06007549 RID: 30025 RVA: 0x00020940 File Offset: 0x0001EB40
		[Token(Token = "0x6007549")]
		[Address(RVA = "0x1598B50", Offset = "0x1598B50", VA = "0x7BBBD98B50")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x0600754A RID: 30026 RVA: 0x00020958 File Offset: 0x0001EB58
		// (set) Token: 0x0600754B RID: 30027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000950")]
		public EFriendTabType CurrentTabType
		{
			[Token(Token = "0x600754A")]
			[Address(RVA = "0x1598BA0", Offset = "0x1598BA0", VA = "0x7BBBD98BA0")]
			get
			{
				return EFriendTabType.eFriend;
			}
			[Token(Token = "0x600754B")]
			[Address(RVA = "0x1598BA8", Offset = "0x1598BA8", VA = "0x7BBBD98BA8")]
			private set
			{
			}
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600754C")]
		[Address(RVA = "0x1598FE8", Offset = "0x1598FE8", VA = "0x7BBBD98FE8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600754D")]
		[Address(RVA = "0x15994F4", Offset = "0x15994F4", VA = "0x7BBBD994F4", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600754E")]
		[Address(RVA = "0x1599564", Offset = "0x1599564", VA = "0x7BBBD99564", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600754F")]
		[Address(RVA = "0x159974C", Offset = "0x159974C", VA = "0x7BBBD9974C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x00020970 File Offset: 0x0001EB70
		[Token(Token = "0x6007550")]
		[Address(RVA = "0x1599EFC", Offset = "0x1599EFC", VA = "0x7BBBD99EFC", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007551")]
		[Address(RVA = "0x1599F40", Offset = "0x1599F40", VA = "0x7BBBD99F40", Slot = "42")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007552")]
		[Address(RVA = "0x1599F44", Offset = "0x1599F44", VA = "0x7BBBD99F44", Slot = "43")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007553")]
		[Address(RVA = "0x1599FD8", Offset = "0x1599FD8", VA = "0x7BBBD99FD8", Slot = "44")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007554")]
		[Address(RVA = "0x159A008", Offset = "0x159A008", VA = "0x7BBBD9A008")]
		private void OnSelectFriendRequest()
		{
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007555")]
		[Address(RVA = "0x159A10C", Offset = "0x159A10C", VA = "0x7BBBD9A10C")]
		private void OnSelectBlackList()
		{
		}

		// Token: 0x06007556 RID: 30038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007556")]
		[Address(RVA = "0x159A1AC", Offset = "0x159A1AC", VA = "0x7BBBD9A1AC")]
		private void ChangeToBlackList()
		{
		}

		// Token: 0x06007557 RID: 30039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007557")]
		[Address(RVA = "0x1598DD0", Offset = "0x1598DD0", VA = "0x7BBBD98DD0")]
		private void UpdateShareUI()
		{
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007558")]
		[Address(RVA = "0x1599B04", Offset = "0x1599B04", VA = "0x7BBBD99B04")]
		private void RefreshViewInfo()
		{
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007559")]
		[Address(RVA = "0x159A294", Offset = "0x159A294", VA = "0x7BBBD9A294")]
		private void OnBtnRefuseAllClick()
		{
		}

		// Token: 0x0600755A RID: 30042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600755A")]
		[Address(RVA = "0x159A578", Offset = "0x159A578", VA = "0x7BBBD9A578")]
		private void OnBtnCheckBoxClick()
		{
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600755B")]
		[Address(RVA = "0x1599888", Offset = "0x1599888", VA = "0x7BBBD99888")]
		private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
		{
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600755C")]
		[Address(RVA = "0x159A720", Offset = "0x159A720", VA = "0x7BBBD9A720")]
		private void OnGetEventReward(params object[] parameters)
		{
		}

		// Token: 0x0600755D RID: 30045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600755D")]
		[Address(RVA = "0x159A894", Offset = "0x159A894", VA = "0x7BBBD9A894")]
		public UIFriendRequestController()
		{
		}

		// Token: 0x04008CD0 RID: 36048
		[Token(Token = "0x4008CD0")]
		[FieldOffset(Offset = "0x98")]
		private UIFriendRequestView m_View;

		// Token: 0x04008CD1 RID: 36049
		[Token(Token = "0x4008CD1")]
		[FieldOffset(Offset = "0xA0")]
		private EFriendTabType m_CurrentType;

		// Token: 0x04008CD2 RID: 36050
		[Token(Token = "0x4008CD2")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_currentPushType;

		// Token: 0x020017CF RID: 6095
		[Token(Token = "0x20017CF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2D34", Offset = "0x10F2D34")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600755F RID: 30047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600755F")]
			[Address(RVA = "0x159A908", Offset = "0x159A908", VA = "0x7BBBD9A908")]
			public <>c()
			{
			}

			// Token: 0x06007560 RID: 30048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007560")]
			[Address(RVA = "0x159A910", Offset = "0x159A910", VA = "0x7BBBD9A910")]
			internal void <OnBtnRefuseAllClick>b__20_0()
			{
			}

			// Token: 0x04008CD3 RID: 36051
			[Token(Token = "0x4008CD3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIFriendRequestController.<>c <>9;

			// Token: 0x04008CD4 RID: 36052
			[Token(Token = "0x4008CD4")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__20_0;
		}
	}
}
