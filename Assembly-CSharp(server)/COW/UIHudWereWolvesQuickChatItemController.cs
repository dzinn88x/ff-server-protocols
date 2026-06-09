using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001999 RID: 6553
	[Token(Token = "0x2001999")]
	public class UIHudWereWolvesQuickChatItemController : UIEasyListItemController
	{
		// Token: 0x060085FE RID: 34302 RVA: 0x000244F8 File Offset: 0x000226F8
		[Token(Token = "0x60085FE")]
		[Address(RVA = "0x1D13F00", Offset = "0x1D13F00", VA = "0x7BBC513F00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085FF")]
		[Address(RVA = "0x1D13F50", Offset = "0x1D13F50", VA = "0x7BBC513F50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008600 RID: 34304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008600")]
		[Address(RVA = "0x1D14034", Offset = "0x1D14034", VA = "0x7BBC514034")]
		private void OnClick()
		{
		}

		// Token: 0x06008601 RID: 34305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008601")]
		[Address(RVA = "0x1D1416C", Offset = "0x1D1416C", VA = "0x7BBC51416C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008602")]
		[Address(RVA = "0x1D1431C", Offset = "0x1D1431C", VA = "0x7BBC51431C")]
		public UIHudWereWolvesQuickChatItemController()
		{
		}

		// Token: 0x04009563 RID: 38243
		[Token(Token = "0x4009563")]
		[FieldOffset(Offset = "0x70")]
		private UIHudWereWolvesQuickChatItemView m_View;

		// Token: 0x04009564 RID: 38244
		[Token(Token = "0x4009564")]
		[FieldOffset(Offset = "0x78")]
		private WereWolvesQuickChatData m_data;
	}
}
