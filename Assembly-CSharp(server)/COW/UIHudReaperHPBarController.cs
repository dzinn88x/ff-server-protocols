using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001643 RID: 5699
	[Token(Token = "0x2001643")]
	public class UIHudReaperHPBarController : UIBaseController
	{
		// Token: 0x060066D6 RID: 26326 RVA: 0x0001D550 File Offset: 0x0001B750
		[Token(Token = "0x60066D6")]
		[Address(RVA = "0x17E9FB4", Offset = "0x17E9FB4", VA = "0x7BBBFE9FB4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D7")]
		[Address(RVA = "0x17EA004", Offset = "0x17EA004", VA = "0x7BBBFEA004", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D8")]
		[Address(RVA = "0x17EA090", Offset = "0x17EA090", VA = "0x7BBBFEA090")]
		public void UpdateHP(int oldV, int newV)
		{
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D9")]
		[Address(RVA = "0x17EA154", Offset = "0x17EA154", VA = "0x7BBBFEA154")]
		public UIHudReaperHPBarController()
		{
		}

		// Token: 0x0400846F RID: 33903
		[Token(Token = "0x400846F")]
		[FieldOffset(Offset = "0x58")]
		private UIHudReaperHPBarView m_View;
	}
}
