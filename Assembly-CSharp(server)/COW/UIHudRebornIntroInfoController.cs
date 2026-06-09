using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001943 RID: 6467
	[Token(Token = "0x2001943")]
	public class UIHudRebornIntroInfoController : UIBaseController
	{
		// Token: 0x06008326 RID: 33574 RVA: 0x000239E8 File Offset: 0x00021BE8
		[Token(Token = "0x6008326")]
		[Address(RVA = "0x17EE0CC", Offset = "0x17EE0CC", VA = "0x7BBBFEE0CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008327 RID: 33575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008327")]
		[Address(RVA = "0x17EE11C", Offset = "0x17EE11C", VA = "0x7BBBFEE11C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008328 RID: 33576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008328")]
		[Address(RVA = "0x17EE220", Offset = "0x17EE220", VA = "0x7BBBFEE220", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008329 RID: 33577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008329")]
		[Address(RVA = "0x17EE2C8", Offset = "0x17EE2C8", VA = "0x7BBBFEE2C8")]
		public UIHudRebornIntroInfoController()
		{
		}

		// Token: 0x0600832A RID: 33578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600832A")]
		[Address(RVA = "0x17EE2D0", Offset = "0x17EE2D0", VA = "0x7BBBFEE2D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143280", Offset = "0x1143280")]
		private void <OnUIInit>b__3_0()
		{
		}

		// Token: 0x04009421 RID: 37921
		[Token(Token = "0x4009421")]
		[FieldOffset(Offset = "0x58")]
		private UIHudDGGIntroInfoView m_View;

		// Token: 0x04009422 RID: 37922
		[Token(Token = "0x4009422")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallId;
	}
}
