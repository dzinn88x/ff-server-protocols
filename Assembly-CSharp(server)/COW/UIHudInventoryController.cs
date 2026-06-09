using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018EA RID: 6378
	[Token(Token = "0x20018EA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F527C", Offset = "0x10F527C")]
	internal class UIHudInventoryController : UIBaseController
	{
		// Token: 0x06007F85 RID: 32645 RVA: 0x00022D28 File Offset: 0x00020F28
		[Token(Token = "0x6007F85")]
		[Address(RVA = "0x1C38414", Offset = "0x1C38414", VA = "0x7BBC438414")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F86")]
		[Address(RVA = "0x1C38464", Offset = "0x1C38464", VA = "0x7BBC438464", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007F87 RID: 32647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F87")]
		[Address(RVA = "0x1C39854", Offset = "0x1C39854", VA = "0x7BBC439854", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007F88 RID: 32648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F88")]
		[Address(RVA = "0x1C3985C", Offset = "0x1C3985C", VA = "0x7BBC43985C")]
		private void OnInventoryTrashStateChange(params object[] data)
		{
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F89")]
		[Address(RVA = "0x1C39A38", Offset = "0x1C39A38", VA = "0x7BBC439A38")]
		private void OnVestToggleChanged()
		{
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8A")]
		[Address(RVA = "0x1C39CB4", Offset = "0x1C39CB4", VA = "0x7BBC439CB4")]
		private void OnHelmetToggleChanged()
		{
		}

		// Token: 0x06007F8B RID: 32651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8B")]
		[Address(RVA = "0x1C39F30", Offset = "0x1C39F30", VA = "0x7BBC439F30")]
		private void OnBagToggleChanged()
		{
		}

		// Token: 0x06007F8C RID: 32652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8C")]
		[Address(RVA = "0x1C3A1AC", Offset = "0x1C3A1AC", VA = "0x7BBC43A1AC")]
		private void OnCoverToggleChanged()
		{
		}

		// Token: 0x06007F8D RID: 32653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8D")]
		[Address(RVA = "0x1C3A428", Offset = "0x1C3A428", VA = "0x7BBC43A428")]
		private void OnPrimaryWToggleChanged()
		{
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8E")]
		[Address(RVA = "0x1C3A6A4", Offset = "0x1C3A6A4", VA = "0x7BBC43A6A4")]
		private void OnSecondaryWToggleChanged()
		{
		}

		// Token: 0x06007F8F RID: 32655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8F")]
		[Address(RVA = "0x1C3A920", Offset = "0x1C3A920", VA = "0x7BBC43A920")]
		private void OnSideWToggleChanged()
		{
		}

		// Token: 0x06007F90 RID: 32656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F90")]
		[Address(RVA = "0x1C3AB9C", Offset = "0x1C3AB9C", VA = "0x7BBC43AB9C")]
		private void OnMeleeToggleChanged()
		{
		}

		// Token: 0x06007F91 RID: 32657 RVA: 0x00022D40 File Offset: 0x00020F40
		[Token(Token = "0x6007F91")]
		[Address(RVA = "0x1C3AE18", Offset = "0x1C3AE18", VA = "0x7BBC43AE18")]
		private bool OnEscapeClick()
		{
			return default(bool);
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F92")]
		[Address(RVA = "0x1C3B24C", Offset = "0x1C3B24C", VA = "0x7BBC43B24C")]
		private void OnInventoryOpen(params object[] param)
		{
		}

		// Token: 0x06007F93 RID: 32659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F93")]
		[Address(RVA = "0x1C3B724", Offset = "0x1C3B724", VA = "0x7BBC43B724")]
		private void OnItemDragStart(params object[] datas)
		{
		}

		// Token: 0x06007F94 RID: 32660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F94")]
		[Address(RVA = "0x1C3B7D8", Offset = "0x1C3B7D8", VA = "0x7BBC43B7D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007F95 RID: 32661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F95")]
		[Address(RVA = "0x1C3AE54", Offset = "0x1C3AE54", VA = "0x7BBC43AE54")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x06007F96 RID: 32662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F96")]
		[Address(RVA = "0x1C3BF04", Offset = "0x1C3BF04", VA = "0x7BBC43BF04")]
		private void OnBtnSort()
		{
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x00022D58 File Offset: 0x00020F58
		[Token(Token = "0x6007F97")]
		[Address(RVA = "0x1C3CEE0", Offset = "0x1C3CEE0", VA = "0x7BBC43CEE0")]
		public int Exchange2NewNegativeId(int type)
		{
			return 0;
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x00022D70 File Offset: 0x00020F70
		[Token(Token = "0x6007F98")]
		[Address(RVA = "0x1C3CF10", Offset = "0x1C3CF10", VA = "0x7BBC43CF10")]
		public int Exchange2NewPositiveId(int type)
		{
			return 0;
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x00022D88 File Offset: 0x00020F88
		[Token(Token = "0x6007F99")]
		[Address(RVA = "0x1C3CF40", Offset = "0x1C3CF40", VA = "0x7BBC43CF40")]
		private int ItemPositiveSort(UIItem a, UIItem b)
		{
			return 0;
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x00022DA0 File Offset: 0x00020FA0
		[Token(Token = "0x6007F9A")]
		[Address(RVA = "0x1C3D0AC", Offset = "0x1C3D0AC", VA = "0x7BBC43D0AC")]
		private int ItemNegativeSort(UIItem a, UIItem b)
		{
			return 0;
		}

		// Token: 0x06007F9B RID: 32667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F9B")]
		[Address(RVA = "0x1C3D218", Offset = "0x1C3D218", VA = "0x7BBC43D218")]
		private void OnAddLocalPlayer(params object[] param)
		{
		}

		// Token: 0x06007F9C RID: 32668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F9C")]
		[Address(RVA = "0x1C3D26C", Offset = "0x1C3D26C", VA = "0x7BBC43D26C")]
		private void OnCapacityRefresh(params object[] param)
		{
		}

		// Token: 0x06007F9D RID: 32669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F9D")]
		[Address(RVA = "0x1C3D4A0", Offset = "0x1C3D4A0", VA = "0x7BBC43D4A0", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007F9E RID: 32670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F9E")]
		[Address(RVA = "0x1C3D760", Offset = "0x1C3D760", VA = "0x7BBC43D760")]
		private void OnInventoryRefresh(params object[] param)
		{
		}

		// Token: 0x06007F9F RID: 32671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F9F")]
		[Address(RVA = "0x1C3DF64", Offset = "0x1C3DF64", VA = "0x7BBC43DF64")]
		private void OnInventoryItemSelected(params object[] param)
		{
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA0")]
		[Address(RVA = "0x1C3E214", Offset = "0x1C3E214", VA = "0x7BBC43E214")]
		private void OnInventoryItemUnSelected(params object[] param)
		{
		}

		// Token: 0x06007FA1 RID: 32673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA1")]
		[Address(RVA = "0x1C3E218", Offset = "0x1C3E218", VA = "0x7BBC43E218")]
		private void OnInventoryItemReleased(params object[] param)
		{
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FA2")]
		[Address(RVA = "0x1C3E30C", Offset = "0x1C3E30C", VA = "0x7BBC43E30C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1142E08", Offset = "0x1142E08")]
		private IEnumerator RefreshCorListItem()
		{
			return null;
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA3")]
		[Address(RVA = "0x1C3E3AC", Offset = "0x1C3E3AC", VA = "0x7BBC43E3AC")]
		private void OnInventoryAttachmentStateChanged(params object[] param)
		{
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA4")]
		[Address(RVA = "0x1C3EE64", Offset = "0x1C3EE64", VA = "0x7BBC43EE64")]
		private void OnInventoryEquipmentStateChanged(params object[] param)
		{
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA5")]
		[Address(RVA = "0x1C39650", Offset = "0x1C39650", VA = "0x7BBC439650")]
		private void ClearDescription()
		{
		}

		// Token: 0x06007FA6 RID: 32678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA6")]
		[Address(RVA = "0x1C3ECD4", Offset = "0x1C3ECD4", VA = "0x7BBC43ECD4")]
		private void RemoveItemFromList(AHtazwI item)
		{
		}

		// Token: 0x06007FA7 RID: 32679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA7")]
		[Address(RVA = "0x1C40B48", Offset = "0x1C40B48", VA = "0x7BBC440B48")]
		private void ResetItemListGrid(bool flag = true)
		{
		}

		// Token: 0x06007FA8 RID: 32680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA8")]
		[Address(RVA = "0x1C3D868", Offset = "0x1C3D868", VA = "0x7BBC43D868")]
		private void RefreshItemList(AHtazwI item)
		{
		}

		// Token: 0x06007FA9 RID: 32681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA9")]
		[Address(RVA = "0x1C40E2C", Offset = "0x1C40E2C", VA = "0x7BBC440E2C")]
		private void UpdateItemGrid()
		{
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FAA")]
		[Address(RVA = "0x1C3D700", Offset = "0x1C3D700", VA = "0x7BBC43D700")]
		private void RefreshWeaponAmmo()
		{
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FAB")]
		[Address(RVA = "0x1C40A8C", Offset = "0x1C40A8C", VA = "0x7BBC440A8C")]
		private void CloseInventoryItemController(UIHudInventoryItemController itemController, AHtazwI item)
		{
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FAC")]
		[Address(RVA = "0x1C3B6AC", Offset = "0x1C3B6AC", VA = "0x7BBC43B6AC")]
		private void SetScrollPos()
		{
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FAD")]
		[Address(RVA = "0x1C40CB4", Offset = "0x1C40CB4", VA = "0x7BBC440CB4")]
		private void RessetScrollPos()
		{
		}

		// Token: 0x06007FAE RID: 32686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FAE")]
		[Address(RVA = "0x1C41558", Offset = "0x1C41558", VA = "0x7BBC441558")]
		private void CloseInventory(params object[] data)
		{
		}

		// Token: 0x06007FAF RID: 32687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FAF")]
		[Address(RVA = "0x1C41608", Offset = "0x1C41608", VA = "0x7BBC441608")]
		private void OnInventoryDragAndDrop(params object[] data)
		{
		}

		// Token: 0x06007FB0 RID: 32688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FB0")]
		[Address(RVA = "0x1C41788", Offset = "0x1C41788", VA = "0x7BBC441788")]
		private void OnInventoryNoCapacityToPickup(params object[] data)
		{
		}

		// Token: 0x06007FB1 RID: 32689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FB1")]
		[Address(RVA = "0x1C41794", Offset = "0x1C41794", VA = "0x7BBC441794")]
		private void OnShowDropTutorial(params object[] data)
		{
		}

		// Token: 0x06007FB2 RID: 32690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FB2")]
		[Address(RVA = "0x1C417A0", Offset = "0x1C417A0", VA = "0x7BBC4417A0")]
		private void OnDropCamouflageOpenBagShowed(params object[] data)
		{
		}

		// Token: 0x06007FB3 RID: 32691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FB3")]
		[Address(RVA = "0x1C417AC", Offset = "0x1C417AC", VA = "0x7BBC4417AC")]
		private void OnShowTutorialDropCamouflageNote(params object[] data)
		{
		}

		// Token: 0x06007FB4 RID: 32692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FB4")]
		[Address(RVA = "0x1C417B8", Offset = "0x1C417B8", VA = "0x7BBC4417B8")]
		public UIHudInventoryController()
		{
		}

		// Token: 0x06007FB5 RID: 32693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FB5")]
		[Address(RVA = "0x1C41D60", Offset = "0x1C41D60", VA = "0x7BBC441D60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142E6C", Offset = "0x1142E6C")]
		private void <OnVisibilityChanged>b__48_0()
		{
		}

		// Token: 0x06007FB6 RID: 32694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FB6")]
		[Address(RVA = "0x1C41EF8", Offset = "0x1C41EF8", VA = "0x7BBC441EF8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142E7C", Offset = "0x1142E7C")]
		private void <OnVisibilityChanged>b__48_1()
		{
		}

		// Token: 0x04009247 RID: 37447
		[Token(Token = "0x4009247")]
		[FieldOffset(Offset = "0x58")]
		private UIHudInventoryView m_View;

		// Token: 0x04009248 RID: 37448
		[Token(Token = "0x4009248")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<uint, List<UIHudInventoryItemController>> m_ItemControllers;

		// Token: 0x04009249 RID: 37449
		[Token(Token = "0x4009249")]
		[FieldOffset(Offset = "0x68")]
		private List<UIHudInventoryItemController> m_ListEndControllers;

		// Token: 0x0400924A RID: 37450
		[Token(Token = "0x400924A")]
		[FieldOffset(Offset = "0x70")]
		private UIHudInventoryEquipSlotItemController m_VestSlot;

		// Token: 0x0400924B RID: 37451
		[Token(Token = "0x400924B")]
		[FieldOffset(Offset = "0x78")]
		private UIHudInventoryEquipSlotItemController m_HelmetSlot;

		// Token: 0x0400924C RID: 37452
		[Token(Token = "0x400924C")]
		[FieldOffset(Offset = "0x80")]
		private UIHudInventoryEquipSlotItemController m_BagSlot;

		// Token: 0x0400924D RID: 37453
		[Token(Token = "0x400924D")]
		[FieldOffset(Offset = "0x88")]
		private UIHudInventoryEquipSlotItemController m_CamouflageSlot;

		// Token: 0x0400924E RID: 37454
		[Token(Token = "0x400924E")]
		[FieldOffset(Offset = "0x90")]
		private UIHudInventoryWeaponSlotItemController m_WeaponP1Slot;

		// Token: 0x0400924F RID: 37455
		[Token(Token = "0x400924F")]
		[FieldOffset(Offset = "0x98")]
		private UIHudInventoryWeaponSlotItemController m_WeaponP2Slot;

		// Token: 0x04009250 RID: 37456
		[Token(Token = "0x4009250")]
		[FieldOffset(Offset = "0xA0")]
		private UIHudInventoryWeaponSlotItemController m_WeaponS1Slot;

		// Token: 0x04009251 RID: 37457
		[Token(Token = "0x4009251")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudInventoryWeaponSlotItemController m_WeaponM1Slot;

		// Token: 0x04009252 RID: 37458
		[Token(Token = "0x4009252")]
		[FieldOffset(Offset = "0xB0")]
		private UIPanel m_ScrollViewPanel;

		// Token: 0x04009253 RID: 37459
		[Token(Token = "0x4009253")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 m_CurrentClipOffset;

		// Token: 0x04009254 RID: 37460
		[Token(Token = "0x4009254")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 m_CurrentPanelLocalPos;

		// Token: 0x04009255 RID: 37461
		[Token(Token = "0x4009255")]
		[FieldOffset(Offset = "0xCC")]
		private Vector3 tempGridPos;

		// Token: 0x04009256 RID: 37462
		[Token(Token = "0x4009256")]
		[FieldOffset(Offset = "0xD8")]
		private bool inventoryTutorialShowed;

		// Token: 0x04009257 RID: 37463
		[Token(Token = "0x4009257")]
		[FieldOffset(Offset = "0xD9")]
		private bool showDropTutorialPrepared;

		// Token: 0x04009258 RID: 37464
		[Token(Token = "0x4009258")]
		[FieldOffset(Offset = "0xDA")]
		private bool dropCamouflageOpenBagShowed;

		// Token: 0x04009259 RID: 37465
		[Token(Token = "0x4009259")]
		[FieldOffset(Offset = "0xDB")]
		private bool showDropCamouflageNoteTutorialPrepared;

		// Token: 0x0400925A RID: 37466
		[Token(Token = "0x400925A")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 m_ScrollRootRelative;

		// Token: 0x0400925B RID: 37467
		[Token(Token = "0x400925B")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 m_OperatorVec;

		// Token: 0x0400925C RID: 37468
		[Token(Token = "0x400925C")]
		[FieldOffset(Offset = "0xF4")]
		private bool m_SortState;

		// Token: 0x0400925D RID: 37469
		[Token(Token = "0x400925D")]
		[FieldOffset(Offset = "0xF8")]
		private Dictionary<UIHudInventoryController.SlotType, List<string>> SlotsKey;

		// Token: 0x020018EB RID: 6379
		[Token(Token = "0x20018EB")]
		public enum SlotType : byte
		{
			// Token: 0x0400925F RID: 37471
			[Token(Token = "0x400925F")]
			Vest,
			// Token: 0x04009260 RID: 37472
			[Token(Token = "0x4009260")]
			Helmet,
			// Token: 0x04009261 RID: 37473
			[Token(Token = "0x4009261")]
			Bag,
			// Token: 0x04009262 RID: 37474
			[Token(Token = "0x4009262")]
			Cover,
			// Token: 0x04009263 RID: 37475
			[Token(Token = "0x4009263")]
			PrimaryW,
			// Token: 0x04009264 RID: 37476
			[Token(Token = "0x4009264")]
			SecondaryW,
			// Token: 0x04009265 RID: 37477
			[Token(Token = "0x4009265")]
			SideW,
			// Token: 0x04009266 RID: 37478
			[Token(Token = "0x4009266")]
			Melee
		}

		// Token: 0x020018EC RID: 6380
		[Token(Token = "0x20018EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F52B4", Offset = "0x10F52B4")]
		private sealed class <RefreshCorListItem>d__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007FB7 RID: 32695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FB7")]
			[Address(RVA = "0x1C3E380", Offset = "0x1C3E380", VA = "0x7BBC43E380")]
			[DebuggerHidden]
			public <RefreshCorListItem>d__53(int <>1__state)
			{
			}

			// Token: 0x06007FB8 RID: 32696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FB8")]
			[Address(RVA = "0x1C41F98", Offset = "0x1C41F98", VA = "0x7BBC441F98", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007FB9 RID: 32697 RVA: 0x00022DB8 File Offset: 0x00020FB8
			[Token(Token = "0x6007FB9")]
			[Address(RVA = "0x1C41F9C", Offset = "0x1C41F9C", VA = "0x7BBC441F9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700099C RID: 2460
			// (get) Token: 0x06007FBA RID: 32698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700099C")]
			private object Current
			{
				[Token(Token = "0x6007FBA")]
				[Address(RVA = "0x1C42008", Offset = "0x1C42008", VA = "0x7BBC442008", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007FBB RID: 32699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FBB")]
			[Address(RVA = "0x1C42010", Offset = "0x1C42010", VA = "0x7BBC442010", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700099D RID: 2461
			// (get) Token: 0x06007FBC RID: 32700 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700099D")]
			private object Current
			{
				[Token(Token = "0x6007FBC")]
				[Address(RVA = "0x1C42078", Offset = "0x1C42078", VA = "0x7BBC442078", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009267 RID: 37479
			[Token(Token = "0x4009267")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009268 RID: 37480
			[Token(Token = "0x4009268")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009269 RID: 37481
			[Token(Token = "0x4009269")]
			[FieldOffset(Offset = "0x20")]
			public UIHudInventoryController <>4__this;
		}
	}
}
