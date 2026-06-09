using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017C9 RID: 6089
	[Token(Token = "0x20017C9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2C54", Offset = "0x10F2C54")]
	public class UIFriendItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06007505 RID: 29957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700093F")]
		public UIDragScrollView DragComponent
		{
			[Token(Token = "0x6007505")]
			[Address(RVA = "0x158E3C8", Offset = "0x158E3C8", VA = "0x7BBBD8E3C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007506 RID: 29958 RVA: 0x000207F0 File Offset: 0x0001E9F0
		[Token(Token = "0x6007506")]
		[Address(RVA = "0x158E460", Offset = "0x158E460", VA = "0x7BBBD8E460")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06007507 RID: 29959 RVA: 0x00020808 File Offset: 0x0001EA08
		[Token(Token = "0x17000940")]
		public Vector2 ItemViewSize
		{
			[Token(Token = "0x6007507")]
			[Address(RVA = "0x158E4B0", Offset = "0x158E4B0", VA = "0x7BBBD8E4B0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007508")]
		[Address(RVA = "0x158E614", Offset = "0x158E614", VA = "0x7BBBD8E614", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007509 RID: 29961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007509")]
		[Address(RVA = "0x158EB90", Offset = "0x158EB90", VA = "0x7BBBD8EB90")]
		public void SetWidth(int width)
		{
		}

		// Token: 0x0600750A RID: 29962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600750A")]
		[Address(RVA = "0x158EC64", Offset = "0x158EC64", VA = "0x7BBBD8EC64")]
		private void OnSendGiftBtnClick()
		{
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600750B")]
		[Address(RVA = "0x158EFCC", Offset = "0x158EFCC", VA = "0x7BBBD8EFCC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600750C")]
		[Address(RVA = "0x158EFF8", Offset = "0x158EFF8", VA = "0x7BBBD8EFF8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600750D")]
		[Address(RVA = "0x158F0B8", Offset = "0x158F0B8", VA = "0x7BBBD8F0B8", Slot = "29")]
		public override void OnItemBtnClick()
		{
		}

		// Token: 0x0600750E RID: 29966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600750E")]
		[Address(RVA = "0x158F720", Offset = "0x158F720", VA = "0x7BBBD8F720")]
		public void SetData(FriendAccountInfo accountInfo)
		{
		}

		// Token: 0x0600750F RID: 29967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600750F")]
		[Address(RVA = "0x1591F60", Offset = "0x1591F60", VA = "0x7BBBD91F60")]
		public void ClearData()
		{
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007510")]
		[Address(RVA = "0x15920B4", Offset = "0x15920B4", VA = "0x7BBBD920B4")]
		private void OnChatBtnClick()
		{
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007511")]
		[Address(RVA = "0x1592478", Offset = "0x1592478", VA = "0x7BBBD92478")]
		private void OnAddBtnClick()
		{
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007512")]
		[Address(RVA = "0x15927B8", Offset = "0x15927B8", VA = "0x7BBBD927B8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007513")]
		[Address(RVA = "0x1592A78", Offset = "0x1592A78", VA = "0x7BBBD92A78", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x00020820 File Offset: 0x0001EA20
		[Token(Token = "0x6007514")]
		[Address(RVA = "0x1592A7C", Offset = "0x1592A7C", VA = "0x7BBBD92A7C", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007515")]
		[Address(RVA = "0x1592AC0", Offset = "0x1592AC0", VA = "0x7BBBD92AC0")]
		public UIFriendItemController()
		{
		}

		// Token: 0x04008CA1 RID: 36001
		[Token(Token = "0x4008CA1")]
		[FieldOffset(Offset = "0x70")]
		private UIFriendItemView m_View;

		// Token: 0x04008CA2 RID: 36002
		[Token(Token = "0x4008CA2")]
		[FieldOffset(Offset = "0x78")]
		private FriendAccountInfo m_Data;

		// Token: 0x04008CA3 RID: 36003
		[Token(Token = "0x4008CA3")]
		[FieldOffset(Offset = "0x80")]
		private UIDragScrollView m_DragComponent;

		// Token: 0x04008CA4 RID: 36004
		[Token(Token = "0x4008CA4")]
		[FieldOffset(Offset = "0x88")]
		private BoxCollider m_ItemCollider;

		// Token: 0x04008CA5 RID: 36005
		[Token(Token = "0x4008CA5")]
		[FieldOffset(Offset = "0x90")]
		private EFriendTabType tabType;

		// Token: 0x04008CA6 RID: 36006
		[Token(Token = "0x4008CA6")]
		[FieldOffset(Offset = "0x98")]
		private UIBaseProfileInfoController m_BaseProfile;

		// Token: 0x04008CA7 RID: 36007
		[Token(Token = "0x4008CA7")]
		[FieldOffset(Offset = "0xA0")]
		private string m_GiftCondition;

		// Token: 0x04008CA8 RID: 36008
		[Token(Token = "0x4008CA8")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_friend_tag;
	}
}
