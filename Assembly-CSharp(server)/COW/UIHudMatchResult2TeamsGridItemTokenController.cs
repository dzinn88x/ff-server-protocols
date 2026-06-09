using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200167C RID: 5756
	[Token(Token = "0x200167C")]
	public class UIHudMatchResult2TeamsGridItemTokenController : UIHudMatchResult2TeamsGridItemController
	{
		// Token: 0x0600687D RID: 26749 RVA: 0x0001DA00 File Offset: 0x0001BC00
		[Token(Token = "0x600687D")]
		[Address(RVA = "0x15C4EE0", Offset = "0x15C4EE0", VA = "0x7BBBDC4EE0")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600687E")]
		[Address(RVA = "0x15C4F30", Offset = "0x15C4F30", VA = "0x7BBBDC4F30", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600687F")]
		[Address(RVA = "0x15C4FA0", Offset = "0x15C4FA0", VA = "0x7BBBDC4FA0", Slot = "28")]
		protected override void InitComponents()
		{
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006880")]
		[Address(RVA = "0x15C518C", Offset = "0x15C518C", VA = "0x7BBBDC518C", Slot = "29")]
		protected override void SetScores(TeammateStats p)
		{
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006881")]
		[Address(RVA = "0x15C52AC", Offset = "0x15C52AC", VA = "0x7BBBDC52AC")]
		public UIHudMatchResult2TeamsGridItemTokenController()
		{
		}

		// Token: 0x04008547 RID: 34119
		[Token(Token = "0x4008547")]
		[FieldOffset(Offset = "0xF0")]
		private UIHudMatchResult2TeamsGridItemTokenView m_View;

		// Token: 0x04008548 RID: 34120
		[Token(Token = "0x4008548")]
		[FieldOffset(Offset = "0xF8")]
		private ulong m_UserAccountId;
	}
}
