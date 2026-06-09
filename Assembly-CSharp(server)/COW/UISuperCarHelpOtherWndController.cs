using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020013B9 RID: 5049
	[Token(Token = "0x20013B9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBC38", Offset = "0x10EBC38")]
	public class UISuperCarHelpOtherWndController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x0600524D RID: 21069 RVA: 0x00018BD0 File Offset: 0x00016DD0
		[Token(Token = "0x600524D")]
		[Address(RVA = "0x2143C6C", Offset = "0x2143C6C", VA = "0x7BBC943C6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524E")]
		[Address(RVA = "0x2143CBC", Offset = "0x2143CBC", VA = "0x7BBC943CBC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524F")]
		[Address(RVA = "0x2143FA4", Offset = "0x2143FA4", VA = "0x7BBC943FA4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005250")]
		[Address(RVA = "0x2144008", Offset = "0x2144008", VA = "0x7BBC944008", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005251")]
		[Address(RVA = "0x2143FCC", Offset = "0x2143FCC", VA = "0x7BBC943FCC")]
		private void RefreshViewData()
		{
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005252")]
		[Address(RVA = "0x2144068", Offset = "0x2144068", VA = "0x7BBC944068")]
		private void RefreshGameOrPlatformFriendView(UIModelSuperCar.EFriendCategory category)
		{
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005253")]
		[Address(RVA = "0x214438C", Offset = "0x214438C", VA = "0x7BBC94438C")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005254")]
		[Address(RVA = "0x2144394", Offset = "0x2144394", VA = "0x7BBC944394")]
		private void OnBtnGameFriendClick()
		{
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005255")]
		[Address(RVA = "0x214439C", Offset = "0x214439C", VA = "0x7BBC94439C")]
		private void OnBtnPlatformFriendClick()
		{
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005256")]
		[Address(RVA = "0x21443A8", Offset = "0x21443A8", VA = "0x7BBC9443A8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x00018BE8 File Offset: 0x00016DE8
		[Token(Token = "0x6005257")]
		[Address(RVA = "0x21445B4", Offset = "0x21445B4", VA = "0x7BBC9445B4", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005258")]
		[Address(RVA = "0x2144618", Offset = "0x2144618", VA = "0x7BBC944618", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005259")]
		[Address(RVA = "0x21446D4", Offset = "0x21446D4", VA = "0x7BBC9446D4", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525A")]
		[Address(RVA = "0x2144704", Offset = "0x2144704", VA = "0x7BBC944704")]
		public UISuperCarHelpOtherWndController()
		{
		}

		// Token: 0x04007858 RID: 30808
		[Token(Token = "0x4007858")]
		[FieldOffset(Offset = "0x98")]
		private UISuperCarHelpOtherWndView m_View;

		// Token: 0x04007859 RID: 30809
		[Token(Token = "0x4007859")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelFriends m_ModelFriends;

		// Token: 0x0400785A RID: 30810
		[Token(Token = "0x400785A")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x0400785B RID: 30811
		[Token(Token = "0x400785B")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelSuperCar m_ModelSuperCar;

		// Token: 0x0400785C RID: 30812
		[Token(Token = "0x400785C")]
		[FieldOffset(Offset = "0xB8")]
		private List<SuperCarFriendItemData> m_FriendInfos;

		// Token: 0x0400785D RID: 30813
		[Token(Token = "0x400785D")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelSuperCar.EFriendCategory m_CurCategory;

		// Token: 0x0400785E RID: 30814
		[Token(Token = "0x400785E")]
		[FieldOffset(Offset = "0xC8")]
		private ulong m_GroupID;

		// Token: 0x0400785F RID: 30815
		[Token(Token = "0x400785F")]
		[FieldOffset(Offset = "0xD0")]
		private string m_CaptainName;

		// Token: 0x04007860 RID: 30816
		[Token(Token = "0x4007860")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_MemberCnt;

		// Token: 0x020013BA RID: 5050
		[Token(Token = "0x20013BA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBC70", Offset = "0x10EBC70")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600525B RID: 21083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600525B")]
			[Address(RVA = "0x2144384", Offset = "0x2144384", VA = "0x7BBC944384")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0600525C RID: 21084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600525C")]
			[Address(RVA = "0x2144764", Offset = "0x2144764", VA = "0x7BBC944764")]
			internal SuperCarFriendItemData <RefreshGameOrPlatformFriendView>b__0(FriendAccountInfo friendInfo)
			{
				return null;
			}

			// Token: 0x04007861 RID: 30817
			[Token(Token = "0x4007861")]
			[FieldOffset(Offset = "0x10")]
			public UISuperCarHelpOtherWndController <>4__this;

			// Token: 0x04007862 RID: 30818
			[Token(Token = "0x4007862")]
			[FieldOffset(Offset = "0x18")]
			public UIModelSuperCar.EFriendCategory category;
		}
	}
}
