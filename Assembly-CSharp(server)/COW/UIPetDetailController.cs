using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AEB RID: 6891
	[Token(Token = "0x2001AEB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8E7C", Offset = "0x10F8E7C")]
	public class UIPetDetailController : UIBaseController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06009213 RID: 37395 RVA: 0x00026DF0 File Offset: 0x00024FF0
		[Token(Token = "0x6009213")]
		[Address(RVA = "0x20D4EEC", Offset = "0x20D4EEC", VA = "0x7BBC8D4EEC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009214")]
		[Address(RVA = "0x20D4F3C", Offset = "0x20D4F3C", VA = "0x7BBC8D4F3C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009215")]
		[Address(RVA = "0x20D5024", Offset = "0x20D5024", VA = "0x7BBC8D5024", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009216")]
		[Address(RVA = "0x20D50D8", Offset = "0x20D50D8", VA = "0x7BBC8D50D8")]
		private void OnCloseButtonClick()
		{
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009217")]
		[Address(RVA = "0x20D50E0", Offset = "0x20D50E0", VA = "0x7BBC8D50E0", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009218")]
		[Address(RVA = "0x20D5174", Offset = "0x20D5174", VA = "0x7BBC8D5174", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009219")]
		[Address(RVA = "0x20D51A4", Offset = "0x20D51A4", VA = "0x7BBC8D51A4", Slot = "30")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x00026E08 File Offset: 0x00025008
		[Token(Token = "0x600921A")]
		[Address(RVA = "0x20D520C", Offset = "0x20D520C", VA = "0x7BBC8D520C", Slot = "31")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600921B")]
		[Address(RVA = "0x20D5274", Offset = "0x20D5274", VA = "0x7BBC8D5274")]
		public UIPetDetailController()
		{
		}

		// Token: 0x04009CCA RID: 40138
		[Token(Token = "0x4009CCA")]
		[FieldOffset(Offset = "0x58")]
		private UIMallDetailView m_View;

		// Token: 0x04009CCB RID: 40139
		[Token(Token = "0x4009CCB")]
		[FieldOffset(Offset = "0x60")]
		private UIModelPet m_PetModel;
	}
}
