using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016C2 RID: 5826
	[Token(Token = "0x20016C2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0B64", Offset = "0x10F0B64")]
	public class UIAvatarProfileItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06006AC1 RID: 27329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC1")]
		[Address(RVA = "0x208B1B4", Offset = "0x208B1B4", VA = "0x7BBC88B1B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x0001E408 File Offset: 0x0001C608
		[Token(Token = "0x6006AC2")]
		[Address(RVA = "0x208B3E4", Offset = "0x208B3E4", VA = "0x7BBC88B3E4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC3")]
		[Address(RVA = "0x208B434", Offset = "0x208B434", VA = "0x7BBC88B434")]
		public void SetData(AvatarProfileDataOverrided data)
		{
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC4")]
		[Address(RVA = "0x208C210", Offset = "0x208C210", VA = "0x7BBC88C210")]
		private void CheckEffect()
		{
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC5")]
		[Address(RVA = "0x208C8F8", Offset = "0x208C8F8", VA = "0x7BBC88C8F8")]
		private void OnUnlockClick()
		{
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC6")]
		[Address(RVA = "0x208CC68", Offset = "0x208CC68", VA = "0x7BBC88CC68")]
		private void OnAwardClick()
		{
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC7")]
		[Address(RVA = "0x208CDD4", Offset = "0x208CDD4", VA = "0x7BBC88CDD4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC8")]
		[Address(RVA = "0x208CE70", Offset = "0x208CE70", VA = "0x7BBC88CE70", Slot = "34")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x0001E420 File Offset: 0x0001C620
		[Token(Token = "0x6006AC9")]
		[Address(RVA = "0x208CEE8", Offset = "0x208CEE8", VA = "0x7BBC88CEE8", Slot = "35")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACA")]
		[Address(RVA = "0x208CF2C", Offset = "0x208CF2C", VA = "0x7BBC88CF2C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACB")]
		[Address(RVA = "0x208CF70", Offset = "0x208CF70", VA = "0x7BBC88CF70")]
		public UIAvatarProfileItemController()
		{
		}

		// Token: 0x04008700 RID: 34560
		[Token(Token = "0x4008700")]
		[FieldOffset(Offset = "0x70")]
		private uint m_AvatarID;

		// Token: 0x04008701 RID: 34561
		[Token(Token = "0x4008701")]
		[FieldOffset(Offset = "0x78")]
		private string m_AwardDesc;

		// Token: 0x04008702 RID: 34562
		[Token(Token = "0x4008702")]
		[FieldOffset(Offset = "0x80")]
		private AvatarProfileDataOverrided m_ProfileInfo;

		// Token: 0x04008703 RID: 34563
		[Token(Token = "0x4008703")]
		[FieldOffset(Offset = "0x88")]
		private EProfileItemStatus m_Status;

		// Token: 0x04008704 RID: 34564
		[Token(Token = "0x4008704")]
		[FieldOffset(Offset = "0x90")]
		private UIAvatarProfileItemView m_View;

		// Token: 0x04008705 RID: 34565
		[Token(Token = "0x4008705")]
		[FieldOffset(Offset = "0x98")]
		private UIAvatarSkillSlotController m_skillCtrl;

		// Token: 0x04008706 RID: 34566
		[Token(Token = "0x4008706")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject m_UnlockEffect;

		// Token: 0x04008707 RID: 34567
		[Token(Token = "0x4008707")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelAvatarProfile m_ModelAvatarProfile;
	}
}
