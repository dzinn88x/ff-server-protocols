using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200188E RID: 6286
	[Token(Token = "0x200188E")]
	internal class UIHUDCenterUpTitleController : UIBaseController
	{
		// Token: 0x06007C82 RID: 31874 RVA: 0x00022350 File Offset: 0x00020550
		[Token(Token = "0x6007C82")]
		[Address(RVA = "0x16B6CC4", Offset = "0x16B6CC4", VA = "0x7BBBEB6CC4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C83")]
		[Address(RVA = "0x16B6D14", Offset = "0x16B6D14", VA = "0x7BBBEB6D14", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C84")]
		[Address(RVA = "0x16B6DF8", Offset = "0x16B6DF8", VA = "0x7BBBEB6DF8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C85")]
		[Address(RVA = "0x16B6EC4", Offset = "0x16B6EC4", VA = "0x7BBBEB6EC4")]
		private void OnTitleInfoCome(params object[] data)
		{
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C86")]
		[Address(RVA = "0x16B7048", Offset = "0x16B7048", VA = "0x7BBBEB7048")]
		public UIHUDCenterUpTitleController()
		{
		}

		// Token: 0x04009063 RID: 36963
		[Token(Token = "0x4009063")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDCenterUpTitleView m_View;
	}
}
