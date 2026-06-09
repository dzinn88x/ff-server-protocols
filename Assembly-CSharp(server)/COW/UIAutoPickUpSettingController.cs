using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016A5 RID: 5797
	[Token(Token = "0x20016A5")]
	public class UIAutoPickUpSettingController : UISettingContentBase
	{
		// Token: 0x060069AD RID: 27053 RVA: 0x0001DF10 File Offset: 0x0001C110
		[Token(Token = "0x60069AD")]
		[Address(RVA = "0x1B16A24", Offset = "0x1B16A24", VA = "0x7BBC316A24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069AE")]
		[Address(RVA = "0x1B16A74", Offset = "0x1B16A74", VA = "0x7BBC316A74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069AF")]
		[Address(RVA = "0x1B16ADC", Offset = "0x1B16ADC", VA = "0x7BBC316ADC")]
		private void InitItem()
		{
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B0")]
		[Address(RVA = "0x1B17124", Offset = "0x1B17124", VA = "0x7BBC317124")]
		private void OnToggleValueChange(int value)
		{
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B1")]
		[Address(RVA = "0x1B17188", Offset = "0x1B17188", VA = "0x7BBC317188")]
		public UIAutoPickUpSettingController()
		{
		}

		// Token: 0x04008674 RID: 34420
		[Token(Token = "0x4008674")]
		[FieldOffset(Offset = "0x60")]
		private UIAutoPickUpSettingView m_View;

		// Token: 0x04008675 RID: 34421
		[Token(Token = "0x4008675")]
		public const string FastAutoPickup = "T_21_C_AUTOPICKUP_FAST";

		// Token: 0x04008676 RID: 34422
		[Token(Token = "0x4008676")]
		public const string DefaultAutoPickup = "T_21_C_AUTOPICKUP_AVERAGE";

		// Token: 0x04008677 RID: 34423
		[Token(Token = "0x4008677")]
		[FieldOffset(Offset = "0x68")]
		private bool isInit;
	}
}
