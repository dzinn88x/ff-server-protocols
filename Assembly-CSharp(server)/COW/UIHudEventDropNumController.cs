using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018BE RID: 6334
	[Token(Token = "0x20018BE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4BC4", Offset = "0x10F4BC4")]
	public class UIHudEventDropNumController : UIBaseController
	{
		// Token: 0x06007E15 RID: 32277 RVA: 0x00022848 File Offset: 0x00020A48
		[Token(Token = "0x6007E15")]
		[Address(RVA = "0x1C0AFAC", Offset = "0x1C0AFAC", VA = "0x7BBC40AFAC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E16 RID: 32278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E16")]
		[Address(RVA = "0x1C0AFFC", Offset = "0x1C0AFFC", VA = "0x7BBC40AFFC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E17 RID: 32279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E17")]
		[Address(RVA = "0x1C0B148", Offset = "0x1C0B148", VA = "0x7BBC40B148", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007E18 RID: 32280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E18")]
		[Address(RVA = "0x1C0B214", Offset = "0x1C0B214", VA = "0x7BBC40B214")]
		private void OnPickUpEventZombieDropItem(object[] data)
		{
		}

		// Token: 0x06007E19 RID: 32281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E19")]
		[Address(RVA = "0x1C0B340", Offset = "0x1C0B340", VA = "0x7BBC40B340")]
		public UIHudEventDropNumController()
		{
		}

		// Token: 0x04009167 RID: 37223
		[Token(Token = "0x4009167")]
		[FieldOffset(Offset = "0x58")]
		private UIHudEventDropNumView m_View;
	}
}
