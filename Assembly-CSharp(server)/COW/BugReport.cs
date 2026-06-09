using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025DF RID: 9695
	[Token(Token = "0x20025DF")]
	public static class BugReport
	{
		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600C760 RID: 51040 RVA: 0x000356A0 File Offset: 0x000338A0
		[Token(Token = "0x17000CDE")]
		public static bool Enabled
		{
			[Token(Token = "0x600C760")]
			[Address(RVA = "0x14E6DC0", Offset = "0x14E6DC0", VA = "0x7BBBCE6DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600C761 RID: 51041 RVA: 0x000356B8 File Offset: 0x000338B8
		// (set) Token: 0x0600C762 RID: 51042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CDF")]
		public static bool IsInited
		{
			[Token(Token = "0x600C761")]
			[Address(RVA = "0x14E6DC8", Offset = "0x14E6DC8", VA = "0x7BBBCE6DC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147F1C", Offset = "0x1147F1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C762")]
			[Address(RVA = "0x14E6E30", Offset = "0x14E6E30", VA = "0x7BBBCE6E30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147F2C", Offset = "0x1147F2C")]
			private set
			{
			}
		}

		// Token: 0x0600C763 RID: 51043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C763")]
		[Address(RVA = "0x14E6EA0", Offset = "0x14E6EA0", VA = "0x7BBBCE6EA0")]
		public static void Init()
		{
		}

		// Token: 0x0600C764 RID: 51044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C764")]
		[Address(RVA = "0x14E713C", Offset = "0x14E713C", VA = "0x7BBBCE713C")]
		public static void SetUnityLogTypes(int logTypes)
		{
		}

		// Token: 0x0600C765 RID: 51045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C765")]
		[Address(RVA = "0x14E72F8", Offset = "0x14E72F8", VA = "0x7BBBCE72F8")]
		public static void OverrideUnityLogTypes(int logTypes)
		{
		}

		// Token: 0x0600C766 RID: 51046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C766")]
		[Address(RVA = "0x14E74B4", Offset = "0x14E74B4", VA = "0x7BBBCE74B4")]
		public static void SetUserId(string userId)
		{
		}

		// Token: 0x0600C767 RID: 51047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C767")]
		[Address(RVA = "0x14E7670", Offset = "0x14E7670", VA = "0x7BBBCE7670")]
		public static void SetKeyValue(string key, string value)
		{
		}

		// Token: 0x0600C768 RID: 51048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C768")]
		[Address(RVA = "0x14E78A0", Offset = "0x14E78A0", VA = "0x7BBBCE78A0")]
		public static void Log(string msg)
		{
		}

		// Token: 0x0600C769 RID: 51049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C769")]
		[Address(RVA = "0x14E7A5C", Offset = "0x14E7A5C", VA = "0x7BBBCE7A5C")]
		public static void Report(string source, string msg, string stacktrace)
		{
		}

		// Token: 0x0600C76A RID: 51050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C76A")]
		[Address(RVA = "0x14E7C30", Offset = "0x14E7C30", VA = "0x7BBBCE7C30")]
		public static void Report(Exception exception)
		{
		}

		// Token: 0x0400F9AE RID: 63918
		[Token(Token = "0x400F9AE")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11308AC", Offset = "0x11308AC")]
		private static bool <IsInited>k__BackingField;

		// Token: 0x0400F9AF RID: 63919
		[Token(Token = "0x400F9AF")]
		[FieldOffset(Offset = "0x8")]
		private static List<BugReport.IBugReporter> _Impls;

		// Token: 0x020025E0 RID: 9696
		[Token(Token = "0x20025E0")]
		private interface IBugReporter
		{
			// Token: 0x17000CE0 RID: 3296
			// (get) Token: 0x0600C76C RID: 51052
			[Token(Token = "0x17000CE0")]
			bool IsInited { [Token(Token = "0x600C76C")] get; }

			// Token: 0x0600C76D RID: 51053
			[Token(Token = "0x600C76D")]
			void Init();

			// Token: 0x0600C76E RID: 51054
			[Token(Token = "0x600C76E")]
			void SetUnityLogTypes(int logTypes);

			// Token: 0x0600C76F RID: 51055
			[Token(Token = "0x600C76F")]
			void OverrideUnityLogTypes(int logTypes);

			// Token: 0x0600C770 RID: 51056
			[Token(Token = "0x600C770")]
			void SetUserId(string userId);

			// Token: 0x0600C771 RID: 51057
			[Token(Token = "0x600C771")]
			void SetKeyValue(string key, string value);

			// Token: 0x0600C772 RID: 51058
			[Token(Token = "0x600C772")]
			void Record(string msg);

			// Token: 0x0600C773 RID: 51059
			[Token(Token = "0x600C773")]
			void Report(string src, string msg, string stacktrace);

			// Token: 0x0600C774 RID: 51060
			[Token(Token = "0x600C774")]
			void Report(Exception exception);
		}

		// Token: 0x020025E1 RID: 9697
		[Token(Token = "0x20025E1")]
		private class Crashlytics : BugReport.IBugReporter
		{
			// Token: 0x17000CE1 RID: 3297
			// (get) Token: 0x0600C775 RID: 51061 RVA: 0x000356D0 File Offset: 0x000338D0
			[Token(Token = "0x17000CE1")]
			public static bool Enabled
			{
				[Token(Token = "0x600C775")]
				[Address(RVA = "0x14E7124", Offset = "0x14E7124", VA = "0x7BBBCE7124")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000CE2 RID: 3298
			// (get) Token: 0x0600C776 RID: 51062 RVA: 0x000356E8 File Offset: 0x000338E8
			[Token(Token = "0x17000CE2")]
			public bool IsInited
			{
				[Token(Token = "0x600C776")]
				[Address(RVA = "0x14E7E60", Offset = "0x14E7E60", VA = "0x7BBBCE7E60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600C777 RID: 51063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C777")]
			[Address(RVA = "0x14E7E68", Offset = "0x14E7E68", VA = "0x7BBBCE7E68", Slot = "5")]
			public void Init()
			{
			}

			// Token: 0x0600C778 RID: 51064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C778")]
			[Address(RVA = "0x14E7F88", Offset = "0x14E7F88", VA = "0x7BBBCE7F88")]
			private void OnApplicationLogMessageReceived(string logString, string stacktrace, LogType type)
			{
			}

			// Token: 0x0600C779 RID: 51065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C779")]
			[Address(RVA = "0x14E7F80", Offset = "0x14E7F80", VA = "0x7BBBCE7F80", Slot = "6")]
			public void SetUnityLogTypes(int logTypes)
			{
			}

			// Token: 0x0600C77A RID: 51066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C77A")]
			[Address(RVA = "0x14E8014", Offset = "0x14E8014", VA = "0x7BBBCE8014", Slot = "7")]
			public void OverrideUnityLogTypes(int logTypes)
			{
			}

			// Token: 0x0600C77B RID: 51067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C77B")]
			[Address(RVA = "0x14E801C", Offset = "0x14E801C", VA = "0x7BBBCE801C", Slot = "8")]
			public void SetUserId(string userId)
			{
			}

			// Token: 0x0600C77C RID: 51068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C77C")]
			[Address(RVA = "0x14E8028", Offset = "0x14E8028", VA = "0x7BBBCE8028", Slot = "9")]
			public void SetKeyValue(string key, string value)
			{
			}

			// Token: 0x0600C77D RID: 51069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C77D")]
			[Address(RVA = "0x14E8008", Offset = "0x14E8008", VA = "0x7BBBCE8008", Slot = "10")]
			public void Record(string msg)
			{
			}

			// Token: 0x0600C77E RID: 51070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C77E")]
			[Address(RVA = "0x14E8038", Offset = "0x14E8038", VA = "0x7BBBCE8038", Slot = "11")]
			public void Report(string src, string msg, string stacktrace)
			{
			}

			// Token: 0x0600C77F RID: 51071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C77F")]
			[Address(RVA = "0x14E80CC", Offset = "0x14E80CC", VA = "0x7BBBCE80CC", Slot = "12")]
			public void Report(Exception exception)
			{
			}

			// Token: 0x0600C780 RID: 51072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C780")]
			[Address(RVA = "0x14E712C", Offset = "0x14E712C", VA = "0x7BBBCE712C")]
			public Crashlytics()
			{
			}

			// Token: 0x0600C781 RID: 51073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C781")]
			[Address(RVA = "0x14E80D8", Offset = "0x14E80D8", VA = "0x7BBBCE80D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147F3C", Offset = "0x1147F3C")]
			private void <Init>b__4_0()
			{
			}

			// Token: 0x0400F9B0 RID: 63920
			[Token(Token = "0x400F9B0")]
			[FieldOffset(Offset = "0x10")]
			private int UnityLogTypes;

			// Token: 0x0400F9B1 RID: 63921
			[Token(Token = "0x400F9B1")]
			[FieldOffset(Offset = "0x14")]
			private int OverrideLogTypes;
		}
	}
}
