using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017AD RID: 6061
	[Token(Token = "0x20017AD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F28E4", Offset = "0x10F28E4")]
	public class UIEmoteSlotController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060073D5 RID: 29653 RVA: 0x000202C8 File Offset: 0x0001E4C8
		[Token(Token = "0x60073D5")]
		[Address(RVA = "0x1E788FC", Offset = "0x1E788FC", VA = "0x7BBC6788FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D6")]
		[Address(RVA = "0x1E7894C", Offset = "0x1E7894C", VA = "0x7BBC67894C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060073D7 RID: 29655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D7")]
		[Address(RVA = "0x1E78AFC", Offset = "0x1E78AFC", VA = "0x7BBC678AFC", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D8")]
		[Address(RVA = "0x1E750D8", Offset = "0x1E750D8", VA = "0x7BBC6750D8")]
		public void RefreshBooyahState()
		{
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D9")]
		[Address(RVA = "0x1E74D08", Offset = "0x1E74D08", VA = "0x7BBC674D08")]
		public void Init(uint _slotIndex)
		{
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DA")]
		[Address(RVA = "0x1E75568", Offset = "0x1E75568", VA = "0x7BBC675568")]
		public void Clean()
		{
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DB")]
		[Address(RVA = "0x1E75688", Offset = "0x1E75688", VA = "0x7BBC675688")]
		public void Refresh(uint _emoteid, uint _slotIndex)
		{
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DC")]
		[Address(RVA = "0x1E78BB0", Offset = "0x1E78BB0", VA = "0x7BBC678BB0")]
		private void OnSlotClick()
		{
		}

		// Token: 0x060073DD RID: 29661 RVA: 0x000202E0 File Offset: 0x0001E4E0
		[Token(Token = "0x60073DD")]
		[Address(RVA = "0x1E74080", Offset = "0x1E74080", VA = "0x7BBC674080")]
		public uint GetEmoteId()
		{
			return 0U;
		}

		// Token: 0x060073DE RID: 29662 RVA: 0x000202F8 File Offset: 0x0001E4F8
		[Token(Token = "0x60073DE")]
		[Address(RVA = "0x1E74088", Offset = "0x1E74088", VA = "0x7BBC674088")]
		public uint GetIndex()
		{
			return 0U;
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x00020310 File Offset: 0x0001E510
		[Token(Token = "0x60073DF")]
		[Address(RVA = "0x1E78D1C", Offset = "0x1E78D1C", VA = "0x7BBC678D1C")]
		public bool GetIsSelect()
		{
			return default(bool);
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E0")]
		[Address(RVA = "0x1E75E64", Offset = "0x1E75E64", VA = "0x7BBC675E64")]
		public void SetSelect(bool _bool)
		{
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E1")]
		[Address(RVA = "0x1E739B8", Offset = "0x1E739B8", VA = "0x7BBC6739B8")]
		public void OnDragDropStart()
		{
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E2")]
		[Address(RVA = "0x1E73EC4", Offset = "0x1E73EC4", VA = "0x7BBC673EC4")]
		public void OnDragDropRelease(uint emoteID, bool needAction)
		{
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E3")]
		[Address(RVA = "0x1E741C8", Offset = "0x1E741C8", VA = "0x7BBC6741C8")]
		public void OnDragOverSlot()
		{
		}

		// Token: 0x060073E4 RID: 29668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E4")]
		[Address(RVA = "0x1E78D24", Offset = "0x1E78D24", VA = "0x7BBC678D24", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060073E5 RID: 29669 RVA: 0x00020328 File Offset: 0x0001E528
		[Token(Token = "0x60073E5")]
		[Address(RVA = "0x1E78E58", Offset = "0x1E78E58", VA = "0x7BBC678E58", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E6")]
		[Address(RVA = "0x1E78E9C", Offset = "0x1E78E9C", VA = "0x7BBC678E9C")]
		public UIEmoteSlotController()
		{
		}

		// Token: 0x04008C09 RID: 35849
		[Token(Token = "0x4008C09")]
		[FieldOffset(Offset = "0x58")]
		private uint m_SlotIndex;

		// Token: 0x04008C0A RID: 35850
		[Token(Token = "0x4008C0A")]
		[FieldOffset(Offset = "0x5C")]
		private uint m_EmoteID;

		// Token: 0x04008C0B RID: 35851
		[Token(Token = "0x4008C0B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isChoose;

		// Token: 0x04008C0C RID: 35852
		[Token(Token = "0x4008C0C")]
		[FieldOffset(Offset = "0x68")]
		private UIEmoteSlotView m_View;

		// Token: 0x04008C0D RID: 35853
		[Token(Token = "0x4008C0D")]
		[FieldOffset(Offset = "0x70")]
		private EmoteBaseInfo m_EmoteInfo;

		// Token: 0x04008C0E RID: 35854
		[Token(Token = "0x4008C0E")]
		[FieldOffset(Offset = "0x78")]
		private UIEmoteDragDropItem m_DragDropItem;

		// Token: 0x04008C0F RID: 35855
		[Token(Token = "0x4008C0F")]
		[FieldOffset(Offset = "0x80")]
		private Color32 m_selectcolor;

		// Token: 0x04008C10 RID: 35856
		[Token(Token = "0x4008C10")]
		[FieldOffset(Offset = "0x84")]
		private Color32 m_disselectcolor;
	}
}
