using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200194D RID: 6477
	[Token(Token = "0x200194D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5F7C", Offset = "0x10F5F7C")]
	internal class UIHudReportController : UIBaseController
	{
		// Token: 0x06008368 RID: 33640 RVA: 0x00023B20 File Offset: 0x00021D20
		[Token(Token = "0x6008368")]
		[Address(RVA = "0x17F2708", Offset = "0x17F2708", VA = "0x7BBBFF2708")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008369 RID: 33641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008369")]
		[Address(RVA = "0x17F2758", Offset = "0x17F2758", VA = "0x7BBBFF2758", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600836A")]
		[Address(RVA = "0x17F2E18", Offset = "0x17F2E18", VA = "0x7BBBFF2E18", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600836B")]
		[Address(RVA = "0x17F2EE4", Offset = "0x17F2EE4", VA = "0x7BBBFF2EE4")]
		public void SetUIData(ulong uID, string nickname, {QAb\u0082~u pID)
		{
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600836C")]
		[Address(RVA = "0x17F2E10", Offset = "0x17F2E10", VA = "0x7BBBFF2E10")]
		private void OnCheatToggleClick()
		{
		}

		// Token: 0x0600836D RID: 33645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600836D")]
		[Address(RVA = "0x17F3024", Offset = "0x17F3024", VA = "0x7BBBFF3024")]
		private void OnTeamToggleClick()
		{
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600836E")]
		[Address(RVA = "0x17F3030", Offset = "0x17F3030", VA = "0x7BBBFF3030")]
		private void OnDirtyToggleClick()
		{
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600836F")]
		[Address(RVA = "0x17F303C", Offset = "0x17F303C", VA = "0x7BBBFF303C")]
		private void OnNegativeToggleClick()
		{
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008370")]
		[Address(RVA = "0x17F3048", Offset = "0x17F3048", VA = "0x7BBBFF3048")]
		private void OnHangUpToggleClick()
		{
		}

		// Token: 0x06008371 RID: 33649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008371")]
		[Address(RVA = "0x17F3054", Offset = "0x17F3054", VA = "0x7BBBFF3054")]
		private void OnBtnConfirmClick()
		{
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008372")]
		[Address(RVA = "0x17F3410", Offset = "0x17F3410", VA = "0x7BBBFF3410")]
		private void OnBtnCancelClick()
		{
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008373")]
		[Address(RVA = "0x17F3418", Offset = "0x17F3418", VA = "0x7BBBFF3418")]
		private void OnUIDataReceived(object[] param)
		{
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008374")]
		[Address(RVA = "0x17F3574", Offset = "0x17F3574", VA = "0x7BBBFF3574")]
		public UIHudReportController()
		{
		}

		// Token: 0x0400943A RID: 37946
		[Token(Token = "0x400943A")]
		[FieldOffset(Offset = "0x58")]
		private UIHudReportView m_View;

		// Token: 0x0400943B RID: 37947
		[Token(Token = "0x400943B")]
		[FieldOffset(Offset = "0x60")]
		private ulong m_ReporteeUserId;

		// Token: 0x0400943C RID: 37948
		[Token(Token = "0x400943C")]
		[FieldOffset(Offset = "0x68")]
		private {QAb\u0082~u m_ReporteePlayerId;

		// Token: 0x0400943D RID: 37949
		[Token(Token = "0x400943D")]
		[FieldOffset(Offset = "0x80")]
		private uint m_ReportReason;

		// Token: 0x0200194E RID: 6478
		[Token(Token = "0x200194E")]
		private enum ReportReason
		{
			// Token: 0x0400943F RID: 37951
			[Token(Token = "0x400943F")]
			Cheat,
			// Token: 0x04009440 RID: 37952
			[Token(Token = "0x4009440")]
			Teaming,
			// Token: 0x04009441 RID: 37953
			[Token(Token = "0x4009441")]
			DirtyName,
			// Token: 0x04009442 RID: 37954
			[Token(Token = "0x4009442")]
			Negative,
			// Token: 0x04009443 RID: 37955
			[Token(Token = "0x4009443")]
			HangUp
		}
	}
}
