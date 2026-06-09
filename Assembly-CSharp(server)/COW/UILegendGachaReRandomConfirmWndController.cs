using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001833 RID: 6195
	[Token(Token = "0x2001833")]
	public class UILegendGachaReRandomConfirmWndController : UIPopupWindowController
	{
		// Token: 0x0600791D RID: 31005 RVA: 0x00021558 File Offset: 0x0001F758
		[Token(Token = "0x600791D")]
		[Address(RVA = "0x1CB4BA0", Offset = "0x1CB4BA0", VA = "0x7BBC4B4BA0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791E")]
		[Address(RVA = "0x1CB4BF0", Offset = "0x1CB4BF0", VA = "0x7BBC4B4BF0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791F")]
		[Address(RVA = "0x1CB4DF8", Offset = "0x1CB4DF8", VA = "0x7BBC4B4DF8")]
		private void OnToggleClick()
		{
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007920")]
		[Address(RVA = "0x1CB4E58", Offset = "0x1CB4E58", VA = "0x7BBC4B4E58")]
		public void SetView(uint gachaID, string text, List<uint> list)
		{
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007921")]
		[Address(RVA = "0x1CB4F78", Offset = "0x1CB4F78", VA = "0x7BBC4B4F78")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06007922 RID: 31010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007922")]
		[Address(RVA = "0x1CB5018", Offset = "0x1CB5018", VA = "0x7BBC4B5018")]
		public UILegendGachaReRandomConfirmWndController()
		{
		}

		// Token: 0x04008EA2 RID: 36514
		[Token(Token = "0x4008EA2")]
		[FieldOffset(Offset = "0x94")]
		private uint m_GachaID;

		// Token: 0x04008EA3 RID: 36515
		[Token(Token = "0x4008EA3")]
		[FieldOffset(Offset = "0x98")]
		private UIModelGacha m_Model;

		// Token: 0x04008EA4 RID: 36516
		[Token(Token = "0x4008EA4")]
		[FieldOffset(Offset = "0xA0")]
		private UILegendGachaReRandomConfirmWndView m_View;

		// Token: 0x04008EA5 RID: 36517
		[Token(Token = "0x4008EA5")]
		[FieldOffset(Offset = "0xA8")]
		private List<uint> m_List;

		// Token: 0x04008EA6 RID: 36518
		[Token(Token = "0x4008EA6")]
		[FieldOffset(Offset = "0xB0")]
		private GachaDesc m_GachaDesc;

		// Token: 0x04008EA7 RID: 36519
		[Token(Token = "0x4008EA7")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_IsLegendClothGacha;
	}
}
