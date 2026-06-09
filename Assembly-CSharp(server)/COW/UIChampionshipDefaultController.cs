using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001471 RID: 5233
	[Token(Token = "0x2001471")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECDA0", Offset = "0x10ECDA0")]
	public class UIChampionshipDefaultController : UINavigationController
	{
		// Token: 0x06005832 RID: 22578 RVA: 0x0001A070 File Offset: 0x00018270
		[Token(Token = "0x6005832")]
		[Address(RVA = "0x1C2FD80", Offset = "0x1C2FD80", VA = "0x7BBC42FD80")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x0001A088 File Offset: 0x00018288
		[Token(Token = "0x6005833")]
		[Address(RVA = "0x1C2FDD0", Offset = "0x1C2FDD0", VA = "0x7BBC42FDD0", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005834")]
		[Address(RVA = "0x1C2FDD8", Offset = "0x1C2FDD8", VA = "0x7BBC42FDD8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005835")]
		[Address(RVA = "0x1C2FF7C", Offset = "0x1C2FF7C", VA = "0x7BBC42FF7C")]
		private void SetView()
		{
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005836")]
		[Address(RVA = "0x1C2FF80", Offset = "0x1C2FF80", VA = "0x7BBC42FF80")]
		protected void OnBtnRuleClick()
		{
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005837")]
		[Address(RVA = "0x1C30034", Offset = "0x1C30034", VA = "0x7BBC430034")]
		public UIChampionshipDefaultController()
		{
		}

		// Token: 0x04007C26 RID: 31782
		[Token(Token = "0x4007C26")]
		[FieldOffset(Offset = "0xB0")]
		private UIChampionshipDefaultView m_View;

		// Token: 0x04007C27 RID: 31783
		[Token(Token = "0x4007C27")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007C28 RID: 31784
		[Token(Token = "0x4007C28")]
		[FieldOffset(Offset = "0xC0")]
		private ChampionshipSettingDesc m_ChampionshipSettingInfo;
	}
}
