using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017C5 RID: 6085
	[Token(Token = "0x20017C5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2BD4", Offset = "0x10F2BD4")]
	public class UIFriendCallbackItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060074C8 RID: 29896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700093C")]
		public UIDragScrollView DragComponent
		{
			[Token(Token = "0x60074C8")]
			[Address(RVA = "0x1DC12DC", Offset = "0x1DC12DC", VA = "0x7BBC5C12DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x00020688 File Offset: 0x0001E888
		[Token(Token = "0x60074C9")]
		[Address(RVA = "0x1DC1374", Offset = "0x1DC1374", VA = "0x7BBC5C1374")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060074CA RID: 29898 RVA: 0x000206A0 File Offset: 0x0001E8A0
		[Token(Token = "0x1700093D")]
		public Vector2 ItemViewSize
		{
			[Token(Token = "0x60074CA")]
			[Address(RVA = "0x1DC13C4", Offset = "0x1DC13C4", VA = "0x7BBC5C13C4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074CB")]
		[Address(RVA = "0x1DC1528", Offset = "0x1DC1528", VA = "0x7BBC5C1528", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074CC")]
		[Address(RVA = "0x1DC15F4", Offset = "0x1DC15F4", VA = "0x7BBC5C15F4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074CD")]
		[Address(RVA = "0x1DC16A8", Offset = "0x1DC16A8", VA = "0x7BBC5C16A8")]
		public void SetData(FriendAccountInfo accountInfo)
		{
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074CE")]
		[Address(RVA = "0x1DC1A10", Offset = "0x1DC1A10", VA = "0x7BBC5C1A10")]
		public void ClearData()
		{
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074CF")]
		[Address(RVA = "0x1DC1A14", Offset = "0x1DC1A14", VA = "0x7BBC5C1A14", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074D0")]
		[Address(RVA = "0x1DC1AB0", Offset = "0x1DC1AB0", VA = "0x7BBC5C1AB0", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x000206B8 File Offset: 0x0001E8B8
		[Token(Token = "0x60074D1")]
		[Address(RVA = "0x1DC1AB4", Offset = "0x1DC1AB4", VA = "0x7BBC5C1AB4", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074D2")]
		[Address(RVA = "0x1DC1AF8", Offset = "0x1DC1AF8", VA = "0x7BBC5C1AF8")]
		public UIFriendCallbackItemController()
		{
		}

		// Token: 0x04008C75 RID: 35957
		[Token(Token = "0x4008C75")]
		[FieldOffset(Offset = "0x70")]
		private UIFriendCallbackItemView m_View;

		// Token: 0x04008C76 RID: 35958
		[Token(Token = "0x4008C76")]
		[FieldOffset(Offset = "0x78")]
		private FriendAccountInfo m_Data;

		// Token: 0x04008C77 RID: 35959
		[Token(Token = "0x4008C77")]
		[FieldOffset(Offset = "0x80")]
		private UIDragScrollView m_DragComponent;

		// Token: 0x04008C78 RID: 35960
		[Token(Token = "0x4008C78")]
		[FieldOffset(Offset = "0x88")]
		private BoxCollider m_ItemCollider;
	}
}
