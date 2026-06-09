using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017D0 RID: 6096
	[Token(Token = "0x20017D0")]
	public class UIFriendRequestItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06007561 RID: 30049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000951")]
		public UIDragScrollView DragComponent
		{
			[Token(Token = "0x6007561")]
			[Address(RVA = "0x159AA54", Offset = "0x159AA54", VA = "0x7BBBD9AA54")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x00020988 File Offset: 0x0001EB88
		[Token(Token = "0x6007562")]
		[Address(RVA = "0x159AAEC", Offset = "0x159AAEC", VA = "0x7BBBD9AAEC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06007563 RID: 30051 RVA: 0x000209A0 File Offset: 0x0001EBA0
		[Token(Token = "0x17000952")]
		public Vector2 ItemViewSize
		{
			[Token(Token = "0x6007563")]
			[Address(RVA = "0x159AB3C", Offset = "0x159AB3C", VA = "0x7BBBD9AB3C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007564")]
		[Address(RVA = "0x159ACA0", Offset = "0x159ACA0", VA = "0x7BBBD9ACA0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007565")]
		[Address(RVA = "0x159AFEC", Offset = "0x159AFEC", VA = "0x7BBBD9AFEC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007566")]
		[Address(RVA = "0x159B018", Offset = "0x159B018", VA = "0x7BBBD9B018", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007567 RID: 30055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007567")]
		[Address(RVA = "0x159B0CC", Offset = "0x159B0CC", VA = "0x7BBBD9B0CC", Slot = "29")]
		public override void OnItemBtnClick()
		{
		}

		// Token: 0x06007568 RID: 30056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007568")]
		[Address(RVA = "0x159B244", Offset = "0x159B244", VA = "0x7BBBD9B244")]
		public void SetData(FriendAccountInfo accountInfo)
		{
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007569")]
		[Address(RVA = "0x159B528", Offset = "0x159B528", VA = "0x7BBBD9B528")]
		public void ClearData()
		{
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600756A")]
		[Address(RVA = "0x159B56C", Offset = "0x159B56C", VA = "0x7BBBD9B56C")]
		private void OnRefuseBtnClick()
		{
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600756B")]
		[Address(RVA = "0x159B668", Offset = "0x159B668", VA = "0x7BBBD9B668")]
		private void OnBlockBtnClick()
		{
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600756C")]
		[Address(RVA = "0x159BA80", Offset = "0x159BA80", VA = "0x7BBBD9BA80")]
		private void OnCancelBlockBtnClick()
		{
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600756D")]
		[Address(RVA = "0x159BBE4", Offset = "0x159BBE4", VA = "0x7BBBD9BBE4")]
		private void OnAgreeBtnClick()
		{
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600756E")]
		[Address(RVA = "0x159BCE0", Offset = "0x159BCE0", VA = "0x7BBBD9BCE0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600756F")]
		[Address(RVA = "0x159BE04", Offset = "0x159BE04", VA = "0x7BBBD9BE04", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x000209B8 File Offset: 0x0001EBB8
		[Token(Token = "0x6007570")]
		[Address(RVA = "0x159BED0", Offset = "0x159BED0", VA = "0x7BBBD9BED0", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007571")]
		[Address(RVA = "0x159BF14", Offset = "0x159BF14", VA = "0x7BBBD9BF14")]
		public UIFriendRequestItemController()
		{
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007572")]
		[Address(RVA = "0x159BF1C", Offset = "0x159BF1C", VA = "0x7BBBD9BF1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11419D0", Offset = "0x11419D0")]
		private void <OnBlockBtnClick>b__18_0()
		{
		}

		// Token: 0x04008CD5 RID: 36053
		[Token(Token = "0x4008CD5")]
		[FieldOffset(Offset = "0x70")]
		private UIFriendRequestItemView m_View;

		// Token: 0x04008CD6 RID: 36054
		[Token(Token = "0x4008CD6")]
		[FieldOffset(Offset = "0x78")]
		private FriendAccountInfo m_Data;

		// Token: 0x04008CD7 RID: 36055
		[Token(Token = "0x4008CD7")]
		[FieldOffset(Offset = "0x80")]
		private UIDragScrollView m_DragComponent;

		// Token: 0x04008CD8 RID: 36056
		[Token(Token = "0x4008CD8")]
		[FieldOffset(Offset = "0x88")]
		private BoxCollider m_ItemCollider;

		// Token: 0x04008CD9 RID: 36057
		[Token(Token = "0x4008CD9")]
		[FieldOffset(Offset = "0x90")]
		private EFriendTabType tabType;

		// Token: 0x04008CDA RID: 36058
		[Token(Token = "0x4008CDA")]
		[FieldOffset(Offset = "0x98")]
		private UIBaseProfileInfoController m_BaseProfile;
	}
}
