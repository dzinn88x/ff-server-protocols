using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017AC RID: 6060
	[Token(Token = "0x20017AC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F28AC", Offset = "0x10F28AC")]
	public class UIEmoteShowPanelController : UIBaseController
	{
		// Token: 0x060073CC RID: 29644 RVA: 0x000202B0 File Offset: 0x0001E4B0
		[Token(Token = "0x60073CC")]
		[Address(RVA = "0x1E77514", Offset = "0x1E77514", VA = "0x7BBC677514")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CD")]
		[Address(RVA = "0x1E77564", Offset = "0x1E77564", VA = "0x7BBC677564", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CE")]
		[Address(RVA = "0x1E77D40", Offset = "0x1E77D40", VA = "0x7BBC677D40", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CF")]
		[Address(RVA = "0x1E778B8", Offset = "0x1E778B8", VA = "0x7BBC6778B8")]
		private void InitEmotions()
		{
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D0")]
		[Address(RVA = "0x1E77F50", Offset = "0x1E77F50", VA = "0x7BBC677F50")]
		private void OnClickMask()
		{
		}

		// Token: 0x060073D1 RID: 29649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D1")]
		[Address(RVA = "0x1E77CE4", Offset = "0x1E77CE4", VA = "0x7BBC677CE4")]
		private void RefreshBtnCustomoAnimVisibility()
		{
		}

		// Token: 0x060073D2 RID: 29650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D2")]
		[Address(RVA = "0x1E77FEC", Offset = "0x1E77FEC", VA = "0x7BBC677FEC")]
		protected void OnBtnCustomAnimClick()
		{
		}

		// Token: 0x060073D3 RID: 29651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D3")]
		[Address(RVA = "0x1E780B0", Offset = "0x1E780B0", VA = "0x7BBC6780B0")]
		private void OnEmoteItemClick(params object[] data)
		{
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D4")]
		[Address(RVA = "0x1E785CC", Offset = "0x1E785CC", VA = "0x7BBC6785CC")]
		public UIEmoteShowPanelController()
		{
		}

		// Token: 0x04008C07 RID: 35847
		[Token(Token = "0x4008C07")]
		[FieldOffset(Offset = "0x58")]
		private UIEmoteShowPanelView m_View;

		// Token: 0x04008C08 RID: 35848
		[Token(Token = "0x4008C08")]
		[FieldOffset(Offset = "0x60")]
		private List<UIEmoteShowItemView> m_EmoteItems;
	}
}
