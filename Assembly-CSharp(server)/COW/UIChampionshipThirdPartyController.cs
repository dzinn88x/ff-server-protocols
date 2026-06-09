using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014A7 RID: 5287
	[Token(Token = "0x20014A7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED494", Offset = "0x10ED494")]
	public class UIChampionshipThirdPartyController : UIChampionshipController
	{
		// Token: 0x060059A6 RID: 22950 RVA: 0x0001A5E0 File Offset: 0x000187E0
		[Token(Token = "0x60059A6")]
		[Address(RVA = "0x1EDBD6C", Offset = "0x1EDBD6C", VA = "0x7BBC6DBD6C")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A7")]
		[Address(RVA = "0x1EDBDBC", Offset = "0x1EDBDBC", VA = "0x7BBC6DBDBC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A8")]
		[Address(RVA = "0x1EDBF1C", Offset = "0x1EDBF1C", VA = "0x7BBC6DBF1C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A9")]
		[Address(RVA = "0x1EDBFE8", Offset = "0x1EDBFE8", VA = "0x7BBC6DBFE8", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AA")]
		[Address(RVA = "0x1EDC2C8", Offset = "0x1EDC2C8", VA = "0x7BBC6DC2C8", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x0001A5F8 File Offset: 0x000187F8
		[Token(Token = "0x60059AB")]
		[Address(RVA = "0x1EDC2D0", Offset = "0x1EDC2D0", VA = "0x7BBC6DC2D0", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AC")]
		[Address(RVA = "0x1EDC028", Offset = "0x1EDC028", VA = "0x7BBC6DC028")]
		private void TryPlayNewSeasonAnim()
		{
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AD")]
		[Address(RVA = "0x1EDC2D8", Offset = "0x1EDC2D8", VA = "0x7BBC6DC2D8", Slot = "42")]
		protected override void AutoShowNotice()
		{
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AE")]
		[Address(RVA = "0x1EDC2EC", Offset = "0x1EDC2EC", VA = "0x7BBC6DC2EC")]
		private void OnChampionshipAnimDone(params object[] param)
		{
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AF")]
		[Address(RVA = "0x1EDC300", Offset = "0x1EDC300", VA = "0x7BBC6DC300")]
		public UIChampionshipThirdPartyController()
		{
		}

		// Token: 0x04007D13 RID: 32019
		[Token(Token = "0x4007D13")]
		[FieldOffset(Offset = "0x1A0")]
		private UIChampionshipView m_View;

		// Token: 0x04007D14 RID: 32020
		[Token(Token = "0x4007D14")]
		[FieldOffset(Offset = "0x1A8")]
		private bool m_ShowNewSeasonAnim;
	}
}
