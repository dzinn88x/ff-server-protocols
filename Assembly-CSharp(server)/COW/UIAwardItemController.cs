using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016E0 RID: 5856
	[Token(Token = "0x20016E0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0ED4", Offset = "0x10F0ED4")]
	public class UIAwardItemController : UIBaseController
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06006BF3 RID: 27635 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006BF4 RID: 27636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000929")]
		public BaseItemInfo ItemInfo
		{
			[Token(Token = "0x6006BF3")]
			[Address(RVA = "0x141E108", Offset = "0x141E108", VA = "0x7BBBC1E108")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006BF4")]
			[Address(RVA = "0x141E110", Offset = "0x141E110", VA = "0x7BBBC1E110")]
			set
			{
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06006BF5 RID: 27637 RVA: 0x0001E870 File Offset: 0x0001CA70
		[Token(Token = "0x1700092A")]
		public int AwardKey
		{
			[Token(Token = "0x6006BF5")]
			[Address(RVA = "0x141E118", Offset = "0x141E118", VA = "0x7BBBC1E118")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x0001E888 File Offset: 0x0001CA88
		[Token(Token = "0x6006BF6")]
		[Address(RVA = "0x141E120", Offset = "0x141E120", VA = "0x7BBBC1E120")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF7")]
		[Address(RVA = "0x141E170", Offset = "0x141E170", VA = "0x7BBBC1E170", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF8")]
		[Address(RVA = "0x141E254", Offset = "0x141E254", VA = "0x7BBBC1E254")]
		public void SetViewData(BaseItemInfo info)
		{
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF9")]
		[Address(RVA = "0x141E448", Offset = "0x141E448", VA = "0x7BBBC1E448")]
		public void SetToggleVisible(bool v)
		{
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFA")]
		[Address(RVA = "0x141E544", Offset = "0x141E544", VA = "0x7BBBC1E544")]
		public void SetAwardCheckState()
		{
		}

		// Token: 0x06006BFB RID: 27643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFB")]
		[Address(RVA = "0x141E71C", Offset = "0x141E71C", VA = "0x7BBBC1E71C")]
		public void SetAwardUnCheckState()
		{
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFC")]
		[Address(RVA = "0x141E74C", Offset = "0x141E74C", VA = "0x7BBBC1E74C")]
		public void SetAwardEquippedState()
		{
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x0001E8A0 File Offset: 0x0001CAA0
		[Token(Token = "0x6006BFD")]
		[Address(RVA = "0x141E77C", Offset = "0x141E77C", VA = "0x7BBBC1E77C")]
		public bool IsAlreadyEquipped()
		{
			return default(bool);
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x0001E8B8 File Offset: 0x0001CAB8
		[Token(Token = "0x6006BFE")]
		[Address(RVA = "0x141E78C", Offset = "0x141E78C", VA = "0x7BBBC1E78C")]
		public CSSharedItemDataManager.ItemType GetAwardType()
		{
			return CSSharedItemDataManager.ItemType.ITEMTYPENONE;
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x0001E8D0 File Offset: 0x0001CAD0
		[Token(Token = "0x6006BFF")]
		[Address(RVA = "0x141E7AC", Offset = "0x141E7AC", VA = "0x7BBBC1E7AC")]
		public int GetAwardSubType()
		{
			return 0;
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x0001E8E8 File Offset: 0x0001CAE8
		[Token(Token = "0x6006C00")]
		[Address(RVA = "0x141E2C0", Offset = "0x141E2C0", VA = "0x7BBBC1E2C0")]
		public static int GenAwardKey(BaseItemInfo info)
		{
			return 0;
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C01")]
		[Address(RVA = "0x141E574", Offset = "0x141E574", VA = "0x7BBBC1E574")]
		private void SetToggleValue(bool v)
		{
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C02")]
		[Address(RVA = "0x141E7D4", Offset = "0x141E7D4", VA = "0x7BBBC1E7D4")]
		private void OnToggleSelected()
		{
		}

		// Token: 0x06006C03 RID: 27651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C03")]
		[Address(RVA = "0x141E5BC", Offset = "0x141E5BC", VA = "0x7BBBC1E5BC")]
		private void RefreshUI()
		{
		}

		// Token: 0x06006C04 RID: 27652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C04")]
		[Address(RVA = "0x141E9F4", Offset = "0x141E9F4", VA = "0x7BBBC1E9F4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C05")]
		[Address(RVA = "0x141E9FC", Offset = "0x141E9FC", VA = "0x7BBBC1E9FC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C06")]
		[Address(RVA = "0x141EA04", Offset = "0x141EA04", VA = "0x7BBBC1EA04")]
		public UIAwardItemController()
		{
		}

		// Token: 0x040087A7 RID: 34727
		[Token(Token = "0x40087A7")]
		[FieldOffset(Offset = "0x58")]
		private UIAwardItemView m_View;

		// Token: 0x040087A8 RID: 34728
		[Token(Token = "0x40087A8")]
		[FieldOffset(Offset = "0x60")]
		private BaseItemInfo m_Info;

		// Token: 0x040087A9 RID: 34729
		[Token(Token = "0x40087A9")]
		[FieldOffset(Offset = "0x68")]
		private int m_AwardKey;

		// Token: 0x040087AA RID: 34730
		[Token(Token = "0x40087AA")]
		[FieldOffset(Offset = "0x6C")]
		private UIAwardItemController.EquipmentState m_EquipmentState;

		// Token: 0x020016E1 RID: 5857
		[Token(Token = "0x20016E1")]
		private enum EquipmentState
		{
			// Token: 0x040087AC RID: 34732
			[Token(Token = "0x40087AC")]
			EQUIPMENTSTATE_NONE,
			// Token: 0x040087AD RID: 34733
			[Token(Token = "0x40087AD")]
			EQUIPMENTSTATE_CHECK,
			// Token: 0x040087AE RID: 34734
			[Token(Token = "0x40087AE")]
			EQUIPMENTSTATE_UNCHECK,
			// Token: 0x040087AF RID: 34735
			[Token(Token = "0x40087AF")]
			EQUIPMENTSTATE_EQUIPPED
		}
	}
}
