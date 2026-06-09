using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020020B0 RID: 8368
	[Token(Token = "0x20020B0")]
	public class UITeamBaseProfileController : UIBaseController
	{
		// Token: 0x0600BC63 RID: 48227 RVA: 0x000353E8 File Offset: 0x000335E8
		[Token(Token = "0x600BC63")]
		[Address(RVA = "0x1F52B68", Offset = "0x1F52B68", VA = "0x7BBC752B68")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC64")]
		[Address(RVA = "0x1F52BB8", Offset = "0x1F52BB8", VA = "0x7BBC752BB8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BC65 RID: 48229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC65")]
		[Address(RVA = "0x1F52C1C", Offset = "0x1F52C1C", VA = "0x7BBC752C1C")]
		public void SetData(TeamInfo teamInfo)
		{
		}

		// Token: 0x0600BC66 RID: 48230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC66")]
		[Address(RVA = "0x1F52F68", Offset = "0x1F52F68", VA = "0x7BBC752F68")]
		public UITeamBaseProfileController()
		{
		}

		// Token: 0x0400BCF2 RID: 48370
		[Token(Token = "0x400BCF2")]
		[FieldOffset(Offset = "0x58")]
		private UITeamBaseProfileView m_View;

		// Token: 0x0400BCF3 RID: 48371
		[Token(Token = "0x400BCF3")]
		[FieldOffset(Offset = "0x60")]
		private TeamInfo m_TeamInfo;
	}
}
