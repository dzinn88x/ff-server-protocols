using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020013BF RID: 5055
	[Token(Token = "0x20013BF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBD28", Offset = "0x10EBD28")]
	public class UISuperCarInviteWndController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06005273 RID: 21107 RVA: 0x00018C48 File Offset: 0x00016E48
		[Token(Token = "0x6005273")]
		[Address(RVA = "0x21466AC", Offset = "0x21466AC", VA = "0x7BBC9466AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005274")]
		[Address(RVA = "0x21466FC", Offset = "0x21466FC", VA = "0x7BBC9466FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005275")]
		[Address(RVA = "0x2146F58", Offset = "0x2146F58", VA = "0x7BBC946F58", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005276")]
		[Address(RVA = "0x2146FCC", Offset = "0x2146FCC", VA = "0x7BBC946FCC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005277")]
		[Address(RVA = "0x2146D34", Offset = "0x2146D34", VA = "0x7BBC946D34")]
		public void InitInviteData()
		{
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005278")]
		[Address(RVA = "0x2146B40", Offset = "0x2146B40", VA = "0x7BBC946B40")]
		private void InitViewData()
		{
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005279")]
		[Address(RVA = "0x2146F80", Offset = "0x2146F80", VA = "0x7BBC946F80")]
		private void RefreshViewData()
		{
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527A")]
		[Address(RVA = "0x214702C", Offset = "0x214702C", VA = "0x7BBC94702C")]
		private void RefreshGameOrPlatformFriendView(UIModelSuperCar.EFriendCategory category)
		{
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527B")]
		[Address(RVA = "0x2147350", Offset = "0x2147350", VA = "0x7BBC947350")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527C")]
		[Address(RVA = "0x2147358", Offset = "0x2147358", VA = "0x7BBC947358")]
		private void OnBtnGameFriendClick()
		{
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527D")]
		[Address(RVA = "0x2147360", Offset = "0x2147360", VA = "0x7BBC947360")]
		private void OnBtnPlatformFriendClick()
		{
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527E")]
		[Address(RVA = "0x214736C", Offset = "0x214736C", VA = "0x7BBC94736C")]
		private void OnBtnLineInviteClick()
		{
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527F")]
		[Address(RVA = "0x2147708", Offset = "0x2147708", VA = "0x7BBC947708")]
		private void OnBtnVKInviteClick()
		{
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005280")]
		[Address(RVA = "0x2147944", Offset = "0x2147944", VA = "0x7BBC947944")]
		private void OnBtnFBInviteClick()
		{
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005281")]
		[Address(RVA = "0x2147D78", Offset = "0x2147D78", VA = "0x7BBC947D78")]
		private void OnBtnOtherInviteClick()
		{
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005282")]
		[Address(RVA = "0x2148044", Offset = "0x2148044", VA = "0x7BBC948044", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x00018C60 File Offset: 0x00016E60
		[Token(Token = "0x6005283")]
		[Address(RVA = "0x21480DC", Offset = "0x21480DC", VA = "0x7BBC9480DC", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005284")]
		[Address(RVA = "0x2148140", Offset = "0x2148140", VA = "0x7BBC948140", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005285")]
		[Address(RVA = "0x21481FC", Offset = "0x21481FC", VA = "0x7BBC9481FC", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005286")]
		[Address(RVA = "0x214822C", Offset = "0x214822C", VA = "0x7BBC94822C")]
		public UISuperCarInviteWndController()
		{
		}

		// Token: 0x04007878 RID: 30840
		[Token(Token = "0x4007878")]
		[FieldOffset(Offset = "0x98")]
		private UISuperCarInviteWndView m_View;

		// Token: 0x04007879 RID: 30841
		[Token(Token = "0x4007879")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelFriends m_ModelFriends;

		// Token: 0x0400787A RID: 30842
		[Token(Token = "0x400787A")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x0400787B RID: 30843
		[Token(Token = "0x400787B")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelSuperCar m_ModelSuperCar;

		// Token: 0x0400787C RID: 30844
		[Token(Token = "0x400787C")]
		[FieldOffset(Offset = "0xB8")]
		private List<SuperCarFriendItemData> m_FriendInfos;

		// Token: 0x0400787D RID: 30845
		[Token(Token = "0x400787D")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelSuperCar.EFriendCategory m_CurCategory;

		// Token: 0x0400787E RID: 30846
		[Token(Token = "0x400787E")]
		[FieldOffset(Offset = "0xC8")]
		private string m_CaptainName;

		// Token: 0x0400787F RID: 30847
		[Token(Token = "0x400787F")]
		[FieldOffset(Offset = "0xD0")]
		private uint m_MemberCnt;

		// Token: 0x020013C0 RID: 5056
		[Token(Token = "0x20013C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBD60", Offset = "0x10EBD60")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06005287 RID: 21127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005287")]
			[Address(RVA = "0x2147348", Offset = "0x2147348", VA = "0x7BBC947348")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x06005288 RID: 21128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005288")]
			[Address(RVA = "0x214828C", Offset = "0x214828C", VA = "0x7BBC94828C")]
			internal SuperCarFriendItemData <RefreshGameOrPlatformFriendView>b__0(FriendAccountInfo friendInfo)
			{
				return null;
			}

			// Token: 0x04007880 RID: 30848
			[Token(Token = "0x4007880")]
			[FieldOffset(Offset = "0x10")]
			public UISuperCarInviteWndController <>4__this;

			// Token: 0x04007881 RID: 30849
			[Token(Token = "0x4007881")]
			[FieldOffset(Offset = "0x18")]
			public UIModelSuperCar.EFriendCategory category;
		}
	}
}
