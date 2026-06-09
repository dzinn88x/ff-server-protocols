using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001909 RID: 6409
	[Token(Token = "0x2001909")]
	public class UIHudMatchResult2TeamsGridItemBombController : UIHudMatchResult2TeamsGridItemController
	{
		// Token: 0x060080CD RID: 32973 RVA: 0x00023250 File Offset: 0x00021450
		[Token(Token = "0x60080CD")]
		[Address(RVA = "0x15C2BC8", Offset = "0x15C2BC8", VA = "0x7BBBDC2BC8")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060080CE RID: 32974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080CE")]
		[Address(RVA = "0x15C2C18", Offset = "0x15C2C18", VA = "0x7BBBDC2C18", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060080CF RID: 32975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080CF")]
		[Address(RVA = "0x15C2C88", Offset = "0x15C2C88", VA = "0x7BBBDC2C88", Slot = "28")]
		protected override void InitComponents()
		{
		}

		// Token: 0x060080D0 RID: 32976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D0")]
		[Address(RVA = "0x15C2F04", Offset = "0x15C2F04", VA = "0x7BBBDC2F04", Slot = "29")]
		protected override void SetScores(TeammateStats p)
		{
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D1")]
		[Address(RVA = "0x15C2FA4", Offset = "0x15C2FA4", VA = "0x7BBBDC2FA4")]
		public UIHudMatchResult2TeamsGridItemBombController()
		{
		}

		// Token: 0x040092CC RID: 37580
		[Token(Token = "0x40092CC")]
		[FieldOffset(Offset = "0xF0")]
		private UIHudMatchResult2TeamsGridItemBombView m_View;
	}
}
