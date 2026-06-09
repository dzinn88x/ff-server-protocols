using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017AB RID: 6059
	[Token(Token = "0x20017AB")]
	public class UIEmoteListController : UIBaseController
	{
		// Token: 0x060073B6 RID: 29622 RVA: 0x00020238 File Offset: 0x0001E438
		[Token(Token = "0x60073B6")]
		[Address(RVA = "0x1E74398", Offset = "0x1E74398", VA = "0x7BBC674398")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B7")]
		[Address(RVA = "0x1E743E8", Offset = "0x1E743E8", VA = "0x7BBC6743E8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B8")]
		[Address(RVA = "0x1E74AEC", Offset = "0x1E74AEC", VA = "0x7BBC674AEC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B9")]
		[Address(RVA = "0x1E749AC", Offset = "0x1E749AC", VA = "0x7BBC6749AC")]
		public void InitData()
		{
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BA")]
		[Address(RVA = "0x1E74F80", Offset = "0x1E74F80", VA = "0x7BBC674F80")]
		public void RefreshBooyahState()
		{
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BB")]
		[Address(RVA = "0x1E751B4", Offset = "0x1E751B4", VA = "0x7BBC6751B4")]
		private void SetEmoteState(uint index)
		{
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BC")]
		[Address(RVA = "0x1E75284", Offset = "0x1E75284", VA = "0x7BBC675284")]
		public void RefreshData(params object[] data)
		{
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BD")]
		[Address(RVA = "0x1E759D4", Offset = "0x1E759D4", VA = "0x7BBC6759D4")]
		public void SelectAvailableItem()
		{
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BE")]
		[Address(RVA = "0x1E75EB4", Offset = "0x1E75EB4", VA = "0x7BBC675EB4")]
		public void UpdateScrollViewSize(UIWidget bgWidget)
		{
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BF")]
		[Address(RVA = "0x1E760A0", Offset = "0x1E760A0", VA = "0x7BBC6760A0")]
		private void OnGridReposition()
		{
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C0")]
		[Address(RVA = "0x1E760E0", Offset = "0x1E760E0", VA = "0x7BBC6760E0", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C1")]
		[Address(RVA = "0x1E760E8", Offset = "0x1E760E8", VA = "0x7BBC6760E8")]
		private void OnChangeEmoteSlot(params object[] data)
		{
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x00020250 File Offset: 0x0001E450
		[Token(Token = "0x60073C2")]
		[Address(RVA = "0x1E76454", Offset = "0x1E76454", VA = "0x7BBC676454")]
		public uint GetCurrentEmoteIndex()
		{
			return 0U;
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00020268 File Offset: 0x0001E468
		[Token(Token = "0x60073C3")]
		[Address(RVA = "0x1E764E8", Offset = "0x1E764E8", VA = "0x7BBC6764E8")]
		public uint GetCurrentEmoteId()
		{
			return 0U;
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x00020280 File Offset: 0x0001E480
		[Token(Token = "0x60073C4")]
		[Address(RVA = "0x1E7657C", Offset = "0x1E7657C", VA = "0x7BBC67657C")]
		public uint GetFirstEmoteId()
		{
			return 0U;
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C5")]
		[Address(RVA = "0x1E766EC", Offset = "0x1E766EC", VA = "0x7BBC6766EC")]
		private void OnSelectEmoteItem(params object[] data)
		{
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C6")]
		[Address(RVA = "0x1E766F0", Offset = "0x1E766F0", VA = "0x7BBC6766F0")]
		public void OnEquipSelectedEmote(uint selectedEmoteId)
		{
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C7")]
		[Address(RVA = "0x1E769D8", Offset = "0x1E769D8", VA = "0x7BBC6769D8")]
		public void OnUnEquipSelectedEmote(uint selectedEmoteId)
		{
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C8")]
		[Address(RVA = "0x1E76AB4", Offset = "0x1E76AB4", VA = "0x7BBC676AB4")]
		private void OnEquipEmoteOnSlot(params object[] data)
		{
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C9")]
		[Address(RVA = "0x1E76C54", Offset = "0x1E76C54", VA = "0x7BBC676C54")]
		private void OnLeaveEmoteTap(params object[] data)
		{
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x00020298 File Offset: 0x0001E498
		[Token(Token = "0x60073CA")]
		[Address(RVA = "0x1E76898", Offset = "0x1E76898", VA = "0x7BBC676898")]
		private int SameEmoteInSlotList(uint emoteID)
		{
			return 0;
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CB")]
		[Address(RVA = "0x1E76D88", Offset = "0x1E76D88", VA = "0x7BBC676D88")]
		public UIEmoteListController()
		{
		}

		// Token: 0x04008C00 RID: 35840
		[Token(Token = "0x4008C00")]
		[FieldOffset(Offset = "0x58")]
		private Transform[] m_EmoteSlotList;

		// Token: 0x04008C01 RID: 35841
		[Token(Token = "0x4008C01")]
		[FieldOffset(Offset = "0x60")]
		private List<UIEmoteSlotController> m_EmoteCtrlList;

		// Token: 0x04008C02 RID: 35842
		[Token(Token = "0x4008C02")]
		[FieldOffset(Offset = "0x68")]
		private UIEmoteSlotController m_currentSelectEmoteCtrl;

		// Token: 0x04008C03 RID: 35843
		[Token(Token = "0x4008C03")]
		[FieldOffset(Offset = "0x70")]
		private UIEmoteListView m_View;

		// Token: 0x04008C04 RID: 35844
		[Token(Token = "0x4008C04")]
		[FieldOffset(Offset = "0x78")]
		private bool isSelecting;

		// Token: 0x04008C05 RID: 35845
		[Token(Token = "0x4008C05")]
		[FieldOffset(Offset = "0x80")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x04008C06 RID: 35846
		[Token(Token = "0x4008C06")]
		[FieldOffset(Offset = "0x88")]
		private int m_FirstAvailabelIndex;
	}
}
