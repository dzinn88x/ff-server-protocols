using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C02 RID: 7170
	[Token(Token = "0x2001C02")]
	public class UIHUDWereWolvesCampInfoController : UIBaseController
	{
		// Token: 0x06009BDE RID: 39902 RVA: 0x00028F08 File Offset: 0x00027108
		[Token(Token = "0x6009BDE")]
		[Address(RVA = "0x1D52CE0", Offset = "0x1D52CE0", VA = "0x7BBC552CE0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009BDF RID: 39903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BDF")]
		[Address(RVA = "0x1D52D30", Offset = "0x1D52D30", VA = "0x7BBC552D30", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE0")]
		[Address(RVA = "0x1D52E50", Offset = "0x1D52E50", VA = "0x7BBC552E50")]
		public void ShowData(bool isWolf, int wolfCount, List<byte> teammateWolfsColorIndex, float endTime)
		{
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE1")]
		[Address(RVA = "0x1D53450", Offset = "0x1D53450", VA = "0x7BBC553450")]
		private void SetWolfTeamateInfo(List<byte> teammateWolfsColorIndex)
		{
		}

		// Token: 0x06009BE2 RID: 39906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE2")]
		[Address(RVA = "0x1D5375C", Offset = "0x1D5375C", VA = "0x7BBC55375C")]
		private void Update()
		{
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE3")]
		[Address(RVA = "0x1D53098", Offset = "0x1D53098", VA = "0x7BBC553098")]
		private void UpdateLeftTimeShow()
		{
		}

		// Token: 0x06009BE4 RID: 39908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE4")]
		[Address(RVA = "0x1D53760", Offset = "0x1D53760", VA = "0x7BBC553760")]
		public UIHUDWereWolvesCampInfoController()
		{
		}

		// Token: 0x0400A1FA RID: 41466
		[Token(Token = "0x400A1FA")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDWereWolvesCampInfoView m_View;

		// Token: 0x0400A1FB RID: 41467
		[Token(Token = "0x400A1FB")]
		[FieldOffset(Offset = "0x60")]
		private KeyHelperWereWolvesCampHUD m_KeyHelper;

		// Token: 0x0400A1FC RID: 41468
		[Token(Token = "0x400A1FC")]
		[FieldOffset(Offset = "0x68")]
		private float m_EndTime;

		// Token: 0x0400A1FD RID: 41469
		[Token(Token = "0x400A1FD")]
		[FieldOffset(Offset = "0x6C")]
		private float m_TotalTime;

		// Token: 0x0400A1FE RID: 41470
		[Token(Token = "0x400A1FE")]
		[FieldOffset(Offset = "0x70")]
		private int lastLeftTimeS;
	}
}
