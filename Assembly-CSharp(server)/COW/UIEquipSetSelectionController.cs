using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017B3 RID: 6067
	[Token(Token = "0x20017B3")]
	public class UIEquipSetSelectionController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060073FF RID: 29695 RVA: 0x000203A0 File Offset: 0x0001E5A0
		[Token(Token = "0x60073FF")]
		[Address(RVA = "0x1E7A438", Offset = "0x1E7A438", VA = "0x7BBC67A438")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007400")]
		[Address(RVA = "0x1E7A488", Offset = "0x1E7A488", VA = "0x7BBC67A488", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007401 RID: 29697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007401")]
		[Address(RVA = "0x1E7A6AC", Offset = "0x1E7A6AC", VA = "0x7BBC67A6AC", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007402 RID: 29698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007402")]
		[Address(RVA = "0x1E7A808", Offset = "0x1E7A808", VA = "0x7BBC67A808", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007403")]
		[Address(RVA = "0x1E7A860", Offset = "0x1E7A860", VA = "0x7BBC67A860")]
		private void SetUIData(int setId)
		{
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007404")]
		[Address(RVA = "0x1E7AEB8", Offset = "0x1E7AEB8", VA = "0x7BBC67AEB8", Slot = "42")]
		protected virtual UIEquipSetItemController OpenChildContainer(Transform parent)
		{
			return null;
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007405")]
		[Address(RVA = "0x1E7AC38", Offset = "0x1E7AC38", VA = "0x7BBC67AC38")]
		private void SetLastTime(DateTime start, DateTime end)
		{
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007406")]
		[Address(RVA = "0x1E7AF4C", Offset = "0x1E7AF4C", VA = "0x7BBC67AF4C")]
		public void ShowLobbyWindow()
		{
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007407")]
		[Address(RVA = "0x1E7B018", Offset = "0x1E7B018", VA = "0x7BBC67B018")]
		public void ShowInGameWindow(int index, float secs)
		{
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007408")]
		[Address(RVA = "0x1E7AF80", Offset = "0x1E7AF80", VA = "0x7BBC67AF80")]
		private void InitUIDataAndShow(bool lobby)
		{
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007409")]
		[Address(RVA = "0x1E7B318", Offset = "0x1E7B318", VA = "0x7BBC67B318")]
		private void SetUIDataAndShow()
		{
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740A")]
		[Address(RVA = "0x1E7A624", Offset = "0x1E7A624", VA = "0x7BBC67A624")]
		private void ShowContent(bool inGame, bool lobby)
		{
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740B")]
		[Address(RVA = "0x1E7B248", Offset = "0x1E7B248", VA = "0x7BBC67B248")]
		private void RequestEquipSets()
		{
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x000203B8 File Offset: 0x0001E5B8
		[Token(Token = "0x600740C")]
		[Address(RVA = "0x1E7B374", Offset = "0x1E7B374", VA = "0x7BBC67B374", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740D")]
		[Address(RVA = "0x1E7B37C", Offset = "0x1E7B37C", VA = "0x7BBC67B37C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740E")]
		[Address(RVA = "0x1E7B1F4", Offset = "0x1E7B1F4", VA = "0x7BBC67B1F4")]
		private void SelectItem(int index)
		{
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740F")]
		[Address(RVA = "0x1E7B38C", Offset = "0x1E7B38C", VA = "0x7BBC67B38C")]
		private void HighLightIndex(int index, bool hightlight)
		{
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007410")]
		[Address(RVA = "0x1E7B44C", Offset = "0x1E7B44C", VA = "0x7BBC67B44C")]
		private void OnClickConfirm()
		{
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007411")]
		[Address(RVA = "0x1E7B588", Offset = "0x1E7B588", VA = "0x7BBC67B588", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007412 RID: 29714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007412")]
		[Address(RVA = "0x1E7A6E4", Offset = "0x1E7A6E4", VA = "0x7BBC67A6E4")]
		private void EnableInventory(bool enable)
		{
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007413")]
		[Address(RVA = "0x1E7B5BC", Offset = "0x1E7B5BC", VA = "0x7BBC67B5BC")]
		private void Update()
		{
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007414")]
		[Address(RVA = "0x1E7B61C", Offset = "0x1E7B61C", VA = "0x7BBC67B61C")]
		public UIEquipSetSelectionController()
		{
		}

		// Token: 0x04008C1B RID: 35867
		[Token(Token = "0x4008C1B")]
		[FieldOffset(Offset = "0x98")]
		private UIEquipSetSelectionView m_View;

		// Token: 0x04008C1C RID: 35868
		[Token(Token = "0x4008C1C")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelLinkActivity m_Model;

		// Token: 0x04008C1D RID: 35869
		[Token(Token = "0x4008C1D")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_ModelRegistered;

		// Token: 0x04008C1E RID: 35870
		[Token(Token = "0x4008C1E")]
		[FieldOffset(Offset = "0xB0")]
		private UITimeLabelHelper m_TimeHelper;

		// Token: 0x04008C1F RID: 35871
		[Token(Token = "0x4008C1F")]
		[FieldOffset(Offset = "0xB8")]
		private List<UIEquipSetItemController> m_Items;

		// Token: 0x04008C20 RID: 35872
		[Token(Token = "0x4008C20")]
		[FieldOffset(Offset = "0xC0")]
		private int m_SelectedIndex;

		// Token: 0x04008C21 RID: 35873
		[Token(Token = "0x4008C21")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_InGame;

		// Token: 0x04008C22 RID: 35874
		[Token(Token = "0x4008C22")]
		[FieldOffset(Offset = "0xC8")]
		private int m_SetId;
	}
}
