using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B73 RID: 7027
	[Token(Token = "0x2001B73")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA13C", Offset = "0x10FA13C")]
	public class UIRoomReopenPopController : UIPopupWindowController
	{
		// Token: 0x0600974F RID: 38735 RVA: 0x00027ED0 File Offset: 0x000260D0
		[Token(Token = "0x600974F")]
		[Address(RVA = "0x1A23084", Offset = "0x1A23084", VA = "0x7BBC223084")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009750 RID: 38736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009750")]
		[Address(RVA = "0x1A230D4", Offset = "0x1A230D4", VA = "0x7BBC2230D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009751 RID: 38737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009751")]
		[Address(RVA = "0x1A23220", Offset = "0x1A23220", VA = "0x7BBC223220")]
		public void SetUIData(Action onOk)
		{
		}

		// Token: 0x06009752 RID: 38738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009752")]
		[Address(RVA = "0x1A23228", Offset = "0x1A23228", VA = "0x7BBC223228")]
		private void OnBtnConfirm()
		{
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009753")]
		[Address(RVA = "0x1A23494", Offset = "0x1A23494", VA = "0x7BBC223494")]
		public UIRoomReopenPopController()
		{
		}

		// Token: 0x04009F8B RID: 40843
		[Token(Token = "0x4009F8B")]
		[FieldOffset(Offset = "0x98")]
		private UIRoomReopenPopView m_View;

		// Token: 0x04009F8C RID: 40844
		[Token(Token = "0x4009F8C")]
		[FieldOffset(Offset = "0xA0")]
		private Action m_OnOK;
	}
}
