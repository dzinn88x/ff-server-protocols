using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013BE RID: 5054
	[Token(Token = "0x20013BE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBCF0", Offset = "0x10EBCF0")]
	public class UISuperCarInviteItemController : UIEasyListItemController
	{
		// Token: 0x0600526C RID: 21100 RVA: 0x00018C30 File Offset: 0x00016E30
		[Token(Token = "0x600526C")]
		[Address(RVA = "0x2145C34", Offset = "0x2145C34", VA = "0x7BBC945C34")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526D")]
		[Address(RVA = "0x2145C84", Offset = "0x2145C84", VA = "0x7BBC945C84", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526E")]
		[Address(RVA = "0x2145DEC", Offset = "0x2145DEC", VA = "0x7BBC945DEC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526F")]
		[Address(RVA = "0x2145DF4", Offset = "0x2145DF4", VA = "0x7BBC945DF4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005270")]
		[Address(RVA = "0x2145EA4", Offset = "0x2145EA4", VA = "0x7BBC945EA4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005271")]
		[Address(RVA = "0x21461E4", Offset = "0x21461E4", VA = "0x7BBC9461E4")]
		private void OnBtnInviteClick()
		{
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005272")]
		[Address(RVA = "0x21464F8", Offset = "0x21464F8", VA = "0x7BBC9464F8")]
		public UISuperCarInviteItemController()
		{
		}

		// Token: 0x04007871 RID: 30833
		[Token(Token = "0x4007871")]
		[FieldOffset(Offset = "0x70")]
		private UISuperCarInviteItemView m_View;

		// Token: 0x04007872 RID: 30834
		[Token(Token = "0x4007872")]
		[FieldOffset(Offset = "0x78")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x04007873 RID: 30835
		[Token(Token = "0x4007873")]
		[FieldOffset(Offset = "0x80")]
		private UIModelSuperCar m_ModelSuperCar;

		// Token: 0x04007874 RID: 30836
		[Token(Token = "0x4007874")]
		[FieldOffset(Offset = "0x88")]
		private ulong m_AccountID;

		// Token: 0x04007875 RID: 30837
		[Token(Token = "0x4007875")]
		[FieldOffset(Offset = "0x90")]
		private FastBigEventMsg m_Msg;

		// Token: 0x04007876 RID: 30838
		[Token(Token = "0x4007876")]
		[FieldOffset(Offset = "0x98")]
		private UIBaseProfileInfoController m_BaseProfile;

		// Token: 0x04007877 RID: 30839
		[Token(Token = "0x4007877")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_IsGameFriend;
	}
}
