using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001418 RID: 5144
	[Token(Token = "0x2001418")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC640", Offset = "0x10EC640")]
	internal class UIHudADSBonusCountdownController : UIBaseController
	{
		// Token: 0x060054CE RID: 21710 RVA: 0x00019518 File Offset: 0x00017718
		[Token(Token = "0x60054CE")]
		[Address(RVA = "0x1D61864", Offset = "0x1D61864", VA = "0x7BBC561864")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CF")]
		[Address(RVA = "0x1D618B4", Offset = "0x1D618B4", VA = "0x7BBC5618B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D0")]
		[Address(RVA = "0x1D61918", Offset = "0x1D61918", VA = "0x7BBC561918")]
		public void ShowBonusCountdown(float bonusEndTime)
		{
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D1")]
		[Address(RVA = "0x1D61B04", Offset = "0x1D61B04", VA = "0x7BBC561B04")]
		public void SetUIStyle(bool isWinStyle)
		{
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D2")]
		[Address(RVA = "0x1D61C18", Offset = "0x1D61C18", VA = "0x7BBC561C18")]
		private void Update()
		{
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D3")]
		[Address(RVA = "0x1D61D7C", Offset = "0x1D61D7C", VA = "0x7BBC561D7C")]
		public UIHudADSBonusCountdownController()
		{
		}

		// Token: 0x04007A0D RID: 31245
		[Token(Token = "0x4007A0D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudADSBonusCountdownView m_View;

		// Token: 0x04007A0E RID: 31246
		[Token(Token = "0x4007A0E")]
		[FieldOffset(Offset = "0x60")]
		private UITimeLabelHelper m_TimeHelper;

		// Token: 0x04007A0F RID: 31247
		[Token(Token = "0x4007A0F")]
		[FieldOffset(Offset = "0x68")]
		private float m_EndTime;

		// Token: 0x04007A10 RID: 31248
		[Token(Token = "0x4007A10")]
		[FieldOffset(Offset = "0x6C")]
		private Color winStyleColorBg;

		// Token: 0x04007A11 RID: 31249
		[Token(Token = "0x4007A11")]
		[FieldOffset(Offset = "0x7C")]
		private Color winStyleColorFor;

		// Token: 0x04007A12 RID: 31250
		[Token(Token = "0x4007A12")]
		[FieldOffset(Offset = "0x8C")]
		private Color loseStyleColorBg;

		// Token: 0x04007A13 RID: 31251
		[Token(Token = "0x4007A13")]
		[FieldOffset(Offset = "0x9C")]
		private Color loseStyleColorFor;
	}
}
