using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B98 RID: 7064
	[Token(Token = "0x2001B98")]
	internal class UISPHudResultShowController : UIHudResultShowBaseController
	{
		// Token: 0x0600985A RID: 39002 RVA: 0x00028230 File Offset: 0x00026430
		[Token(Token = "0x600985A")]
		[Address(RVA = "0x1EF0F84", Offset = "0x1EF0F84", VA = "0x7BBC6F0F84")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600985B RID: 39003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600985B")]
		[Address(RVA = "0x1EF0FD4", Offset = "0x1EF0FD4", VA = "0x7BBC6F0FD4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600985C RID: 39004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600985C")]
		[Address(RVA = "0x1EF1674", Offset = "0x1EF1674", VA = "0x7BBC6F1674", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600985D RID: 39005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600985D")]
		[Address(RVA = "0x1EF1354", Offset = "0x1EF1354", VA = "0x7BBC6F1354")]
		private void DoCreateResultShowWindow()
		{
		}

		// Token: 0x0600985E RID: 39006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600985E")]
		[Address(RVA = "0x1EF1CFC", Offset = "0x1EF1CFC", VA = "0x7BBC6F1CFC", Slot = "36")]
		public override void CreateProfileCallSign(PlayerData data, int index)
		{
		}

		// Token: 0x0600985F RID: 39007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600985F")]
		[Address(RVA = "0x1EF1FD0", Offset = "0x1EF1FD0", VA = "0x7BBC6F1FD0")]
		private void BtnMaskTriggered(params object[] data)
		{
		}

		// Token: 0x06009860 RID: 39008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009860")]
		[Address(RVA = "0x1EF1FD4", Offset = "0x1EF1FD4", VA = "0x7BBC6F1FD4")]
		private void OnUIClick()
		{
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009861")]
		[Address(RVA = "0x1EF1794", Offset = "0x1EF1794", VA = "0x7BBC6F1794")]
		private void InitTeamView(ResultTeamData teamData)
		{
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009862")]
		[Address(RVA = "0x1EF1A90", Offset = "0x1EF1A90", VA = "0x7BBC6F1A90")]
		private List<PlayerData> SortAndCopyPlayers(List<ResultPlayerData> dataList)
		{
			return null;
		}

		// Token: 0x06009863 RID: 39011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009863")]
		[Address(RVA = "0x1EF22C0", Offset = "0x1EF22C0", VA = "0x7BBC6F22C0")]
		public UISPHudResultShowController()
		{
		}

		// Token: 0x0400A030 RID: 41008
		[Token(Token = "0x400A030")]
		[FieldOffset(Offset = "0xD8")]
		private UISPHudResultShowView m_View;
	}
}
