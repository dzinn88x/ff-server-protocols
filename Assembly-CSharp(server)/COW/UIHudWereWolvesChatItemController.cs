using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001995 RID: 6549
	[Token(Token = "0x2001995")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6A34", Offset = "0x10F6A34")]
	public class UIHudWereWolvesChatItemController : UIEasyListItemController
	{
		// Token: 0x060085E0 RID: 34272 RVA: 0x000244B0 File Offset: 0x000226B0
		[Token(Token = "0x60085E0")]
		[Address(RVA = "0x1D10B04", Offset = "0x1D10B04", VA = "0x7BBC510B04")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060085E1 RID: 34273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085E1")]
		[Address(RVA = "0x1D10B54", Offset = "0x1D10B54", VA = "0x7BBC510B54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060085E2 RID: 34274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085E2")]
		[Address(RVA = "0x1D10BB8", Offset = "0x1D10BB8", VA = "0x7BBC510BB8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060085E3 RID: 34275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085E3")]
		[Address(RVA = "0x1D11970", Offset = "0x1D11970", VA = "0x7BBC511970")]
		public UIHudWereWolvesChatItemController()
		{
		}

		// Token: 0x04009554 RID: 38228
		[Token(Token = "0x4009554")]
		[FieldOffset(Offset = "0x70")]
		private UIHudWereWolvesChatItemView m_View;
	}
}
