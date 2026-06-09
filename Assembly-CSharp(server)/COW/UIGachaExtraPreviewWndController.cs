using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017EB RID: 6123
	[Token(Token = "0x20017EB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3124", Offset = "0x10F3124")]
	public class UIGachaExtraPreviewWndController : UIPopupWindowController
	{
		// Token: 0x06007681 RID: 30337 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		[Token(Token = "0x6007681")]
		[Address(RVA = "0x2164094", Offset = "0x2164094", VA = "0x7BBC964094")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007682")]
		[Address(RVA = "0x21640E4", Offset = "0x21640E4", VA = "0x7BBC9640E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007683")]
		[Address(RVA = "0x21641C8", Offset = "0x21641C8", VA = "0x7BBC9641C8")]
		public void SetViewData(ExtraRewardDesc desc, bool isLimit = false)
		{
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007684")]
		[Address(RVA = "0x216476C", Offset = "0x216476C", VA = "0x7BBC96476C")]
		private void ShowLeftTimeLabel(ExtraRewardDesc desc)
		{
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007685")]
		[Address(RVA = "0x21649F4", Offset = "0x21649F4", VA = "0x7BBC9649F4")]
		private void OnOKClick()
		{
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007686")]
		[Address(RVA = "0x21649FC", Offset = "0x21649FC", VA = "0x7BBC9649FC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007687")]
		[Address(RVA = "0x2164A04", Offset = "0x2164A04", VA = "0x7BBC964A04", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007688 RID: 30344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007688")]
		[Address(RVA = "0x2164A0C", Offset = "0x2164A0C", VA = "0x7BBC964A0C")]
		public UIGachaExtraPreviewWndController()
		{
		}

		// Token: 0x04008D4C RID: 36172
		[Token(Token = "0x4008D4C")]
		[FieldOffset(Offset = "0x98")]
		private UIGachaExtraPreviewWndView m_View;
	}
}
