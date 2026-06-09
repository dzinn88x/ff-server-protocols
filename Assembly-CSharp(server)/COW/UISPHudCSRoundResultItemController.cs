using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B8D RID: 7053
	[Token(Token = "0x2001B8D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA564", Offset = "0x10FA564")]
	internal class UISPHudCSRoundResultItemController : UIBaseController
	{
		// Token: 0x06009824 RID: 38948 RVA: 0x000280F8 File Offset: 0x000262F8
		[Token(Token = "0x6009824")]
		[Address(RVA = "0x1EE1F40", Offset = "0x1EE1F40", VA = "0x7BBC6E1F40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009825 RID: 38949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009825")]
		[Address(RVA = "0x1EE1F90", Offset = "0x1EE1F90", VA = "0x7BBC6E1F90", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009826")]
		[Address(RVA = "0x1EE1FF4", Offset = "0x1EE1FF4", VA = "0x7BBC6E1FF4", Slot = "28")]
		public virtual void Reset()
		{
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009827")]
		[Address(RVA = "0x1EE2234", Offset = "0x1EE2234", VA = "0x7BBC6E2234")]
		public void SetRoundId(int roundId)
		{
		}

		// Token: 0x06009828 RID: 38952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009828")]
		[Address(RVA = "0x1EE2298", Offset = "0x1EE2298", VA = "0x7BBC6E2298", Slot = "29")]
		public virtual void OnTeamWin(bool winOnLeft, byte winReason)
		{
		}

		// Token: 0x06009829 RID: 38953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009829")]
		[Address(RVA = "0x1EE24D0", Offset = "0x1EE24D0", VA = "0x7BBC6E24D0")]
		public UISPHudCSRoundResultItemController()
		{
		}

		// Token: 0x0400A01F RID: 40991
		[Token(Token = "0x400A01F")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudCSRoundResultItemView m_View;
	}
}
