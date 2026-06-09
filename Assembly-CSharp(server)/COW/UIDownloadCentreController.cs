using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014E4 RID: 5348
	[Token(Token = "0x20014E4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDB54", Offset = "0x10EDB54")]
	public class UIDownloadCentreController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06005B6A RID: 23402 RVA: 0x0001AB20 File Offset: 0x00018D20
		[Token(Token = "0x6005B6A")]
		[Address(RVA = "0x2206D54", Offset = "0x2206D54", VA = "0x7BBCA06D54")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0x2206DA4", Offset = "0x2206DA4", VA = "0x7BBCA06DA4", Slot = "28")]
		public override string Rule()
		{
			return null;
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0x2206DEC", Offset = "0x2206DEC", VA = "0x7BBCA06DEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0x2206F88", Offset = "0x2206F88", VA = "0x7BBCA06F88", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x0001AB38 File Offset: 0x00018D38
		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0x2206FE4", Offset = "0x2206FE4", VA = "0x7BBCA06FE4", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0x2207028", Offset = "0x2207028", VA = "0x7BBCA07028")]
		private void Update()
		{
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B70")]
		[Address(RVA = "0x22071E8", Offset = "0x22071E8", VA = "0x7BBCA071E8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B71")]
		[Address(RVA = "0x2207308", Offset = "0x2207308", VA = "0x7BBCA07308", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B72")]
		[Address(RVA = "0x2207338", Offset = "0x2207338", VA = "0x7BBCA07338", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005B73 RID: 23411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B73")]
		[Address(RVA = "0x22073CC", Offset = "0x22073CC", VA = "0x7BBCA073CC")]
		public UIDownloadCentreController()
		{
		}

		// Token: 0x04007DFD RID: 32253
		[Token(Token = "0x4007DFD")]
		[FieldOffset(Offset = "0x98")]
		private UIDownloadCentreView m_View;

		// Token: 0x04007DFE RID: 32254
		[Token(Token = "0x4007DFE")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelOptionalDownload m_Model;

		// Token: 0x04007DFF RID: 32255
		[Token(Token = "0x4007DFF")]
		[FieldOffset(Offset = "0xA8")]
		private EModelDownloadState m_LastShowedState;
	}
}
