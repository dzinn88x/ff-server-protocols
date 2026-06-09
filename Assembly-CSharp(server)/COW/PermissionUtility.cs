using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012E5 RID: 4837
	[Token(Token = "0x20012E5")]
	public static class PermissionUtility
	{
		// Token: 0x06004C87 RID: 19591 RVA: 0x00016EC0 File Offset: 0x000150C0
		[Token(Token = "0x6004C87")]
		[Address(RVA = "0x204C074", Offset = "0x204C074", VA = "0x7BBC84C074")]
		public static bool CheckPermission(PermissionUtility.Permission permission)
		{
			return default(bool);
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x00016ED8 File Offset: 0x000150D8
		[Token(Token = "0x6004C88")]
		[Address(RVA = "0x204C140", Offset = "0x204C140", VA = "0x7BBC84C140")]
		public static bool CheckPermissions()
		{
			return default(bool);
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C89")]
		[Address(RVA = "0x204C30C", Offset = "0x204C30C", VA = "0x7BBC84C30C")]
		public static void RequestPermissions(PermissionUtility.OnPermissionsResult callback)
		{
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x00016EF0 File Offset: 0x000150F0
		[Token(Token = "0x6004C8A")]
		[Address(RVA = "0x204C19C", Offset = "0x204C19C", VA = "0x7BBC84C19C")]
		private static bool CheckPermissions_Android()
		{
			return default(bool);
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C8B")]
		[Address(RVA = "0x204C4C8", Offset = "0x204C4C8", VA = "0x7BBC84C4C8")]
		private static void UpdatePermissionStatus_Android()
		{
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C8C")]
		[Address(RVA = "0x204C788", Offset = "0x204C788", VA = "0x7BBC84C788")]
		private static void DoCallback_Android()
		{
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C8D")]
		[Address(RVA = "0x204C378", Offset = "0x204C378", VA = "0x7BBC84C378")]
		private static void RequestPermissions_Android()
		{
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C8E")]
		[Address(RVA = "0x204D0F4", Offset = "0x204D0F4", VA = "0x7BBC84D0F4")]
		private static void _RequestPermissions_Android()
		{
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x00016F08 File Offset: 0x00015108
		[Token(Token = "0x6004C8F")]
		[Address(RVA = "0x204D954", Offset = "0x204D954", VA = "0x7BBC84D954")]
		private static bool Attempting(PermissionUtility.Permission permission)
		{
			return default(bool);
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x00016F20 File Offset: 0x00015120
		[Token(Token = "0x6004C90")]
		[Address(RVA = "0x204D338", Offset = "0x204D338", VA = "0x7BBC84D338")]
		private static bool Attempted(PermissionUtility.Permission permission)
		{
			return default(bool);
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C91")]
		[Address(RVA = "0x204D42C", Offset = "0x204D42C", VA = "0x7BBC84D42C")]
		private static void RequestPermission_Android(PermissionUtility.Permission permission)
		{
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C92")]
		[Address(RVA = "0x204DA50", Offset = "0x204DA50", VA = "0x7BBC84DA50")]
		private static void _RequestPermission_Android(PermissionUtility.Permission permission)
		{
		}

		// Token: 0x0400741C RID: 29724
		[Token(Token = "0x400741C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PermissionUtility.Permission[] Permissions_Critical;

		// Token: 0x0400741D RID: 29725
		[Token(Token = "0x400741D")]
		[FieldOffset(Offset = "0x8")]
		public static readonly PermissionUtility.Permission[] Permissions_Trivial;

		// Token: 0x0400741E RID: 29726
		[Token(Token = "0x400741E")]
		[FieldOffset(Offset = "0x10")]
		private static PermissionUtility.OnPermissionsResult _OnPermissionsResultCalkback;

		// Token: 0x0400741F RID: 29727
		[Token(Token = "0x400741F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<PermissionUtility.Permission, string> _AndroidPermissions;

		// Token: 0x04007420 RID: 29728
		[Token(Token = "0x4007420")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<PermissionUtility.Permission, bool> _PermissionStatus_Android;

		// Token: 0x04007421 RID: 29729
		[Token(Token = "0x4007421")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<PermissionUtility.Permission, bool> _PermissionAttempt_Android;

		// Token: 0x04007422 RID: 29730
		[Token(Token = "0x4007422")]
		private const string PERMISSION_RATIONALES_ALERT_DIALOG_IDENTIFIER = "PermissionRationalesAlertDialogIdentifier";

		// Token: 0x04007423 RID: 29731
		[Token(Token = "0x4007423")]
		private const string PERMISSION_RATIONALE_ALERT_DIALOG_IDENTIFIER = "PermissionRationaleAlertDialogIdentifier";

		// Token: 0x04007424 RID: 29732
		[Token(Token = "0x4007424")]
		private const string GOTO_APPLICATION_DETAILS_SETTINGS_ALERT_DIALOG_IDENTIFIER = "GotoApplicationDetailsSettingsAlertDialogIdentifier";

		// Token: 0x020012E6 RID: 4838
		[Token(Token = "0x20012E6")]
		public enum Permission
		{
			// Token: 0x04007426 RID: 29734
			[Token(Token = "0x4007426")]
			None,
			// Token: 0x04007427 RID: 29735
			[Token(Token = "0x4007427")]
			ReadExternalStorage,
			// Token: 0x04007428 RID: 29736
			[Token(Token = "0x4007428")]
			WriteExternalStorage,
			// Token: 0x04007429 RID: 29737
			[Token(Token = "0x4007429")]
			PhoneState,
			// Token: 0x0400742A RID: 29738
			[Token(Token = "0x400742A")]
			Microphone
		}

		// Token: 0x020012E7 RID: 4839
		// (Invoke) Token: 0x06004C95 RID: 19605
		[Token(Token = "0x20012E7")]
		public delegate void OnPermissionsResult(Dictionary<PermissionUtility.Permission, bool> results);

		// Token: 0x020012E8 RID: 4840
		[Token(Token = "0x20012E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB118", Offset = "0x10EB118")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C99 RID: 19609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C99")]
			[Address(RVA = "0x204DF20", Offset = "0x204DF20", VA = "0x7BBC84DF20")]
			public <>c()
			{
			}

			// Token: 0x06004C9A RID: 19610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C9A")]
			[Address(RVA = "0x204DF28", Offset = "0x204DF28", VA = "0x7BBC84DF28")]
			internal void <RequestPermissions_Android>b__14_0()
			{
			}

			// Token: 0x06004C9B RID: 19611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C9B")]
			[Address(RVA = "0x204DF84", Offset = "0x204DF84", VA = "0x7BBC84DF84")]
			internal void <RequestPermission_Android>b__21_2()
			{
			}

			// Token: 0x06004C9C RID: 19612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C9C")]
			[Address(RVA = "0x204DFEC", Offset = "0x204DFEC", VA = "0x7BBC84DFEC")]
			internal void <RequestPermission_Android>b__21_3()
			{
			}

			// Token: 0x0400742B RID: 29739
			[Token(Token = "0x400742B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PermissionUtility.<>c <>9;

			// Token: 0x0400742C RID: 29740
			[Token(Token = "0x400742C")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__14_0;

			// Token: 0x0400742D RID: 29741
			[Token(Token = "0x400742D")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__21_2;

			// Token: 0x0400742E RID: 29742
			[Token(Token = "0x400742E")]
			[FieldOffset(Offset = "0x18")]
			public static Action <>9__21_3;
		}

		// Token: 0x020012E9 RID: 4841
		[Token(Token = "0x20012E9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB128", Offset = "0x10EB128")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06004C9D RID: 19613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C9D")]
			[Address(RVA = "0x204DA48", Offset = "0x204DA48", VA = "0x7BBC84DA48")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06004C9E RID: 19614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C9E")]
			[Address(RVA = "0x204DFF4", Offset = "0x204DFF4", VA = "0x7BBC84DFF4")]
			internal void <RequestPermission_Android>b__0()
			{
			}

			// Token: 0x06004C9F RID: 19615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C9F")]
			[Address(RVA = "0x204E05C", Offset = "0x204E05C", VA = "0x7BBC84E05C")]
			internal void <RequestPermission_Android>b__1()
			{
			}

			// Token: 0x0400742F RID: 29743
			[Token(Token = "0x400742F")]
			[FieldOffset(Offset = "0x10")]
			public PermissionUtility.Permission permission;
		}

		// Token: 0x020012EA RID: 4842
		[Token(Token = "0x20012EA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB138", Offset = "0x10EB138")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06004CA0 RID: 19616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CA0")]
			[Address(RVA = "0x204DC20", Offset = "0x204DC20", VA = "0x7BBC84DC20")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x06004CA1 RID: 19617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CA1")]
			[Address(RVA = "0x204E108", Offset = "0x204E108", VA = "0x7BBC84E108")]
			internal void <_RequestPermission_Android>b__0(PlatformUtility_Android.RequestPermissionResult result)
			{
			}

			// Token: 0x04007430 RID: 29744
			[Token(Token = "0x4007430")]
			[FieldOffset(Offset = "0x10")]
			public PermissionUtility.Permission permission;
		}
	}
}
