using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001729 RID: 5929
	[Token(Token = "0x2001729")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F19BC", Offset = "0x10F19BC")]
	public class UIClanLogController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06006ECE RID: 28366 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
		[Token(Token = "0x6006ECE")]
		[Address(RVA = "0x1CFCFE0", Offset = "0x1CFCFE0", VA = "0x7BBC4FCFE0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x0001F2C0 File Offset: 0x0001D4C0
		[Token(Token = "0x6006ECF")]
		[Address(RVA = "0x1CFD030", Offset = "0x1CFD030", VA = "0x7BBC4FD030", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED0")]
		[Address(RVA = "0x1CFD074", Offset = "0x1CFD074", VA = "0x7BBC4FD074", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED1")]
		[Address(RVA = "0x1CFD540", Offset = "0x1CFD540", VA = "0x7BBC4FD540", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED2")]
		[Address(RVA = "0x1CFD8E8", Offset = "0x1CFD8E8", VA = "0x7BBC4FD8E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED3")]
		[Address(RVA = "0x1CFD680", Offset = "0x1CFD680", VA = "0x7BBC4FD680")]
		private void PrepareItems()
		{
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ED4")]
		[Address(RVA = "0x1CFD99C", Offset = "0x1CFD99C", VA = "0x7BBC4FD99C")]
		public UIClanLogItemView GetItem()
		{
			return null;
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED5")]
		[Address(RVA = "0x1CFDC30", Offset = "0x1CFDC30", VA = "0x7BBC4FDC30")]
		public void PushItem(UIClanLogItemView item)
		{
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED6")]
		[Address(RVA = "0x1CFD0E4", Offset = "0x1CFD0E4", VA = "0x7BBC4FD0E4")]
		private void UpdateView()
		{
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED7")]
		[Address(RVA = "0x1CFDDEC", Offset = "0x1CFDDEC", VA = "0x7BBC4FDDEC")]
		public UIClanLogController()
		{
		}

		// Token: 0x04008936 RID: 35126
		[Token(Token = "0x4008936")]
		[FieldOffset(Offset = "0x58")]
		private UIClanLogView m_View;

		// Token: 0x04008937 RID: 35127
		[Token(Token = "0x4008937")]
		[FieldOffset(Offset = "0x60")]
		private List<UIClanLogItemView> m_Items;

		// Token: 0x04008938 RID: 35128
		[Token(Token = "0x4008938")]
		[FieldOffset(Offset = "0x68")]
		private Queue<UIClanLogItemView> m_ItemPool;
	}
}
