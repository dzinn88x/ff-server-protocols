using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001946 RID: 6470
	[Token(Token = "0x2001946")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5E54", Offset = "0x10F5E54")]
	internal class UIHudRedEnvelopeMatchResultPopupController : UIPopupWindowController
	{
		// Token: 0x06008335 RID: 33589 RVA: 0x00023A30 File Offset: 0x00021C30
		[Token(Token = "0x6008335")]
		[Address(RVA = "0x17EF3A4", Offset = "0x17EF3A4", VA = "0x7BBBFEF3A4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008336 RID: 33590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008336")]
		[Address(RVA = "0x17EF3F4", Offset = "0x17EF3F4", VA = "0x7BBBFEF3F4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008337 RID: 33591 RVA: 0x00023A48 File Offset: 0x00021C48
		[Token(Token = "0x6008337")]
		[Address(RVA = "0x17EF510", Offset = "0x17EF510", VA = "0x7BBBFEF510")]
		private int GetSortOrder(RedEnvelopeAwardDisplayInfo award)
		{
			return 0;
		}

		// Token: 0x06008338 RID: 33592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008338")]
		[Address(RVA = "0x17EF55C", Offset = "0x17EF55C", VA = "0x7BBBFEF55C")]
		public void SetReceiveData(List<RedEnvelopeAwardDisplayInfo> itemList)
		{
		}

		// Token: 0x06008339 RID: 33593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008339")]
		[Address(RVA = "0x17EF8C4", Offset = "0x17EF8C4", VA = "0x7BBBFEF8C4")]
		public UIHudRedEnvelopeMatchResultPopupController()
		{
		}

		// Token: 0x0600833A RID: 33594 RVA: 0x00023A60 File Offset: 0x00021C60
		[Token(Token = "0x600833A")]
		[Address(RVA = "0x17EF934", Offset = "0x17EF934", VA = "0x7BBBFEF934")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143290", Offset = "0x1143290")]
		private int <SetReceiveData>b__5_0(RedEnvelopeAwardDisplayInfo a, RedEnvelopeAwardDisplayInfo b)
		{
			return 0;
		}

		// Token: 0x04009427 RID: 37927
		[Token(Token = "0x4009427")]
		[FieldOffset(Offset = "0x98")]
		private UIHudRedEnvelopeMatchResultPopWindowView m_View;

		// Token: 0x04009428 RID: 37928
		[Token(Token = "0x4009428")]
		[FieldOffset(Offset = "0xA0")]
		private List<RedEnvelopeAwardItemView> m_ItemViewList;
	}
}
