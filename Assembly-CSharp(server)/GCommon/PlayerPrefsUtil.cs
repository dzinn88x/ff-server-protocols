using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F56 RID: 3926
	[Token(Token = "0x2000F56")]
	public static class PlayerPrefsUtil
	{
		// Token: 0x060038BE RID: 14526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038BE")]
		[Address(RVA = "0x247A334", Offset = "0x247A334", VA = "0x7BBCC7A334")]
		public static void DeleteKey(string key, bool global = false)
		{
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x00011A00 File Offset: 0x0000FC00
		[Token(Token = "0x60038BF")]
		[Address(RVA = "0x247A60C", Offset = "0x247A60C", VA = "0x7BBCC7A60C")]
		public static float GetFloat(string key, float defaultValue = 0f, bool global = false)
		{
			return 0f;
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x00011A18 File Offset: 0x0000FC18
		[Token(Token = "0x60038C0")]
		[Address(RVA = "0x247A698", Offset = "0x247A698", VA = "0x7BBCC7A698")]
		public static int GetInt(string key, int defaultValue = 0, bool global = false)
		{
			return 0;
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C1")]
		[Address(RVA = "0x24628B8", Offset = "0x24628B8", VA = "0x7BBCC628B8")]
		public static string GetString(string key, [Optional] string defaultValue, bool global = false)
		{
			return null;
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x00011A30 File Offset: 0x0000FC30
		[Token(Token = "0x60038C2")]
		[Address(RVA = "0x247A71C", Offset = "0x247A71C", VA = "0x7BBCC7A71C")]
		public static bool HasKey(string key, bool global = false)
		{
			return default(bool);
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x247A798", Offset = "0x247A798", VA = "0x7BBCC7A798")]
		public static void Save()
		{
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C4")]
		[Address(RVA = "0x247A8DC", Offset = "0x247A8DC", VA = "0x7BBCC7A8DC")]
		public static void SetFloat(string key, float value, bool global = false)
		{
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C5")]
		[Address(RVA = "0x247AA78", Offset = "0x247AA78", VA = "0x7BBCC7AA78")]
		public static void SetInt(string key, int value, bool global = false)
		{
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C6")]
		[Address(RVA = "0x247AC08", Offset = "0x247AC08", VA = "0x7BBCC7AC08")]
		public static void SetGlobalAddedIntKey(string key, int startnum)
		{
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C7")]
		[Address(RVA = "0x2462AE4", Offset = "0x2462AE4", VA = "0x7BBCC62AE4")]
		public static void SetString(string key, string value, bool global = false)
		{
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C8")]
		[Address(RVA = "0x247A4BC", Offset = "0x247A4BC", VA = "0x7BBCC7A4BC")]
		private static string GenKeyWithUserPrefix(string key, bool global)
		{
			return null;
		}

		// Token: 0x04004AB7 RID: 19127
		[Token(Token = "0x4004AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string UserKey;

		// Token: 0x04004AB8 RID: 19128
		[Token(Token = "0x4004AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static StringBuilder m_KeyStringBuilder;
	}
}
