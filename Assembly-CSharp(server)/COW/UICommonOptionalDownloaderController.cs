using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200174F RID: 5967
	[Token(Token = "0x200174F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1DE4", Offset = "0x10F1DE4")]
	public class UICommonOptionalDownloaderController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06007049 RID: 28745 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
		[Token(Token = "0x6007049")]
		[Address(RVA = "0x1802EE4", Offset = "0x1802EE4", VA = "0x7BBC002EE4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600704A RID: 28746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704A")]
		[Address(RVA = "0x1802F34", Offset = "0x1802F34", VA = "0x7BBC002F34", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600704B RID: 28747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704B")]
		[Address(RVA = "0x18030B8", Offset = "0x18030B8", VA = "0x7BBC0030B8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600704C RID: 28748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704C")]
		[Address(RVA = "0x18030F8", Offset = "0x18030F8", VA = "0x7BBC0030F8")]
		private void Update()
		{
		}

		// Token: 0x0600704D RID: 28749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704D")]
		[Address(RVA = "0x1803200", Offset = "0x1803200", VA = "0x7BBC003200")]
		public void SetData(List<ResourceID> needDownloadList)
		{
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704E")]
		[Address(RVA = "0x1803208", Offset = "0x1803208", VA = "0x7BBC003208")]
		private void OnControlBtnClick()
		{
		}

		// Token: 0x0600704F RID: 28751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704F")]
		[Address(RVA = "0x180320C", Offset = "0x180320C", VA = "0x7BBC00320C")]
		public void SetButtonShow(bool show)
		{
		}

		// Token: 0x06007050 RID: 28752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007050")]
		[Address(RVA = "0x180326C", Offset = "0x180326C", VA = "0x7BBC00326C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		[Token(Token = "0x6007051")]
		[Address(RVA = "0x18032E8", Offset = "0x18032E8", VA = "0x7BBC0032E8", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007052")]
		[Address(RVA = "0x180332C", Offset = "0x180332C", VA = "0x7BBC00332C")]
		public UICommonOptionalDownloaderController()
		{
		}

		// Token: 0x04008A2C RID: 35372
		[Token(Token = "0x4008A2C")]
		private const float CIRCLE_SPEED = 0.2f;

		// Token: 0x04008A2D RID: 35373
		[Token(Token = "0x4008A2D")]
		[FieldOffset(Offset = "0x58")]
		private UIModelOptionalDownload m_Model;

		// Token: 0x04008A2E RID: 35374
		[Token(Token = "0x4008A2E")]
		[FieldOffset(Offset = "0x60")]
		private UICommonOptionalDownloaderView m_View;

		// Token: 0x04008A2F RID: 35375
		[Token(Token = "0x4008A2F")]
		[FieldOffset(Offset = "0x68")]
		private List<ResourceID> m_NeedDownloadRes;

		// Token: 0x04008A30 RID: 35376
		[Token(Token = "0x4008A30")]
		[FieldOffset(Offset = "0x70")]
		private bool m_ContentShow;
	}
}
