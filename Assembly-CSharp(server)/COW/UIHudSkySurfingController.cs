using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200195D RID: 6493
	[Token(Token = "0x200195D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F622C", Offset = "0x10F622C")]
	internal class UIHudSkySurfingController : UIHudButtonBaseController
	{
		// Token: 0x060083E6 RID: 33766 RVA: 0x00023D48 File Offset: 0x00021F48
		[Token(Token = "0x60083E6")]
		[Address(RVA = "0x166B6D0", Offset = "0x166B6D0", VA = "0x7BBBE6B6D0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083E7 RID: 33767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083E7")]
		[Address(RVA = "0x166B720", Offset = "0x166B720", VA = "0x7BBBE6B720", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083E8")]
		[Address(RVA = "0x166B9D8", Offset = "0x166B9D8", VA = "0x7BBBE6B9D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060083E9 RID: 33769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60083E9")]
		[Address(RVA = "0x166BBA0", Offset = "0x166BBA0", VA = "0x7BBBE6BBA0", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x060083EA RID: 33770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083EA")]
		[Address(RVA = "0x166BBE8", Offset = "0x166BBE8", VA = "0x7BBBE6BBE8")]
		private void Update()
		{
		}

		// Token: 0x060083EB RID: 33771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083EB")]
		[Address(RVA = "0x166BD28", Offset = "0x166BD28", VA = "0x7BBBE6BD28")]
		private void SetHightlight(bool highlight, bool haveFlilght)
		{
		}

		// Token: 0x060083EC RID: 33772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083EC")]
		[Address(RVA = "0x166BE08", Offset = "0x166BE08", VA = "0x7BBBE6BE08")]
		private void OnStopSkySurfing(params object[] param)
		{
		}

		// Token: 0x060083ED RID: 33773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083ED")]
		[Address(RVA = "0x166BE4C", Offset = "0x166BE4C", VA = "0x7BBBE6BE4C")]
		private void OnStartSkyDiving(params object[] param)
		{
		}

		// Token: 0x060083EE RID: 33774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083EE")]
		[Address(RVA = "0x166C048", Offset = "0x166C048", VA = "0x7BBBE6C048")]
		private void OnShowSurfingTutorial(params object[] param)
		{
		}

		// Token: 0x060083EF RID: 33775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083EF")]
		[Address(RVA = "0x166C0E8", Offset = "0x166C0E8", VA = "0x7BBBE6C0E8")]
		private void OnLocalPlayerTeamParachuteModeChange(params object[] param)
		{
		}

		// Token: 0x060083F0 RID: 33776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083F0")]
		[Address(RVA = "0x166C230", Offset = "0x166C230", VA = "0x7BBBE6C230")]
		public UIHudSkySurfingController()
		{
		}

		// Token: 0x04009481 RID: 38017
		[Token(Token = "0x4009481")]
		[FieldOffset(Offset = "0x60")]
		private UIHudSkySurfingView m_View;

		// Token: 0x04009482 RID: 38018
		[Token(Token = "0x4009482")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsHighlight;

		// Token: 0x04009483 RID: 38019
		[Token(Token = "0x4009483")]
		private const string m_SkySurfingIcon = "UI_icon_SkydivingStance";

		// Token: 0x04009484 RID: 38020
		[Token(Token = "0x4009484")]
		private const string m_SkySurfingIconHighLight = "UI_icon_SkydivingStance_choose";

		// Token: 0x04009485 RID: 38021
		[Token(Token = "0x4009485")]
		private const string m_SkyFlightSurfingIcon = "UI_icon_Mounts_Dive";

		// Token: 0x04009486 RID: 38022
		[Token(Token = "0x4009486")]
		private const string m_SkyFlightSurfingIconHighLight = "UI_icon_Mounts_Dive_Choose";
	}
}
