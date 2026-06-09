using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200205C RID: 8284
	[Token(Token = "0x200205C")]
	public static class OpenUrl
	{
		// Token: 0x0600B882 RID: 47234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B882")]
		[Address(RVA = "0x1A67FD8", Offset = "0x1A67FD8", VA = "0x7BBC267FD8")]
		public static string Get(string key)
		{
			return null;
		}

		// Token: 0x0600B883 RID: 47235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B883")]
		[Address(RVA = "0x1A680D8", Offset = "0x1A680D8", VA = "0x7BBC2680D8")]
		public static void Open(string url)
		{
		}

		// Token: 0x0600B884 RID: 47236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B884")]
		[Address(RVA = "0x1A68144", Offset = "0x1A68144", VA = "0x7BBC268144")]
		public static string Modify(string url)
		{
			return null;
		}

		// Token: 0x0400BA6B RID: 47723
		[Token(Token = "0x400BA6B")]
		private const string PLACEHOLDER_FORMAT = "<{0}>";

		// Token: 0x0400BA6C RID: 47724
		[Token(Token = "0x400BA6C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, OpenUrl.ReplaceDelegate> Replacements;

		// Token: 0x0400BA6D RID: 47725
		[Token(Token = "0x400BA6D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly AES.AESOption aesOption;

		// Token: 0x0200205D RID: 8285
		// (Invoke) Token: 0x0600B887 RID: 47239
		[Token(Token = "0x200205D")]
		private delegate string ReplaceDelegate(string url);

		// Token: 0x0200205E RID: 8286
		[Token(Token = "0x200205E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD964", Offset = "0x10FD964")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B88B RID: 47243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B88B")]
			[Address(RVA = "0x1A68EF0", Offset = "0x1A68EF0", VA = "0x7BBC268EF0")]
			public <>c()
			{
			}

			// Token: 0x0600B88C RID: 47244 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B88C")]
			[Address(RVA = "0x1A68EF8", Offset = "0x1A68EF8", VA = "0x7BBC268EF8")]
			internal string <.cctor>b__7_0(string url)
			{
				return null;
			}

			// Token: 0x0600B88D RID: 47245 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B88D")]
			[Address(RVA = "0x1A68F70", Offset = "0x1A68F70", VA = "0x7BBC268F70")]
			internal string <.cctor>b__7_1(string url)
			{
				return null;
			}

			// Token: 0x0600B88E RID: 47246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B88E")]
			[Address(RVA = "0x1A69028", Offset = "0x1A69028", VA = "0x7BBC269028")]
			internal string <.cctor>b__7_2(string url)
			{
				return null;
			}

			// Token: 0x0600B88F RID: 47247 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B88F")]
			[Address(RVA = "0x1A69090", Offset = "0x1A69090", VA = "0x7BBC269090")]
			internal string <.cctor>b__7_3(string url)
			{
				return null;
			}

			// Token: 0x0600B890 RID: 47248 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B890")]
			[Address(RVA = "0x1A69124", Offset = "0x1A69124", VA = "0x7BBC269124")]
			internal string <.cctor>b__7_4(string url)
			{
				return null;
			}

			// Token: 0x0400BA6E RID: 47726
			[Token(Token = "0x400BA6E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly OpenUrl.<>c <>9;
		}
	}
}
