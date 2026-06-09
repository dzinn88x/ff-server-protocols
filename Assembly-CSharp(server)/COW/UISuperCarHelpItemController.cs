using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013B8 RID: 5048
	[Token(Token = "0x20013B8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBC00", Offset = "0x10EBC00")]
	public class UISuperCarHelpItemController : UIEasyListItemController
	{
		// Token: 0x06005246 RID: 21062 RVA: 0x00018BB8 File Offset: 0x00016DB8
		[Token(Token = "0x6005246")]
		[Address(RVA = "0x2143470", Offset = "0x2143470", VA = "0x7BBC943470")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005247")]
		[Address(RVA = "0x21434C0", Offset = "0x21434C0", VA = "0x7BBC9434C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005248")]
		[Address(RVA = "0x21435FC", Offset = "0x21435FC", VA = "0x7BBC9435FC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005249")]
		[Address(RVA = "0x2143604", Offset = "0x2143604", VA = "0x7BBC943604", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524A")]
		[Address(RVA = "0x21436B4", Offset = "0x21436B4", VA = "0x7BBC9436B4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524B")]
		[Address(RVA = "0x2143904", Offset = "0x2143904", VA = "0x7BBC943904")]
		private void OnBtnInviteClick()
		{
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524C")]
		[Address(RVA = "0x2143AB8", Offset = "0x2143AB8", VA = "0x7BBC943AB8")]
		public UISuperCarHelpItemController()
		{
		}

		// Token: 0x04007853 RID: 30803
		[Token(Token = "0x4007853")]
		[FieldOffset(Offset = "0x70")]
		private UISuperCarInviteItemView m_View;

		// Token: 0x04007854 RID: 30804
		[Token(Token = "0x4007854")]
		[FieldOffset(Offset = "0x78")]
		private UIModelSuperCar m_ModelSuperCar;

		// Token: 0x04007855 RID: 30805
		[Token(Token = "0x4007855")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsGameFriend;

		// Token: 0x04007856 RID: 30806
		[Token(Token = "0x4007856")]
		[FieldOffset(Offset = "0x88")]
		private ulong m_AccountID;

		// Token: 0x04007857 RID: 30807
		[Token(Token = "0x4007857")]
		[FieldOffset(Offset = "0x90")]
		private UIBaseProfileInfoController m_BaseProfile;
	}
}
