using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001784 RID: 6020
	[Token(Token = "0x2001784")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2374", Offset = "0x10F2374")]
	public class UIDebtWindowController : UIPopupWindowController
	{
		// Token: 0x06007251 RID: 29265 RVA: 0x0001FD10 File Offset: 0x0001DF10
		[Token(Token = "0x6007251")]
		[Address(RVA = "0x1BB02DC", Offset = "0x1BB02DC", VA = "0x7BBC3B02DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007252")]
		[Address(RVA = "0x1BB032C", Offset = "0x1BB032C", VA = "0x7BBC3B032C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007253")]
		[Address(RVA = "0x1BB0410", Offset = "0x1BB0410", VA = "0x7BBC3B0410")]
		private void OnChargeBtn()
		{
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007254")]
		[Address(RVA = "0x1BB0450", Offset = "0x1BB0450", VA = "0x7BBC3B0450")]
		public void SetDebtCount(int _gemsCount)
		{
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007255")]
		[Address(RVA = "0x1BB0448", Offset = "0x1BB0448", VA = "0x7BBC3B0448")]
		public void CloseDebtWindows()
		{
		}

		// Token: 0x06007256 RID: 29270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007256")]
		[Address(RVA = "0x1BB0510", Offset = "0x1BB0510", VA = "0x7BBC3B0510")]
		public UIDebtWindowController()
		{
		}

		// Token: 0x04008B65 RID: 35685
		[Token(Token = "0x4008B65")]
		[FieldOffset(Offset = "0x98")]
		private UIDebtWindowView m_view;
	}
}
